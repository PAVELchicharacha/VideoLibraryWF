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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void purchase_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchase_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.медиатекаDataSet);

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "медиатекаDataSet.Purchase_". При необходимости она может быть перемещена или удалена.
            this.purchase_TableAdapter.Fill(this.медиатекаDataSet.Purchase_);

        }
    }
}
