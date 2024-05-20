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
    public partial class Rates : Form
    {
        public Rates()
        {
            InitializeComponent();
        }

        private void ratesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ratesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);

        }

        private void Rates_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.Rates". При необходимости она может быть перемещена или удалена.
            this.ratesTableAdapter.Fill(this.медиатекаDataSet.Rates);

        }
    }
}
