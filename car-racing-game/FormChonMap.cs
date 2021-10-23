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
    public partial class FormChonMap : Form
    {
        public FormChonMap()
        {
            InitializeComponent();
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
    }
}
