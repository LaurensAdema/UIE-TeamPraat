using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TeamPraat.Ui_Elements
{
    public partial class Server : UserControl
    {
        private readonly int DefaultHeight = 12;
        private readonly MainForm main;
        public ConnectedServer OpenServer;
        public bool bookmark = false;

        private int people;

        [Description("The name of the server"), Category("Data")]
        public string ServerName
        {
            get { return lbl_Server.Text; }
            set { lbl_Server.Text = value; }
        }

        [Description("People in the server"), Category("Data")]
        public int ConnecedPeople
        {
            get { return people; }
            set
            {
                people = value;
                lbl_People.Text = people + " / Infinite";
            }
        }

        public Server(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        public Server()
        {
            InitializeComponent();
            main = MainForm.main;
        }

        private void pb_Settings_Click(object sender, EventArgs e)
        {
            if (OpenServer == null)
            {
                ConnecedPeople++;
                main.pbEmpty.Location = new Point(main.pbEmpty.Location.X,
                    main.pbEmpty.Location.Y + main.pbEmpty.Height + DefaultHeight);

                ConnectedServer cs;
                OpenServer = cs = new ConnectedServer(main, this);
                cs.ServerName = ServerName;
                cs.Location = new Point(main.pbEmpty.Location.X,
                    (main.defaultHeight + cs.Height) * main.Servers + DefaultHeight);
                main.Servers++;

                main.plConnected.Controls.Add(cs);
            }
        }
    }
}