using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_racing_game
{
    class BG
    {
        public int speed = 0;
        public System.Windows.Forms.PictureBox[] VachDut;
        public int[] lane;

        public BG(int speed, System.Windows.Forms.PictureBox[] vachDut, int[] lane)
        {
            this.speed = speed;
            this.VachDut = vachDut;
            this.lane = lane;
        }
        public void move(System.Windows.Forms.PictureBox pb, System.Drawing.Rectangle clientRec)
        {
            pb.Top += speed;
            if (pb.Top >= clientRec.Bottom)
            {
                pb.Top = clientRec.Top - pb.Height;
            }
        }
        public void loopmove(System.Drawing.Rectangle clientRec)
        {
            foreach(var item in VachDut)
            {
                move(item, clientRec);
            }
        }
    }
}
