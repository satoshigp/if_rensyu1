using System;
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
        int vx = 10;
        int vy = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left-= vx;


            if (button1.Left < 0)
            {
                vx += 10;
                button1.Left += vx;
               
            }
            else if (button1.Left > 300)
           
            button1.Left -= vx;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
        }
    }
}
