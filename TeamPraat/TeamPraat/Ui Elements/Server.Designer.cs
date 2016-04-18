namespace TeamPraat.Ui_Elements
{
    partial class Server
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
            this.lbl_Server = new System.Windows.Forms.Label();
            this.lbl_People = new System.Windows.Forms.Label();
            this.pb_Settings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.ForeColor = System.Drawing.Color.Black;
            this.lbl_Server.Location = new System.Drawing.Point(25, 11);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(34, 13);
            this.lbl_Server.TabIndex = 1;
            this.lbl_Server.Text = "Text?";
            // 
            // lbl_People
            // 
            this.lbl_People.AutoSize = true;
            this.lbl_People.Location = new System.Drawing.Point(288, 26);
            this.lbl_People.Name = "lbl_People";
            this.lbl_People.Size = new System.Drawing.Size(35, 13);
            this.lbl_People.TabIndex = 2;
            this.lbl_People.Text = "label2";
            // 
            // pb_Settings
            // 
            this.pb_Settings.Image = global::TeamPraat.Properties.Resources.ic_control_point_black_24dp_2x;
            this.pb_Settings.Location = new System.Drawing.Point(692, 23);
            this.pb_Settings.Name = "pb_Settings";
            this.pb_Settings.Size = new System.Drawing.Size(24, 24);
            this.pb_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Settings.TabIndex = 3;
            this.pb_Settings.TabStop = false;
            this.pb_Settings.Click += new System.EventHandler(this.pb_Settings_Click);
            // 
            // Server
            // 
            this.AccessibleName = "test";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pb_Settings);
            this.Controls.Add(this.lbl_People);
            this.Controls.Add(this.lbl_Server);
            this.Name = "Server";
            this.Size = new System.Drawing.Size(719, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Label lbl_People;
        private System.Windows.Forms.PictureBox pb_Settings;
    }
}
