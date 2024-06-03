using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void filmsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.медиатекаDataSet.Films);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void directorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            filmsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filmsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filmsBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filmsBindingSource.MoveLast();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            filmsBindingSource.MoveNext();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            filmsBindingSource.RemoveCurrent();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

            this.Validate();
            this.filmsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tablet tablet = new Tablet();
            tablet.ShowDialog();
        }
    }
}
