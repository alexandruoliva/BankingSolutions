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
    public partial class Detalii_banca : Form
    {
        private int id;

        public Detalii_banca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Back button
        {
            this.Hide();
            Operatiuni oo = new Operatiuni(id);
            oo.Show(); 

        }

        private void button3_Click(object sender, EventArgs e)     //Logout button
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Detalii_banca_Load(object sender, EventArgs e)
        {

        }
    }
}
