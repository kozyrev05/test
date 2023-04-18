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
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }

        private void clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.agNedvDataSet.client);

        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

         
       private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //this.clientBindingSource.AddNew();
            Form a = new clientNew();
            a.Show();   
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons mb = MessageBoxButtons.YesNo;
                DialogResult dr;
                dr = MessageBox.Show ("Вы действительно хотите удалить запись?", "Подтверждение", mb);
                if (dr == DialogResult.Yes)
                {
                    this.clientBindingSource.RemoveCurrent();
                    this.Validate();
                    this.clientBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.agNedvDataSet);
                    MessageBox.Show("Запись успешно удалена", "Готово");
                }
                this.clientTableAdapter.Fill(this.agNedvDataSet.client);
            }
            catch
            {
                MessageBox.Show("Не удалось удалить запись, возможно есть связанные с ней записи", "Ошибка");
            }
        }

        private void clients_Activated(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);
            this.clientTableAdapter.Fill(this.agNedvDataSet.client);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            int i = clientBindingSource.Find("family", toolStripTextBox1);
            if (i == -1)
            {
                DataView dv = new DataView (this.agNedvDataSet.client as System.Data.DataTable);
                dv.RowFilter = string.Format("family LIKE '{0}*'", this.toolStripTextBox1.Text);
                if (dv.Count != 0)
                {
                    i = this.clientBindingSource.Find("family", dv[0]["family"]);
                }
                dv.Dispose();
                this.clientBindingSource.Position = i;
            }
            this.clientBindingSource.Position = i;
        }
    }
}
