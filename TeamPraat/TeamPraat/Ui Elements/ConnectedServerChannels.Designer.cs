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
            this.components = new System.ComponentModel.Container();
            this.lbl_Channels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChatHistory = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.channel4 = new TeamPraat.Ui_Elements.Channel();
            this.channel3 = new TeamPraat.Ui_Elements.Channel();
            this.channel2 = new TeamPraat.Ui_Elements.Channel();
            this.channel1 = new TeamPraat.Ui_Elements.Channel();
            this.SuspendLayout();
            // 
            // lbl_Channels
            // 
            this.lbl_Channels.AutoSize = true;
            this.lbl_Channels.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Channels.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Channels.ForeColor = System.Drawing.Color.White;
            this.lbl_Channels.Location = new System.Drawing.Point(3, 34);
            this.lbl_Channels.Name = "lbl_Channels";
            this.lbl_Channels.Size = new System.Drawing.Size(163, 39);
            this.lbl_Channels.TabIndex = 0;
            this.lbl_Channels.Text = "Channels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(722, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(725, 574);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // ChatHistory
            // 
            this.ChatHistory.Location = new System.Drawing.Point(725, 98);
            this.ChatHistory.Name = "ChatHistory";
            this.ChatHistory.Size = new System.Drawing.Size(361, 460);
            this.ChatHistory.TabIndex = 7;
            this.ChatHistory.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // channel4
            // 
            this.channel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.channel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channel4.Location = new System.Drawing.Point(5, 272);
            this.channel4.Name = "channel4";
            this.channel4.Size = new System.Drawing.Size(648, 58);
            this.channel4.TabIndex = 4;
            // 
            // channel3
            // 
            this.channel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.channel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channel3.Location = new System.Drawing.Point(5, 208);
            this.channel3.Name = "channel3";
            this.channel3.Size = new System.Drawing.Size(648, 58);
            this.channel3.TabIndex = 3;
            // 
            // channel2
            // 
            this.channel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.channel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channel2.Location = new System.Drawing.Point(5, 142);
            this.channel2.Name = "channel2";
            this.channel2.Size = new System.Drawing.Size(650, 60);
            this.channel2.TabIndex = 2;
            // 
            // channel1
            // 
            this.channel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.channel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channel1.Location = new System.Drawing.Point(5, 76);
            this.channel1.Name = "channel1";
            this.channel1.Size = new System.Drawing.Size(650, 60);
            this.channel1.TabIndex = 1;
            // 
            // ConnectedServerChannels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChatHistory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.channel4);
            this.Controls.Add(this.channel3);
            this.Controls.Add(this.channel2);
            this.Controls.Add(this.channel1);
            this.Controls.Add(this.lbl_Channels);
            this.Name = "ConnectedServerChannels";
            this.Size = new System.Drawing.Size(1193, 637);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Channels;
        private Channel channel1;
        private Channel channel2;
        private Channel channel3;
        private Channel channel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox ChatHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
