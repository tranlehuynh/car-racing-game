using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace car_racing_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbGameOver.Visible = false;
            lbCount.BackColor = System.Drawing.Color.Transparent;
        }
        #region
        string path = Application.StartupPath + @"\Images\";
        int coinTemp;
        int x;
        Random rand = new Random();
        #endregion
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
                do
                {
                    x = rand.Next(0, 150);
                    ptbEnemyCar1.Location = new Point(x, 0);
                } while (ptbEnemyCar1.Bounds.IntersectsWith(coin1.Bounds));
            }
            else { ptbEnemyCar1.Top += speed; }

            if (ptbEnemyCar2.Top > 400)
            {
                do
                {
                    x = rand.Next(170, 250);
                    ptbEnemyCar2.Location = new Point(x, 0);
                } while (ptbEnemyCar2.Bounds.IntersectsWith(coin2.Bounds));
            }
            else { ptbEnemyCar2.Top += speed; }

            if (ptbEnemyCar3.Top > 400)
            {
                do
                {
                    x = rand.Next(270, 350);
                    ptbEnemyCar3.Location = new Point(x, 0);
                } while (ptbEnemyCar3.Bounds.IntersectsWith(coin3.Bounds));
            }
            else { ptbEnemyCar3.Top += speed; }

            if (ptbEnemyCar4.Top > 400)
            {
                do
                {
                    x = rand.Next(370, 450);
                    ptbEnemyCar4.Location = new Point(x, 0);
                } while (ptbEnemyCar4.Bounds.IntersectsWith(coin4.Bounds) || ptbEnemyCar4.Bounds.IntersectsWith(coin3.Bounds));
            }
            else { ptbEnemyCar4.Top += speed; }
            if (ptbEnemyCar5.Top > 400)
            {
                do
                {
                    x = rand.Next(470, 570);
                    ptbEnemyCar5.Location = new Point(x, 0);
                } while (ptbEnemyCar5.Bounds.IntersectsWith(coin4.Bounds) || ptbEnemyCar5.Bounds.IntersectsWith(coin3.Bounds));
            }
            else { ptbEnemyCar5.Top += speed; }
        }

        void coin(int speed)
        {
            if (coin1.Top > 400)
            {
                do
                {
                    x = rand.Next(0, 150);
                    coin1.Location = new Point(x, 0);
                } while (coin1.Bounds.IntersectsWith(ptbEnemyCar1.Bounds));
            }
            else { coin1.Top += speed; }

            if (coin2.Top > 400)
            {
                do
                {
                    x = rand.Next(170, 250);
                    coin2.Location = new Point(x, 0);
                } while (coin2.Bounds.IntersectsWith(ptbEnemyCar2.Bounds));
            }
            else { coin2.Top += speed; }

            if (coin3.Top > 400)
            {
                do
                {
                    x = rand.Next(270, 350);
                    coin3.Location = new Point(x, 0);
                } while (coin3.Bounds.IntersectsWith(ptbEnemyCar3.Bounds) || coin3.Bounds.IntersectsWith(ptbEnemyCar2.Bounds));
            }
            else { coin3.Top += speed; }

            if (coin4.Top > 400)
            {
                do
                {
                    x = rand.Next(360, 570);
                    coin4.Location = new Point(x, 0);
                } while (coin4.Bounds.IntersectsWith(ptbEnemyCar4.Bounds) || coin4.Bounds.IntersectsWith(ptbEnemyCar5.Bounds));
            }
            else { coin4.Top += speed; }
        }

        void collectionCoin()
        {
            if (ptbMainCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                soundCoin();
                coinTemp++;
                numberOfCoin.Text = "Coin = " + coinTemp.ToString();
                do
                {
                    x = rand.Next(0, 150);
                    coin1.Location = new Point(x, 0);
                } while (coin1.Bounds.IntersectsWith(ptbEnemyCar1.Bounds));
            }

            if (ptbMainCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                soundCoin();
                coinTemp++;
                numberOfCoin.Text = "Coin = " + coinTemp.ToString();
                do
                {
                    x = rand.Next(170, 250);
                    coin2.Location = new Point(x, 0);
                } while (coin2.Bounds.IntersectsWith(ptbEnemyCar2.Bounds));
            }

            if (ptbMainCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                soundCoin();
                coinTemp++;
                numberOfCoin.Text = "Coin = " + coinTemp.ToString();
                do
                {
                    x = rand.Next(270, 350);
                    coin3.Location = new Point(x, 0);
                } while (coin3.Bounds.IntersectsWith(ptbEnemyCar3.Bounds));
            }

            if (ptbMainCar.Bounds.IntersectsWith(coin4.Bounds))
            {
                soundCoin();
                coinTemp++;
                numberOfCoin.Text = "Coin = " + coinTemp.ToString();
                do
                {
                    x = rand.Next(360, 570);
                    coin4.Location = new Point(x, 0);
                } while (coin4.Bounds.IntersectsWith(ptbEnemyCar4.Bounds) || coin4.Bounds.IntersectsWith(ptbEnemyCar5.Bounds));
            }
        }
        void gameOver()
        {
            if(ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar1.Bounds))
            {
                gameOverSound();
                timer1.Enabled = false;
                lbGameOver.Visible = true;
            }
            if (ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar2.Bounds))
            {
                gameOverSound();
                timer1.Enabled = false;
                lbGameOver.Visible = true;
            }
            if (ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar3.Bounds))
            {
                gameOverSound();
                timer1.Enabled = false;
                lbGameOver.Visible = true;
            }
            if (ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar4.Bounds))
            {
                gameOverSound();
                timer1.Enabled = false;
                lbGameOver.Visible = true;
            }
            if (ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar5.Bounds))
            {
                gameOverSound(); 
                timer1.Enabled = false;
                lbGameOver.Visible = true;
            }
        }

        void gameOverSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = Application.StartupPath + @"\..\..\Sound\GameOverSound.wav";
            soundPlayer.Play();
        }
        void soundCoin()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = Application.StartupPath + @"\..\..\Sound\CoinSound.wav";
            soundPlayer.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime(8);
            enemyCar(8);
            gameOver();
            coin(8);
            collectionCoin();
            ////if (ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar1.Bounds) || ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar2.Bounds)
            ////    || ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar3.Bounds) || ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar4.Bounds)
            ////    || ptbMainCar.Bounds.IntersectsWith(ptbEnemyCar5.Bounds))
            //{
            //    timer1.Enabled = false;
            //}
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = Application.StartupPath + @"\..\..\Sound\ThemeSong2.wav";
            soundPlayer.PlayLooping();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int superTemp; 
            superTemp = int.Parse(lbCount.Text) - 1;
            lbCount.Text = superTemp.ToString();
            if (superTemp == 0)
            {
                timer2.Enabled = false;
                lbCount.Visible = false;
                timer1.Enabled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == true)
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
}
