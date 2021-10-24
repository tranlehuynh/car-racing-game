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
using System.Media;
using System.Threading;

namespace car_racing_game
{
    public partial class FormDiemSo : Form
    {
        public FormDiemSo()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        DataTable dataTable1 = new DataTable();
        DataTable dataTable2 = new DataTable();
        private void FormDiemSo_Load(object sender, EventArgs e)
        {
            DataRow dataRow;
            DataRow dataRow1;
            DataRow dataRow2;
            //Add 2 column
            dataTable.Columns.Add("Họ tên người chơi");
            dataTable.Columns.Add("Điểm số");       
            //Add data
            dataGridView1.DataSource = dataTable;
            //Dinh dang hai cot
            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.5);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.5);
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.BackColor;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            dataGridView1.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[1].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Rows[0].Resizable = DataGridViewTriState.False;
            //dataGridView1.Rows[1].Resizable = DataGridViewTriState.False;

            //Add 3 column
            dataTable1.Columns.Add("Họ tên người chơi");
            dataTable1.Columns.Add("Điểm số");
            //dataTable1.Columns.Add("Thời gian");
            //Add data
            dataGridView2.DataSource = dataTable1;
            //Dinh dang hai cot
            dataGridView2.Columns[0].Width = (int)(dataGridView2.Width * 0.5);
            dataGridView2.Columns[1].Width = (int)(dataGridView2.Width * 0.5);
            dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.BackColor;
            this.dataGridView2.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            //dataGridView2.Columns[2].Width = (int)(dataGridView2.Width * 0.2);
            dataGridView2.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridView2.Columns[1].Resizable = DataGridViewTriState.False;
            //dataGridView2.Columns[2].Resizable = DataGridViewTriState.False;
            dataGridView2.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Rows[0].Resizable = DataGridViewTriState.False;
            //dataGridView2.Rows[1].Resizable = DataGridViewTriState.False;

            //Add 3 column
            dataTable2.Columns.Add("Tên xe cảnh sát");
            dataTable2.Columns.Add("Tên xe cướp");
            dataTable2.Columns.Add("Kết quả");
            //Add data
            dataGridView3.DataSource = dataTable2;
            //Dinh dang hai cot
            dataGridView3.Columns[0].Width = (int)(dataGridView2.Width * 0.4);
            dataGridView3.Columns[1].Width = (int)(dataGridView2.Width * 0.4);
            dataGridView3.Columns[2].Width = (int)(dataGridView2.Width * 0.2);
            this.dataGridView3.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.BackColor;
            this.dataGridView3.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.GradientActiveCaption;
            dataGridView3.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridView3.Columns[1].Resizable = DataGridViewTriState.False;
            dataGridView3.Columns[2].Resizable = DataGridViewTriState.False;
            dataGridView3.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.Rows[0].Resizable = DataGridViewTriState.False;
            //dataGridView2.Rows[1].Resizable = DataGridViewTriState.False;


            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn col in dataGridView3.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            string path = Application.StartupPath + @"\..\..\1PlayerScore.txt";
            string path1 = Application.StartupPath + @"\..\..\Map1PlayerScore.txt";
            string path2 = Application.StartupPath + @"\..\..\Map2PlayerScore.txt";
            try
            {
                using (StreamReader streamReader = new StreamReader(path1))
                {
                    while (streamReader.Peek() > 0)
                    {
                        //listBox1.Items.Add(streamReader.ReadLine());
                        string temp1 = streamReader.ReadLine();
                        string[] entries1 = temp1.Split(' ');

                        dataRow1 = dataTable1.NewRow();
                        dataRow1[0] = entries1[0];
                        dataRow1[1] = entries1[1];
                        dataTable1.Rows.Add(dataRow1);
                    }


                }

                using (StreamReader streamReader = new StreamReader(path2))
                {
                    while (streamReader.Peek() > 0)
                    {
                        //listBox1.Items.Add(streamReader.ReadLine());
                        string temp1 = streamReader.ReadLine();
                        string[] entries1 = temp1.Split(' ');

                        dataRow2 = dataTable2.NewRow();
                        dataRow2[0] = entries1[0];
                        dataRow2[1] = entries1[1];
                        dataRow2[2] = entries1[2];
                        dataTable2.Rows.Add(dataRow2);
                    }
                }


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

        private void FormDiemSo_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
