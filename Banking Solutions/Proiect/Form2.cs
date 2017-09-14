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

namespace Proiect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            closeSignUpForm();
            this.Hide();
            Login ll = new Login();
            ll.Show();


        }
        public void closeSignUpForm()
        {
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateUser();
        }
        public void CreateUser()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7518PG\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Client  (Name, Surname, CNP, Adress, [User], [Password], Age, Income, ClientType, Sex, LoginID) VALUES ( @Name, @Surname, @CNP, @Adress, @User, @Password, @Age, @Income,@Type, @Sex, @LoginID)", con);
               // cmd.Parameters.AddWithValue("@IdClient", 4);
                cmd.Parameters.AddWithValue("@Name", FirstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Surname", LastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@CNP", CnpTextBox.Text);
                cmd.Parameters.AddWithValue("@Age", AgeTextBox.Text);
                cmd.Parameters.AddWithValue("@Adress", AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@User", UsernameTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@Income", IncomeTextBox.Text);
                cmd.Parameters.AddWithValue("@Sex", SexTextBox.Text);
                cmd.Parameters.AddWithValue("@LoginID", LoginIDTextBox.Text);
                cmd.Parameters.AddWithValue("@Type", ClientTypeTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("user registered");
                this.Close();
            }
            
        

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
