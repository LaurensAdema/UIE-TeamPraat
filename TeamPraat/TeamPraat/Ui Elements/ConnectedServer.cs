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
    public partial class ConnectedServer : UserControl
    {
        private MainForm main;

        public ConnectedServer(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }
        
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
           ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            
        }
        private void pb_ServerIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Disconnected");
                main.pbEmpty.Location = new Point(main.pbEmpty.Location.X, main.pbEmpty.Location.Y - main.pbEmpty.Height - 10);
                main.Servers--;
                Dispose();
            }
            else
            {
                main.splitContainer1.Panel1.Controls.Clear();
                main.splitContainer1.Panel1.Controls.Add(new Server(main));
            }
        }
    }
}
