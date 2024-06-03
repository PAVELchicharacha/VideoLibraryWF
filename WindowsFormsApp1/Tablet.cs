using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Tablet : Form
    {
        public Tablet()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Tablet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.медиатекаDataSet.Films);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn column = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    column = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    column = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    column = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    column = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    column = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    column = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    column = dataGridViewTextBoxColumn9;
                    break;
                    if (radioButton1.Checked)
                        filmsDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Ascending);
                    else
                        filmsDataGridView.Sort(column, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filmsBindingSource.Filter = "name='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filmsBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filmsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < filmsDataGridView.RowCount - 1; j++)
                {
                    filmsDataGridView[i, j].Style.BackColor = Color.White;
                    filmsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < filmsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < filmsDataGridView.RowCount - 1; j++)
                {
                    if (filmsDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        filmsDataGridView[i, j].Style.BackColor = Color.Blue;
                        filmsDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}

