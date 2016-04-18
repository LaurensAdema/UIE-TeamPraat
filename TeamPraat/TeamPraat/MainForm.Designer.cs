namespace TeamPraat
{
    partial class MainForm
    {

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.plConnected = new System.Windows.Forms.Panel();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.pbMic = new System.Windows.Forms.PictureBox();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbSound = new System.Windows.Forms.PictureBox();
            this.pbEmpty = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.scMainScreen = new System.Windows.Forms.SplitContainer();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblFriends = new System.Windows.Forms.Label();
            this.lbFriends = new System.Windows.Forms.ListBox();
            this.pbFriendsSlide = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.plConnected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainScreen)).BeginInit();
            this.scMainScreen.Panel2.SuspendLayout();
            this.scMainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFriendsSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // plConnected
            // 
            this.plConnected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.plConnected.Controls.Add(this.tbVolume);
            this.plConnected.Controls.Add(this.pbMic);
            this.plConnected.Controls.Add(this.pbSettings);
            this.plConnected.Controls.Add(this.pbSound);
            this.plConnected.Controls.Add(this.pbEmpty);
            this.plConnected.Location = new System.Drawing.Point(0, 0);
            this.plConnected.Name = "plConnected";
            this.plConnected.Size = new System.Drawing.Size(126, 682);
            this.plConnected.TabIndex = 0;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(3, 589);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(123, 45);
            this.tbVolume.TabIndex = 3;
            // 
            // pbMic
            // 
            this.pbMic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pbMic.BackgroundImage = global::TeamPraat.Properties.Resources.ic_mic_black_24dp_2x;
            this.pbMic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMic.Location = new System.Drawing.Point(12, 640);
            this.pbMic.Name = "pbMic";
            this.pbMic.Size = new System.Drawing.Size(26, 29);
            this.pbMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMic.TabIndex = 2;
            this.pbMic.TabStop = false;
            this.pbMic.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pbSettings
            // 
            this.pbSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pbSettings.BackgroundImage = global::TeamPraat.Properties.Resources.ic_settings_black_24dp_2x;
            this.pbSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSettings.Location = new System.Drawing.Point(92, 640);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(26, 29);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSettings.TabIndex = 2;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbSound
            // 
            this.pbSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pbSound.Image = global::TeamPraat.Properties.Resources.ic_volume_up_black_24dp_2x;
            this.pbSound.Location = new System.Drawing.Point(50, 640);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(30, 29);
            this.pbSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSound.TabIndex = 1;
            this.pbSound.TabStop = false;
            this.pbSound.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pbEmpty
            // 
            this.pbEmpty.Image = ((System.Drawing.Image)(resources.GetObject("pbEmpty.Image")));
            this.pbEmpty.Location = new System.Drawing.Point(12, 12);
            this.pbEmpty.Name = "pbEmpty";
            this.pbEmpty.Size = new System.Drawing.Size(90, 90);
            this.pbEmpty.TabIndex = 0;
            this.pbEmpty.TabStop = false;
            this.pbEmpty.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(1255, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 254);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // scMainScreen
            // 
            this.scMainScreen.IsSplitterFixed = true;
            this.scMainScreen.Location = new System.Drawing.Point(124, 0);
            this.scMainScreen.Name = "scMainScreen";
            // 
            // scMainScreen.Panel2
            // 
            this.scMainScreen.Panel2.Controls.Add(this.pictureBox6);
            this.scMainScreen.Panel2.Controls.Add(this.lblFriends);
            this.scMainScreen.Panel2.Controls.Add(this.lbFriends);
            this.scMainScreen.Size = new System.Drawing.Size(1128, 682);
            this.scMainScreen.SplitterDistance = 950;
            this.scMainScreen.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TeamPraat.Properties.Resources.ic_add_circle_white_24dp_2x;
            this.pictureBox6.Location = new System.Drawing.Point(127, 646);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lblFriends
            // 
            this.lblFriends.AutoSize = true;
            this.lblFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriends.ForeColor = System.Drawing.Color.White;
            this.lblFriends.Location = new System.Drawing.Point(19, 16);
            this.lblFriends.Name = "lblFriends";
            this.lblFriends.Size = new System.Drawing.Size(142, 29);
            this.lblFriends.TabIndex = 2;
            this.lblFriends.Text = "My Friends";
            // 
            // lbFriends
            // 
            this.lbFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFriends.Font = new System.Drawing.Font("Gill Sans MT", 8.25F);
            this.lbFriends.ForeColor = System.Drawing.Color.White;
            this.lbFriends.FormattingEnabled = true;
            this.lbFriends.ItemHeight = 16;
            this.lbFriends.Items.AddRange(new object[] {
            "Online",
            " Karel",
            " Piet ",
            " Henk",
            " Jantje",
            " Pietertje",
            " Tjidde",
            " Laurens",
            "Offline",
            " Michel",
            " Synclair",
            " Vikki  ",
            " Rudolph  ",
            " Emerson  ",
            " Loan  ",
            " Janina  ",
            " Daine  ",
            " Randa",
            " Rosalind  ",
            " Reanna  ",
            " Daniella  ",
            " Leigh  ",
            " Asia  ",
            " Eric  ",
            " Noelle  ",
            " Kellee  ",
            " Coralee  ",
            " Minda  ",
            " Taylor  ",
            " Sheree  ",
            " Spencer  ",
            " Neva  ",
            " Elin",
            " Giselle  ",
            " Leatha",
            " Kimberlee  ",
            " Teodoro  ",
            " May  ",
            " Johanna  ",
            " Irving  ",
            " Joi  ",
            " Harlan  ",
            " Tamra  ",
            " Hildred  ",
            " Williemae  ",
            " Margareta  ",
            " Melia  ",
            " Sarina  ",
            " Meridith",
            " Tyisha  ",
            " Arcelia  ",
            " Bonnie  ",
            " Wilfred  ",
            " Willetta  ",
            " Blaine  ",
            " Monica  ",
            " Josef  ",
            " Fay  ",
            " Mendy  ",
            "Delmer  ",
            "Mose  "});
            this.lbFriends.Location = new System.Drawing.Point(3, 48);
            this.lbFriends.Name = "lbFriends";
            this.lbFriends.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbFriends.Size = new System.Drawing.Size(166, 592);
            this.lbFriends.TabIndex = 1;
            // 
            // pbFriendsSlide
            // 
            this.pbFriendsSlide.Image = global::TeamPraat.Properties.Resources.ic_keyboard_arrow_right_white_24dp_2x;
            this.pbFriendsSlide.InitialImage = global::TeamPraat.Properties.Resources.ic_keyboard_arrow_right_black_24dp_2x;
            this.pbFriendsSlide.Location = new System.Drawing.Point(1030, 340);
            this.pbFriendsSlide.Name = "pbFriendsSlide";
            this.pbFriendsSlide.Size = new System.Drawing.Size(39, 37);
            this.pbFriendsSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFriendsSlide.TabIndex = 2;
            this.pbFriendsSlide.TabStop = false;
            this.pbFriendsSlide.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1251, 681);
            this.Controls.Add(this.pbFriendsSlide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plConnected);
            this.Controls.Add(this.scMainScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "TeamPraat";
            this.plConnected.ResumeLayout(false);
            this.plConnected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpty)).EndInit();
            this.panel2.ResumeLayout(false);
            this.scMainScreen.Panel2.ResumeLayout(false);
            this.scMainScreen.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainScreen)).EndInit();
            this.scMainScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFriendsSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel plConnected;
        public System.Windows.Forms.PictureBox pbEmpty;
        public System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.SplitContainer scMainScreen;
        public System.Windows.Forms.PictureBox pbSound;
        public System.Windows.Forms.PictureBox pbSettings;
        public System.Windows.Forms.PictureBox pbMic;
        public System.Windows.Forms.TrackBar tbVolume;
        public System.Windows.Forms.PictureBox pbFriendsSlide;
        public System.Windows.Forms.ListBox lbFriends;
        public System.Windows.Forms.Label lblFriends;
        public System.Windows.Forms.PictureBox pictureBox6;
        private System.ComponentModel.IContainer components;
    }
}

