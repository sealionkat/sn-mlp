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
using MLPCore;
using System.Globalization;

namespace MLPGui
{
    public partial class Main : Form
    {
        private string trainingFilename = "..\\..\\..\\..\\data\\data.train.csv";
        private string testFilename = "..\\..\\..\\..\\data\\data.test.csv";
        private List<int> layers = new List<int>() { };

        public Main()
        {
            InitializeComponent();

            this.comboBoxActFun.SelectedIndex = 0;
            this.comboBoxProblem.SelectedIndex = 0;
            this.comboBoxLayerNo.SelectedIndex = 0;
        }

        private void runClassification(bool learning)
        {
            var actFun = this.comboBoxActFun.SelectedIndex == 0 ? Network.ActivationFunctionType.UniPolar : Network.ActivationFunctionType.BiPolar;

            Network n = new ClassificationNetwork(trainingFilename,
                new List<int>() { 8 }, actFun, this.checkBoxBias.Checked);

            if (learning)
            {
                n.Train((int)this.numericUDIterations.Value, Double.Parse(this.textBoxLearnCoeff.Text, CultureInfo.InvariantCulture), Double.Parse(this.textBoxInertCoeff.Text, CultureInfo.InvariantCulture));
                this.toolSSLStatus.Text = "gotowe...";
            }
            else
            {
                n.Test(testFilename);
                this.toolSSLStatus.Text = "gotowe...";
            }
        }

        private void runRegression(bool learning)
        {
            var actFun = this.comboBoxActFun.SelectedIndex == 0 ? Network.ActivationFunctionType.UniPolar : Network.ActivationFunctionType.BiPolar;

            Network n = new ClassificationNetwork(trainingFilename,
                new List<int>() { 8 }, actFun, this.checkBoxBias.Checked);

            if (learning)
            {
                n.Train((int)this.numericUDIterations.Value, Double.Parse(this.textBoxLearnCoeff.Text, CultureInfo.InvariantCulture), Double.Parse(this.textBoxInertCoeff.Text, CultureInfo.InvariantCulture));
                this.toolSSLStatus.Text = "gotowe...";
            }
            else
            {
                n.Test(testFilename);
                this.toolSSLStatus.Text = "gotowe...";
            }
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

        private void buttonLoadTrainingSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "csv";
            ofd.Filter = "csv files (*.csv)|*.csv";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                

                this.lTrainingFilename.Text = ofd.FileName; 
                trainingFilename = ofd.FileName;
                this.buttonLearn.Enabled = true;

                
            }
        }

        private void buttonLoadTestSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "csv";
            ofd.Filter = "csv files (*.csv)|*.csv";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                this.lTestFilename.Text = ofd.FileName;
                testFilename = ofd.FileName;

                this.buttonExecute.Enabled = this.buttonLearn.Enabled;
                
            }
        }

        private void numericUDLayers_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLayerNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            toolSSLStatus.Text = "uczenie...";
            if (this.comboBoxProblem.SelectedIndex == 0) //classification
            {
                runClassification(true);
            }
            else //regression
            {
                runRegression(true);
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            toolSSLStatus.Text = "obliczanie...";
            if (this.comboBoxProblem.SelectedIndex == 0) //classification
            {
                runClassification(false);
            }
            else //regression
            {
                runRegression(false);
            }
        }
    }
}
