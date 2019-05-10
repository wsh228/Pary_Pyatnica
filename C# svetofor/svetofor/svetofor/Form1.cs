using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace svetofor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            timer2.Stop();
        }

        int ticks1 = 0;
        bool ticks1HelpBool = false;
        int ticks1Help = 0;
        int ticks2 = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ticks1++;
            ticks1Help--;

            if (ticks1HelpBool == true)
            {
                ticks1Help--;
            }
            else
            {
                label2.Text = ticks1Help.ToString("0");
            }
            this.Text = Text.ToString("Pozniakov Nikita");
            label2.Text = ticks1Help.ToString();

            if (ticks1 == 35)
            {
                ticks1 = 0;
            }
            else if (ticks1 == 1)
            {
                ticks1Help = 14;
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.White;
                panel4.BackColor = Color.White;
                panel5.BackColor = Color.White;
            }
            else if (ticks1 == 3)
            {
                panel4.BackColor = Color.Green;
                panel5.BackColor = Color.Green;
            }
            else if (ticks1 == 10)
            {

                panel4.BackColor = Color.White;
                panel5.BackColor = Color.White;
            }
            else if (ticks1 == 11)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Yellow;
                panel3.BackColor = Color.White;
                panel4.BackColor = Color.White;
                panel5.BackColor = Color.White;
            }
            else if (ticks1 == 15)
            {
                ticks1Help = 15;

                panel1.BackColor = Color.White;
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.Green;
                panel4.BackColor = Color.White;
                panel5.BackColor = Color.White;
            }
            else if (ticks1 == 30)
            {
                ticks1Help = 5;
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.Yellow;
                panel3.BackColor = Color.White;
                panel4.BackColor = Color.White;
                panel5.BackColor = Color.White;
            }
            else if (ticks1 == 35)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.White;
                panel4.BackColor = Color.White;
                panel5.BackColor = Color.White;
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
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

        private void startDay_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Stop();

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
        }

        private void startNight_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
        }

        private void stop_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            DrawLift();
        }

        private void DrawLift()
        {
            Bitmap bitmap = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.White);
            pen.Width = 3.0F;

            graph.DrawLine(pen, 10, 30, 40, 30);
            graph.DrawLine(pen, 40, 30, 40, 25);
            graph.DrawLine(pen, 40, 25, 60, 38);

            graph.DrawLine(pen, 60, 38, 40, 50);
            graph.DrawLine(pen, 40, 50, 40, 45);
            graph.DrawLine(pen, 40, 45, 10, 45);

            graph.DrawLine(pen, 10, 45, 10, 30);
            picture.Image = bitmap;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawRight();
        }

        private void DrawRight()
        {
            Bitmap bitmap = new Bitmap(picture1.Width, picture1.Height);
            Graphics graph = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.White);
            pen.Width = 3.0F;

            graph.DrawLine(pen, 60, 30, 30, 30);
            graph.DrawLine(pen, 30, 30, 30, 25);
            graph.DrawLine(pen, 30, 25, 10, 38);

            graph.DrawLine(pen, 10, 38, 30, 50);
            graph.DrawLine(pen, 30, 50, 30, 45);
            graph.DrawLine(pen, 30, 45, 60, 45);

            graph.DrawLine(pen, 60, 45, 60, 30);
            picture1.Image = bitmap;
        }

        
    }
}
