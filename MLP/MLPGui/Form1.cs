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
        private List<int> neuronLayers = new List<int>() { };
        private Network reg = null;
        private Network cl = null;
        private string classificationFileName = "classification.csv";
        private string classificationErrFileName = "classification_err.csv";
        private string regressionFnFileName = "regression_fun.csv";
        private string regressionErrFileName = "regression_err.csv";
        private bool trained = false;
        private bool testFileLoaded = false;

        public Main()
        {
            InitializeComponent();

            this.comboBoxActFun.SelectedIndex = 0;
            this.comboBoxProblem.SelectedIndex = 0;
        }

        private void getNeuronsCount()
        {

        }

        private void runClassification(bool learning)
        {
            var actFun = this.comboBoxActFun.SelectedIndex == 0 ? Network.ActivationFunctionType.UniPolar : Network.ActivationFunctionType.BiPolar;

            if (learning)
            {
                cl = new ClassificationNetwork(trainingFilename,
                neuronLayers, actFun, this.checkBoxBias.Checked);
                var result = cl.Train((int)this.numericUDIterations.Value, Double.Parse(this.textBoxLearnCoeff.Text, CultureInfo.InvariantCulture), Double.Parse(this.textBoxInertCoeff.Text, CultureInfo.InvariantCulture));

                try
                {

                    var csv = new StringBuilder();

                    var firstLine = "it, y1, y2\n";
                    csv.Append(firstLine);

                    foreach (var row in result)
                    {
                        var newline = string.Format("{0},{1},{2}\n", row.Item1, row.Item2.ToString().Replace(",", "."), row.Item3.ToString().Replace(",", "."));
                        csv.Append(newline);
                    }

                    File.WriteAllText(classificationErrFileName, csv.ToString());
                    MessageBox.Show("Zapisano plik " + classificationErrFileName);


                }
                catch (Exception)
                {
                    MessageBox.Show("Nie udało się zapisać pliku");
                }

                this.toolSSLStatus.Text = "gotowe...";
                trained = true;
                MessageBox.Show("Skończono naukę");
            }
            else
            {
                var result = cl.Test(testFilename);
                    try
                    {
                        var csv = new StringBuilder();

                        var firstLine = "x, y, cls\n";
                        csv.Append(firstLine);

                        foreach (var row in result.Item1)
                        {
                            var newline = string.Format("{0},{1},{2}\n", row.X.ToString().Replace(",", "."), row.Y.ToString().Replace(",", "."), row.Class);
                            csv.Append(newline);
                        }

                        File.WriteAllText(classificationFileName, csv.ToString());
                        MessageBox.Show("Zapisano plik " + classificationFileName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie udało się zapisać pliku.");
                    }

                this.toolSSLStatus.Text = "gotowe...";
            }
        }

        private void runRegression(bool learning)
        {
            var actFun = this.comboBoxActFun.SelectedIndex == 0 ? Network.ActivationFunctionType.UniPolar : Network.ActivationFunctionType.BiPolar;

            if (learning)
            {
                reg = new RegressionNetwork(trainingFilename,
                neuronLayers, actFun, this.checkBoxBias.Checked);
                var result = reg.Train((int)this.numericUDIterations.Value, Double.Parse(this.textBoxLearnCoeff.Text, CultureInfo.InvariantCulture), Double.Parse(this.textBoxInertCoeff.Text, CultureInfo.InvariantCulture));

                    try
                    {

                        var csv = new StringBuilder();

                        var firstLine = "it, y1, y2\n";
                        csv.Append(firstLine);

                        foreach (var row in result)
                        {
                            var newline = string.Format("{0},{1},{2}\n", row.Item1, row.Item2.ToString().Replace(",", "."), row.Item3.ToString().Replace(",", "."));
                            csv.Append(newline);
                        }

                        File.WriteAllText(regressionErrFileName, csv.ToString());
                        MessageBox.Show("Zapisano plik " + regressionErrFileName);


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie udało się zapisać pliku");
                    }

                this.toolSSLStatus.Text = "gotowe...";
                trained = true;
                MessageBox.Show("Skończono naukę");
            }
            else
            {
                var result = reg.Test(testFilename);

                    try
                    {
                        var csv = new StringBuilder();

                        var firstLine = "x, y\n";
                        csv.Append(firstLine);

                        foreach (var row in result.Item1)
                        {
                            var newline = string.Format("{0},{1}\n", row.X.ToString().Replace(",", "."), row.Y.ToString().Replace(",", "."));
                            csv.Append(newline);
                        }

                        File.WriteAllText(regressionFnFileName, csv.ToString());
                        MessageBox.Show("Zapisano plik " + regressionFnFileName);


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nie udało się zapisać pliku");
                    }

                this.toolSSLStatus.Text = "gotowe...";
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

                this.buttonExecute.Enabled = trained && this.buttonLearn.Enabled;
                testFileLoaded = true;
            }
        }

        private void numericUDLayers_ValueChanged(object sender, EventArgs e)
        {
            var layersNo = (int)this.numericUDLayers.Value;
            neuronLayers = new List<int>() { };
            var layers = new decimal[layersNo];

            this.comboBoxLayerNo.Items.Clear();

            if (layersNo > 0)
            {
                this.comboBoxLayerNo.Enabled = true;
                this.numericUDNeurons.Enabled = true;
            }
            else
            {
                this.comboBoxLayerNo.Enabled = false;
                this.numericUDNeurons.Enabled = false;
                return;
            }


            for (var i = 0; i < layersNo; ++i)
            {
                layers[i] = i + 1;
                neuronLayers.Add(1);
                this.comboBoxLayerNo.Items.Add(i + 1);
            }

            this.comboBoxLayerNo.SelectedIndex = 0;

        }

        private void comboBoxLayerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.numericUDNeurons.Value = neuronLayers[this.comboBoxLayerNo.SelectedIndex];
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            this.toolSSLStatus.Text = "uczenie...";
            if (this.comboBoxProblem.SelectedIndex == 0) //classification
            {
                runClassification(true);
            }
            else //regression
            {
                runRegression(true);
            }

            this.buttonExecute.Enabled = trained && this.buttonLearn.Enabled && testFileLoaded;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            this.toolSSLStatus.Text = "obliczanie...";
            if (this.comboBoxProblem.SelectedIndex == 0) //classification
            {
                runClassification(false);
            }
            else //regression
            {
                runRegression(false);
            }
        }

        private void numericUDNeurons_ValueChanged(object sender, EventArgs e)
        {
            neuronLayers[this.comboBoxLayerNo.SelectedIndex] = (int)this.numericUDNeurons.Value;
        }
    }
}
