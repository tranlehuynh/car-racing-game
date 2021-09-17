using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_racing_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;
        Random rand = new Random();
        int x, y;
        void getTime(int speed)
        {
            if (pictureBox1.Top >= 440) {pictureBox1.Top = -2;}
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 440) { pictureBox2.Top = -2; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 440) { pictureBox3.Top = -2; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 440) { pictureBox4.Top = -2; }
            else { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 440) { pictureBox5.Top = -2; }
            else { pictureBox5.Top += speed; }

            if (pictureBox6.Top >= 440) { pictureBox6.Top = -2; }
            else { pictureBox6.Top += speed; }

            if (pictureBox7.Top >= 440) { pictureBox7.Top = -2; }
            else { pictureBox7.Top += speed; }

            if (pictureBox8.Top >= 440) { pictureBox8.Top = -2; }
            else { pictureBox8.Top += speed; }
        }
        void enemyCar(int speed)
        {
            if (ptbEnemyCar1.Top > 400)
            {
                x = rand.Next(0, 300);
                ptbEnemyCar1.Location = new Point(x, 0);
            }
            else { ptbEnemyCar1.Top += speed; }

            if (ptbEnemyCar2.Top > 400)
            {
                x = rand.Next(0, 300);
                ptbEnemyCar2.Location = new Point(x, 0);
            }
            else { ptbEnemyCar2.Top += speed; }

            if (ptbEnemyCar3.Top > 400)
            {
                x = rand.Next(180, 350);
                ptbEnemyCar3.Location = new Point(x, 0);
            }
            else { ptbEnemyCar3.Top += speed; }

            if (ptbEnemyCar4.Top > 400)
            {
                x = rand.Next(300, 350);
                ptbEnemyCar4.Location = new Point(x, 0);
            }
            else { ptbEnemyCar4.Top += speed; }
            if (ptbEnemyCar5.Top > 400)
            {
                x = rand.Next(350, 500);
                ptbEnemyCar5.Location = new Point(x, 0);
            }
            else { ptbEnemyCar5.Top += speed; }
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime(8);
            enemyCar(8);
            if (ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar1.Bounds) || ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar2.Bounds)
                || ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar3.Bounds) || ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar4.Bounds)
                || ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar5.Bounds))
            {
                timer1.Enabled = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (ptbMainCar.Left > 0)
                    ptbMainCar.Left -= 10;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (ptbMainCar.Right < 720)
                    ptbMainCar.Left += 10;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (ptbMainCar.Top > 0)
                    ptbMainCar.Top -= 10;
            }

            if (e.KeyCode == Keys.Down)
            {
                if (ptbMainCar.Top < 340)
                    ptbMainCar.Top += 10;
            }

        }
    }
}
