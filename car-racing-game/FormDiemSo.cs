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
        DataTable dataTable = new DataTable();
        private void FormDiemSo_Load(object sender, EventArgs e)
        {
            DataRow dataRow;
            //Add 2 column
            dataTable.Columns.Add("Họ tên người chơi");
            dataTable.Columns.Add("Điểm số");       
            //Add data
            dataGridView1.DataSource = dataTable;

            //Dinh dang hai cot
            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.5);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.5);

            dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[1].Resizable = DataGridViewTriState.False;

            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Rows[0].Resizable = DataGridViewTriState.False;
            dataGridView1.Rows[0].Resizable = DataGridViewTriState.False;


            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            string path = Application.StartupPath + @"\1PlayerScore.txt";
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    while (streamReader.Peek() > 0)
                    {
                        //listBox1.Items.Add(streamReader.ReadLine());
                        string temp = streamReader.ReadLine();
                        string[] entries = temp.Split(' ');

                        dataRow = dataTable.NewRow();
                        dataRow[0] = entries[0];
                        dataRow[1] = entries[1];
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
