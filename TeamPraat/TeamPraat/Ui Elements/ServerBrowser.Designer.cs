namespace TeamPraat.Ui_Elements
{
    partial class ServerBrowser
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
            this.label1 = new System.Windows.Forms.Label();
            this.server3 = new TeamPraat.Ui_Elements.Server();
            this.server2 = new TeamPraat.Ui_Elements.Server();
            this.Tjidde_Server = new TeamPraat.Ui_Elements.Server();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Browser";
            // 
            // server3
            // 
            this.server3.AccessibleName = "Server 3";
            this.server3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server3.ConnecedPeople = 10;
            this.server3.Location = new System.Drawing.Point(32, 223);
            this.server3.Name = "server3";
            this.server3.ServerName = "Other_Server";
            this.server3.Size = new System.Drawing.Size(721, 52);
            this.server3.TabIndex = 4;
            // 
            // server2
            // 
            this.server2.AccessibleName = "Server 2";
            this.server2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server2.ConnecedPeople = 10;
            this.server2.Location = new System.Drawing.Point(32, 165);
            this.server2.Name = "server2";
            this.server2.ServerName = "Michel_Server";
            this.server2.Size = new System.Drawing.Size(721, 52);
            this.server2.TabIndex = 3;
            // 
            // Tjidde_Server
            // 
            this.Tjidde_Server.AccessibleDescription = "";
            this.Tjidde_Server.AccessibleName = "Tijdde Server";
            this.Tjidde_Server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tjidde_Server.ConnecedPeople = 10;
            this.Tjidde_Server.Location = new System.Drawing.Point(32, 107);
            this.Tjidde_Server.Name = "Tjidde_Server";
            this.Tjidde_Server.ServerName = "Tjidde_Server";
            this.Tjidde_Server.Size = new System.Drawing.Size(721, 52);
            this.Tjidde_Server.TabIndex = 2;
            // 
            // ServerBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.server3);
            this.Controls.Add(this.server2);
            this.Controls.Add(this.Tjidde_Server);
            this.Controls.Add(this.label1);
            this.Name = "ServerBrowser";
            this.Size = new System.Drawing.Size(757, 563);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Server Tjidde_Server;
        private Server server2;
        private Server server3;
    }
}
