using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asansör
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bkat = 0;
        int kat;

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            kat = Convert.ToInt32(btn.Text);
            timer1.Start();
            groupBox1.Enabled = false;
        }
        string durum;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bkat>kat)
            {
                durum ="asagı";
                
            }
            if (bkat<kat)
            {
                durum = "yukarı";
            }
            if (durum=="yukarı")
            { 
               

                if (kat==1)
                {
                   
                    if (kat1.Top <= asansör.Top)
                    {
                        asansör.Top -= 5;
                        
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 1; 
                        groupBox1.Enabled = true;
                    }
                    
                }
                if (kat == 2)
                {
                    if (kat2.Top <= asansör.Top)
                    {
                        asansör.Top -= 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 2;
                        groupBox1.Enabled = true;
                    }

                }
                if (kat == 3)
                {
                    if (kat3.Top <= asansör.Top)
                    {
                        asansör.Top -= 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 3;
                        groupBox1.Enabled = true;
                    }

                }
                if (kat == 4)
                {
                    if (kat4.Top <= asansör.Top)
                    {
                        asansör.Top -= 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 4;
                        groupBox1.Enabled = true;
                    }

                }
                if (kat == 5)
                {
                    if (kat5.Top <= asansör.Top)
                    {
                        asansör.Top -= 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 5;
                        groupBox1.Enabled = true;
                    }

                }
            }
            if (durum == "asagı")
            {
                if (kat == 0)
                {
                    if (kat0.Top >= asansör.Top)
                    {
                        asansör.Top += 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 0;
                        groupBox1.Enabled = true;
                    }

                }
                if (kat == 1)
                {
                    if (kat1.Top >= asansör.Top)
                    {
                        asansör.Top += 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 1;
                        groupBox1.Enabled = true;
                    }

                }
                if (kat == 2)
                {
                    if (kat2.Top >= asansör.Top)
                    {
                        asansör.Top += 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 2;
                        groupBox1.Enabled = true;
                    }

                }
                if (kat == 3)
                {
                    if (kat3.Top >= asansör.Top)
                    {
                        asansör.Top += 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 3;
                        groupBox1.Enabled = true;
                    }

                }
                if (kat == 4)
                {
                    if (kat4.Top >= asansör.Top)
                    {
                        asansör.Top += 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 4;
                        groupBox1.Enabled = true;
                    }

                }
                if (kat == 5)
                {
                    if (kat5.Top >= asansör.Top)
                    {
                        asansör.Top += 5;
                    }
                    else
                    {
                        timer1.Stop();
                        bkat = 5;
                        groupBox1.Enabled = true;
                    }

                }
            }
        }
    }
}
