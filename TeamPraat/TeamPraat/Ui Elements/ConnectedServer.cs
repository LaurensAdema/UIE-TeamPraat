﻿using System;
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
        public ConnectedServer()
        {
            InitializeComponent();
        }

        private void pb_ServerIcon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klick");
            this.BorderStyle = BorderStyle.None;
            
        }
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
           ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
            
        }
    }
}