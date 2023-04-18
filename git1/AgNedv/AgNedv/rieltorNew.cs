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
    public partial class rieltorNew : Form
    {
        public rieltorNew()
        {
            InitializeComponent();
        }

        private void rieltorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rieltorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void rieltorNew_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.rieltor". При необходимости она может быть перемещена или удалена.
            this.rieltorTableAdapter.Fill(this.agNedvDataSet.rieltor);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запись в таблмице ''Риелторы'' сохранена", "Успешно");
            this.Validate();
            this.rieltorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);
        }
    }
}
