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
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }
        private void btXacNhan_Click(object sender, EventArgs e)
        {
            //StringWriter stringWriter;
            string path = Application.StartupPath + @"\1PlayerScore.txt";

            //Neu chua co file
            if (!File.Exists(path))
            {
                using (StreamWriter streamWriter = File.CreateText(path))
                {
                    streamWriter.WriteLine(txtPlayerName.Text);
                }
            }
            else
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine(txtPlayerName.Text);
                }
            }
        }
    }
}
