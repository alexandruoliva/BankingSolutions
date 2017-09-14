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
    public partial class Login : Form
    {

        SqlConnection abcdata = new SqlConnection(@"Data Source=DESKTOP-U7518PG\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginUser();


        }

        private void loginUser()
        {
            SqlDataAdapter asdf = new SqlDataAdapter("select [IdClient] from [Client] where [User] = '" + textBox1.Text + "' AND [Password]='" + textBox2.Text + "'", abcdata);
            DataTable ss = new DataTable();

            SqlDataAdapter asdfg = new SqlDataAdapter("select * from [Administrator] where [User] = '" + textBox1.Text + "' AND [Parola]='" + textBox2.Text + "'", abcdata);
            DataTable adminDT = new DataTable();

            asdf.Fill(ss);
            asdfg.Fill(adminDT);
            if (ss.Rows.Count != 0)                //verifica daca contul introdus este de client si te trimite la Client_homepage vezi la OLI
            {
                Conturi con = new Proiect.Conturi(int.Parse(ss.Rows[0][0].ToString()));
                con.Show();

            }
            else if (adminDT.Rows.Count != 0)       //verifica daca contul introdus este de administrator si te trimite la Admin_homepage vezi la Pocol
            {
                Admin_Homepage ah = new Admin_Homepage();
                this.Hide();
                ah.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Invalid username or password!");               // In cazul in care nu exista userul afiseaza mesajul "Invalid username or password!"
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ff = new Form2();
            ff.Show();
        }
    }
}
