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
    public partial class Avtorization : Form
    {
        public Avtorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Adapter.SelectCommand.CommandText =
                string.Format(@"select * from users where (login='{0}' and parol='{1}')", mtLogin.Text, mtPassword.Text);
            this.usersTableAdapter.Fill(this.agNedvDataSet.users);
            if (this.agNedvDataSet.users.Count > 0)
            {
                if (this.agNedvDataSet.users[0].prava == "Administrator")
                {
                    Form a = new Adminka();
                    a.Show();
                }

                if (this.agNedvDataSet.users[0].prava == "User")
                {
                    Form a = new Userka();
                    a.Show();
                }
            }
            else MessageBox.Show("Не правильно ввели логин или пароль", "Ошибка");
            mtLogin.Text = "";
            mtPassword.Text = "";
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agNedvDataSet);

        }

        private void Avtorization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agNedvDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.agNedvDataSet.users);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
