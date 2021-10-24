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
    public partial class FormChonMap : Form
    {
        public FormChonMap()
        {
            InitializeComponent();
            btMap1.GotFocus += ColorMove;
            btMap1.LostFocus += ColorLeave;

            btMap2.GotFocus += ColorMove;
            btMap2.LostFocus += ColorLeave;
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
        public void openBeginForm()
        {
            Application.Run(new BeginForm());
        }

        private void btMap1_Click(object sender, EventArgs e)
        {
            Map1 map1 = new Map1(false);
            map1.ShowDialog();
            this.Close();
        }

        private void btMap2_Click(object sender, EventArgs e)
        {
            Map2 map2 = new Map2(false);
            map2.ShowDialog();
            this.Close();
        }

        private void FormChonMap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread thread = new Thread(openBeginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btMap1_MouseMove(object sender, MouseEventArgs e)
        {
            btMap1.Focus();
        }

        private void btMap2_MouseMove(object sender, MouseEventArgs e)
        {
            btMap2.Focus();
        }

        private void btMap1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Map1 map1 = new Map1(true);
                map1.ShowDialog();
                this.Close();
            }
        }

        private void btMap2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Map2 map2 = new Map2(true);
                map2.ShowDialog();
                this.Close();
            }
        }
    }
}
