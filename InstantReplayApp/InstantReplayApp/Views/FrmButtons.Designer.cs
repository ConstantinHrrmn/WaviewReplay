namespace InstantReplayApp
{
    partial class FrmButtons
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
            this.btnSecondDisplay = new System.Windows.Forms.Button();
            this.btnSaveReplay = new System.Windows.Forms.Button();
            this.btnLive = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnForward25 = new System.Windows.Forms.Button();
            this.btnForward10 = new System.Windows.Forms.Button();
            this.btnForward1 = new System.Windows.Forms.Button();
            this.btnRewind1 = new System.Windows.Forms.Button();
            this.btnRewind10 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRewind25 = new System.Windows.Forms.Button();
            this.btnStartBuffer = new System.Windows.Forms.Button();
            this.btnReplayLive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSecondDisplay
            // 
            this.btnSecondDisplay.BackColor = System.Drawing.Color.White;
            this.btnSecondDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondDisplay.Location = new System.Drawing.Point(168, 12);
            this.btnSecondDisplay.Name = "btnSecondDisplay";
            this.btnSecondDisplay.Size = new System.Drawing.Size(150, 150);
            this.btnSecondDisplay.TabIndex = 1;
            this.btnSecondDisplay.Text = "Open Second Display";
            this.btnSecondDisplay.UseVisualStyleBackColor = false;
            this.btnSecondDisplay.Click += new System.EventHandler(this.btnSecondDisplay_Click);
            // 
            // btnSaveReplay
            // 
            this.btnSaveReplay.BackColor = System.Drawing.Color.White;
            this.btnSaveReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReplay.Image = global::InstantReplayApp.Properties.Resources.save;
            this.btnSaveReplay.Location = new System.Drawing.Point(12, 393);
            this.btnSaveReplay.Name = "btnSaveReplay";
            this.btnSaveReplay.Size = new System.Drawing.Size(150, 150);
            this.btnSaveReplay.TabIndex = 17;
            this.btnSaveReplay.Text = "Save Replay";
            this.btnSaveReplay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveReplay.UseVisualStyleBackColor = false;
            this.btnSaveReplay.Click += new System.EventHandler(this.btnSaveReplay_Click);
            // 
            // btnLive
            // 
            this.btnLive.BackColor = System.Drawing.Color.Red;
            this.btnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive.Image = global::InstantReplayApp.Properties.Resources.live;
            this.btnLive.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLive.Location = new System.Drawing.Point(1104, 393);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(150, 150);
            this.btnLive.TabIndex = 16;
            this.btnLive.Text = "GO LIVE (APP)";
            this.btnLive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLive.UseVisualStyleBackColor = false;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.BackColor = System.Drawing.Color.White;
            this.btnClearSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSelection.Image = global::InstantReplayApp.Properties.Resources.clear;
            this.btnClearSelection.Location = new System.Drawing.Point(792, 393);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(150, 150);
            this.btnClearSelection.TabIndex = 15;
            this.btnClearSelection.Text = "Clear";
            this.btnClearSelection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClearSelection.UseVisualStyleBackColor = false;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.White;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Image = global::InstantReplayApp.Properties.Resources.end;
            this.btnOut.Location = new System.Drawing.Point(636, 393);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(150, 150);
            this.btnOut.TabIndex = 14;
            this.btnOut.Text = "OUT";
            this.btnOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.White;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Image = global::InstantReplayApp.Properties.Resources.skip_start;
            this.btnIn.Location = new System.Drawing.Point(480, 393);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 150);
            this.btnIn.TabIndex = 13;
            this.btnIn.Text = "IN";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnCut
            // 
            this.btnCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCut.Image = global::InstantReplayApp.Properties.Resources.repeat;
            this.btnCut.Location = new System.Drawing.Point(324, 393);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(150, 150);
            this.btnCut.TabIndex = 12;
            this.btnCut.Text = "REPLAY";
            this.btnCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCut.UseVisualStyleBackColor = false;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnForward25
            // 
            this.btnForward25.BackColor = System.Drawing.Color.White;
            this.btnForward25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward25.Image = global::InstantReplayApp.Properties.Resources.fast_forward;
            this.btnForward25.Location = new System.Drawing.Point(1104, 219);
            this.btnForward25.Name = "btnForward25";
            this.btnForward25.Size = new System.Drawing.Size(150, 150);
            this.btnForward25.TabIndex = 11;
            this.btnForward25.Text = "25 %";
            this.btnForward25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForward25.UseVisualStyleBackColor = false;
            this.btnForward25.Click += new System.EventHandler(this.btnForward25_Click);
            // 
            // btnForward10
            // 
            this.btnForward10.BackColor = System.Drawing.Color.White;
            this.btnForward10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward10.Image = global::InstantReplayApp.Properties.Resources.fast_forward;
            this.btnForward10.Location = new System.Drawing.Point(948, 219);
            this.btnForward10.Name = "btnForward10";
            this.btnForward10.Size = new System.Drawing.Size(150, 150);
            this.btnForward10.TabIndex = 10;
            this.btnForward10.Text = "10 %";
            this.btnForward10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForward10.UseVisualStyleBackColor = false;
            this.btnForward10.Click += new System.EventHandler(this.btnForward10_Click);
            // 
            // btnForward1
            // 
            this.btnForward1.BackColor = System.Drawing.Color.White;
            this.btnForward1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward1.Image = global::InstantReplayApp.Properties.Resources.fast_forward;
            this.btnForward1.Location = new System.Drawing.Point(792, 219);
            this.btnForward1.Name = "btnForward1";
            this.btnForward1.Size = new System.Drawing.Size(150, 150);
            this.btnForward1.TabIndex = 9;
            this.btnForward1.Text = "1 %";
            this.btnForward1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForward1.UseVisualStyleBackColor = false;
            this.btnForward1.Click += new System.EventHandler(this.btnForward1_Click);
            // 
            // btnRewind1
            // 
            this.btnRewind1.BackColor = System.Drawing.Color.White;
            this.btnRewind1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRewind1.Image = global::InstantReplayApp.Properties.Resources.rewind;
            this.btnRewind1.Location = new System.Drawing.Point(324, 219);
            this.btnRewind1.Name = "btnRewind1";
            this.btnRewind1.Size = new System.Drawing.Size(150, 150);
            this.btnRewind1.TabIndex = 8;
            this.btnRewind1.Text = "1 %";
            this.btnRewind1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRewind1.UseVisualStyleBackColor = false;
            this.btnRewind1.Click += new System.EventHandler(this.btnRewind1_Click);
            // 
            // btnRewind10
            // 
            this.btnRewind10.BackColor = System.Drawing.Color.White;
            this.btnRewind10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRewind10.Image = global::InstantReplayApp.Properties.Resources.rewind;
            this.btnRewind10.Location = new System.Drawing.Point(168, 219);
            this.btnRewind10.Name = "btnRewind10";
            this.btnRewind10.Size = new System.Drawing.Size(150, 150);
            this.btnRewind10.TabIndex = 7;
            this.btnRewind10.Text = "10 %";
            this.btnRewind10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRewind10.UseVisualStyleBackColor = false;
            this.btnRewind10.Click += new System.EventHandler(this.btnRewind10_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::InstantReplayApp.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(636, 219);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 150);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.White;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::InstantReplayApp.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(480, 219);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(150, 150);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRewind25
            // 
            this.btnRewind25.BackColor = System.Drawing.Color.White;
            this.btnRewind25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRewind25.Image = global::InstantReplayApp.Properties.Resources.rewind;
            this.btnRewind25.Location = new System.Drawing.Point(12, 219);
            this.btnRewind25.Name = "btnRewind25";
            this.btnRewind25.Size = new System.Drawing.Size(150, 150);
            this.btnRewind25.TabIndex = 2;
            this.btnRewind25.Text = "25 %";
            this.btnRewind25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRewind25.UseVisualStyleBackColor = false;
            this.btnRewind25.Click += new System.EventHandler(this.btnRewind25_Click);
            // 
            // btnStartBuffer
            // 
            this.btnStartBuffer.BackColor = System.Drawing.Color.Red;
            this.btnStartBuffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartBuffer.Image = global::InstantReplayApp.Properties.Resources.smart_record;
            this.btnStartBuffer.Location = new System.Drawing.Point(12, 12);
            this.btnStartBuffer.Name = "btnStartBuffer";
            this.btnStartBuffer.Size = new System.Drawing.Size(150, 150);
            this.btnStartBuffer.TabIndex = 0;
            this.btnStartBuffer.Text = "Start Buffer";
            this.btnStartBuffer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStartBuffer.UseVisualStyleBackColor = false;
            this.btnStartBuffer.Click += new System.EventHandler(this.btnStartBuffer_Click);
            // 
            // btnReplayLive
            // 
            this.btnReplayLive.BackColor = System.Drawing.Color.White;
            this.btnReplayLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplayLive.Location = new System.Drawing.Point(324, 12);
            this.btnReplayLive.Name = "btnReplayLive";
            this.btnReplayLive.Size = new System.Drawing.Size(150, 150);
            this.btnReplayLive.TabIndex = 18;
            this.btnReplayLive.Text = "Live view (Replay screen)";
            this.btnReplayLive.UseVisualStyleBackColor = false;
            this.btnReplayLive.Click += new System.EventHandler(this.btnReplayLive_Click);
            // 
            // FrmButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1266, 568);
            this.Controls.Add(this.btnReplayLive);
            this.Controls.Add(this.btnSaveReplay);
            this.Controls.Add(this.btnLive);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnForward25);
            this.Controls.Add(this.btnForward10);
            this.Controls.Add(this.btnForward1);
            this.Controls.Add(this.btnRewind1);
            this.Controls.Add(this.btnRewind10);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnRewind25);
            this.Controls.Add(this.btnSecondDisplay);
            this.Controls.Add(this.btnStartBuffer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmButtons";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "On Screen Buttons";
            this.Load += new System.EventHandler(this.FrmButtons_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmButtons_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartBuffer;
        private System.Windows.Forms.Button btnSecondDisplay;
        private System.Windows.Forms.Button btnRewind25;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRewind10;
        private System.Windows.Forms.Button btnRewind1;
        private System.Windows.Forms.Button btnForward1;
        private System.Windows.Forms.Button btnForward10;
        private System.Windows.Forms.Button btnForward25;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnLive;
        private System.Windows.Forms.Button btnSaveReplay;
        private System.Windows.Forms.Button btnReplayLive;
    }
}