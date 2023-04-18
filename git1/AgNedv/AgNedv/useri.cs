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
    public partial class useri : Form
    {
        public useri()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void useri_Load(object sender, EventArgs e)
        {
           // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.agNedvDataSet.users);

        }
    }
}
