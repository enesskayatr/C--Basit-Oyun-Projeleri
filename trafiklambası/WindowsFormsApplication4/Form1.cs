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
        int ksaniye = 9;
        int ssaniye = 3;
        int ysaniye = 5;
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
              if (i==1)
	{
        button3.BackColor = Color.White;
         button1.BackColor=Color.Red;
         label1.Text = ksaniye.ToString();
         label1.ForeColor=Color.Red;
         ksaniye--;
                  if (ksaniye==-1)
	{
		 ksaniye = 9;
         i++;
	}
	}  
              if (i==2)
	{
		button2.BackColor = Color.Yellow;
        label1.Text=ssaniye.ToString();
        label1.ForeColor = Color.Yellow;
                  ssaniye--;
                  if (ssaniye==-1)
	{
                      ssaniye=3;
                      button2.BackColor = Color.Transparent;
                      i++;
	}
	}   
              if (i==3)
	{
        button1.BackColor = Color.Transparent;
		 button3.BackColor = Color.Green;
                  label1.Text=ysaniye.ToString();
                  label1.ForeColor=Color.Green;
                  ysaniye--;
                  if (ysaniye==-1)
	{
		 ysaniye=5;
                      i=1;
	}
	} 
            }
         
            
         //if (a == 1)
         //   {
         //       a = 5;
         //       a = a - 1;
         //       button1.BackColor = Color.Black;
         //       button2.BackColor = Color.Black;
         //       button3.BackColor = Color.Green;
         //       label1.Text = a.ToString();
                

         //   }
        }
    }

