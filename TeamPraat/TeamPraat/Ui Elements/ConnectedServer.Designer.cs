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
            this.pbServerSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbServerSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // pbServerSettings
            // 
            this.pbServerSettings.Image = global::TeamPraat.Properties.Resources.ic_keyboard_arrow_down_black_24dp_2x1;
            this.pbServerSettings.Location = new System.Drawing.Point(66, 64);
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
            this.Controls.Add(this.pbServerSettings);
            this.Name = "ConnectedServer";
            this.Size = new System.Drawing.Size(90, 90);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_ServerIcon_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbServerSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbServerSettings;
    }
}
