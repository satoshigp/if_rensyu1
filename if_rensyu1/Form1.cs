﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_rensyu1
{
    public partial class Form1 : Form
       
    {
        int vx = -10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            button1.Left += vx;
           button1.Top += vy;

            if (button1.Left < 0)
            {
                vx += 10;
               
               
            }
            if(button1.Left>=193)
            {
                vx -= 10;
               
            }
           if(button1.Top<0)
           {
               vy += 10;
           }
           if (button1.Top > 213)
           {
               vy = -10;
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
        }
    }
}
