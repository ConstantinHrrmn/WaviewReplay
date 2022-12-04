namespace InstantReplayApp
{
    partial class FrmSettings
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
            this.gbInputSource = new System.Windows.Forms.GroupBox();
            this.cmbSources = new System.Windows.Forms.ComboBox();
            this.btnCloseLiveInput = new System.Windows.Forms.Button();
            this.btnSetSavePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.fbdReplay = new System.Windows.Forms.FolderBrowserDialog();
            this.nudR25 = new System.Windows.Forms.NumericUpDown();
            this.nudR10 = new System.Windows.Forms.NumericUpDown();
            this.nudR1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nudF1 = new System.Windows.Forms.NumericUpDown();
            this.nudF10 = new System.Windows.Forms.NumericUpDown();
            this.nudF25 = new System.Windows.Forms.NumericUpDown();
            this.btnResetSpeeds = new System.Windows.Forms.Button();
            this.lbl0 = new System.Windows.Forms.Label();
            this.tbx0 = new System.Windows.Forms.TextBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.tbx5 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tbx6 = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.tbx7 = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.tbx16 = new System.Windows.Forms.TextBox();
            this.lbl16 = new System.Windows.Forms.Label();
            this.tbx15 = new System.Windows.Forms.TextBox();
            this.lbl15 = new System.Windows.Forms.Label();
            this.tbx14 = new System.Windows.Forms.TextBox();
            this.lbl14 = new System.Windows.Forms.Label();
            this.tbx13 = new System.Windows.Forms.TextBox();
            this.lbl13 = new System.Windows.Forms.Label();
            this.tbx12 = new System.Windows.Forms.TextBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.tbx11 = new System.Windows.Forms.TextBox();
            this.lbl11 = new System.Windows.Forms.Label();
            this.tbx10 = new System.Windows.Forms.TextBox();
            this.lbl10 = new System.Windows.Forms.Label();
            this.tbx9 = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.tbx8 = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.btnResetShortcuts = new System.Windows.Forms.Button();
            this.gbInputSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudR25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudF10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudF25)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInputSource
            // 
            this.gbInputSource.BackColor = System.Drawing.Color.Black;
            this.gbInputSource.Controls.Add(this.cmbSources);
            this.gbInputSource.Controls.Add(this.btnCloseLiveInput);
            this.gbInputSource.ForeColor = System.Drawing.Color.Red;
            this.gbInputSource.Location = new System.Drawing.Point(12, 12);
            this.gbInputSource.Name = "gbInputSource";
            this.gbInputSource.Size = new System.Drawing.Size(657, 82);
            this.gbInputSource.TabIndex = 7;
            this.gbInputSource.TabStop = false;
            this.gbInputSource.Text = "Input Source";
            // 
            // cmbSources
            // 
            this.cmbSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSources.Location = new System.Drawing.Point(6, 29);
            this.cmbSources.Name = "cmbSources";
            this.cmbSources.Size = new System.Drawing.Size(543, 32);
            this.cmbSources.TabIndex = 1;
            this.cmbSources.SelectedIndexChanged += new System.EventHandler(this.cmbSources_SelectedIndexChanged);
            // 
            // btnCloseLiveInput
            // 
            this.btnCloseLiveInput.BackColor = System.Drawing.Color.Black;
            this.btnCloseLiveInput.Enabled = false;
            this.btnCloseLiveInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLiveInput.Location = new System.Drawing.Point(555, 20);
            this.btnCloseLiveInput.Name = "btnCloseLiveInput";
            this.btnCloseLiveInput.Size = new System.Drawing.Size(94, 49);
            this.btnCloseLiveInput.TabIndex = 3;
            this.btnCloseLiveInput.Text = "STOP";
            this.btnCloseLiveInput.UseVisualStyleBackColor = false;
            this.btnCloseLiveInput.Click += new System.EventHandler(this.btnCloseLiveInput_Click);
            // 
            // btnSetSavePath
            // 
            this.btnSetSavePath.BackColor = System.Drawing.Color.White;
            this.btnSetSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSavePath.Location = new System.Drawing.Point(12, 128);
            this.btnSetSavePath.Name = "btnSetSavePath";
            this.btnSetSavePath.Size = new System.Drawing.Size(216, 57);
            this.btnSetSavePath.TabIndex = 10;
            this.btnSetSavePath.Text = "CHANGE PATH";
            this.btnSetSavePath.UseVisualStyleBackColor = false;
            this.btnSetSavePath.Click += new System.EventHandler(this.btnSetSavePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select the path to the folder to save the replays";
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.ForeColor = System.Drawing.Color.Red;
            this.lblSavePath.Location = new System.Drawing.Point(234, 160);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(219, 25);
            this.lblSavePath.TabIndex = 12;
            this.lblSavePath.Text = "(No save path selected)";
            // 
            // nudR25
            // 
            this.nudR25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudR25.Font = new System.Drawing.Font("Arial", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudR25.Location = new System.Drawing.Point(7, 38);
            this.nudR25.Name = "nudR25";
            this.nudR25.Size = new System.Drawing.Size(102, 50);
            this.nudR25.TabIndex = 13;
            this.nudR25.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudR25.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            this.nudR25.Click += new System.EventHandler(this.nud_Click);
            // 
            // nudR10
            // 
            this.nudR10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudR10.Font = new System.Drawing.Font("Arial", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudR10.Location = new System.Drawing.Point(113, 38);
            this.nudR10.Name = "nudR10";
            this.nudR10.Size = new System.Drawing.Size(102, 50);
            this.nudR10.TabIndex = 14;
            this.nudR10.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudR10.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            this.nudR10.Click += new System.EventHandler(this.nud_Click);
            // 
            // nudR1
            // 
            this.nudR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudR1.Font = new System.Drawing.Font("Arial", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudR1.Location = new System.Drawing.Point(220, 38);
            this.nudR1.Name = "nudR1";
            this.nudR1.Size = new System.Drawing.Size(102, 50);
            this.nudR1.TabIndex = 15;
            this.nudR1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudR1.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            this.nudR1.Click += new System.EventHandler(this.nud_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rewind and Forward speeds";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudR25);
            this.panel1.Controls.Add(this.nudR10);
            this.panel1.Controls.Add(this.nudR1);
            this.panel1.Location = new System.Drawing.Point(12, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 100);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "REWIND";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nudF1);
            this.panel2.Controls.Add(this.nudF10);
            this.panel2.Controls.Add(this.nudF25);
            this.panel2.Location = new System.Drawing.Point(347, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 100);
            this.panel2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "FORWARD";
            // 
            // nudF1
            // 
            this.nudF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudF1.Font = new System.Drawing.Font("Arial", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudF1.Location = new System.Drawing.Point(7, 38);
            this.nudF1.Name = "nudF1";
            this.nudF1.Size = new System.Drawing.Size(102, 50);
            this.nudF1.TabIndex = 13;
            this.nudF1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudF1.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            this.nudF1.Click += new System.EventHandler(this.nud_Click);
            // 
            // nudF10
            // 
            this.nudF10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudF10.Font = new System.Drawing.Font("Arial", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudF10.Location = new System.Drawing.Point(113, 38);
            this.nudF10.Name = "nudF10";
            this.nudF10.Size = new System.Drawing.Size(102, 50);
            this.nudF10.TabIndex = 14;
            this.nudF10.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudF10.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            this.nudF10.Click += new System.EventHandler(this.nud_Click);
            // 
            // nudF25
            // 
            this.nudF25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudF25.Font = new System.Drawing.Font("Arial", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudF25.Location = new System.Drawing.Point(220, 38);
            this.nudF25.Name = "nudF25";
            this.nudF25.Size = new System.Drawing.Size(102, 50);
            this.nudF25.TabIndex = 15;
            this.nudF25.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudF25.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            this.nudF25.Click += new System.EventHandler(this.nud_Click);
            // 
            // btnResetSpeeds
            // 
            this.btnResetSpeeds.BackColor = System.Drawing.Color.Black;
            this.btnResetSpeeds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSpeeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSpeeds.ForeColor = System.Drawing.Color.Red;
            this.btnResetSpeeds.Location = new System.Drawing.Point(562, 221);
            this.btnResetSpeeds.Name = "btnResetSpeeds";
            this.btnResetSpeeds.Size = new System.Drawing.Size(114, 41);
            this.btnResetSpeeds.TabIndex = 24;
            this.btnResetSpeeds.Text = "Reset default";
            this.btnResetSpeeds.UseVisualStyleBackColor = false;
            this.btnResetSpeeds.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl0
            // 
            this.lbl0.ForeColor = System.Drawing.Color.White;
            this.lbl0.Location = new System.Drawing.Point(114, 422);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(155, 43);
            this.lbl0.TabIndex = 25;
            this.lbl0.Text = "-";
            this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx0
            // 
            this.tbx0.BackColor = System.Drawing.Color.Black;
            this.tbx0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx0.Location = new System.Drawing.Point(275, 429);
            this.tbx0.Name = "tbx0";
            this.tbx0.Size = new System.Drawing.Size(54, 29);
            this.tbx0.TabIndex = 26;
            this.tbx0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx0.Click += new System.EventHandler(this.tbx_Click);
            this.tbx0.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // tbx1
            // 
            this.tbx1.BackColor = System.Drawing.Color.Black;
            this.tbx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx1.Location = new System.Drawing.Point(275, 472);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(54, 29);
            this.tbx1.TabIndex = 28;
            this.tbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx1.Click += new System.EventHandler(this.tbx_Click);
            this.tbx1.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(114, 465);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(155, 43);
            this.lbl1.TabIndex = 27;
            this.lbl1.Text = "-";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx2
            // 
            this.tbx2.BackColor = System.Drawing.Color.Black;
            this.tbx2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx2.Location = new System.Drawing.Point(275, 515);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(54, 29);
            this.tbx2.TabIndex = 30;
            this.tbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx2.Click += new System.EventHandler(this.tbx_Click);
            this.tbx2.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(114, 508);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(155, 43);
            this.lbl2.TabIndex = 29;
            this.lbl2.Text = "-";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx3
            // 
            this.tbx3.BackColor = System.Drawing.Color.Black;
            this.tbx3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx3.Location = new System.Drawing.Point(275, 558);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(54, 29);
            this.tbx3.TabIndex = 32;
            this.tbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx3.Click += new System.EventHandler(this.tbx_Click);
            this.tbx3.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(114, 551);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(155, 43);
            this.lbl3.TabIndex = 31;
            this.lbl3.Text = "-";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx4
            // 
            this.tbx4.BackColor = System.Drawing.Color.Black;
            this.tbx4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx4.Location = new System.Drawing.Point(275, 601);
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(54, 29);
            this.tbx4.TabIndex = 34;
            this.tbx4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx4.Click += new System.EventHandler(this.tbx_Click);
            this.tbx4.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl4
            // 
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(114, 594);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(155, 43);
            this.lbl4.TabIndex = 33;
            this.lbl4.Text = "-";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx5
            // 
            this.tbx5.BackColor = System.Drawing.Color.Black;
            this.tbx5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx5.Location = new System.Drawing.Point(275, 644);
            this.tbx5.Name = "tbx5";
            this.tbx5.Size = new System.Drawing.Size(54, 29);
            this.tbx5.TabIndex = 36;
            this.tbx5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx5.Click += new System.EventHandler(this.tbx_Click);
            this.tbx5.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl5
            // 
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(114, 637);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(155, 43);
            this.lbl5.TabIndex = 35;
            this.lbl5.Text = "-";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx6
            // 
            this.tbx6.BackColor = System.Drawing.Color.Black;
            this.tbx6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx6.Location = new System.Drawing.Point(275, 687);
            this.tbx6.Name = "tbx6";
            this.tbx6.Size = new System.Drawing.Size(54, 29);
            this.tbx6.TabIndex = 38;
            this.tbx6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx6.Click += new System.EventHandler(this.tbx_Click);
            this.tbx6.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl6
            // 
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(114, 680);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(155, 43);
            this.lbl6.TabIndex = 37;
            this.lbl6.Text = "-";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx7
            // 
            this.tbx7.BackColor = System.Drawing.Color.Black;
            this.tbx7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx7.Location = new System.Drawing.Point(275, 730);
            this.tbx7.Name = "tbx7";
            this.tbx7.Size = new System.Drawing.Size(54, 29);
            this.tbx7.TabIndex = 40;
            this.tbx7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx7.Click += new System.EventHandler(this.tbx_Click);
            this.tbx7.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl7
            // 
            this.lbl7.ForeColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(114, 723);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(155, 43);
            this.lbl7.TabIndex = 39;
            this.lbl7.Text = "-";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx16
            // 
            this.tbx16.BackColor = System.Drawing.Color.Black;
            this.tbx16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx16.Location = new System.Drawing.Point(511, 730);
            this.tbx16.Name = "tbx16";
            this.tbx16.Size = new System.Drawing.Size(54, 29);
            this.tbx16.TabIndex = 56;
            this.tbx16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx16.Click += new System.EventHandler(this.tbx_Click);
            this.tbx16.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl16
            // 
            this.lbl16.ForeColor = System.Drawing.Color.White;
            this.lbl16.Location = new System.Drawing.Point(350, 723);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(155, 43);
            this.lbl16.TabIndex = 55;
            this.lbl16.Text = "-";
            this.lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx15
            // 
            this.tbx15.BackColor = System.Drawing.Color.Black;
            this.tbx15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx15.Location = new System.Drawing.Point(511, 687);
            this.tbx15.Name = "tbx15";
            this.tbx15.Size = new System.Drawing.Size(54, 29);
            this.tbx15.TabIndex = 54;
            this.tbx15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx15.Click += new System.EventHandler(this.tbx_Click);
            this.tbx15.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl15
            // 
            this.lbl15.ForeColor = System.Drawing.Color.White;
            this.lbl15.Location = new System.Drawing.Point(350, 680);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(155, 43);
            this.lbl15.TabIndex = 53;
            this.lbl15.Text = "-";
            this.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx14
            // 
            this.tbx14.BackColor = System.Drawing.Color.Black;
            this.tbx14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx14.Location = new System.Drawing.Point(511, 644);
            this.tbx14.Name = "tbx14";
            this.tbx14.Size = new System.Drawing.Size(54, 29);
            this.tbx14.TabIndex = 52;
            this.tbx14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx14.Click += new System.EventHandler(this.tbx_Click);
            this.tbx14.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl14
            // 
            this.lbl14.ForeColor = System.Drawing.Color.White;
            this.lbl14.Location = new System.Drawing.Point(350, 637);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(155, 43);
            this.lbl14.TabIndex = 51;
            this.lbl14.Text = "-";
            this.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx13
            // 
            this.tbx13.BackColor = System.Drawing.Color.Black;
            this.tbx13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx13.Location = new System.Drawing.Point(511, 601);
            this.tbx13.Name = "tbx13";
            this.tbx13.Size = new System.Drawing.Size(54, 29);
            this.tbx13.TabIndex = 50;
            this.tbx13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx13.Click += new System.EventHandler(this.tbx_Click);
            this.tbx13.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl13
            // 
            this.lbl13.ForeColor = System.Drawing.Color.White;
            this.lbl13.Location = new System.Drawing.Point(350, 594);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(155, 43);
            this.lbl13.TabIndex = 49;
            this.lbl13.Text = "-";
            this.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx12
            // 
            this.tbx12.BackColor = System.Drawing.Color.Black;
            this.tbx12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx12.Location = new System.Drawing.Point(511, 558);
            this.tbx12.Name = "tbx12";
            this.tbx12.Size = new System.Drawing.Size(54, 29);
            this.tbx12.TabIndex = 48;
            this.tbx12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx12.Click += new System.EventHandler(this.tbx_Click);
            this.tbx12.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl12
            // 
            this.lbl12.ForeColor = System.Drawing.Color.White;
            this.lbl12.Location = new System.Drawing.Point(350, 551);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(155, 43);
            this.lbl12.TabIndex = 47;
            this.lbl12.Text = "-";
            this.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx11
            // 
            this.tbx11.BackColor = System.Drawing.Color.Black;
            this.tbx11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx11.Location = new System.Drawing.Point(511, 515);
            this.tbx11.Name = "tbx11";
            this.tbx11.Size = new System.Drawing.Size(54, 29);
            this.tbx11.TabIndex = 46;
            this.tbx11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx11.Click += new System.EventHandler(this.tbx_Click);
            this.tbx11.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl11
            // 
            this.lbl11.ForeColor = System.Drawing.Color.White;
            this.lbl11.Location = new System.Drawing.Point(350, 508);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(155, 43);
            this.lbl11.TabIndex = 45;
            this.lbl11.Text = "-";
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx10
            // 
            this.tbx10.BackColor = System.Drawing.Color.Black;
            this.tbx10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx10.Location = new System.Drawing.Point(511, 472);
            this.tbx10.Name = "tbx10";
            this.tbx10.Size = new System.Drawing.Size(54, 29);
            this.tbx10.TabIndex = 44;
            this.tbx10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx10.Click += new System.EventHandler(this.tbx_Click);
            this.tbx10.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl10
            // 
            this.lbl10.ForeColor = System.Drawing.Color.White;
            this.lbl10.Location = new System.Drawing.Point(350, 465);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(155, 43);
            this.lbl10.TabIndex = 43;
            this.lbl10.Text = "-";
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx9
            // 
            this.tbx9.BackColor = System.Drawing.Color.Black;
            this.tbx9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx9.Location = new System.Drawing.Point(511, 429);
            this.tbx9.Name = "tbx9";
            this.tbx9.Size = new System.Drawing.Size(54, 29);
            this.tbx9.TabIndex = 42;
            this.tbx9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx9.Click += new System.EventHandler(this.tbx_Click);
            this.tbx9.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl9
            // 
            this.lbl9.ForeColor = System.Drawing.Color.White;
            this.lbl9.Location = new System.Drawing.Point(350, 422);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(155, 43);
            this.lbl9.TabIndex = 41;
            this.lbl9.Text = "-";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx8
            // 
            this.tbx8.BackColor = System.Drawing.Color.Black;
            this.tbx8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx8.Location = new System.Drawing.Point(275, 773);
            this.tbx8.Name = "tbx8";
            this.tbx8.Size = new System.Drawing.Size(54, 29);
            this.tbx8.TabIndex = 58;
            this.tbx8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx8.Click += new System.EventHandler(this.tbx_Click);
            this.tbx8.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lbl8
            // 
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(114, 766);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(155, 43);
            this.lbl8.TabIndex = 57;
            this.lbl8.Text = "-";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnResetShortcuts
            // 
            this.btnResetShortcuts.BackColor = System.Drawing.Color.Black;
            this.btnResetShortcuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetShortcuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetShortcuts.ForeColor = System.Drawing.Color.Red;
            this.btnResetShortcuts.Location = new System.Drawing.Point(355, 768);
            this.btnResetShortcuts.Name = "btnResetShortcuts";
            this.btnResetShortcuts.Size = new System.Drawing.Size(210, 41);
            this.btnResetShortcuts.TabIndex = 59;
            this.btnResetShortcuts.Text = "Reset default";
            this.btnResetShortcuts.UseVisualStyleBackColor = false;
            this.btnResetShortcuts.Click += new System.EventHandler(this.btnResetShortcuts_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(688, 836);
            this.Controls.Add(this.btnResetShortcuts);
            this.Controls.Add(this.tbx8);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.tbx16);
            this.Controls.Add(this.lbl16);
            this.Controls.Add(this.tbx15);
            this.Controls.Add(this.lbl15);
            this.Controls.Add(this.tbx14);
            this.Controls.Add(this.lbl14);
            this.Controls.Add(this.tbx13);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.tbx12);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.tbx11);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.tbx10);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.tbx9);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.tbx7);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.tbx6);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.tbx5);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.tbx4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tbx0);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.btnResetSpeeds);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetSavePath);
            this.Controls.Add(this.gbInputSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.gbInputSource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudR25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudF10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudF25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInputSource;
        private System.Windows.Forms.ComboBox cmbSources;
        private System.Windows.Forms.Button btnCloseLiveInput;
        private System.Windows.Forms.Button btnSetSavePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.FolderBrowserDialog fbdReplay;
        private System.Windows.Forms.NumericUpDown nudR25;
        private System.Windows.Forms.NumericUpDown nudR10;
        private System.Windows.Forms.NumericUpDown nudR1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudF1;
        private System.Windows.Forms.NumericUpDown nudF10;
        private System.Windows.Forms.NumericUpDown nudF25;
        private System.Windows.Forms.Button btnResetSpeeds;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.TextBox tbx0;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tbx5;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox tbx6;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox tbx7;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox tbx16;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.TextBox tbx15;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.TextBox tbx14;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.TextBox tbx13;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.TextBox tbx12;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.TextBox tbx11;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.TextBox tbx10;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.TextBox tbx9;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.TextBox tbx8;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Button btnResetShortcuts;
    }
}