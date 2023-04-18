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
    public partial class clientNew : Form
    {
        public clientNew()
        {
            InitializeComponent();
        }

        private void clientNew_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.agNedvDataSet.client);

        }

       private void clientBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Запись в таблице ''Клиенты'' сохранена  ", "Успешно");
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mb = MessageBoxButtons.YesNo;
            DialogResult dr;
            dr = MessageBox.Show("Вы действительно хотите выйти? Не сохраненная запись будет потеряна", "Подтверждение", mb);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.agNedvDataSet);
                this.clientTableAdapter.Fill(this.agNedvDataSet.client);
            }
        }

        private void clientNew_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void clientNew_Activated(object sender, EventArgs e)
        {
           // this.clientBindingSource.AddNew();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.AddNew();
        }
    }
}
