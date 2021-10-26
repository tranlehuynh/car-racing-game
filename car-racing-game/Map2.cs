using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace car_racing_game
{
    public partial class Map2 : Form
    {
        Int64 roadMainCar = 0, roadThief = 0;
        BG backGround; //Gồm lane và vạch kẻ đường đã thiết kế sẵn
        MainCar mainCar;
        bool mode = false, checkSkillMainCar = false, checkSkillThief = false, win = false;
        EnemyCar[] enemies; //enemies này là tập hợp của các enemyCar
        ThiefCar thief;
        System.Windows.Forms.Timer timerMain, timerThief, timerCountDown;
        int buffMain = 10, buffThief = 10, speedbuff, speedmap, time = 0;
        SoundPlayer soundPlayer;
        EnemyCar car;

        public Map2(bool mode)
        {
            InitializeComponent();
            // Hàm BG với tham số (speed của map, mảng các vạch đứt trong map đã được thiết kế sẵn, mảng các vạch liền, mảng các toạ độ X của từng lane dựa vào toạ độ này để xác định lane cho Car)
            backGround = new BG(5, new PictureBox[] { pbVachDut1, pbVachDut2, pbVachDut3, pbVachDut5, pbVachDut6, pbVachDut8, pbVachDut9, pbVachDut10, pbVachDut11, pbVachDut12 }
            , new int[] { 112, 302, 492, 672 }); // left của từng lane

            // Hàm khởi tạo cần pictureBox của mainCar
            mainCar = new MainCar(pbMainCar, 0, ClientRectangle, backGround);
            this.mode = mode;
            speedmap = backGround.speed;
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
            // Them pictureBox cua cac enemyCar vao mang enemies
            enemies = new EnemyCar[] { new EnemyCar(pbEnemyCar1, backGround.speed, backGround),
                new EnemyCar(pbEnemyCar2, backGround.speed, backGround),
                new EnemyCar(pbEnemyCar3, backGround.speed, backGround)};

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Tính quãng đường đi được, hiện bên tay trái form
            roadMainCar += backGround.speed;

            //1000 có thể thay đổi //Tính điểm theo cơ chế road = 1000 thì được 1 điểm
            pointlb.Text = string.Format("Point: {0}", roadMainCar / 1000);

            // Di chuyển các vạch đứt trong vạch kẻ đường, vạch kẻ đường đã được thêm vào bằng hàm khởi tạo
            foreach (var item in backGround.VachDut)
            {
                backGround.move(item, ClientRectangle);
            }

            //Di chuyen enemyCar
            foreach (EnemyCar enemyCar in enemies)
            {
                enemyCar.move(ClientRectangle, backGround, enemies);
            }
            //Xet va cham
            EnemyCar.EnemyCarVsEnemyCar(enemies); // Kiểm tra xem các enemyCar có đụng trúng nhau không, nếu có thì hãm speed của enemyCar lại
            if (mode)
            {
                //
                thief.run(backGround);
                roadThief += thief.speed;
                if (roadThief == 100000 || thief.pb.Top <= 0)
                {
                    win = true;
                    timer1.Enabled = timer2.Enabled = timerMain.Enabled = timerThief.Enabled = false;
                }
                else if (thief.pb.Bottom >= ClientRectangle.Bottom)
                {
                    timer1.Enabled = timer2.Enabled = timerMain.Enabled = timerThief.Enabled = false;
                }
                else if (mainCar.pb.Bounds.IntersectsWith(thief.pb.Bounds))
                {
                    thief.pb.Image = mainCar.pb.Image = Image.FromFile(Application.StartupPath + @"\..\..\Images\boom-1.png");
                    timer1.Enabled = timer2.Enabled = timerMain.Enabled = timerThief.Enabled = false;
                }
                else if ((car = thief.vaChamXe(enemies)) != null)
                {
                    thief.pb.Image = car.pb.Image = Image.FromFile(Application.StartupPath + @"\..\..\Images\boom-1.png");
                    timer1.Enabled = timer2.Enabled = timerMain.Enabled = timerThief.Enabled = false;
                }
                else if ((car = mainCar.vaChamXe(enemies)) != null)
                {
                    win = true;
                    mainCar.pb.Image = car.pb.Image = Image.FromFile(Application.StartupPath + @"\..\..\Images\boom-1.png");
                    timer1.Enabled = timer2.Enabled = timerMain.Enabled = timerThief.Enabled = false;
                }
                else
                {
                    //Check skill
                    checkSkillThief = thief.checkSkill(progressBar1.Value);
                }
            }
            else
            {
                if ((car = mainCar.vaChamXe(enemies)) != null)
                {
                    mainCar.pb.Image = car.pb.Image = Image.FromFile(Application.StartupPath + @"\..\..\Images\boom-1.png");
                    timer1.Enabled = timer2.Enabled = timerMain.Enabled = false;
                }
            }
            //Check skill main Car
            checkSkillMainCar = mainCar.checkSkill(progressBar2.Value);
            if (timer1.Enabled == false)
            {
                if (mode)
                {
                    if (win == true)
                    {
                        soundPlayer.SoundLocation = Application.StartupPath + @"/../../Sound/win.wav";
                        soundPlayer.Play();
                        startlb.Text = "WIN";
                    }
                    else
                    {
                        soundPlayer.SoundLocation = Application.StartupPath + @"/../../Sound/GameOverSound.wav";
                        startlb.Text = "LOSE";
                        soundPlayer.Play();
                    }
                    ScoreForm2 f = new ScoreForm2();
                    f.Message = win.ToString();
                    f.ShowDialog();
                }
                else
                {
                    soundPlayer.SoundLocation = Application.StartupPath + @"/../../Sound/GameOverSound.wav";
                    startlb.Text = "GAME OVER";
                    soundPlayer.Play();
                    ScoreForm1 scoreForm = new ScoreForm1();
                    scoreForm.Message = (roadMainCar / 1000).ToString();
                    scoreForm.ShowDialog();
                }
                MessageBox.Show("Bạn vui lòng đóng màn chơi để quay về màn hình bắt đầu nhé");
            }
        }

        protected void timer2_Tick(object sender, EventArgs e)
        {
            //Tich nitro, xe an trom tich nitro lau hon xe canh sat
            if (!checkSkillMainCar && !timerMain.Enabled)
            {
                progressBar2.Increment(5);
                if (mainCar.pb.Left == coin1.Left) progressBar2.Increment(5);
            }
            if (mode)
            {
                timelb.Text = string.Format("Point: {0}", roadThief / 1000);
                if (!checkSkillThief && !timerThief.Enabled)
                {
                    progressBar1.Increment(5);
                    if (thief.pb.Left == coin1.Left) progressBar1.Increment(5);
                }
            }
            else
            {
                time++;
                timelb.Text = string.Format("Time: {0}s", time);
            }
        }

        protected void Map2_Load(object sender, EventArgs e)
        {
            timelb.Text = 0.ToString();
            progressBar2.Visible = true;
            //timer MainCar
            timerMain = new System.Windows.Forms.Timer();
            timerMain.Tick += new EventHandler(timerMain_tick);
            timerMain.Interval = 1000;
            //timer Count down
            timerCountDown = new System.Windows.Forms.Timer();
            timerCountDown.Tick += new EventHandler(timerCountDown_tick);
            timerCountDown.Interval = 1000;
            timer1.Enabled = timer2.Enabled = false;
            if (mode)
            {
                //Timer Thief car
                timerThief = new System.Windows.Forms.Timer();
                timerThief.Tick += new EventHandler(timerThief_tick);
                timerThief.Interval = 1000;
                progressBar1.Visible = progressBar1.Enabled = true;

                //Lane buff nitro
                Random random = new Random();
                coin1.Left = backGround.lane[random.Next(0, backGround.lane.Length)];
                coin1.Top = ClientRectangle.Top;
            }
            else
            {
                coin1.Visible = false;
                progressBar1.Visible = progressBar1.Enabled = false;
            }
            //Chay timer count down
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = Application.StartupPath + @"/../../Sound/start.wav";
            soundPlayer.Play();
            timerCountDown.Start();
        }

        private void Map2_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled)
            {
                soundPlayer.SoundLocation = Application.StartupPath + @"/../../Sound/buff.wav";
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
                        if (mode)
                        {
                            backGround.speed = speedbuff + speedmap;
                        }
                        else
                        {
                            backGround.speed += speedbuff;
                        }
                        soundPlayer.Play();
                        EnemyCar.buffSpeed(enemies, speedbuff);
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
                            thief.speed = speedbuff + speedmap;
                            soundPlayer.Play();
                            timerThief.Start();
                        }
                    }
                    else
                    {
                        if (checkSkillMainCar)
                        {
                            backGround.speed += speedbuff;
                            soundPlayer.Play();
                            EnemyCar.buffSpeed(enemies, speedbuff);
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
                if (mode)
                {
                    backGround.speed = speedmap;
                }
                buffMain = 10;
                timerMain.Stop();
            }
        }
        private void timerThief_tick(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
            buffThief--;
            if (buffThief == 0)
            {
                thief.speed = speedmap;
                buffThief = 10;
                timerThief.Stop();
            }
        }
        private void timerCountDown_tick(object sender, EventArgs e)
        {
            if (startlb.Text == "START")
            {
                startlb.Visible = false;
                timer1.Start();
                timer2.Start();
                timerCountDown.Stop();
            }
            else
            {
                if (startlb.Text == "1")
                {
                    startlb.Text = "START";
                }
                else
                {
                    startlb.Text = (int.Parse(startlb.Text) - 1).ToString();
                }
            }
        }
    }
}
