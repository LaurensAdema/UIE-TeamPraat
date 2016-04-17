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
        private MainForm main;

        public Server(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void btn_Dropdown_Click(object sender, EventArgs e)
        {

        }

        private void Server_MouseClick(object sender, MouseEventArgs e)
        {
            //Connect
        }
    }
}
