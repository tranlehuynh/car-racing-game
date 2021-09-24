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
    public partial class Map2 : Form
    {
        Int64 road = 0;
        BG backGround;
        MainCar mainCar;
        EnemyCar[] enemies;
        public Map2()
        {
            InitializeComponent();
            backGround = new BG(5, new PictureBox[] { pbVachDut1, pbVachDut2, pbVachDut3, pbVachDut4, pbVachDut5, pbVachDut6, pbVachDut7, pbVachDut8, pbVachDut9, pbVachDut10, pbVachDut11, pbVachDut12}
            ,new PictureBox[] { pictureBox1}
            , new int[] { 112, 302, 492, 672 });
            mainCar = new MainCar(pbMainCar, 0, ClientRectangle, backGround);
            EnemyCar enemyCar1 = new EnemyCar(pbEnemyCar1, backGround.speed, backGround);
            EnemyCar enemyCar2 = new EnemyCar(pbEnemyCar2, backGround.speed, backGround);
            EnemyCar enemyCar3 = new EnemyCar(pbEnemyCar3, backGround.speed, backGround);
            EnemyCar enemyCar4 = new EnemyCar(pbEnemyCar4, backGround.speed, backGround);
            enemies = new EnemyCar[] { enemyCar1, enemyCar2, enemyCar3, enemyCar4 };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            road += backGround.speed;
            Point.Text = (road / 1000).ToString(); //1000 có thể thay đổi
            backGround.loopmove(ClientRectangle);
            foreach(var item in enemies)
            {
                item.move(ClientRectangle, backGround, enemies);
            }
            EnemyCar.EnemyCarVsEnemyCar(enemies);
            if (mainCar.vaChamXe(enemies))
            {
                timer1.Enabled = false;
            }
        }

        protected void timer2_Tick(object sender, EventArgs e)
        {
            Time.Text = (int.Parse(Time.Text) + 1).ToString();
        }

        protected void Map2_Load(object sender, EventArgs e)
        {
            Time.Text = Point.Text = 0.ToString();
        }

        private void Map2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                mainCar.move(backGround, true);
            }
            if (e.KeyCode == Keys.D)
            {
                mainCar.move(backGround, false);
            }
        }
    }
}
