﻿namespace TeamPraat.Ui_Elements
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
            this.channel2 = new Channel();
            this.channel1 = new Channel();
            this.channel3 = new Channel();
            this.channel4 = new Channel();
            this.SuspendLayout();
            // 
            // lbl_Channels
            // 
            this.lbl_Channels.AutoSize = true;
            this.lbl_Channels.Location = new System.Drawing.Point(14, 10);
            this.lbl_Channels.Name = "lbl_Channels";
            this.lbl_Channels.Size = new System.Drawing.Size(51, 13);
            this.lbl_Channels.TabIndex = 0;
            this.lbl_Channels.Text = "Channels";
            // 
            // channel2
            // 
            this.channel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channel2.Location = new System.Drawing.Point(3, 92);
            this.channel2.Name = "channel2";
            this.channel2.Size = new System.Drawing.Size(650, 60);
            this.channel2.TabIndex = 2;
            // 
            // channel1
            // 
            this.channel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channel1.Location = new System.Drawing.Point(3, 26);
            this.channel1.Name = "channel1";
            this.channel1.Size = new System.Drawing.Size(650, 60);
            this.channel1.TabIndex = 1;
            // 
            // channel3
            // 
            this.channel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channel3.Location = new System.Drawing.Point(5, 158);
            this.channel3.Name = "channel3";
            this.channel3.Size = new System.Drawing.Size(648, 58);
            this.channel3.TabIndex = 3;
            // 
            // channel4
            // 
            this.channel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channel4.Location = new System.Drawing.Point(5, 222);
            this.channel4.Name = "channel4";
            this.channel4.Size = new System.Drawing.Size(648, 58);
            this.channel4.TabIndex = 4;
            // 
            // ConnectedServerChannels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.channel4);
            this.Controls.Add(this.channel3);
            this.Controls.Add(this.channel2);
            this.Controls.Add(this.channel1);
            this.Controls.Add(this.lbl_Channels);
            this.Name = "ConnectedServerChannels";
            this.Size = new System.Drawing.Size(677, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Channels;
        private Channel channel1;
        private Channel channel2;
        private Channel channel3;
        private Channel channel4;
    }
}
