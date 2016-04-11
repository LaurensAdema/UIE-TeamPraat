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
            this.pb_ServerIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ServerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_ServerIcon
            // 
            this.pb_ServerIcon.Location = new System.Drawing.Point(-1, -1);
            this.pb_ServerIcon.Name = "pb_ServerIcon";
            this.pb_ServerIcon.Size = new System.Drawing.Size(92, 92);
            this.pb_ServerIcon.TabIndex = 0;
            this.pb_ServerIcon.TabStop = false;
            this.pb_ServerIcon.Click += new System.EventHandler(this.pb_ServerIcon_Click);
            // 
            // ConnectedServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pb_ServerIcon);
            this.Name = "ConnectedServer";
            this.Size = new System.Drawing.Size(90, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ServerIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ServerIcon;
    }
}
