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
    public partial class FormDiemSo : Form
    {
        public FormDiemSo()
        {
            InitializeComponent();
        }

        private void FormDiemSo_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\1PlayerScore.txt";
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    //listBox1.Items.Add(streamReader.ReadToEnd());
                    while (streamReader.Peek() > 10)
                    {
                        listBox1.Items.Add(streamReader.ReadLine());
                    }
                    //for (int i = 1; i < 11; i++)
                    //{
                    //    listBox1.Items.Add(streamReader.ReadLine());
                    //}
                    //listBox1.Items.Add(streamReader.ReadLine());
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
