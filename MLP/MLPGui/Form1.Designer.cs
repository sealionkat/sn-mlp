namespace MLPGui
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOpts = new System.Windows.Forms.GroupBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBoxOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDNeurons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDLayers)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSSLStatusTxt,
            this.toolSSLStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 321);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(627, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolSSLStatusTxt
            // 
            this.toolSSLStatusTxt.Name = "toolSSLStatusTxt";
            this.toolSSLStatusTxt.Size = new System.Drawing.Size(42, 17);
            this.toolSSLStatusTxt.Text = "Status:";
            // 
            // toolSSLStatus
            // 
            this.toolSSLStatus.Name = "toolSSLStatus";
            this.toolSSLStatus.Size = new System.Drawing.Size(47, 17);
            this.toolSSLStatus.Text = "gotowy";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(627, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLoadFile,
            this.toolStripSeparator1,
            this.toolStripMenuItemClose});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // toolStripMenuItemLoadFile
            // 
            this.toolStripMenuItemLoadFile.Name = "toolStripMenuItemLoadFile";
            this.toolStripMenuItemLoadFile.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemLoadFile.Text = "Wczytaj plik";
            this.toolStripMenuItemLoadFile.Click += new System.EventHandler(this.ToolStripMenuItemLoadFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItemClose
            // 
            this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
            this.toolStripMenuItemClose.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemClose.Text = "Wyjście";
            this.toolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // groupBoxOpts
            // 
            this.groupBoxOpts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBoxOpts.Location = new System.Drawing.Point(12, 65);
            this.groupBoxOpts.Name = "groupBoxOpts";
            this.groupBoxOpts.Size = new System.Drawing.Size(601, 168);
            this.groupBoxOpts.TabIndex = 2;
            this.groupBoxOpts.TabStop = false;
            this.groupBoxOpts.Text = "Opcje sieci MLP";
            // 
            // comboBoxProblem
            // 
            this.comboBoxProblem.FormattingEnabled = true;
            this.comboBoxProblem.Items.AddRange(new object[] {
            "klasyfikacja",
            "regresja"});
            this.comboBoxProblem.Location = new System.Drawing.Point(463, 99);
            this.comboBoxProblem.Name = "comboBoxProblem";
            this.comboBoxProblem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProblem.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Rodzaj problemu";
            // 
            // textBoxInertCoeff
            // 
            this.textBoxInertCoeff.Location = new System.Drawing.Point(309, 101);
            this.textBoxInertCoeff.Name = "textBoxInertCoeff";
            this.textBoxInertCoeff.Size = new System.Drawing.Size(121, 20);
            this.textBoxInertCoeff.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Współczynnik bezwładności";
            // 
            // textBoxLearnCoeff
            // 
            this.textBoxLearnCoeff.Location = new System.Drawing.Point(147, 101);
            this.textBoxLearnCoeff.Name = "textBoxLearnCoeff";
            this.textBoxLearnCoeff.Size = new System.Drawing.Size(120, 20);
            this.textBoxLearnCoeff.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Współczynnik nauki";
            // 
            // numericUDIterations
            // 
            this.numericUDIterations.Location = new System.Drawing.Point(463, 46);
            this.numericUDIterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUDIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDIterations.Name = "numericUDIterations";
            this.numericUDIterations.Size = new System.Drawing.Size(120, 20);
            this.numericUDIterations.TabIndex = 9;
            this.numericUDIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Liczba iteracji";
            // 
            // checkBoxBias
            // 
            this.checkBoxBias.AutoSize = true;
            this.checkBoxBias.Location = new System.Drawing.Point(40, 85);
            this.checkBoxBias.Name = "checkBoxBias";
            this.checkBoxBias.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBias.TabIndex = 7;
            this.checkBoxBias.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bias";
            // 
            // comboBoxActFun
            // 
            this.comboBoxActFun.FormattingEnabled = true;
            this.comboBoxActFun.Items.AddRange(new object[] {
            "unipolarna",
            "bipolarna"});
            this.comboBoxActFun.Location = new System.Drawing.Point(309, 45);
            this.comboBoxActFun.Name = "comboBoxActFun";
            this.comboBoxActFun.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActFun.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Funkcja aktywacji";
            // 
            // numericUDNeurons
            // 
            this.numericUDNeurons.Location = new System.Drawing.Point(147, 45);
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
            this.numericUDNeurons.Size = new System.Drawing.Size(120, 20);
            this.numericUDNeurons.TabIndex = 3;
            this.numericUDNeurons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Liczba neuronów w warstwie";
            // 
            // numericUDLayers
            // 
            this.numericUDLayers.Location = new System.Drawing.Point(10, 45);
            this.numericUDLayers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUDLayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUDLayers.Name = "numericUDLayers";
            this.numericUDLayers.Size = new System.Drawing.Size(120, 20);
            this.numericUDLayers.TabIndex = 1;
            this.numericUDLayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Liczba warstw";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wczytany plik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "brak";
            // 
            // buttonLearn
            // 
            this.buttonLearn.Location = new System.Drawing.Point(12, 248);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(75, 23);
            this.buttonLearn.TabIndex = 5;
            this.buttonLearn.Text = "Ucz";
            this.buttonLearn.UseVisualStyleBackColor = true;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(93, 248);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 6;
            this.buttonExecute.Text = "Uruchom";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 343);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonLearn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxOpts);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(643, 382);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLP Encog";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClose;
        private System.Windows.Forms.GroupBox groupBoxOpts;
        private System.Windows.Forms.NumericUpDown numericUDLayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

