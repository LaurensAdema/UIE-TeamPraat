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
            this.btn_Dropdown = new System.Windows.Forms.Button();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.lbl_People = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Dropdown
            // 
            this.btn_Dropdown.Location = new System.Drawing.Point(643, 26);
            this.btn_Dropdown.Name = "btn_Dropdown";
            this.btn_Dropdown.Size = new System.Drawing.Size(75, 23);
            this.btn_Dropdown.TabIndex = 0;
            this.btn_Dropdown.Text = "button1";
            this.btn_Dropdown.UseVisualStyleBackColor = true;
            this.btn_Dropdown.Click += new System.EventHandler(this.btn_Dropdown_Click);
            // 
            // lbl_Server
            // 
            this.lbl_Server.ForeColor = System.Drawing.Color.Black;
            this.lbl_Server.Location = new System.Drawing.Point(25, 11);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(212, 17);
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
            // Server
            // 
            this.AccessibleName = "test";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_People);
            this.Controls.Add(this.lbl_Server);
            this.Controls.Add(this.btn_Dropdown);
            this.Name = "Server";
            this.Size = new System.Drawing.Size(719, 50);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Server_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Dropdown;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Label lbl_People;
    }
}
