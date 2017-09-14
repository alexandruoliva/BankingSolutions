using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Admin_Informatii_Client : Form
    {
        int idClient;
        pocol poc = new pocol();
        public Admin_Informatii_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Homepage myForm = new Admin_Homepage();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Admin_Informatii_Client_Load(object sender, EventArgs e)
        {
            poc.ListClients(dataGridView1);
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idClient = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (idClient != 0) poc.UpdatePassword(idClient, textBox1.Text);
            }
            else MessageBox.Show("Invalid password");
            poc.ListClients(dataGridView1);
            textBox1.Text = "";
            idClient = 0;
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
