using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Depunere : Form
    {
       



        SqlConnection abcdata = new SqlConnection(@"Data Source=DESKTOP-U7518PG\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");

        public int IdClient { get; private set; }

        public Depunere()
        {
            InitializeComponent();
        }

        public void depunere_get()
        {
           
            
        }

        private void Depunere_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter asdf = new SqlDataAdapter("select Balance from Account where IdAccount='" + textBox1.Text + "' ", abcdata);
            DataTable ss = new DataTable();

            asdf.Fill(ss);
         
            textBox2.Text = ss.Rows[0][0].ToString();

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7518PG\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select Balance from Account where IdAccount=" + textBox1.Text + "   ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                
                int a, b, c;
                a = Convert.ToInt32(textBox2.Text);
                b = Convert.ToInt32(textBox3.Text);
                c = a + b;
                textBox2.Text = c.ToString();
                if (dr.Read())
                {
                SqlCommand cmd2 = new SqlCommand("update Account set Balance=@bal where IdAccount=@id", con);
                cmd2.Parameters.AddWithValue("@bal", int.Parse(textBox2.Text));
                cmd2.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                dr.Close();  
                 cmd2.ExecuteNonQuery();
                    
                    
                    MessageBox.Show("Value Updated");
                   
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operatiuni op = new Operatiuni(IdClient);
            op.Show();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ll = new Login();
            ll.Show();
        }
    }
}
