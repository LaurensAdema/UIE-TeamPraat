using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamPraat.Ui_Elements
{
    public partial class Server : UserControl
    {
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
                people = value; lbl_People.Text = people + " / Infinite"; }
        }

        private int people;
        private int DefaultHeight = 12;
        private MainForm main;
        public ConnectedServer OpenServer;

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

        private void btn_Dropdown_Click(object sender, EventArgs e)
        {

        }

        private void Server_MouseClick(object sender, MouseEventArgs e)
        {
            if (OpenServer == null)
            {
                ConnecedPeople++;
                main.pbEmpty.Location = new Point(main.pbEmpty.Location.X,
                    main.pbEmpty.Location.Y + main.pbEmpty.Height + DefaultHeight);

                ConnectedServer cs;
                OpenServer = cs = new ConnectedServer(main, this);
                cs.Location = new Point(main.pbEmpty.Location.X,
                    (main.defaultHeight + cs.Height)*main.Servers + DefaultHeight);
                main.Servers++;

                main.plConnected.Controls.Add(cs);
            }
        }
    }
}
