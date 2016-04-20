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
            this.ButtonExp = new System.Windows.Forms.PictureBox();
            this.channelMemberList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExp)).BeginInit();
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
            // ButtonExp
            // 
            this.ButtonExp.Image = global::TeamPraat.Properties.Resources.ic_keyboard_arrow_down_black_24dp_2x;
            this.ButtonExp.Location = new System.Drawing.Point(598, 13);
            this.ButtonExp.Name = "ButtonExp";
            this.ButtonExp.Size = new System.Drawing.Size(37, 32);
            this.ButtonExp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButtonExp.TabIndex = 1;
            this.ButtonExp.TabStop = false;
            this.ButtonExp.Click += new System.EventHandler(this.ButtonExp_Click);
            // 
            // channelMemberList
            // 
            this.channelMemberList.FormattingEnabled = true;
            this.channelMemberList.Location = new System.Drawing.Point(19, 53);
            this.channelMemberList.Name = "channelMemberList";
            this.channelMemberList.Size = new System.Drawing.Size(616, 264);
            this.channelMemberList.TabIndex = 2;
            // 
            // Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.channelMemberList);
            this.Controls.Add(this.ButtonExp);
            this.Controls.Add(this.lbl_ChannelName);
            this.Name = "Channel";
            this.Size = new System.Drawing.Size(648, 474);
            this.Load += new System.EventHandler(this.Channel_Load);
            this.Click += new System.EventHandler(this.Channel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ChannelName;
        private System.Windows.Forms.PictureBox ButtonExp;
        private System.Windows.Forms.ListBox channelMemberList;
    }
}
