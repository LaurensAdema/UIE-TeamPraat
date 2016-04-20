﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeamPraat.Properties;

namespace TeamPraat.Ui_Elements{
    public partial class Channel : UserControl{
        public static Channel SelectedChannel;
        public static List<Channel> Allchannels = new List<Channel>();
        private readonly int colapseSize = 50;
        private readonly MainForm main;
        private readonly int preHeight;
        private Color border;

        Names name= new Names();
        public Channel(){
            InitializeComponent();
            lbl_ChannelName.Text = "Channel " + Location.Y;
            BorderColor = Color.Red;
            Allchannels.Add(this);
            preHeight = 60;
            Random rnd = new Random();
            for (int i = 1; i <= 5; i++){
                int r = rnd.Next(name.names.Count);
                channelMemberList.Items.Add(name.names[r]);
            }
        }

        private Color BorderColor{
            get { return border; }
            set{
                border = value;
                Refresh();
            }
        }

        private void Channel_Load(object sender, EventArgs e){
        }

        protected override void OnPaint(PaintEventArgs e){
            base.OnPaint(e);
            var borderWidth = 3;
            var borderColor = BorderColor; //SystemColors.AppWorkspace;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
                ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid);
        }

        private void ButtonExp_Click(object sender, EventArgs e){
            if (preHeight >= Height){
                Expand();
            }
            else{
                Collapse();
            }
        }

        private void Collapse(){
            Size = new Size(Width, preHeight);


            foreach (var ch in from Control c in Parent.Controls
                select c as Channel
                into ch
                where ch?.Location.Y > Location.Y
                select ch){
                ch.Location = new Point(ch.Location.X, ch.Location.Y - colapseSize);
                ch.Refresh();
            }
            ButtonExp.Location = new Point(ButtonExp.Location.X, ButtonExp.Location.Y - colapseSize);
            ButtonExp.Image = Resources.ic_keyboard_arrow_down_black_24dp_2x1;
            Refresh();
        }

        public void Expand(){
            Size = new Size(Width, Height + colapseSize);


            foreach (var ch in from Control c in Parent.Controls
                select c as Channel
                into ch
                where ch?.Location.Y > Location.Y
                select ch){
                ch.Location = new Point(ch.Location.X, ch.Location.Y + colapseSize);
                ch.Refresh();
            }
            ButtonExp.Location = new Point(ButtonExp.Location.X, ButtonExp.Location.Y + colapseSize);
            ButtonExp.Image = Resources.ic_keyboard_arrow_up_black_24dp_2x;
            Refresh();
        }

        private void Channel_Click(object sender, EventArgs e){ 
        }
    }
}