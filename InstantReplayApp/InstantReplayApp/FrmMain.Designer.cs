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
            this.btnCreateVideo = new System.Windows.Forms.Button();
            this.btnSetSavePath = new System.Windows.Forms.Button();
            this.fbdReplay = new System.Windows.Forms.FolderBrowserDialog();
            this.lblSaveReplayPath = new System.Windows.Forms.Label();
            this.btnStartBuffer = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.replayTimer = new System.Windows.Forms.Timer(this.components);
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.lblReplay = new System.Windows.Forms.Label();
            this.BufferTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBackToLive = new System.Windows.Forms.Button();
            this.tbReplay = new System.Windows.Forms.TrackBar();
            this.tbxCommand = new System.Windows.Forms.TextBox();
            this.btnCut = new System.Windows.Forms.Button();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.btnStartSecondWindow = new System.Windows.Forms.Button();
            this.btnToLive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).BeginInit();
            this.gbInputSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLive
            // 
            this.pbLive.Location = new System.Drawing.Point(17, 69);
            this.pbLive.Name = "pbLive";
            this.pbLive.Size = new System.Drawing.Size(640, 360);
            this.pbLive.TabIndex = 0;
            this.pbLive.TabStop = false;
            // 
            // cmbSources
            // 
            this.cmbSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSources.Location = new System.Drawing.Point(6, 36);
            this.cmbSources.Name = "cmbSources";
            this.cmbSources.Size = new System.Drawing.Size(528, 32);
            this.cmbSources.TabIndex = 1;
            this.cmbSources.SelectedIndexChanged += new System.EventHandler(this.cmbSources_SelectedIndexChanged);
            // 
            // btnCloseLiveInput
            // 
            this.btnCloseLiveInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLiveInput.Location = new System.Drawing.Point(540, 27);
            this.btnCloseLiveInput.Name = "btnCloseLiveInput";
            this.btnCloseLiveInput.Size = new System.Drawing.Size(94, 49);
            this.btnCloseLiveInput.TabIndex = 3;
            this.btnCloseLiveInput.Text = "Stop";
            this.btnCloseLiveInput.UseVisualStyleBackColor = true;
            this.btnCloseLiveInput.Click += new System.EventHandler(this.btnCloseLiveInput_Click);
            // 
            // lblInputResolution
            // 
            this.lblInputResolution.AutoSize = true;
            this.lblInputResolution.Location = new System.Drawing.Point(12, 24);
            this.lblInputResolution.Name = "lblInputResolution";
            this.lblInputResolution.Size = new System.Drawing.Size(206, 25);
            this.lblInputResolution.TabIndex = 4;
            this.lblInputResolution.Text = "Input resolution : Y x Y";
            this.lblInputResolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisplayResolution
            // 
            this.lblDisplayResolution.AutoSize = true;
            this.lblDisplayResolution.Location = new System.Drawing.Point(425, 24);
            this.lblDisplayResolution.Name = "lblDisplayResolution";
            this.lblDisplayResolution.Size = new System.Drawing.Size(227, 25);
            this.lblDisplayResolution.TabIndex = 5;
            this.lblDisplayResolution.Text = "Display resolution : Y x Y";
            this.lblDisplayResolution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbInputSource
            // 
            this.gbInputSource.Controls.Add(this.cmbSources);
            this.gbInputSource.Controls.Add(this.btnCloseLiveInput);
            this.gbInputSource.Location = new System.Drawing.Point(17, 435);
            this.gbInputSource.Name = "gbInputSource";
            this.gbInputSource.Size = new System.Drawing.Size(640, 82);
            this.gbInputSource.TabIndex = 6;
            this.gbInputSource.TabStop = false;
            this.gbInputSource.Text = "Input Source";
            // 
            // pbReplay
            // 
            this.pbReplay.Location = new System.Drawing.Point(663, 67);
            this.pbReplay.Name = "pbReplay";
            this.pbReplay.Size = new System.Drawing.Size(640, 360);
            this.pbReplay.TabIndex = 7;
            this.pbReplay.TabStop = false;
            // 
            // btnCreateVideo
            // 
            this.btnCreateVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateVideo.Location = new System.Drawing.Point(1080, 827);
            this.btnCreateVideo.Name = "btnCreateVideo";
            this.btnCreateVideo.Size = new System.Drawing.Size(223, 49);
            this.btnCreateVideo.TabIndex = 8;
            this.btnCreateVideo.Text = "Create Video";
            this.btnCreateVideo.UseVisualStyleBackColor = true;
            this.btnCreateVideo.Click += new System.EventHandler(this.btnCreateVideo_Click);
            // 
            // btnSetSavePath
            // 
            this.btnSetSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSavePath.Location = new System.Drawing.Point(788, 12);
            this.btnSetSavePath.Name = "btnSetSavePath";
            this.btnSetSavePath.Size = new System.Drawing.Size(223, 49);
            this.btnSetSavePath.TabIndex = 9;
            this.btnSetSavePath.Text = "Set Save Path";
            this.btnSetSavePath.UseVisualStyleBackColor = true;
            this.btnSetSavePath.Click += new System.EventHandler(this.btnSetSavePath_Click);
            // 
            // lblSaveReplayPath
            // 
            this.lblSaveReplayPath.AutoSize = true;
            this.lblSaveReplayPath.Location = new System.Drawing.Point(1017, 24);
            this.lblSaveReplayPath.Name = "lblSaveReplayPath";
            this.lblSaveReplayPath.Size = new System.Drawing.Size(19, 25);
            this.lblSaveReplayPath.TabIndex = 10;
            this.lblSaveReplayPath.Text = "-";
            this.lblSaveReplayPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStartBuffer
            // 
            this.btnStartBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartBuffer.Location = new System.Drawing.Point(1080, 717);
            this.btnStartBuffer.Name = "btnStartBuffer";
            this.btnStartBuffer.Size = new System.Drawing.Size(223, 49);
            this.btnStartBuffer.TabIndex = 11;
            this.btnStartBuffer.Text = "Start Buffer";
            this.btnStartBuffer.UseVisualStyleBackColor = true;
            this.btnStartBuffer.Click += new System.EventHandler(this.btnStartBuffer_Click);
            // 
            // btnOut
            // 
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Location = new System.Drawing.Point(851, 827);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(223, 49);
            this.btnOut.TabIndex = 12;
            this.btnOut.Text = "&Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Location = new System.Drawing.Point(622, 827);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(223, 49);
            this.btnIn.TabIndex = 13;
            this.btnIn.Text = "&In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // replayTimer
            // 
            this.replayTimer.Tick += new System.EventHandler(this.replayTimer_Tick);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSelection.Location = new System.Drawing.Point(393, 827);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(223, 49);
            this.btnClearSelection.TabIndex = 14;
            this.btnClearSelection.Text = "Clear";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // lblReplay
            // 
            this.lblReplay.AutoSize = true;
            this.lblReplay.Location = new System.Drawing.Point(388, 799);
            this.lblReplay.Name = "lblReplay";
            this.lblReplay.Size = new System.Drawing.Size(19, 25);
            this.lblReplay.TabIndex = 15;
            this.lblReplay.Text = "-";
            this.lblReplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BufferTimer
            // 
            this.BufferTimer.Tick += new System.EventHandler(this.BufferTimer_Tick);
            // 
            // btnBackToLive
            // 
            this.btnBackToLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLive.Location = new System.Drawing.Point(851, 717);
            this.btnBackToLive.Name = "btnBackToLive";
            this.btnBackToLive.Size = new System.Drawing.Size(223, 49);
            this.btnBackToLive.TabIndex = 16;
            this.btnBackToLive.Text = "Back To Live";
            this.btnBackToLive.UseVisualStyleBackColor = true;
            // 
            // tbReplay
            // 
            this.tbReplay.Location = new System.Drawing.Point(663, 437);
            this.tbReplay.Name = "tbReplay";
            this.tbReplay.Size = new System.Drawing.Size(640, 80);
            this.tbReplay.TabIndex = 17;
            this.tbReplay.Scroll += new System.EventHandler(this.tbReplay_Scroll);
            // 
            // tbxCommand
            // 
            this.tbxCommand.Location = new System.Drawing.Point(2, 809);
            this.tbxCommand.Name = "tbxCommand";
            this.tbxCommand.Size = new System.Drawing.Size(100, 29);
            this.tbxCommand.TabIndex = 18;
            this.tbxCommand.TextChanged += new System.EventHandler(this.tbxCommand_TextChanged);
            this.tbxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCommand_KeyPress);
            // 
            // btnCut
            // 
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCut.Location = new System.Drawing.Point(622, 772);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(681, 49);
            this.btnCut.TabIndex = 19;
            this.btnCut.Text = "CUT";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(663, 495);
            this.tbSpeed.Maximum = 100;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(640, 80);
            this.tbSpeed.TabIndex = 20;
            this.tbSpeed.TickFrequency = 10;
            this.tbSpeed.Value = 100;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // btnStartSecondWindow
            // 
            this.btnStartSecondWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSecondWindow.Location = new System.Drawing.Point(622, 717);
            this.btnStartSecondWindow.Name = "btnStartSecondWindow";
            this.btnStartSecondWindow.Size = new System.Drawing.Size(223, 49);
            this.btnStartSecondWindow.TabIndex = 21;
            this.btnStartSecondWindow.Text = "Start 2nd Window";
            this.btnStartSecondWindow.UseVisualStyleBackColor = true;
            this.btnStartSecondWindow.Click += new System.EventHandler(this.btnStartSecondWindow_Click);
            // 
            // btnToLive
            // 
            this.btnToLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLive.Location = new System.Drawing.Point(393, 717);
            this.btnToLive.Name = "btnToLive";
            this.btnToLive.Size = new System.Drawing.Size(223, 49);
            this.btnToLive.TabIndex = 22;
            this.btnToLive.Text = "SEND REPLAY LIVE";
            this.btnToLive.UseVisualStyleBackColor = true;
            this.btnToLive.Click += new System.EventHandler(this.btnToLive_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1314, 886);
            this.Controls.Add(this.btnToLive);
            this.Controls.Add(this.btnStartSecondWindow);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.tbxCommand);
            this.Controls.Add(this.tbReplay);
            this.Controls.Add(this.btnBackToLive);
            this.Controls.Add(this.lblReplay);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnStartBuffer);
            this.Controls.Add(this.lblSaveReplayPath);
            this.Controls.Add(this.btnSetSavePath);
            this.Controls.Add(this.btnCreateVideo);
            this.Controls.Add(this.pbReplay);
            this.Controls.Add(this.gbInputSource);
            this.Controls.Add(this.lblDisplayResolution);
            this.Controls.Add(this.lblInputResolution);
            this.Controls.Add(this.pbLive);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Waview Instant Replay";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbLive)).EndInit();
            this.gbInputSource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
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
        private System.Windows.Forms.Button btnCreateVideo;
        private System.Windows.Forms.Button btnSetSavePath;
        private System.Windows.Forms.FolderBrowserDialog fbdReplay;
        private System.Windows.Forms.Label lblSaveReplayPath;
        private System.Windows.Forms.Button btnStartBuffer;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Timer replayTimer;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Label lblReplay;
        private System.Windows.Forms.Timer BufferTimer;
        private System.Windows.Forms.Button btnBackToLive;
        private System.Windows.Forms.TrackBar tbReplay;
        private System.Windows.Forms.TextBox tbxCommand;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Button btnStartSecondWindow;
        private System.Windows.Forms.Button btnToLive;
    }
}

