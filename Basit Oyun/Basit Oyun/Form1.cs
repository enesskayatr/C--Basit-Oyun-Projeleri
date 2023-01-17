using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int hız;
        int y1, y2, y3, y4,sayac,Para;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hız = rnd.Next(1, 20);
            pictureBoxY1.Left += hız;
            hız = rnd.Next(1, 20);
            pictureBoxY2.Left += hız;
            hız = rnd.Next(1, 20);
            pictureBoxY3.Left += hız;
            hız = rnd.Next(1, 20);
            pictureBoxY4.Left += hız;
            if (pictureBoxY1.Left > pictureBoxY2.Left && pictureBoxY1.Left > pictureBoxY3.Left && pictureBoxY1.Left > pictureBoxY4.Left)
            {
                labelSpiker.Text = "1. At Yarışı Önde Götürüyor,Ama Diğer Atlar Hemen Arkasında";
            }
            if (pictureBoxY2.Left > pictureBoxY1.Left && pictureBoxY2.Left > pictureBoxY3.Left && pictureBoxY2.Left > pictureBoxY4.Left)
            {
                labelSpiker.Text = "2. At Yarışı Önde Götürüyor,Ama Diğer Atlar Hemen Arkasında";
            }
            if (pictureBoxY3.Left > pictureBoxY1.Left && pictureBoxY3.Left > pictureBoxY2.Left && pictureBoxY2.Left > pictureBoxY4.Left)
            {
                labelSpiker.Text = "3. At Yarışı Önde Götürüyor,Ama Diğer Atlar Hemen Arkasında";
            }
            if (pictureBoxY4.Left > pictureBoxY1.Left && pictureBoxY4.Left > pictureBoxY2.Left && pictureBoxY4.Left > pictureBoxY3.Left)
            {
                labelSpiker.Text = "4. At Yarışı Önde Götürüyor,Ama Diğer Atlar Hemen Arkasında";
            }

            if (pictureBoxY1.Left + pictureBoxY1.Width >= labelBitis.Left)
            {
                timer1.Stop();
                Para = Para / y1;
                MessageBox.Show("1. At Çok Yakın Bir Mesafeyle Kazandı "+ Para);

            }
            if (pictureBoxY2.Left + pictureBoxY2.Width >= labelBitis.Left)
            {
                timer1.Stop();
                Para = Para / y2;
                MessageBox.Show("2. At Çok Yakın Bir Mesafeyle Kazandı "+Para);
            }
            if (pictureBoxY3.Left + pictureBoxY3.Width >= labelBitis.Left)
            {
                timer1.Stop();
                Para = Para / y3;
                MessageBox.Show("3. At Çok Yakın Bir Mesafeyle Kazandı "+ Para);
            }
            if (pictureBoxY4.Left + pictureBoxY4.Width >= labelBitis.Left)
            {
                timer1.Stop();
                Para = Para / y4;
                MessageBox.Show("4. At Çok Yakın Bir Mesafeyle Kazandı "+ Para);
            }
        }

        private void buttonOyna_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="1")
            {
                sayac += 1;
                y1++;
                listBox1.Items.Add(1);
            }
            if (comboBox1.Text=="2")
            {
                sayac += 1;
                y2++;
                listBox1.Items.Add(2);
            }
            if (comboBox1.Text=="3")
            {
                sayac += 1;
                y3++;
                listBox1.Items.Add(3);
            }
            if (comboBox1.Text=="4")
            {
                sayac += 1;
                y4++;
                listBox1.Items.Add(4);
            }
            Para = sayac * 50;
        }
    }
}
