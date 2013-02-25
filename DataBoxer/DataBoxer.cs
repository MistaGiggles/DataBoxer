using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;


namespace DataBoxer
{
    public partial class DataBoxer : Form
    {
        Thread downloader;
        string selectedPort;
        int minBox;
        int maxBox;
        bool BibListLocked = false;
        BoxCommunicator BC;
        string con1;
        string con2;
        bool screen = true;
        bool _working;
        bool _scanning;

        DataSet Scanning;
        DataTable ScanningChips;
        DataTable BibList;


        public DataBoxer()
        {
            InitializeComponent();
        }

        private void bLockBibs_Click(object sender, EventArgs e)
        {
            if (BibListLocked)
            {

                dataGridBibs.ReadOnly = false;
                bLockBibs.Text = "Lock";
                BibListLocked = false;
                dataGridBibs.Enabled = false;
                
            }
            else
            {
                dataGridBibs.ReadOnly = true;
                bLockBibs.Text = "Unlock";
                BibListLocked = true;
                dataGridBibs.Enabled = true;
                
            }
        }

        private void combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPort = combox.SelectedItem.ToString();
        }

        private void DataBoxer_Load(object sender, EventArgs e)
        {
            BC = new BoxCommunicator();
            minBox = 1;
            maxBox = 1;
            combox.Items.AddRange(BoxCommunicator.getPorts());
            combox.SelectedIndex = 0;
            selectedPort = combox.SelectedItem.ToString();
            con1 = "";
            backgroundWorker.RunWorkerAsync();
            tFileName.Text = Directory.GetCurrentDirectory();
            BibList = new DataTable();
            BibList.Columns.Add("BIB");
            dataGridBibs.DataSource = BibList;
        }

        private void bminplus_Click(object sender, EventArgs e)
        {
            if (minBox == maxBox)
            {

                maxBox += 1;
            }
            minBox += 1;
            updatemaxBoxminBox();
        }

        private void bminminus_Click(object sender, EventArgs e)
        {
            minBox -= 1;
            updatemaxBoxminBox();
        }

        private void bmaxminus_Click(object sender, EventArgs e)
        {
            if (maxBox == minBox)
            {
                minBox -= 1;
            }
            maxBox -= 1;
            updatemaxBoxminBox();
        }

        private void updatemaxBoxminBox()
        {
            if (maxBox < minBox) { maxBox = minBox; }
            if (minBox > maxBox) { minBox = maxBox; }
            if (minBox < 1) { minBox = 1; }
            if (maxBox < 1) { maxBox = 1; }

            tmin.Text = minBox.ToString();
            tmax.Text = maxBox.ToString();
        }

        private void bmaxplus_Click(object sender, EventArgs e)
        {
            maxBox += 1;
            updatemaxBoxminBox();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (selectedPort == null)
            {
                return;
            }

            BC.setPort(selectedPort);
            BC.connect();
            print1("Connected to Box on port " + selectedPort);
            bConnect.Enabled = false;
            bDisconnect.Enabled = true;
        }

        private void print1(string s)
        {
            con1 += s + "\r\n";

        }

        private void print2(string s)
        {
            con2 += s + "\r\n";
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            if (BC.isConnected())
            {
                BC.disconnect();
                print1("Disconnected from the box");
                bDisconnect.Enabled = false;
                bConnect.Enabled = true;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (screen)
            {

                Action updateCon1 = () =>
                {
                    if (tabControl.SelectedIndex == 0)
                    {
                        if (!textconsole1.Text.Equals(con1))
                        {
                            textconsole1.Text = con1;
                            textconsole1.SelectionStart = textconsole1.Text.Length;
                            textconsole1.ScrollToCaret();
                            textconsole1.Refresh();
                        }
                        
                    }
                };
                if (textconsole1 != null)
                {
                    textconsole1.BeginInvoke(updateCon1);
                }

                Action updateCon2 = () =>
                {
                    if (tabControl.SelectedIndex == 1)
                    {
                        if (!textConsole2.Text.Equals(con2))
                        {
                            textConsole2.Text = con2;
                            textConsole2.SelectionStart = textConsole2.Text.Length;
                            textConsole2.ScrollToCaret();
                            textConsole2.Refresh();
                        }

                    }
                };
                if (textConsole2 != null)
                {
                    textConsole2.BeginInvoke(updateCon2);
                }

               


                Thread.Sleep(400);
            }
        }

        private void bStartDownload_Click(object sender, EventArgs e)
        {
            if (downloader == null)
            {
                print1("Starting download");
                _working = true;
                downloader = new Thread(new ThreadStart(this.doDownload));
                downloader.Start();

            }
            
            bStopDownload.Enabled = true;
            bStartDownload.Enabled = bReloadData.Enabled = bSyncronize.Enabled = bDownloadSingle.Enabled = bChooseCommdat.Enabled = false;
            
        }

        private void bStopDownload_Click(object sender, EventArgs e)
        {
            if(downloader != null)
            {
                print1("Stopping Download");
                _working = false;
            }
            bStopDownload.Enabled = false;
            bStartDownload.Enabled = bReloadData.Enabled = bSyncronize.Enabled = bDownloadSingle.Enabled = bChooseCommdat.Enabled = true;
        }

        private void bReloadData_Click(object sender, EventArgs e)
        {
            if (BC.isConnected())
            {
                for (int i = minBox; i < maxBox + 1; i++)
                {
                    if (BC.reloadData(i))
                    {
                        print1("Data Reloaded on box " + i.ToString());

                    }
                    else
                    {

                        print1("Problem Reloading Data on Box " + i.ToString());
                    }
                }
            }
        }

        private void bSyncronize_Click(object sender, EventArgs e)
        {
            if (BC.isConnected())
            {
                for (int i = minBox; i < maxBox + 1; i++)
                {

                    print1("Syncing box " + i.ToString() + " with time " + DateTime.Now.ToString("HH:mm:ss"));
                    BC.send(WTCodes.sync(i));
                    Thread.Sleep(200);
                    byte[] res = BC.receive();
                    if (WTCodes.matches(WTCodes.confirmSync(i), res)) 
                    {
                        print1("Synced");
                    }
                    else
                    {
                        print1("Sync failed");
                    }
                }
            }
            
            
        }

        private void bDownloadSingle_Click(object sender, EventArgs e)
        {
            download();
        }

        private void doDownload()
        {
            while (_working)
            {
                print1("Getting data");
                download();
                Thread.Sleep(200);
            }
            print1("Stopped downloading");
            downloader = null;
        }

        private void download()
        {
            if (BC.isConnected())
            {
                for (int b = minBox; b < maxBox + 1; b++)
                {
                    string[] result = TimeChipBuilder.getTimes(BC.requestData(b));
                    if (result != null)
                    {




                        for (int i = 0; i < result.Length; i++)
                        {
                            print1(result[i]);
                            System.IO.StreamWriter file = new System.IO.StreamWriter(tFileName.Text + "\\comdat." + result[i][1] + "AL", true);
                            file.WriteLine(result[i]);
                            file.Close();
                        }

                    }
                    else
                    {
                        print1("No more data!");
                    }
                }

            }
        }

        private void bChooseCommdat_Click(object sender, EventArgs e)
        {
            if (folderBrowserDownload.ShowDialog() == DialogResult.OK)
            {
                tFileName.Text = folderBrowserDownload.SelectedPath;
               
            }
        }

        private void bOpenFileLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = tFileName.Text;
            prc.Start();
        }

        private void bChooseScanning_Click(object sender, EventArgs e)
        {
            if (openFileDialogScanning.ShowDialog() == DialogResult.OK)
            {
                textScanningCSV.Text = openFileDialogScanning.FileName;
            }
        }

        private void bImportScanning_Click(object sender, EventArgs e)
        {
            ScanningChips = new DataTable("BibChip");

            ScanningChips.Columns.Add("BIB");
            ScanningChips.Columns.Add("ID");  
            ScanningChips.Columns.Add("NEW ID");
            String[] data = File.ReadAllLines(textScanningCSV.Text);
            bool first = true;
            foreach(String s in data)
            {
                if (!first)
                {
                    String[] f = s.Split(new char[] { ',' });
                    ScanningChips.Rows.Add(f[0], f[1]);
                }
                else
                {
                    first = false;
                }
            }

            
            dataCSVView.DataSource = ScanningChips;
            dataCSVView.Columns[1].Width = 180;
            dataCSVView.Columns[2].Width = 180;
            bStartScanning.Enabled = true;
            DataColumn[] key = new DataColumn[1];
            key[0] = ScanningChips.Columns["BIB"];
            ScanningChips.PrimaryKey = key;

        }

        private void bStartScanning_Click(object sender, EventArgs e)
        {

            _scanning = true;
            backgroundScanner.RunWorkerAsync();
            bStopScanning.Enabled = true;
            bStartScanning.Enabled = false;
            
            
        }

        private void setCurrentChip()
        {

            
        }

        private void backgroundScanner_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] bibs;
            List<int> list = new List<int>();
            foreach (DataRow row in BibList.Rows)
            {
                list.Add(Int32.Parse(row[0].ToString()));
            }
            bibs = list.ToArray();
            int i = 0;
            while (_scanning)
            {

                textCurrentChip.Invoke(new Action(() =>
                {
                    textCurrentChip.Text = bibs[i].ToString();
                }
                ));


                for (int b = minBox; b < maxBox + 1; b++)
                {
                    string[] result = TimeChipBuilder.getChips(BC.requestData(b));
                    if (result == null)
                    {
                        // no data
                    }
                    else
                    {
                        foreach (string s in result)
                        {
                            /*DataRow[] toChange = ScanningChips.Select("BIB = " + bibs[i].ToString());
                            print2(ScanningChips.Rows.Count.ToString());
                            print2(toChange.Length.ToString() + " - " + bibs[i].ToString());
                            foreach (DataRow row in toChange)
                            {
                                print2("Length = " + toChange.Length.ToString());
                                row[2] = "BIB = " + bibs[i].ToString();
                                
                                i++;
                            }
                             */


                            DataRow foundRow = ScanningChips.Rows.Find(bibs[i].ToString());

                            if (foundRow != null)
                            {
                                print2(foundRow[0].ToString());
                                foundRow[2] = s;
                            }
                            i++;
                            if (i >= bibs.Length)
                            {
                                bStopScanning.Invoke(new Action(() => { MessageBox.Show("Scanning Completed"); }));
                                _scanning = false;
                                b = maxBox + 10;
                                break;
                                
                            }
                           

                           
                        }

                    }


                    Thread.Sleep(100);
                }
                Thread.Sleep(100);

            }
            

            bStopScanning.Invoke(new Action(() => {bStopScanning.Enabled = false;}));
            bStartScanning.Invoke(new Action(() => { bStartScanning.Enabled = true; }));
        }

        private void bInsertBibRange_Click(object sender, EventArgs e)
        {
            int bibfrom = Int32.Parse(tBibFrom.Text);
            int bibto = Int32.Parse(tBibTo.Text);
            for (int i = bibfrom; i <= bibto; i++)
            {
               BibList.Rows.Add(i.ToString());
            }
        }

        private void bClearBibs_Click(object sender, EventArgs e)
        {
            BibList = new DataTable();
            BibList.Columns.Add("BIB");
            dataGridBibs.DataSource = BibList;
        }

        private void bStopScanning_Click(object sender, EventArgs e)
        {
            
            backgroundScanner.CancelAsync();
            bStopScanning.Enabled = false;
            bStartScanning.Enabled = true;
        }

        private void bExportScanning_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter changefile = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + "\\" + Path.GetFileNameWithoutExtension(textScanningCSV.Text) + ".changes.csv");
            System.IO.StreamWriter csvfile = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + "\\" + Path.GetFileNameWithoutExtension(textScanningCSV.Text) + ".new.csv");
            csvfile.WriteLine("BIB,ID");
            changefile.WriteLine("BIB,ID");
            foreach (DataRow row in ScanningChips.Rows)
            {
                
                csvfile.Write(row[0] + ",");
                print2(row[2].ToString());
                if (row[2].ToString().Equals(""))
                {
                    csvfile.Write(row[1]);
                }
                else
                {
                    changefile.Write(row[0] + ",");
                    changefile.Write(row[2]);
                    csvfile.Write(row[2]);
                    changefile.WriteLine();
                }
                
                csvfile.WriteLine();
            }
            csvfile.Close();
            changefile.Close();
        }

        private void bDeleteBox_Click(object sender, EventArgs e)
        {
            if (BC.isConnected())
            {
                for (int b = minBox; b < maxBox + 1; b++)
                {
                    BC.send(WTCodes.deletebox(b));
                    Thread.Sleep(400);
                    byte[] rc = BC.receive();
                    if(WTCodes.matches(rc, WTCodes.confirm(b)))
                    {
                        textConsole3.Text += "Deleted Data\r\n";
                    }
                    else
                    {
                        textConsole3.Text += "Timeout\r\n";
                    }

                }
            }
        }
        
    }
}
