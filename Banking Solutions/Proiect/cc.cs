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
    public partial class cc : Form
    {
        int IdClient;
        SqlConnection abcdata = new SqlConnection(@"Data Source=DESKTOP-U7518PG\SQLEXPRESS;Initial Catalog=Database;Integrated Security=True");
        public cc(int i)
        {
            InitializeComponent();
            IdClient = i;

        }

        private void cc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter asdf = new SqlDataAdapter("select * from Client where IdClient=" + IdClient + " ", abcdata);
            DataTable ss = new DataTable();

            asdf.Fill(ss);
          
            textBox2.Text = ss.Rows[0][1].ToString();

            textBox3.Text = ss.Rows[0][2].ToString();
            textBox4.Text = ss.Rows[0][3].ToString();
            textBox5.Text = ss.Rows[0][4].ToString();
            textBox6.Text = ss.Rows[0][5].ToString();
            textBox7.Text = ss.Rows[0][8].ToString();
            textBox8.Text = ss.Rows[0][9].ToString();
            textBox9.Text = ss.Rows[0][10].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conturi ppp= new Conturi(IdClient);
            ppp.Show();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ll = new Login();
            ll.Show();
        }
    }
}
