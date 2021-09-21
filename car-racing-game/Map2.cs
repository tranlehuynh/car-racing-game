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
        public Map2()
        {
            InitializeComponent();
            backGround = new BG(5, new PictureBox[] { pbVachDut1, pbVachDut2, pbVachDut3, pbVachDut4, pbVachDut5, pbVachDut6, pbVachDut7, pbVachDut8, pbVachDut9, pbVachDut10, pbVachDut11, pbVachDut12}
            ,new PictureBox[] { pictureBox1});
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            road += backGround.speed;
            Point.Text = (road / 1000).ToString();
            backGround.loopmove(ClientRectangle);
        }

        protected void timer2_Tick(object sender, EventArgs e)
        {
            Time.Text = (int.Parse(Time.Text) + 1).ToString();
        }

        protected void Map2_Load(object sender, EventArgs e)
        {
            Time.Text = Point.Text = 0.ToString();
        }
    }
}
