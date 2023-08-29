using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Grosu_Daniel_Stefan_609_Racing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }
        int collectedcoins = 0;
        Random r = new Random();
        int x, y;


        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0,200);
                
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }
            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);

                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);

                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }
        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(20, 250);

                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);

                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            if (coin4.Top >= 500)
            {
                x = r.Next(100, 400);

                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }

        }
        void gameover()
        {
            if(car.Bounds.IntersectsWith(enemy1.Bounds))
                { timer1.Enabled = false;
                over.Visible = true; }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            string input = Interaction.InputBox("Name", "Title", "Default", this.Location.X, this.Location.Y);
            if (input == null)
               input = "No Name";

            string line = input +","+this.collectedcoins.ToString();
            System.IO.File.AppendAllText("score.txt", line);
        }
        void moveline(int speed)
        {
            if( pictureBox1.Top >=500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void car_Click(object sender, EventArgs e)
        {

        }
        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(50, 300);

                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(50, 300);

                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoins++;
                label1.Text = "Coins=" + collectedcoins.ToString();
                x = r.Next(50, 300);

                coin4.Location = new Point(x, 0);
            }
        }
        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (car.Left > 5)
                        car.Left += -8;
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (car.Right < 380)
                        car.Left += 8;
                }
                if (e.KeyCode==Keys.Up)
                if(gamespeed<21)
                { gamespeed++; }
            if (e.KeyCode == Keys.Down)
                if (gamespeed > 0)
                { gamespeed--; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
