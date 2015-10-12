using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace MLPGui
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // reading files
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string csvToRead = (string)e.Argument;
            using (StreamReader sr = new StreamReader(csvToRead))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                }
                //e.Result = 
            } 
        }

        private void bgWorker_RunWorker(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                //e.Result
            }
        }
        //-----------------------



        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItemLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "csv";
            ofd.Filter = "csv files (*.csv)|*.csv";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                toolSSLStatus.Text = "wczytywanie pliku...";

                BackgroundWorker bgWorker = new BackgroundWorker();
                bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
                bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorker);

                bgWorker.RunWorkerAsync(ofd.FileName);
            }
        }
    }
}
