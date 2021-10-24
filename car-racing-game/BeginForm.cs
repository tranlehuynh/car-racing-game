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
using System.Threading;

namespace car_racing_game
{
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
            btMotNguoiChoi.GotFocus += ColorMove;
            btMotNguoiChoi.LostFocus += ColorLeave;


            btHaiNguoiChoi.GotFocus += ColorMove;
            btHaiNguoiChoi.LostFocus += ColorLeave;

            btBaNguoiChoi.GotFocus += ColorMove;
            btBaNguoiChoi.LostFocus += ColorLeave;

            btDiemSo.GotFocus += ColorMove;
            btDiemSo.LostFocus += ColorLeave;

            btHuongDan.GotFocus += ColorMove;
            btHuongDan.LostFocus += ColorLeave;
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        string soundPath = Application.StartupPath + @"\..\..\Sound\";
        string imagePath = Application.StartupPath + @"\..\..\Images\";
        public void openForm1()
        {
            Application.Run(new Form1());
        }
        public void openForm2()
        {
            Application.Run(new FormChonMap());
        }
        public void openForm3()
        {
            Application.Run(new FormChonMap2());
        }
        public void openForm4()
        {
            Application.Run(new FormDiemSo());
        }
        public void openForm5()
        {
            Application.Run(new InstructionForm());
        }
        private void BeginForm_Load(object sender, EventArgs e)
        {
            //soundPlayer.SoundLocation = Application.StartupPath + @"\..\..\Sound\Theme.wav";
            //soundPlayer.PlayLooping();
        }
        private void btMotNguoiChoi_Click(object sender, EventArgs e)
        {
            this.Close();
            soundPlayer.Stop();
            Thread thread = new Thread(openForm1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void btHaiNguoiChoi_Click(object sender, EventArgs e)
        {
            this.Close();
            soundPlayer.Stop();
            Thread thread = new Thread(openForm2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void btBaNguoiChoi_Click(object sender, EventArgs e)
        {
            this.Close();
            soundPlayer.Stop();
            Thread thread = new Thread(openForm3);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void btDiemSo_Click(object sender, EventArgs e)
        {
            FormDiemSo f = new FormDiemSo();
            f.Show();
        }

        private void btHuongDan_Click(object sender, EventArgs e)
        {
            InstructionForm f = new InstructionForm();
            f.Show();
        }

        private void btMotNguoiChoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
                soundPlayer.Stop();
                Thread thread = new Thread(openForm1);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void btHaiNguoiChoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
                soundPlayer.Stop();
                Thread thread = new Thread(openForm2);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        private void btBaNguoiChoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
                soundPlayer.Stop();
                Thread thread = new Thread(openForm3);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }
        private void btDiemSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormDiemSo f = new FormDiemSo();
                f.Show();
            }
        }
        private void btHuongDan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InstructionForm f = new InstructionForm();
                f.Show();
            }
        }
        private void btMotNguoiChoi_MouseMove(object sender, MouseEventArgs e)
        {
            btMotNguoiChoi.Focus();
        }
        private void btHaiNguoiChoi_MouseMove(object sender, MouseEventArgs e)
        {
            btHaiNguoiChoi.Focus();
        }
        private void btBaNguoiChoi_MouseMove(object sender, MouseEventArgs e)
        {
            btBaNguoiChoi.Focus();
        }
        private void btDiemSo_MouseMove(object sender, MouseEventArgs e)
        {
            btDiemSo.Focus();
        }
        private void btHuongDan_MouseMove(object sender, MouseEventArgs e)
        {
            btHuongDan.Focus();
        }
        private void ColorMove(object sender, EventArgs e)
        {
            var temp = sender as Button;
            temp.BackColor = SystemColors.ControlDark;
        }
        private void ColorLeave(object sender, EventArgs e)
        {
            var temp = sender as Button;
            temp.BackColor = SystemColors.Control;
        }
    }
}
