using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_racing_game
{
    class Car
    {
        public System.Windows.Forms.PictureBox pb; //pictureBox của Car
        public int speed;
        public Car(System.Windows.Forms.PictureBox pictureBox, int speed)
        {
            this.pb = pictureBox;
            this.speed = speed;
        }
    }
    class MainCar : Car
    {
        public MainCar(System.Windows.Forms.PictureBox pictureBox, int speed, System.Drawing.Rectangle rectangle, BG bG) : base(pictureBox, speed)
        {
            pb.Top = rectangle.Bottom - pb.Height; // gán top cho mainCar nằm dưới cùng
            pb.Left = bG.lane[bG.lane.Length / 2]; // Khởi tạo xe tại lane giữa
        }


        public void move(BG bG, bool left)
        {
            int vt = Array.IndexOf(bG.lane, pb.Left);
            if (left)
            {
                if (pb.Left != bG.lane[0])
                    pb.Left = bG.lane[vt - 1];
            }
            else
            {
                if (pb.Left != bG.lane[bG.lane.Length - 1])
                    pb.Left = bG.lane[vt + 1];
            }
        }
        public bool vaChamXe(EnemyCar[] enemies)
        {
            foreach (var enemy in enemies)
            {
                if (this.pb.Bounds.IntersectsWith(enemy.pb.Bounds))
                {
                    return true;
                }
            }
            return false;
        }
    }
    class EnemyCar : Car
    {
        public bool nguoc = false;
        public bool available = true;

        public EnemyCar(System.Windows.Forms.PictureBox pictureBox, int speed, BG bG) : base(pictureBox, speed)
        {
            pb.Top = -pb.Height;
        }
        public void makeEnemy(BG bG, EnemyCar[] enemies) // Tao enemyCar neu xe chua xuat hien hoac da di qua
        {
            Random random = new Random();
            int temp = random.Next(0, (bG.lane.Length));
            pb.Left = bG.lane[temp]; // lay lane random trong Background.lane
            pb.Top = 0 - pb.Height;
            foreach (var enemy in enemies)
            {
                if (this.Equals(enemy)) // kiểm tra trùng
                    continue;
                if (enemy.pb.Bounds.IntersectsWith(pb.Bounds))
                {
                    pb.Top = enemy.pb.Top - 2 * pb.Height;
                }
            }
            if (temp < bG.lane.Length / 2) // nếu xe đi ngược chiều
            {
                this.speed = random.Next(bG.speed, (int)(3.0 / 2.0 * bG.speed)); // tốc độ sẽ random trong khoảng {backGround speed, 1,5 lần backGround speed}
                pb.Image.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipY); // lật hình xe nếu enemyCar đi lane ngược lại
                nguoc = true;
            }
            else
            {
                nguoc = false; // Chỗ này hơi thừa, nhưng cứ để đây cho chắc ăn
                this.speed = random.Next((bG.speed / 2), bG.speed);
            }
        }
        public static void EnemyCarVsEnemyCar(EnemyCar[] enemyCars)
        {
            foreach (var item in enemyCars)
            {
                foreach (var y in enemyCars)
                {
                    if (item.Equals(y))
                        continue; // Kiểm tra trùng xe
                    if (item.pb.Bounds.IntersectsWith(y.pb.Bounds))
                    {
                        item.speed = y.speed; // Nếu trùng thì hãm speed 2 xe bằng speed xe nào thấp hơn
                    }
                }
            }
        }

        public void move(System.Drawing.Rectangle rec, BG bG, EnemyCar[] enemies)
        {
            if (!available)
            {
                pb.Top += speed;
                if (pb.Top >= rec.Bottom)
                {
                    pb.Top = -pb.Height;
                    available = true;
                    if (nguoc)
                    {
                        pb.Image.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipY); //Nếu enemyCar ngược chiều thì xoay lại cho hàm makeEnemy dễ xử lý
                        nguoc = false;
                    }
                }
            }
            else
            {
                available = false;
                makeEnemy(bG, enemies);
            }
        }
    }
}
