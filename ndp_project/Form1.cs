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
        Meyveler[] meyve;
        public Form1()
        {
            InitializeComponent();
            meyve = new Meyveler[6];
            Meyveler orange = new Meyveler("orange", 1, 1, @"C:\Users\NISA\source\repos\ndp_project\ndp_project\img\orange.jpg");
            Meyveler grapefruit = new Meyveler("grapefruit", 1, 1, @"C:\Users\NISA\source\repos\ndp_project\ndp_project\img\grapefruit.jpg");
            Meyveler strawberry = new Meyveler("strawberry", 1, 1, @"C:\Users\NISA\source\repos\ndp_project\ndp_project\img\stawberry.jpg");
            Meyveler apple = new Meyveler("apple", 1, 1, @"C:\Users\NISA\source\repos\ndp_project\ndp_project\img\apple.jpg");
            Meyveler mandarin = new Meyveler("mandarin", 1, 1, @"C:\Users\NISA\source\repos\ndp_project\ndp_project\img\mandarin.jpg");
            Meyveler pear = new Meyveler("pear", 1, 1, @"C:\Users\NISA\source\repos\ndp_project\ndp_project\img\pear.jpg");

            meyve[0] = orange;
            meyve[1] = grapefruit;
            meyve[2] = mandarin;
            meyve[3] = strawberry;
            meyve[4] = apple;
            meyve[5] = pear;

        }


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
        int clock2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Random r = new Random();
            int random = r.Next(0, 6);
            pictureBox1.ImageLocation = meyve[random].getimg();

            Random rastgele = new Random();
            int meyveGram = rastgele.Next(70, 120);

            Random rastgele2 = new Random();
            int vitaminA = rastgele2.Next(20, 100);

            Random rastgele3 = new Random();
            int vitaminC = rastgele3.Next(20, 100);

            Random rastgele4 = new Random();
            int verimKati = rastgele4.Next(30, 70);

            Random rastgele5 = new Random();
            int verimNarenciye = rastgele5.Next(80, 95);

            int katiMeyveSuyu = meyveGram * verimKati / 100;
            int narenciyeMeyceSuyu = meyveGram * verimNarenciye / 100;

            label2.Text = meyveGram.ToString();
            
            label5.Text = vitaminA.ToString();

            label7.Text = vitaminC.ToString();

            

            
            
            if (pictureBox1.ImageLocation == meyve[0].getimg()  )
            {
                label9.Text = "%" + verimNarenciye.ToString();
            }
            if (pictureBox1.ImageLocation == meyve[1].getimg())
            {
                label9.Text = "%" + verimNarenciye.ToString();
            }
            if (pictureBox1.ImageLocation == meyve[2].getimg())
            {
                label9.Text = "%" + verimNarenciye.ToString();
            }
            if (pictureBox1.ImageLocation == meyve[3].getimg())
            {
                label9.Text ="%"+ verimKati.ToString();
            }
            if (pictureBox1.ImageLocation == meyve[4].getimg())
            {
                label9.Text = "%"+verimKati.ToString();
            }
            if (pictureBox1.ImageLocation == meyve[5].getimg())
            {
                label9.Text ="%"+ verimKati.ToString();
            }

            if (clock2 == 30)
            {
                timer2.Stop();
            }
            clock2++;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
           
        }
    }
}


