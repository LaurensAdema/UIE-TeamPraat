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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.server6 = new TeamPraat.Ui_Elements.Server();
            this.server5 = new TeamPraat.Ui_Elements.Server();
            this.server4 = new TeamPraat.Ui_Elements.Server();
            this.server1 = new TeamPraat.Ui_Elements.Server();
            this.server3 = new TeamPraat.Ui_Elements.Server();
            this.server2 = new TeamPraat.Ui_Elements.Server();
            this.Tjidde_Server = new TeamPraat.Ui_Elements.Server();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "BookMarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Servers\'";
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Tjidde_Server",
            "Michel_Server",
            "Other_Server",
            "Sinclair_Server",
            "Call of duty Server",
            "Counter Strike: Global Offensive",
            "cyka bliat"});
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSearch.Location = new System.Drawing.Point(557, 84);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(168, 20);
            this.tbSearch.TabIndex = 11;
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::TeamPraat.Properties.Resources.ic_search_white_24dp_2x;
            this.pbSearch.Location = new System.Drawing.Point(731, 84);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(20, 20);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 12;
            this.pbSearch.TabStop = false;
            // 
            // server6
            // 
            this.server6.AccessibleName = "test";
            this.server6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.server6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server6.ConnecedPeople = 94;
            this.server6.Location = new System.Drawing.Point(32, 473);
            this.server6.Name = "server6";
            this.server6.ServerName = "cyka bliat";
            this.server6.Size = new System.Drawing.Size(719, 50);
            this.server6.TabIndex = 10;
            // 
            // server5
            // 
            this.server5.AccessibleName = "test";
            this.server5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.server5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server5.ConnecedPeople = 189245;
            this.server5.Location = new System.Drawing.Point(32, 417);
            this.server5.Name = "server5";
            this.server5.ServerName = "Counter Strike: Global Offensive";
            this.server5.Size = new System.Drawing.Size(719, 50);
            this.server5.TabIndex = 9;
            // 
            // server4
            // 
            this.server4.AccessibleName = "test";
            this.server4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.server4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server4.ConnecedPeople = 0;
            this.server4.Location = new System.Drawing.Point(32, 361);
            this.server4.Name = "server4";
            this.server4.ServerName = "Call of duty Server";
            this.server4.Size = new System.Drawing.Size(719, 50);
            this.server4.TabIndex = 8;
            // 
            // server1
            // 
            this.server1.AccessibleName = "test";
            this.server1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.server1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server1.ConnecedPeople = 2;
            this.server1.Location = new System.Drawing.Point(32, 305);
            this.server1.Name = "server1";
            this.server1.ServerName = "Sinclair_Server";
            this.server1.Size = new System.Drawing.Size(719, 50);
            this.server1.TabIndex = 7;
            // 
            // server3
            // 
            this.server3.AccessibleName = "Server 3";
            this.server3.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.server2.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.Tjidde_Server.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.server6);
            this.Controls.Add(this.server5);
            this.Controls.Add(this.server4);
            this.Controls.Add(this.server1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.server3);
            this.Controls.Add(this.server2);
            this.Controls.Add(this.Tjidde_Server);
            this.Controls.Add(this.label1);
            this.Name = "ServerBrowser";
            this.Size = new System.Drawing.Size(757, 563);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Server Tjidde_Server;
        private Server server2;
        private Server server3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Server server1;
        private Server server4;
        private Server server5;
        private Server server6;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pbSearch;
    }
}
