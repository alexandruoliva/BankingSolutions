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
    public partial class FAQ : Form
    {
        private int id;
        public FAQ()
        {
            InitializeComponent();
        }

        public FAQ(int idSelectedClient)
        {
         
        }
        private void FAQ_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

     

        private void button2_Click(object sender, EventArgs e) //back button
        {
            this.Hide();
            Operatiuni oo = new Operatiuni(id);
            oo.Show();
        }

        private void button3_Click(object sender, EventArgs e) //logout button
        {
            Login myForm = new Login();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
