using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ndp_project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string[] dosyalar = Directory.GetFiles(@"C:\Users\NISA\source\repos\ndp_project\ndp_project\img\", "*.jpg");


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Interval = 2000;
            pictureBox2.Image = Image.FromFile(@"C:\Users\NISA\source\repos\ndp_project\ndp_project\img\machine\narenciye.jpg");
            pictureBox3.Image = Image.FromFile(@"C:\Users\NISA\source\repos\ndp_project\ndp_project\img\machine\kati.jpg");

        }
        int clock=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock == 60)
            {
                timer1.Stop();
            }
            progressBar1.Value = clock;
            label1.Text = clock.ToString();

            clock++;


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            pictureBox1.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];
        }

       
    }
}


