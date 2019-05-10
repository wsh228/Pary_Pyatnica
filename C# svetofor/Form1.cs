using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int ticks1;
        private int ticks2;

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks1++;


            this.Text = ticks1.ToString();
            if(ticks1 == 80)
            {
                ticks1 = 0;
            }
            else if( ticks1 == 1)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.White;
                panel4.BackColor = Color.White;
            } 
            else if (ticks1 == 30)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Yellow;
                panel4.BackColor = Color.White;
            }
            else if (ticks1 == 40)
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.White;
                panel4.BackColor = Color.Green;
            }
            else if(ticks1 == 70)
            {
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.Yellow;
                panel4.BackColor = Color.White;
            }
            else if (ticks1 == 80)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.White;
                panel4.BackColor = Color.White;
            }
            
        
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ticks2++;

            this.Text = ticks2.ToString();

            if (ticks2 == 10)
            {
                ticks2 = 0;
            }
            else if (ticks2 == 1)
            {
                panel2.BackColor = Color.Yellow;
            }
            else if (ticks2 == 6)
            {
                panel2.BackColor = Color.White;
            }

        }

    }
}
