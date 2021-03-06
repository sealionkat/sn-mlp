﻿namespace MLPGui
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolSSLStatusTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSSLStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxOpts = new System.Windows.Forms.GroupBox();
            this.comboBoxLayerNo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxProblem = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxInertCoeff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLearnCoeff = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUDIterations = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxBias = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxActFun = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUDNeurons = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUDLayers = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lTrainingFilename = new System.Windows.Forms.Label();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lTestFilename = new System.Windows.Forms.Label();
            this.buttonLoadTrainingSet = new System.Windows.Forms.Button();
            this.buttonLoadTestSet = new System.Windows.Forms.Button();
            this.buttonLaunchR = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.groupBoxOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDNeurons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDLayers)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSSLStatusTxt,
            this.toolSSLStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 387);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(833, 25);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolSSLStatusTxt
            // 
            this.toolSSLStatusTxt.Name = "toolSSLStatusTxt";
            this.toolSSLStatusTxt.Size = new System.Drawing.Size(52, 20);
            this.toolSSLStatusTxt.Text = "Status:";
            // 
            // toolSSLStatus
            // 
            this.toolSSLStatus.Name = "toolSSLStatus";
            this.toolSSLStatus.Size = new System.Drawing.Size(59, 20);
            this.toolSSLStatus.Text = "gotowy";
            // 
            // groupBoxOpts
            // 
            this.groupBoxOpts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOpts.Controls.Add(this.comboBoxLayerNo);
            this.groupBoxOpts.Controls.Add(this.label12);
            this.groupBoxOpts.Controls.Add(this.comboBoxProblem);
            this.groupBoxOpts.Controls.Add(this.label10);
            this.groupBoxOpts.Controls.Add(this.textBoxInertCoeff);
            this.groupBoxOpts.Controls.Add(this.label9);
            this.groupBoxOpts.Controls.Add(this.textBoxLearnCoeff);
            this.groupBoxOpts.Controls.Add(this.label8);
            this.groupBoxOpts.Controls.Add(this.numericUDIterations);
            this.groupBoxOpts.Controls.Add(this.label7);
            this.groupBoxOpts.Controls.Add(this.checkBoxBias);
            this.groupBoxOpts.Controls.Add(this.label6);
            this.groupBoxOpts.Controls.Add(this.comboBoxActFun);
            this.groupBoxOpts.Controls.Add(this.label5);
            this.groupBoxOpts.Controls.Add(this.numericUDNeurons);
            this.groupBoxOpts.Controls.Add(this.label4);
            this.groupBoxOpts.Controls.Add(this.numericUDLayers);
            this.groupBoxOpts.Controls.Add(this.label3);
            this.groupBoxOpts.Location = new System.Drawing.Point(16, 96);
            this.groupBoxOpts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOpts.Name = "groupBoxOpts";
            this.groupBoxOpts.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOpts.Size = new System.Drawing.Size(801, 207);
            this.groupBoxOpts.TabIndex = 2;
            this.groupBoxOpts.TabStop = false;
            this.groupBoxOpts.Text = "Opcje sieci MLP";
            // 
            // comboBoxLayerNo
            // 
            this.comboBoxLayerNo.Enabled = false;
            this.comboBoxLayerNo.FormattingEnabled = true;
            this.comboBoxLayerNo.Location = new System.Drawing.Point(196, 53);
            this.comboBoxLayerNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLayerNo.Name = "comboBoxLayerNo";
            this.comboBoxLayerNo.Size = new System.Drawing.Size(159, 24);
            this.comboBoxLayerNo.TabIndex = 17;
            this.comboBoxLayerNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxLayerNo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Numer dod. warstwy";
            // 
            // comboBoxProblem
            // 
            this.comboBoxProblem.FormattingEnabled = true;
            this.comboBoxProblem.Items.AddRange(new object[] {
            "klasyfikacja",
            "regresja"});
            this.comboBoxProblem.Location = new System.Drawing.Point(617, 122);
            this.comboBoxProblem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProblem.Name = "comboBoxProblem";
            this.comboBoxProblem.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProblem.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(613, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Rodzaj problemu";
            // 
            // textBoxInertCoeff
            // 
            this.textBoxInertCoeff.Location = new System.Drawing.Point(412, 124);
            this.textBoxInertCoeff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInertCoeff.Name = "textBoxInertCoeff";
            this.textBoxInertCoeff.Size = new System.Drawing.Size(160, 22);
            this.textBoxInertCoeff.TabIndex = 13;
            this.textBoxInertCoeff.Text = "0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Współczynnik bezwładności";
            // 
            // textBoxLearnCoeff
            // 
            this.textBoxLearnCoeff.Location = new System.Drawing.Point(196, 124);
            this.textBoxLearnCoeff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLearnCoeff.Name = "textBoxLearnCoeff";
            this.textBoxLearnCoeff.Size = new System.Drawing.Size(159, 22);
            this.textBoxLearnCoeff.TabIndex = 11;
            this.textBoxLearnCoeff.Text = "0.01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Współczynnik nauki";
            // 
            // numericUDIterations
            // 
            this.numericUDIterations.Location = new System.Drawing.Point(13, 124);
            this.numericUDIterations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUDIterations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUDIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDIterations.Name = "numericUDIterations";
            this.numericUDIterations.Size = new System.Drawing.Size(160, 22);
            this.numericUDIterations.TabIndex = 9;
            this.numericUDIterations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Liczba iteracji";
            // 
            // checkBoxBias
            // 
            this.checkBoxBias.AutoSize = true;
            this.checkBoxBias.Location = new System.Drawing.Point(52, 167);
            this.checkBoxBias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxBias.Name = "checkBoxBias";
            this.checkBoxBias.Size = new System.Drawing.Size(18, 17);
            this.checkBoxBias.TabIndex = 7;
            this.checkBoxBias.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bias";
            // 
            // comboBoxActFun
            // 
            this.comboBoxActFun.FormattingEnabled = true;
            this.comboBoxActFun.Items.AddRange(new object[] {
            "unipolarna",
            "bipolarna"});
            this.comboBoxActFun.Location = new System.Drawing.Point(617, 54);
            this.comboBoxActFun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxActFun.Name = "comboBoxActFun";
            this.comboBoxActFun.Size = new System.Drawing.Size(160, 24);
            this.comboBoxActFun.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Funkcja aktywacji";
            // 
            // numericUDNeurons
            // 
            this.numericUDNeurons.Enabled = false;
            this.numericUDNeurons.Location = new System.Drawing.Point(413, 54);
            this.numericUDNeurons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUDNeurons.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUDNeurons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDNeurons.Name = "numericUDNeurons";
            this.numericUDNeurons.Size = new System.Drawing.Size(160, 22);
            this.numericUDNeurons.TabIndex = 3;
            this.numericUDNeurons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDNeurons.ValueChanged += new System.EventHandler(this.numericUDNeurons_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "L. neuronów w dod. warstwie";
            // 
            // numericUDLayers
            // 
            this.numericUDLayers.Location = new System.Drawing.Point(13, 55);
            this.numericUDLayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUDLayers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUDLayers.Name = "numericUDLayers";
            this.numericUDLayers.Size = new System.Drawing.Size(160, 22);
            this.numericUDLayers.TabIndex = 1;
            this.numericUDLayers.ValueChanged += new System.EventHandler(this.numericUDLayers_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Liczba dod. warstw";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wczytany plik treningowy:";
            // 
            // lTrainingFilename
            // 
            this.lTrainingFilename.AutoSize = true;
            this.lTrainingFilename.Location = new System.Drawing.Point(200, 17);
            this.lTrainingFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTrainingFilename.Name = "lTrainingFilename";
            this.lTrainingFilename.Size = new System.Drawing.Size(36, 17);
            this.lTrainingFilename.TabIndex = 4;
            this.lTrainingFilename.Text = "brak";
            // 
            // buttonLearn
            // 
            this.buttonLearn.Enabled = false;
            this.buttonLearn.Location = new System.Drawing.Point(16, 310);
            this.buttonLearn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(100, 28);
            this.buttonLearn.TabIndex = 5;
            this.buttonLearn.Text = "Ucz";
            this.buttonLearn.UseVisualStyleBackColor = true;
            this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Enabled = false;
            this.buttonExecute.Location = new System.Drawing.Point(124, 310);
            this.buttonExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(100, 28);
            this.buttonExecute.TabIndex = 6;
            this.buttonExecute.Text = "Uruchom";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 53);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Wczytany plik testowy:";
            // 
            // lTestFilename
            // 
            this.lTestFilename.AutoSize = true;
            this.lTestFilename.Location = new System.Drawing.Point(200, 53);
            this.lTestFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTestFilename.Name = "lTestFilename";
            this.lTestFilename.Size = new System.Drawing.Size(36, 17);
            this.lTestFilename.TabIndex = 8;
            this.lTestFilename.Text = "brak";
            // 
            // buttonLoadTrainingSet
            // 
            this.buttonLoadTrainingSet.Location = new System.Drawing.Point(720, 11);
            this.buttonLoadTrainingSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadTrainingSet.Name = "buttonLoadTrainingSet";
            this.buttonLoadTrainingSet.Size = new System.Drawing.Size(100, 28);
            this.buttonLoadTrainingSet.TabIndex = 9;
            this.buttonLoadTrainingSet.Text = "Wczytaj";
            this.buttonLoadTrainingSet.UseVisualStyleBackColor = true;
            this.buttonLoadTrainingSet.Click += new System.EventHandler(this.buttonLoadTrainingSet_Click);
            // 
            // buttonLoadTestSet
            // 
            this.buttonLoadTestSet.Location = new System.Drawing.Point(720, 47);
            this.buttonLoadTestSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoadTestSet.Name = "buttonLoadTestSet";
            this.buttonLoadTestSet.Size = new System.Drawing.Size(100, 28);
            this.buttonLoadTestSet.TabIndex = 10;
            this.buttonLoadTestSet.Text = "Wczytaj";
            this.buttonLoadTestSet.UseVisualStyleBackColor = true;
            this.buttonLoadTestSet.Click += new System.EventHandler(this.buttonLoadTestSet_Click);
            // 
            // buttonLaunchR
            // 
            this.buttonLaunchR.Enabled = false;
            this.buttonLaunchR.Location = new System.Drawing.Point(232, 310);
            this.buttonLaunchR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLaunchR.Name = "buttonLaunchR";
            this.buttonLaunchR.Size = new System.Drawing.Size(140, 28);
            this.buttonLaunchR.TabIndex = 11;
            this.buttonLaunchR.Text = "Generuj wykresy";
            this.buttonLaunchR.UseVisualStyleBackColor = true;
            this.buttonLaunchR.Click += new System.EventHandler(this.buttonLaunchR_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 412);
            this.Controls.Add(this.buttonLaunchR);
            this.Controls.Add(this.buttonLoadTestSet);
            this.Controls.Add(this.buttonLoadTrainingSet);
            this.Controls.Add(this.lTestFilename);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonLearn);
            this.Controls.Add(this.lTrainingFilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxOpts);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(851, 459);
            this.MinimumSize = new System.Drawing.Size(851, 459);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLP Encog";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxOpts.ResumeLayout(false);
            this.groupBoxOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDNeurons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDLayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolSSLStatusTxt;
        private System.Windows.Forms.ToolStripStatusLabel toolSSLStatus;
        private System.Windows.Forms.GroupBox groupBoxOpts;
        private System.Windows.Forms.NumericUpDown numericUDLayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTrainingFilename;
        private System.Windows.Forms.ComboBox comboBoxProblem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxInertCoeff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLearnCoeff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUDIterations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxBias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxActFun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUDNeurons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.ComboBox comboBoxLayerNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lTestFilename;
        private System.Windows.Forms.Button buttonLoadTrainingSet;
        private System.Windows.Forms.Button buttonLoadTestSet;
        private System.Windows.Forms.Button buttonLaunchR;
    }
}

