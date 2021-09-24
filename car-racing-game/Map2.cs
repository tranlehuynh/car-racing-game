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
        BG backGround; //Gồm lane và vạch kẻ đường đã thiết kế sẵn
        MainCar mainCar;
        EnemyCar[] enemies; //enemies này là tập hợp của các enemyCar
        public Map2()
        {
            InitializeComponent();
            // Hàm BG với tham số (speed của map, mảng các vạch đứt trong map đã được thiết kế sẵn, mảng các vạch liền, mảng các toạ độ X của từng lane dựa vào toạ độ này để xác định lane cho Car)
            backGround = new BG(5, new PictureBox[] { pbVachDut1, pbVachDut2, pbVachDut3, pbVachDut4, pbVachDut5, pbVachDut6, pbVachDut7, pbVachDut8, pbVachDut9, pbVachDut10, pbVachDut11, pbVachDut12}
            ,new PictureBox[] { pictureBox1} // Vạch liền
            , new int[] { 112, 302, 492, 672 }); // left của từng lane
            mainCar = new MainCar(pbMainCar, 0, ClientRectangle, backGround); // Hàm khởi tạo cần pictureBox của mainCar
            EnemyCar enemyCar1 = new EnemyCar(pbEnemyCar1, backGround.speed, backGround); // EnemyCar cần pictureBox của enemyCar, speed của map và đối tượng backGround (hiện tại trong code đang là backGround thiết kế với 4 lane)
            EnemyCar enemyCar2 = new EnemyCar(pbEnemyCar2, backGround.speed, backGround);
            EnemyCar enemyCar3 = new EnemyCar(pbEnemyCar3, backGround.speed, backGround);
            EnemyCar enemyCar4 = new EnemyCar(pbEnemyCar4, backGround.speed, backGround);
            enemies = new EnemyCar[] { enemyCar1, enemyCar2, enemyCar3, enemyCar4 }; //Thêm các enemyCar vào tập hợp enemies để dễ kiểm soát
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            road += backGround.speed; //Tính quãng đường đi được, hiện bên tay trái form
            Point.Text = (road / 1000).ToString(); //1000 có thể thay đổi //Tính điểm theo cơ chế road = 1000 thì được 1 điểm
            backGround.loopmove(ClientRectangle); // Hàm loopmove dùng để di chuyển các vạch đứt trong vạch kẻ đường, vạch kẻ đường đã được thêm vào bằng hàm khởi tạo
            foreach(var item in enemies)
            {
                item.move(ClientRectangle, backGround, enemies); //EnemyCar.move dùng để di chuyển các enemyCar, đã xử lý việc random xuất hiện
            }
            EnemyCar.EnemyCarVsEnemyCar(enemies); // Kiểm tra xem các enemyCar có đụng trúng nhau không, nếu có thì hãm speed của enemyCar lại
            if (mainCar.vaChamXe(enemies)) // Kiểm tra đụng xe giữa mainCar và các enemyCar, tham số enemies là tập hợp các enemyCar
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
                mainCar.move(backGround, true); // tham số thứ 2 = true nếu xe rẽ trái
            }
            if (e.KeyCode == Keys.D)
            {
                mainCar.move(backGround, false); // và ngược lại nếu xe rẽ phải
            }
        }
    }
}
