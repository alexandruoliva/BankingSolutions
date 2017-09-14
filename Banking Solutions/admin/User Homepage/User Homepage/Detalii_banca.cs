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
    public partial class Detalii_banca : Form
    {
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

        }

        private void button3_Click(object sender, EventArgs e)     //Logout button
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
