namespace TeamPraat.Ui_Elements
{
    partial class ConnectedServer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblServerName = new System.Windows.Forms.Label();
            this.pbDisconnect = new System.Windows.Forms.PictureBox();
            this.pbServerSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisconnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(4, 4);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(35, 13);
            this.lblServerName.TabIndex = 2;
            this.lblServerName.Text = "label1";
            // 
            // pbDisconnect
            // 
            this.pbDisconnect.Image = global::TeamPraat.Properties.Resources.ic_clear_black_24dp_2x;
            this.pbDisconnect.Location = new System.Drawing.Point(3, 110);
            this.pbDisconnect.Name = "pbDisconnect";
            this.pbDisconnect.Size = new System.Drawing.Size(25, 27);
            this.pbDisconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDisconnect.TabIndex = 3;
            this.pbDisconnect.TabStop = false;
            this.pbDisconnect.Click += new System.EventHandler(this.pbDisconnect_Click);
            // 
            // pbServerSettings
            // 
            this.pbServerSettings.Image = global::TeamPraat.Properties.Resources.ic_keyboard_arrow_down_black_24dp_2x;
            this.pbServerSettings.Location = new System.Drawing.Point(60, 60);
            this.pbServerSettings.Name = "pbServerSettings";
            this.pbServerSettings.Size = new System.Drawing.Size(25, 27);
            this.pbServerSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbServerSettings.TabIndex = 1;
            this.pbServerSettings.TabStop = false;
            this.pbServerSettings.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ConnectedServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbDisconnect);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.pbServerSettings);
            this.Name = "ConnectedServer";
            this.Size = new System.Drawing.Size(90, 90);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_ServerIcon_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisconnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbServerSettings;
        private System.Windows.Forms.Label lblServerName;
        public System.Windows.Forms.PictureBox pbDisconnect;
    }
}
