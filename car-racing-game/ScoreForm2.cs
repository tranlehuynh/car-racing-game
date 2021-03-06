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
        string path = Application.StartupPath + @"\..\..\Map2PlayerScore.txt";
        string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void ScoreForm2_Load(object sender, EventArgs e)
        {

        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            //Neu chua co file
            if (txtXeCanhSat != null && txtXeCanhSat.Text != "" && !String.IsNullOrWhiteSpace(txtXeCanhSat.Text))
            {
                try
                {
                    if (!File.Exists(path))
                    {
                        using (StreamWriter streamWriter = File.CreateText(path))
                        {
                            if (_message == "true")
                            {
                                streamWriter.WriteLine(txtXeCuop.Text + " " + txtXeCanhSat.Text + " " + "Thắng"); 
                            }
                            else
                            {
                                streamWriter.WriteLine(txtXeCuop.Text + " " + txtXeCanhSat.Text + " " + "Thua");
                            }
                        }
                    }
                    else
                    {
                        using (StreamWriter streamWriter = File.AppendText(path))
                        {
                            if (_message == "true")
                            {
                                streamWriter.WriteLine(txtXeCuop.Text + " " + txtXeCanhSat.Text + " " + "Thắng");
                            }
                            else
                            {
                                streamWriter.WriteLine(txtXeCuop.Text + " " + txtXeCanhSat.Text + " " + "Thua");
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi lưu");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy nhập tên người chơi!");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtXeCanhSat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtXeCuop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
