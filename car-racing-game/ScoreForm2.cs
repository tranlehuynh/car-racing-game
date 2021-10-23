using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace car_racing_game
{
    public partial class ScoreForm2 : Form
    {
        public ScoreForm2()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath + @"\2PlayerScore.txt";

        private void ScoreForm2_Load(object sender, EventArgs e)
        {

        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
           
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
