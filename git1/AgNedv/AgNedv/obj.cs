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
    public partial class obj : Form
    {
        public obj()
        {
            InitializeComponent();
        }

        private void objekt_NedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.objekt_NedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void obj_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.TipObj". При необходимости она может быть перемещена или удалена.
            this.tipObjTableAdapter.Fill(this.agNedvDataSet.TipObj);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.Objekt_Ned". При необходимости она может быть перемещена или удалена.
            this.objekt_NedTableAdapter.Fill(this.agNedvDataSet.Objekt_Ned);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.TipObj". При необходимости она может быть перемещена или удалена.
            this.tipObjTableAdapter.Fill(this.agNedvDataSet.TipObj);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.Objekt_Ned". При необходимости она может быть перемещена или удалена.
            this.objekt_NedTableAdapter.Fill(this.agNedvDataSet.Objekt_Ned);

        }

        private void tipObjComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void objekt_NedBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.objekt_NedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
