namespace InstantReplayApp
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.pbLive = new System.Windows.Forms.PictureBox();
            this.cmbSources = new System.Windows.Forms.ComboBox();
            this.btnCloseLiveInput = new System.Windows.Forms.Button();
            this.lblInputResolution = new System.Windows.Forms.Label();
            this.lblDisplayResolution = new System.Windows.Forms.Label();
            this.gbInputSource = new System.Windows.Forms.GroupBox();
            this.pbReplay = new System.Windows.Forms.PictureBox();
            this.btnSetSavePath = new System.Windows.Forms.Button();
            this.fbdReplay = new System.Windows.Forms.FolderBrowserDialog();
            this.replayTimer = new System.Windows.Forms.Timer(this.components);
            this.lblReplay = new System.Windows.Forms.Label();
            this.BufferTimer = new System.Windows.Forms.Timer(this.components);
            this.tbReplay = new System.Windows.Forms.TrackBar();
            this.tbxCommand = new System.Windows.Forms.TextBox();
            this.lblSpeedPourcentage = new System.Windows.Forms.Label();
            this.lblSecondsInBuffer = new System.Windows.Forms.Label();
            this.lblLiveEnds = new System.Windows.Forms.Label();
            this.lblBufferWarning = new System.Windows.Forms.Label();
            this.lblLiveWarning = new System.Windows.Forms.Label();
            this.pbLiveReplay = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnOnScreenButtons = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).BeginInit();
            this.gbInputSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveReplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLive
            // 
            this.pbLive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLive.Location = new System.Drawing.Point(17, 113);
            this.pbLive.Name = "pbLive";
            this.pbLive.Size = new System.Drawing.Size(640, 360);
            this.pbLive.TabIndex = 0;
            this.pbLive.TabStop = false;
            this.pbLive.Click += new System.EventHandler(this.pbLive_Click);
            // 
            // cmbSources
            // 
            this.cmbSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSources.Location = new System.Drawing.Point(6, 29);
            this.cmbSources.Name = "cmbSources";
            this.cmbSources.Size = new System.Drawing.Size(363, 32);
            this.cmbSources.TabIndex = 1;
            this.cmbSources.SelectedIndexChanged += new System.EventHandler(this.cmbSources_SelectedIndexChanged);
            // 
            // btnCloseLiveInput
            // 
            this.btnCloseLiveInput.BackColor = System.Drawing.Color.Black;
            this.btnCloseLiveInput.Enabled = false;
            this.btnCloseLiveInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLiveInput.Location = new System.Drawing.Point(375, 20);
            this.btnCloseLiveInput.Name = "btnCloseLiveInput";
            this.btnCloseLiveInput.Size = new System.Drawing.Size(94, 49);
            this.btnCloseLiveInput.TabIndex = 3;
            this.btnCloseLiveInput.Text = "STOP";
            this.btnCloseLiveInput.UseVisualStyleBackColor = false;
            this.btnCloseLiveInput.Click += new System.EventHandler(this.btnCloseLiveInput_Click);
            // 
            // lblInputResolution
            // 
            this.lblInputResolution.AutoSize = true;
            this.lblInputResolution.ForeColor = System.Drawing.Color.White;
            this.lblInputResolution.Location = new System.Drawing.Point(1309, 47);
            this.lblInputResolution.Name = "lblInputResolution";
            this.lblInputResolution.Size = new System.Drawing.Size(206, 25);
            this.lblInputResolution.TabIndex = 4;
            this.lblInputResolution.Text = "Input resolution : Y x Y";
            this.lblInputResolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisplayResolution
            // 
            this.lblDisplayResolution.AutoSize = true;
            this.lblDisplayResolution.ForeColor = System.Drawing.Color.White;
            this.lblDisplayResolution.Location = new System.Drawing.Point(1309, 20);
            this.lblDisplayResolution.Name = "lblDisplayResolution";
            this.lblDisplayResolution.Size = new System.Drawing.Size(227, 25);
            this.lblDisplayResolution.TabIndex = 5;
            this.lblDisplayResolution.Text = "Display resolution : Y x Y";
            this.lblDisplayResolution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbInputSource
            // 
            this.gbInputSource.BackColor = System.Drawing.Color.Black;
            this.gbInputSource.Controls.Add(this.cmbSources);
            this.gbInputSource.Controls.Add(this.btnCloseLiveInput);
            this.gbInputSource.ForeColor = System.Drawing.Color.Red;
            this.gbInputSource.Location = new System.Drawing.Point(17, 12);
            this.gbInputSource.Name = "gbInputSource";
            this.gbInputSource.Size = new System.Drawing.Size(475, 82);
            this.gbInputSource.TabIndex = 6;
            this.gbInputSource.TabStop = false;
            this.gbInputSource.Text = "Input Source";
            // 
            // pbReplay
            // 
            this.pbReplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReplay.Location = new System.Drawing.Point(663, 113);
            this.pbReplay.Name = "pbReplay";
            this.pbReplay.Size = new System.Drawing.Size(640, 360);
            this.pbReplay.TabIndex = 7;
            this.pbReplay.TabStop = false;
            this.pbReplay.Click += new System.EventHandler(this.pbReplay_Click);
            // 
            // btnSetSavePath
            // 
            this.btnSetSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSavePath.Location = new System.Drawing.Point(498, 32);
            this.btnSetSavePath.Name = "btnSetSavePath";
            this.btnSetSavePath.Size = new System.Drawing.Size(159, 49);
            this.btnSetSavePath.TabIndex = 9;
            this.btnSetSavePath.Text = "SAVE";
            this.btnSetSavePath.UseVisualStyleBackColor = true;
            this.btnSetSavePath.Click += new System.EventHandler(this.btnSetSavePath_Click);
            // 
            // replayTimer
            // 
            this.replayTimer.Tick += new System.EventHandler(this.replayTimer_Tick);
            // 
            // lblReplay
            // 
            this.lblReplay.AutoSize = true;
            this.lblReplay.ForeColor = System.Drawing.Color.White;
            this.lblReplay.Location = new System.Drawing.Point(1309, 77);
            this.lblReplay.Name = "lblReplay";
            this.lblReplay.Size = new System.Drawing.Size(128, 25);
            this.lblReplay.TabIndex = 15;
            this.lblReplay.Text = "Speed : 0 ms";
            this.lblReplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BufferTimer
            // 
            this.BufferTimer.Tick += new System.EventHandler(this.BufferTimer_Tick);
            // 
            // tbReplay
            // 
            this.tbReplay.Location = new System.Drawing.Point(663, 32);
            this.tbReplay.Maximum = 400;
            this.tbReplay.Name = "tbReplay";
            this.tbReplay.Size = new System.Drawing.Size(640, 80);
            this.tbReplay.TabIndex = 17;
            this.tbReplay.TickFrequency = 10;
            this.tbReplay.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbReplay.Value = 100;
            this.tbReplay.Scroll += new System.EventHandler(this.tbReplay_Scroll);
            // 
            // tbxCommand
            // 
            this.tbxCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbxCommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCommand.Location = new System.Drawing.Point(1663, 32);
            this.tbxCommand.Name = "tbxCommand";
            this.tbxCommand.Size = new System.Drawing.Size(100, 22);
            this.tbxCommand.TabIndex = 18;
            this.tbxCommand.TextChanged += new System.EventHandler(this.tbxCommand_TextChanged);
            this.tbxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCommand_KeyPress);
            // 
            // lblSpeedPourcentage
            // 
            this.lblSpeedPourcentage.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedPourcentage.ForeColor = System.Drawing.Color.White;
            this.lblSpeedPourcentage.Location = new System.Drawing.Point(1001, 476);
            this.lblSpeedPourcentage.Name = "lblSpeedPourcentage";
            this.lblSpeedPourcentage.Size = new System.Drawing.Size(302, 98);
            this.lblSpeedPourcentage.TabIndex = 25;
            this.lblSpeedPourcentage.Text = "000%";
            this.lblSpeedPourcentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecondsInBuffer
            // 
            this.lblSecondsInBuffer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSecondsInBuffer.ForeColor = System.Drawing.Color.Black;
            this.lblSecondsInBuffer.Location = new System.Drawing.Point(1563, 72);
            this.lblSecondsInBuffer.Name = "lblSecondsInBuffer";
            this.lblSecondsInBuffer.Size = new System.Drawing.Size(66, 34);
            this.lblSecondsInBuffer.TabIndex = 26;
            this.lblSecondsInBuffer.Text = "0,00";
            this.lblSecondsInBuffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLiveEnds
            // 
            this.lblLiveEnds.BackColor = System.Drawing.Color.Green;
            this.lblLiveEnds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLiveEnds.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveEnds.ForeColor = System.Drawing.Color.White;
            this.lblLiveEnds.Location = new System.Drawing.Point(1309, 113);
            this.lblLiveEnds.Name = "lblLiveEnds";
            this.lblLiveEnds.Size = new System.Drawing.Size(320, 168);
            this.lblLiveEnds.TabIndex = 27;
            this.lblLiveEnds.Text = "0.00";
            this.lblLiveEnds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBufferWarning
            // 
            this.lblBufferWarning.AutoSize = true;
            this.lblBufferWarning.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBufferWarning.ForeColor = System.Drawing.Color.Red;
            this.lblBufferWarning.Location = new System.Drawing.Point(709, 261);
            this.lblBufferWarning.Name = "lblBufferWarning";
            this.lblBufferWarning.Size = new System.Drawing.Size(554, 59);
            this.lblBufferWarning.TabIndex = 28;
            this.lblBufferWarning.Text = "BUFFER NOT STARTED";
            // 
            // lblLiveWarning
            // 
            this.lblLiveWarning.AutoSize = true;
            this.lblLiveWarning.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveWarning.ForeColor = System.Drawing.Color.Red;
            this.lblLiveWarning.Location = new System.Drawing.Point(66, 261);
            this.lblLiveWarning.Name = "lblLiveWarning";
            this.lblLiveWarning.Size = new System.Drawing.Size(513, 59);
            this.lblLiveWarning.TabIndex = 29;
            this.lblLiveWarning.Text = "NO INPUT SELECTED";
            // 
            // pbLiveReplay
            // 
            this.pbLiveReplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbLiveReplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLiveReplay.Location = new System.Drawing.Point(1309, 293);
            this.pbLiveReplay.Name = "pbLiveReplay";
            this.pbLiveReplay.Size = new System.Drawing.Size(320, 180);
            this.pbLiveReplay.TabIndex = 30;
            this.pbLiveReplay.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(1309, 476);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(320, 98);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "-";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOnScreenButtons
            // 
            this.btnOnScreenButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnScreenButtons.Location = new System.Drawing.Point(17, 507);
            this.btnOnScreenButtons.Name = "btnOnScreenButtons";
            this.btnOnScreenButtons.Size = new System.Drawing.Size(202, 57);
            this.btnOnScreenButtons.TabIndex = 32;
            this.btnOnScreenButtons.Text = "BUTTONS";
            this.btnOnScreenButtons.UseVisualStyleBackColor = true;
            this.btnOnScreenButtons.Click += new System.EventHandler(this.btnOnScreenButtons_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(225, 507);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(202, 57);
            this.btnSettings.TabIndex = 33;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1645, 585);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnOnScreenButtons);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbLiveReplay);
            this.Controls.Add(this.lblLiveWarning);
            this.Controls.Add(this.lblBufferWarning);
            this.Controls.Add(this.lblLiveEnds);
            this.Controls.Add(this.lblSecondsInBuffer);
            this.Controls.Add(this.lblSpeedPourcentage);
            this.Controls.Add(this.tbxCommand);
            this.Controls.Add(this.tbReplay);
            this.Controls.Add(this.lblReplay);
            this.Controls.Add(this.btnSetSavePath);
            this.Controls.Add(this.pbReplay);
            this.Controls.Add(this.gbInputSource);
            this.Controls.Add(this.lblDisplayResolution);
            this.Controls.Add(this.lblInputResolution);
            this.Controls.Add(this.pbLive);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waview Instant Replay";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).EndInit();
            this.gbInputSource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveReplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLive;
        private System.Windows.Forms.ComboBox cmbSources;
        private System.Windows.Forms.Button btnCloseLiveInput;
        private System.Windows.Forms.Label lblInputResolution;
        private System.Windows.Forms.Label lblDisplayResolution;
        private System.Windows.Forms.GroupBox gbInputSource;
        private System.Windows.Forms.PictureBox pbReplay;
        private System.Windows.Forms.Button btnSetSavePath;
        private System.Windows.Forms.FolderBrowserDialog fbdReplay;
        private System.Windows.Forms.Timer replayTimer;
        private System.Windows.Forms.Label lblReplay;
        private System.Windows.Forms.Timer BufferTimer;
        private System.Windows.Forms.TrackBar tbReplay;
        private System.Windows.Forms.TextBox tbxCommand;
        private System.Windows.Forms.Label lblSpeedPourcentage;
        private System.Windows.Forms.Label lblSecondsInBuffer;
        private System.Windows.Forms.Label lblLiveEnds;
        private System.Windows.Forms.Label lblBufferWarning;
        private System.Windows.Forms.Label lblLiveWarning;
        private System.Windows.Forms.PictureBox pbLiveReplay;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnOnScreenButtons;
        private System.Windows.Forms.Button btnSettings;
    }
}

