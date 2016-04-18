namespace TeamPraat.Ui_Elements
{
    partial class Channel
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
            this.lbl_ChannelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ChannelName
            // 
            this.lbl_ChannelName.AutoSize = true;
            this.lbl_ChannelName.Location = new System.Drawing.Point(16, 23);
            this.lbl_ChannelName.Name = "lbl_ChannelName";
            this.lbl_ChannelName.Size = new System.Drawing.Size(35, 13);
            this.lbl_ChannelName.TabIndex = 0;
            this.lbl_ChannelName.Text = "label1";
            // 
            // Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_ChannelName);
            this.Name = "Channel";
            this.Size = new System.Drawing.Size(648, 58);
            this.Load += new System.EventHandler(this.Channel_Load);
            this.Click += new System.EventHandler(this.Channel_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ChannelName;
    }
}
