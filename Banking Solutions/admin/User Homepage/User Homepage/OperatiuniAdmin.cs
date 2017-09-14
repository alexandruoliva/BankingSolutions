using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Homepage
{
    public partial class OperatiuniAdmin : Form
    {
        pocol p = new pocol();
        int idAccount;

        public OperatiuniAdmin()
        {
            InitializeComponent();
        }

        private void OperatiuniAdmin_Load(object sender, EventArgs e)
        {
            p.ListAccounts(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idAccount != 0)
            {
                p.AddBalance(idAccount, Int32.Parse(textBox1.Text));
                p.ListAccounts(dataGridView1);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            idAccount = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idAccount = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idAccount != 0)
            {
                p.RemoveBalance(idAccount, Int32.Parse(textBox2.Text));
                p.ListAccounts(dataGridView1);
            }
            textBox2.Text = "";
            textBox1.Text = "";
            idAccount = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Homepage myForm = new Admin_Homepage();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
