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
   
    public partial class Transfer : Form
    {
        int IdClient;
        public Transfer(int i)
        {
            InitializeComponent();
            IdClient = i;

        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7518PG\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
            try
            {
                int a, b, c;
            SqlDataAdapter asdf = new SqlDataAdapter("select Balance from Account where IdAccount='" + textBox1.Text + "' ", con);
            DataTable ss = new DataTable();

                asdf.Fill(ss);
                a = int.Parse(ss.Rows[0][0].ToString());
                if (textBox2.Text != "" && textBox1.Text != "" && textBox3.Text != "")
                {

                    b = Convert.ToInt32(textBox2.Text);
                    c = a - b;
                    if (c > 0)
                    {
                       

                        SqlCommand cmd2 = new SqlCommand("begin transaction; update Account set Balance=@bal where IdAccount=@id; update Account set Balance=Balance + @bal2 where IdAccount LIKE(select IDAccount FROM Account where IDClient LIKE (SELECT IdClient FROM Client WHERE CNP =@cnp)); commit;", con);
                        cmd2.Parameters.AddWithValue("@bal", c);
                        cmd2.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        cmd2.Parameters.AddWithValue("@bal2", c);
                        cmd2.Parameters.AddWithValue("@cnp", textBox3.Text);
                        con.Open();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                       
                        MessageBox.Show("Transaction completed!");
                        
                    }
                    else
                        MessageBox.Show("We are sorry, but you don't have enough money!");
                }
                else
                {
                    MessageBox.Show("No value entered");

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error:" + e1.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operatiuni op = new Operatiuni(IdClient);
            op.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ll = new Login();
            ll.Show();
        }
    }
}
