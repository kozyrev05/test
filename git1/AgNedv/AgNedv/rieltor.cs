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
    public partial class rieltor : Form
    {
        public rieltor()
        {
            InitializeComponent();
        }

        private void rieltorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rieltorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void rieltor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.rieltor". При необходимости она может быть перемещена или удалена.
            this.rieltorTableAdapter.Fill(this.agNedvDataSet.rieltor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.rieltor". При необходимости она может быть перемещена или удалена.
            this.rieltorTableAdapter.Fill(this.agNedvDataSet.rieltor);

        }

        private void rieltorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.rieltorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void rieltorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form a = new rieltorNew();
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons mb = MessageBoxButtons.YesNo;
                DialogResult dr;
                dr = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", mb);
                if (dr == DialogResult.Yes)
                {
                    this.rieltorBindingSource.RemoveCurrent();
                    this.Validate();
                    this.rieltorBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.agNedvDataSet);
                    MessageBox.Show("Запись успешно удалена", "Готово");
                }
                this.rieltorTableAdapter.Fill(this.agNedvDataSet.rieltor);
            }
            catch
            {
                MessageBox.Show("Не удалось удалить запись, возможно есть связанные с ней записи", "Ошибка");
            }
        }
    }
}
