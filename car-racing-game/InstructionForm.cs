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
    public partial class InstructionForm : Form
    {
        public InstructionForm()
        {
            InitializeComponent();
            lbCachChoi.BackColor = System.Drawing.Color.Transparent;
            lbNguoiChoi1.BackColor = lbNguoiChoi2.BackColor = lbNoiDung1.BackColor = lbNoiDung2.BackColor = System.Drawing.Color.Transparent;
        }
        private void DeleteBackColor(object sender, EventArgs e)
        {
            var temp = sender as Label;
            temp.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
