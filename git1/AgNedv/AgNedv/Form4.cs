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
    public partial class Predlozhenie : Form
    {
        public Predlozhenie()
        {
            InitializeComponent();
        }

        private void predlozhenieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.predlozhenieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void Predlozhenie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet1.Predlozhenie". При необходимости она может быть перемещена или удалена.
            this.predlozhenieTableAdapter.Fill(this.agNedvDataSet1.Predlozhenie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.rieltor". При необходимости она может быть перемещена или удалена.
            this.rieltorTableAdapter.Fill(this.agNedvDataSet.rieltor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.TipObj". При необходимости она может быть перемещена или удалена.
            this.tipObjTableAdapter.Fill(this.agNedvDataSet.TipObj);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.Predlozhenie". При необходимости она может быть перемещена или удалена.
            this.predlozhenieTableAdapter.Fill(this.agNedvDataSet.Predlozhenie);

        }
    }
}
