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
            this.lblBrouwser = new System.Windows.Forms.Label();
            this.lblBookmarks = new System.Windows.Forms.Label();
            this.lblServers = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pnlBookmark = new System.Windows.Forms.Panel();
            this.pnlServers = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrouwser
            // 
            this.lblBrouwser.AutoSize = true;
            this.lblBrouwser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrouwser.ForeColor = System.Drawing.Color.White;
            this.lblBrouwser.Location = new System.Drawing.Point(26, 25);
            this.lblBrouwser.Name = "lblBrouwser";
            this.lblBrouwser.Size = new System.Drawing.Size(230, 33);
            this.lblBrouwser.TabIndex = 1;
            this.lblBrouwser.Text = "Server Browser";
            // 
            // lblBookmarks
            // 
            this.lblBookmarks.AutoSize = true;
            this.lblBookmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookmarks.ForeColor = System.Drawing.Color.White;
            this.lblBookmarks.Location = new System.Drawing.Point(28, 84);
            this.lblBookmarks.Name = "lblBookmarks";
            this.lblBookmarks.Size = new System.Drawing.Size(89, 20);
            this.lblBookmarks.TabIndex = 5;
            this.lblBookmarks.Text = "BookMarks";
            // 
            // lblServers
            // 
            this.lblServers.AutoSize = true;
            this.lblServers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServers.ForeColor = System.Drawing.Color.White;
            this.lblServers.Location = new System.Drawing.Point(28, 278);
            this.lblServers.Name = "lblServers";
            this.lblServers.Size = new System.Drawing.Size(74, 24);
            this.lblServers.TabIndex = 6;
            this.lblServers.Text = "Servers";
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
            // pnlBookmark
            // 
            this.pnlBookmark.Location = new System.Drawing.Point(32, 107);
            this.pnlBookmark.MinimumSize = new System.Drawing.Size(719, 50);
            this.pnlBookmark.Name = "pnlBookmark";
            this.pnlBookmark.Size = new System.Drawing.Size(719, 168);
            this.pnlBookmark.TabIndex = 13;
            this.pnlBookmark.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlBookmark_ControlAdded);
            // 
            // pnlServers
            // 
            this.pnlServers.Location = new System.Drawing.Point(32, 305);
            this.pnlServers.Name = "pnlServers";
            this.pnlServers.Size = new System.Drawing.Size(719, 239);
            this.pnlServers.TabIndex = 14;
            this.pnlServers.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlServers_ControlAdded);
            // 
            // ServerBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlServers);
            this.Controls.Add(this.pnlBookmark);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblServers);
            this.Controls.Add(this.lblBookmarks);
            this.Controls.Add(this.lblBrouwser);
            this.Name = "ServerBrowser";
            this.Size = new System.Drawing.Size(775, 565);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBrouwser;
        private System.Windows.Forms.Label lblBookmarks;
        private System.Windows.Forms.Label lblServers;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Panel pnlBookmark;
        private System.Windows.Forms.Panel pnlServers;
    }
}
