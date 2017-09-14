using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Admin_Homepage : Form
    {
        SqlConnection myCon;
        string connectionString;
        public Admin_Homepage()
        {
            InitializeComponent();
            connectionString = @"Data Source=DESKTOP-U7518PG\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True";
            myCon = new SqlConnection(connectionString);
        }


        private void Admin_Homepage_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)     
        {
          
        }

     
        private void button3_Click(object sender, EventArgs e)      //Operatiuni
        {
            OperatiuniAdmin myForm = new OperatiuniAdmin();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

   

        private void button6_Click(object sender, EventArgs e)      //Administrare
        {
            Admin_Informatii_Client myForm = new Admin_Informatii_Client();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
   

        private void button10_Click(object sender, EventArgs e)     //Logout
        {
            Login myform = new Login();
            this.Hide();
            myform.ShowDialog();
            this.Close();
        }
       
    }
}
