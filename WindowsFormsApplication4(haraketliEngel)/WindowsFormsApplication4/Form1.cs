using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int c = 0;
        PictureBox[] ates = new PictureBox[100];
        private void vuruş(int x, int y)
        {
            ates[c+1].ImageLocation = "C:\\Users\\Enes Kaya\\Desktop\\mermi-png-3.png";
            ates[c + 1].SizeMode = PictureBoxSizeMode.StretchImage;
            ates[c + 1].Location = new Point(x + 60, y);
            ates[c + 1].Height = 41;
            ates[c + 1].Width = 41;
            ates[c + 1].Visible = true;
            this.Controls.Add(ates[c + 1]);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timerengelyukari.Start();
            timer1.Start();
            for (int i = 0; i < 30; i++)
            {
                ates[i] = new PictureBox();
            }
            at.ImageLocation = "";
            at.Height = 70;
            at.Width = 120;
            at.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(at);
            at.Location = new Point(250, 250);
            c = -1;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelengel.Top -= 1;
            if(labelengel.Top==0)
            {
                timerengelyukari.Stop();
                timerengelasagi.Start();
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelengel.Top += 1;
            if(labelengel.Top==350)
            {
                timerengelasagi.Stop();
                timerengelyukari.Start();

            }
        }
        int tane=0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                vuruş(at.Location.X, at.Location.Y);
                ateş.Start();
                timersag.Stop();
                c++;
                tane++;

            }
            if(e.KeyCode==Keys.Up)
            {
                timeryukari.Start();

            }
            if (e.KeyCode == Keys.Down)
            {
                timerasagi.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                timersag.Start();

            }
            if (e.KeyCode == Keys.Left)
            {
                timersol.Start();

            }





        }

        private void timersag_Tick(object sender, EventArgs e)
        {
            at.Left += 1;
        }

        private void timersol_Tick(object sender, EventArgs e)
        {
            at.Left -= 1;
        }

        private void timeryukari_Tick(object sender, EventArgs e)
        {
            at.Top -= 1;
        }

        private void timerasagi_Tick(object sender, EventArgs e)
        {
            at.Top += 1;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                timeryukari.Stop();

            }
            if (e.KeyCode == Keys.Down)
            {
                timerasagi.Stop();
            }
            if (e.KeyCode == Keys.Right)
            {
                timersag.Stop();

            }
            if (e.KeyCode == Keys.Left)
            {
                timersol.Stop();

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (at.Top >= labelengel.Top)
            {
                if (at.Left < labelengel.Left)
                {

                    if (at.Right >= labelengel.Left)
                    {
                        timersag.Stop();
                        at.Left -= 2;
                    }

                }
                if (at.Left > labelengel.Left)
                {
                    if (at.Left <= labelengel.Right)
                    {
                        timersol.Stop();
                        at.Left += 2;
                    }
                }
            }
            if (at.Top >= labelengel.Top && at.Bottom <= labelengel.Bottom)
            {
                

            }





            

        }

        private void ateş_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < tane; i++)
            {
                ates[i].Left += 10;
            }
                
        }
    }
}
