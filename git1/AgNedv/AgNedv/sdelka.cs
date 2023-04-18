using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgNedv
{
    public partial class sdelka : Form
    {
        public sdelka()
        {
            InitializeComponent();
        }

        private void slelkaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.slelkaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void sdelka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.slelka". При необходимости она может быть перемещена или удалена.
            this.slelkaTableAdapter.Fill(this.agNedvDataSet.slelka);

        }

        private void slelkaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
