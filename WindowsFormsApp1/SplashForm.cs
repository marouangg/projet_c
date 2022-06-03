﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SplashForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect,     // x-coordinate of upper-left corner
      int nTopRect,      // y-coordinate of upper-left corner
      int nRightRect,    // x-coordinate of lower-right corner
      int nBottomRect,   // y-coordinate of lower-right corner
      int nWidthEllipse, // height of ellipse
      int nHeightEllipse // width of ellipse
  );


        public SplashForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            guna2ProgressBar1.Value = startpoint;
            if (guna2ProgressBar1.Value==100)
            {
                guna2ProgressBar1.Value = 0;
                timer1.Stop();
               

                LOGIN f = new LOGIN();
                f.Show();
                this.Close();

            }



        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();

        }
    }
}
