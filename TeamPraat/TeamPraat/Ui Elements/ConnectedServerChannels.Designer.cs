namespace TeamPraat.Ui_Elements
{
    partial class ConnectedServerChannels
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
            this.lbl_Channels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Channels
            // 
            this.lbl_Channels.AutoSize = true;
            this.lbl_Channels.Location = new System.Drawing.Point(3, 12);
            this.lbl_Channels.Name = "lbl_Channels";
            this.lbl_Channels.Size = new System.Drawing.Size(51, 13);
            this.lbl_Channels.TabIndex = 0;
            this.lbl_Channels.Text = "Channels";
            // 
            // ConnectedServerChannels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Channels);
            this.Name = "ConnectedServerChannels";
            this.Size = new System.Drawing.Size(677, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Channels;
    }
}
