﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plasmoid.Extensions;
namespace KuehneNaggelMAIN.Forms
{
    public partial class Network : Form
    {
        public Network()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(50, Color.White)), 1, 1, panel1.Width - 1, panel1.Height - 1, 10);


            //g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.FromArgb(50, panel1.BackColor), 0.00f)), 12, 12, this.Width , this.Height , 10);
            //g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(50, panel1.BackColor)), 12, 12 + ((this.Height - 64) / 2), this.Width - 44, (this.Height - 64) / 2, 10);

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(70, Color.White)), 1, 1, panel2.Width - 1, panel2.Height - 1, 10);
        }

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(70, Color.White)), 1, 1, panel4.Width - 1, panel4.Height - 1, 10);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(70, Color.White)), 1, 1, panel7.Width - 1, panel7.Height - 1, 10);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(70, Color.White)), 1, 1, panel5.Width - 1, panel5.Height - 1, 10);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(70, Color.White)), 1, 1, panel6.Width - 1, panel6.Height - 1, 10);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.FromArgb(70, Color.White)), 1, 1, panel8.Width - 1, panel8.Height - 1, 10);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
