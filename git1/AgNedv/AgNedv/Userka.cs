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
    public partial class Userka : Form
    {
        public Userka()
        {
            InitializeComponent();
        }

        private void Userka_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form a = new clients();
            a.Show();
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new rieltor();
            a.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form a = new obj();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form a = new Potrebnost();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form a = new Predlozhenie();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form a = new sdelka();
            a.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
