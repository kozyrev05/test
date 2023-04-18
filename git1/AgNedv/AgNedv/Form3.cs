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
    public partial class Potrebnost : Form
    {
        public Potrebnost()
        {
            InitializeComponent();
        }

        private void potrebnostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.potrebnostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void Potrebnost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet1.TipObj". При необходимости она может быть перемещена или удалена.
            this.tipObjTableAdapter.Fill(this.agNedvDataSet1.TipObj);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.Potrebnost". При необходимости она может быть перемещена или удалена.
            this.potrebnostTableAdapter.Fill(this.agNedvDataSet.Potrebnost);

        }

        private void idClientaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
