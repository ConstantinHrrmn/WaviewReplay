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
            this.gbInputSource.SuspendLayout();
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
            this.gbInputSource.Size = new System.Drawing.Size(475, 82);
            this.gbInputSource.TabIndex = 7;
            this.gbInputSource.TabStop = false;
            this.gbInputSource.Text = "Input Source";
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
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(776, 836);
            this.Controls.Add(this.gbInputSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.gbInputSource.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInputSource;
        private System.Windows.Forms.ComboBox cmbSources;
        private System.Windows.Forms.Button btnCloseLiveInput;
    }
}