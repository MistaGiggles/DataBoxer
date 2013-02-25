using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace DataBoxer
{
    public partial class Form1 : Form
    {

        BoxCommunicator BC;
        string selected;
        int from;
        int to;
        bool _working;
        string con;
        bool screen = true;

        Thread downloader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BC = new BoxCommunicator();
            selected = null;
            string[] choices = BoxCommunicator.getPorts();
            
            
            for (int i = 0; i < choices.Length; i++)
            {
        
                combox.Items.Insert(i, choices[i]);
            }
            to = 1;
            from = 1;

            tmin.Text = from.ToString();
            tmax.Text = to.ToString();
            downloader = null;
            con = "";
            backgroundWorker.RunWorkerAsync();
        }

        private void combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = combox.SelectedItem.ToString();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                return;
            }

            BC.setPort(selected);
            BC.connect();
            print("Connected to Box on port " + selected);
        }

        private void bDownload_Click(object sender, EventArgs e)
        {
            download();
        }

        private void download()
        {
            if (BC.isConnected())
            {
                for (int b = from; b < to + 1; b++)
                {
                    string[] result = TimeChipBuilder.getTimes(BC.requestData(b));
                    if (result != null)
                    {




                        for (int i = 0; i < result.Length; i++)
                        {
                            print(result[i]);
                            System.IO.StreamWriter file = new System.IO.StreamWriter(tOutput.Text + "\\comdat." + result[i][1] + "AL", true);
                            file.WriteLine(result[i]);
                            file.Close();
                        }

                    }
                    else
                    {
                        print("No more data!");
                    }
                }
                
            }
        }

        private void print(string s)
        {
            con += s + "\r\n";

        }

        private void bReload_Click(object sender, EventArgs e)
        {
            if (BC.isConnected())
            {
                for (int i = from; i < to + 1; i++)
                {
                    if (BC.reloadData(i))
                    {
                        print("Data Reloaded on box " + i.ToString());

                    }
                    else
                    {

                        print("Problem Reloading Data on Box " + i.ToString());
                    }
                }
            }
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            if(BC.isConnected())
            {
                BC.disconnect();
                print("Disconnected from the box");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tOutput.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void bminplus_Click(object sender, EventArgs e)
        {
            if (from == to)
            {
             
                to += 1;
            }
            from += 1;
            updateToFrom();
        }

        private void bminminus_Click(object sender, EventArgs e)
        {
            from -= 1;
            updateToFrom();
        }

        
        private void bmaxminus_Click(object sender, EventArgs e)
        {
            if (to == from)
            {
                from -= 1;
            }
            to -= 1;
            updateToFrom();
        }


        private void updateToFrom()
        {
            if (to < from) { to = from; }
            if (from > to) { from = to; }
            if (from < 1) { from = 1; }
            if (to < 1) { to = 1; }

             tmin.Text = from.ToString();
             tmax.Text = to.ToString();
        }

        private void tmaxplus_Click_1(object sender, EventArgs e)
        {
            to += 1;
            updateToFrom();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (downloader == null)
            {
                print("Starting downloader");
                bAutoDownload.Text = "Stop";
                _working = true;
                downloader = new Thread(new ThreadStart(this.doDownload));
                downloader.Start();

            }
            else
            {
                bAutoDownload.Text = "Auto Download";
                _working = false;
            }
        }

        

        private void doDownload()
        {
            while (_working)
            {
                print("Getting data");
                download();
                Thread.Sleep(50);
            }
            print("Stopped downloading");
            downloader = null;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (screen)
            {

                Action updateLabel = () =>
                {
                    textconsole.Text = con;
                    textconsole.SelectionStart = textconsole.Text.Length;
                    textconsole.ScrollToCaret();
                    textconsole.Refresh();
                };
                textconsole.BeginInvoke(updateLabel);
                
                Thread.Sleep(100);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataBoxer b = new DataBoxer();
            b.Show();
        }

        
        

        
    }
}
