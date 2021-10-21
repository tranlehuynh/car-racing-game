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
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
            btMotNguoiChoi.GotFocus += ColorMove;
            btMotNguoiChoi.LostFocus += ColorLeave;


            btHaiNguoiChoi.GotFocus += ColorMove;
            btHaiNguoiChoi.LostFocus += ColorLeave;

            btDiemSo.GotFocus += ColorMove;
            btDiemSo.LostFocus += ColorLeave;

            btHuongDan.GotFocus += ColorMove;
            btHuongDan.LostFocus += ColorLeave;
        }

        SoundPlayer soundPlayer = new SoundPlayer();
        string soundPath = Application.StartupPath + @"\..\..\Sound\";
        string imagePath = Application.StartupPath + @"\..\..\Images\";
        private void BeginForm_Load(object sender, EventArgs e)
        {
            //soundPlayer.SoundLocation = Application.StartupPath + @"\..\..\Sound\ThemeSong2.wav";
            //soundPlayer.PlayLooping();
        }

        private void btMotNguoiChoi_Click(object sender, EventArgs e)
        {
            //Map1 f = new Map1(false);
            Form1 form1 = new Form1();
            soundPlayer.Stop();
            form1.ShowDialog();
        }

        private void btHaiNguoiChoi_Click(object sender, EventArgs e)
        {
            Map1 m = new Map1(true);
            soundPlayer.Stop();
            m.ShowDialog();
        }

        private void btDiemSo_Click(object sender, EventArgs e)
        {
            FormDiemSo formDiemSo = new FormDiemSo();
            formDiemSo.ShowDialog();
        }

        private void btHuongDan_Click(object sender, EventArgs e)
        {
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.ShowDialog();
        }

        private void btMotNguoiChoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form1 f = new Form1();
                f.ShowDialog();
            }
        }

        private void btHaiNguoiChoi_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btDiemSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormDiemSo formDiemSo = new FormDiemSo();
                formDiemSo.ShowDialog();
            }
        }

        private void btHuongDan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InstructionForm instructionForm = new InstructionForm();
                instructionForm.ShowDialog();
            }
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

        private void btMotNguoiChoi_MouseMove(object sender, MouseEventArgs e)
        {
            btMotNguoiChoi.Focus();
        }

        private void btHaiNguoiChoi_MouseMove(object sender, MouseEventArgs e)
        {
            btHaiNguoiChoi.Focus();
        }

        private void btDiemSo_MouseMove(object sender, MouseEventArgs e)
        {
            btDiemSo.Focus();
        }

        private void btHuongDan_MouseMove(object sender, MouseEventArgs e)
        {
            btHuongDan.Focus();
        }


    }
}
