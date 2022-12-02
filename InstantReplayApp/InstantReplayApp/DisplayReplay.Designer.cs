namespace InstantReplayApp
{
    partial class DisplayReplay
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
            this.pbReplayFull = new System.Windows.Forms.PictureBox();
            this.replayLive = new System.Windows.Forms.Timer(this.components);
            this.lblDebug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplayFull)).BeginInit();
            this.SuspendLayout();
            // 
            // pbReplayFull
            // 
            this.pbReplayFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbReplayFull.Location = new System.Drawing.Point(0, 0);
            this.pbReplayFull.Name = "pbReplayFull";
            this.pbReplayFull.Size = new System.Drawing.Size(100, 100);
            this.pbReplayFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReplayFull.TabIndex = 0;
            this.pbReplayFull.TabStop = false;
            // 
            // replayLive
            // 
            this.replayLive.Interval = 40;
            this.replayLive.Tick += new System.EventHandler(this.replayLive_Tick);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebug.ForeColor = System.Drawing.Color.Red;
            this.lblDebug.Location = new System.Drawing.Point(371, 208);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(452, 126);
            this.lblDebug.TabIndex = 1;
            this.lblDebug.Text = "DEBUG";
            this.lblDebug.Visible = false;
            // 
            // DisplayReplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.pbReplayFull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayReplay";
            this.Text = "DisplayReplay";
            this.Load += new System.EventHandler(this.DisplayReplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReplayFull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbReplayFull;
        private System.Windows.Forms.Timer replayLive;
        private System.Windows.Forms.Label lblDebug;
    }
}