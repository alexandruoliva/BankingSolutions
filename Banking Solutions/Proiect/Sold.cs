using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Windows.Input;
using System.Security.Principal;

namespace Proiect
{
    public partial class Sold : Form
    {
        SqlConnection abcdata = new SqlConnection(@"Data Source=DESKTOP-U7518PG\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
        int IdClient;

        public Sold(int i)
        {
            InitializeComponent();
            IdClient = i;

        }

        private void Sold_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter asdf = new SqlDataAdapter("select Balance from Account where IDClient=" + IdClient + " ", abcdata);
            DataTable ss = new DataTable();
            //if pentru un idaccount specific 
            asdf.Fill(ss);
            
            textBox2.Text = ss.Rows[0][0].ToString();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ll = new Login();
            ll.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operatiuni op = new Operatiuni(IdClient);
            op.Show();

        }
    }
}
