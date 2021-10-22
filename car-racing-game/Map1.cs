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
    public partial class Map1 : Form
    {
        Int64 roadMainCar = 0, roadThief = 0;
        BG backGround; //Gồm lane và vạch kẻ đường đã thiết kế sẵn
        MainCar mainCar;
        bool mode = false, checkSkillMainCar = false, checkSkillThief = false, checkBuffSpeedEnemy = false;
        EnemyCar[] enemies; //enemies này là tập hợp của các enemyCar
        ThiefCar thief;
        System.Windows.Forms.Timer timerMain, timerThief;
        int buffMain = 10, buffThief = 10;
        int speedbuff;
        public Map1(bool mode)
        {
            InitializeComponent();
            backGround = new BG(8, new PictureBox[] { pbVachDut1, pbVachDut2, pbVachDut3, pbVachDut4, pbVachDut5, pbVachDut6, pbVachDut7, pbVachDut8, pbVachDut9, pbVachDut10, pbVachDut11, pbVachDut12 }
            , new int[] { 44, 164, 324, 468, 614, 748 }); // left của từng lane
            mainCar = new MainCar(ptbMainCar, 0, ClientRectangle, backGround); // Hàm khởi tạo cần pictureBox của mainCar

            this.mode = mode;
            speedbuff = backGround.speed / 4;
            if (this.mode)
            {
                //Khoi tao pictureBox thief car
                PictureBox thiefCar = new PictureBox();
                thiefCar.Size = mainCar.pb.Size;
                thiefCar.Image = mainCar.pb.Image;
                thiefCar.SizeMode = PictureBoxSizeMode.StretchImage;

                //add controls vao form
                Controls.Add(thiefCar);

                //gan lai anh cho mainCar thanh police car
                mainCar.pb.Image = Image.FromFile(Application.StartupPath + @"/../../Images/police-car.png");

                //Khoi tao thief car
                thief = new ThiefCar(thiefCar, ClientRectangle, mainCar, backGround.speed, backGround);
            }

            EnemyCar enemyCar1 = new EnemyCar(ptbEnemyCar1, backGround.speed, backGround); // EnemyCar cần pictureBox của enemyCar, speed của map và đối tượng backGround (hiện tại trong code đang là backGround thiết kế với 4 lane)
            EnemyCar enemyCar2 = new EnemyCar(ptbEnemyCar2, backGround.speed, backGround);
            EnemyCar enemyCar3 = new EnemyCar(ptbEnemyCar3, backGround.speed, backGround);
            EnemyCar enemyCar4 = new EnemyCar(ptbEnemyCar4, backGround.speed, backGround);
            EnemyCar enemyCar5 = new EnemyCar(ptbEnemyCar5, backGround.speed, backGround);
            enemies = new EnemyCar[] { enemyCar1, enemyCar2, enemyCar3, enemyCar4, enemyCar5}; //Thêm các enemyCar vào tập hợp enemies để dễ kiểm soát
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Tính quãng đường đi được, hiện bên tay trái form
            roadMainCar += backGround.speed;

            //1000 có thể thay đổi //Tính điểm theo cơ chế road = 1000 thì được 1 điểm
            Point.Text = (roadMainCar / 1000).ToString();

            // Hàm loopmove dùng để di chuyển các vạch đứt trong vạch kẻ đường, vạch kẻ đường đã được thêm vào bằng hàm khởi tạo
            backGround.loopmove(ClientRectangle);

            //enemyCar.move dùng để di chuyển các enemyCar, đã xử lý việc random xuất hiện
            foreach (var item in enemies)
            {
                item.move(ClientRectangle, backGround, enemies);
            }

            //Xet va cham
            EnemyCar.EnemyCarVsEnemyCar(enemies); // Kiểm tra xem các enemyCar có đụng trúng nhau không, nếu có thì hãm speed của enemyCar lại
            if (mode)
            {
                //
                thief.run(backGround);
                roadThief += thief.speed;
                // Kiểm tra đụng xe giữa mainCar và thiefCar với các enemyCar, tham số enemies là tập hợp các enemyCar
                {
                    if (roadThief == 100000 || thief.vaChamXe(enemies) || mainCar.pb.Bounds.IntersectsWith(thief.pb.Bounds) || thief.pb.Bottom == ClientRectangle.Bottom)
                        timer1.Enabled = timer2.Enabled = timerMain.Enabled = timerThief.Enabled = false;
                }

                //Check skill
                checkSkillThief = thief.checkSkill(progressBar1.Value);
            }
            if (mainCar.vaChamXe(enemies))
            {
                timer1.Enabled = timer2.Enabled = timerMain.Enabled = false;
            }
            //Check skill main Car
            checkSkillMainCar = mainCar.checkSkill(progressBar2.Value);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Time.Text = (int.Parse(Time.Text) + 1).ToString();
            //Tich nitro, xe an trom tich nitro lau hon xe canh sat
            if (!checkSkillMainCar && !timerMain.Enabled)
            {
                progressBar2.Increment(10);
            }
            if (mode)
            {
                if (!checkSkillThief && !timerThief.Enabled) progressBar1.Increment(5);
            }
        }

        private void Map1_Load(object sender, EventArgs e)
        {
            Time.Text = Point.Text = 0.ToString();
            progressBar2.Visible = true;
            //timer MainCar
            timerMain = new System.Windows.Forms.Timer();
            timerMain.Tick += new EventHandler(timerMain_tick);
            timerMain.Interval = 1000;
            if (mode)
            {
                //Timer Thief car
                timerThief = new System.Windows.Forms.Timer();
                timerThief.Tick += new EventHandler(timerThief_tick);
                timerThief.Interval = 1000;
                progressBar1.Visible = progressBar1.Enabled = true;
            }
            else
            {
                progressBar1.Visible = progressBar1.Enabled = false;
            }
        }

        private void Map1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled)
            {
                if (e.KeyCode == Keys.A)
                {
                    mainCar.move(backGround, true); // tham số thứ 2 = true nếu xe rẽ trái
                }
                if (e.KeyCode == Keys.D)
                {
                    mainCar.move(backGround, false); // và ngược lại nếu xe rẽ phải
                }
                if (e.KeyCode == Keys.W)
                {
                    if (checkSkillMainCar)
                    {
                        backGround.speed += speedbuff;
                        if ((mode && timerThief.Enabled == false) || mode == false)
                        {
                            EnemyCar.buffSpeedEnenemy(enemies, speedbuff);
                            checkBuffSpeedEnemy = true;
                        }
                        timerMain.Start();
                    }
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (mode)
                    {
                        thief.move(backGround, true);
                    }
                    else
                    {
                        mainCar.move(backGround, true);
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (mode)
                    {
                        thief.move(backGround, false);
                    }
                    else
                    {
                        mainCar.move(backGround, false);
                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (mode)
                    {
                        if (checkSkillThief)
                        {
                            thief.speed += speedbuff;
                            if (timerMain.Enabled == false) EnemyCar.buffSpeedEnenemy(enemies, speedbuff);
                            timerThief.Start();
                        }
                    }
                    else
                    {
                        if (checkSkillMainCar)
                        {
                            backGround.speed += speedbuff;
                            EnemyCar.buffSpeedEnenemy(enemies, speedbuff);
                            checkBuffSpeedEnemy = true;
                            timerMain.Start();
                        }
                    }
                }
            }
        }
        private void timerMain_tick(object sender, EventArgs e)
        {
            progressBar2.Value -= 10;
            buffMain--;
            if (buffMain == 0)
            {
                buffMain = 10;
                backGround.speed -= speedbuff;
                if (checkBuffSpeedEnemy)
                {
                    EnemyCar.downSpeed(enemies, speedbuff);
                    checkBuffSpeedEnemy = false;
                }
                timerMain.Stop();
            }
        }
        private void timerThief_tick(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
            buffThief--;
            if (buffThief == 0)
            {
                buffThief = 10;
                thief.speed -= speedbuff;
                if (checkBuffSpeedEnemy)
                {
                    EnemyCar.downSpeed(enemies, speedbuff);
                    checkBuffSpeedEnemy = false;
                }
                timerThief.Stop();
            }
        }
    }
}
