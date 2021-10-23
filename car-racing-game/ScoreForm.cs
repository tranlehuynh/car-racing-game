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
        string path = Application.StartupPath + @"\1PlayerScore.txt";
        string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void btXacNhan_Click(object sender, EventArgs e)
        {

            //Neu chua co file
            if (txtPlayerName != null && txtPlayerName.Text != "" && !String.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                try
                {
                    if (!File.Exists(path))
                    {
                        using (StreamWriter streamWriter = File.CreateText(path))
                        {
                            streamWriter.WriteLine(txtPlayerName.Text + " " + _message);
                        }
                    }
                    else
                    {
                        using (StreamWriter streamWriter = File.AppendText(path))
                        {
                            streamWriter.WriteLine(txtPlayerName.Text + " " + _message);
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

        private void txtPlayerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ScoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Player> PlayerList = new List<Player>();
            List<string> lines = File.ReadAllLines(path).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(' ');

                Player newPlayer = new Player();
                newPlayer.Name = entries[0];
                newPlayer.Score = entries[1];

                PlayerList.Add(newPlayer);
            }




            //List<Player> PlayerList = new List<Player>();
            //List<string> lines = File.ReadAllLines(path).ToList();

            //foreach (var line in lines)
            //{
            //    string[] entries = line.Split(' ');

            //    Player newPlayer = new Player();
            //    newPlayer.Name = entries[0];
            //    newPlayer.Score = entries[1];

            //    PlayerList.Add(newPlayer);
            //}

            PlayerList.Sort((a, b) => int.Parse(b.Score).CompareTo(int.Parse(a.Score)));
            //foreach (var person in PlayerList)
            //{
            //    Console.WriteLine($"{person.Name}{' '}{person.Score}");
            //}

            List<string> output = new List<string>();
            foreach (var person in PlayerList)
            {
                output.Add($"{person.Name}{' '}{person.Score}");
            }
            File.WriteAllLines(path, output);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
