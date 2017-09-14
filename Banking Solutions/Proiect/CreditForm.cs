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

namespace BankingSolutions
{
    public partial class CreditForm : Form
    {
        private UserAccount currentClient;
        private SqlDataAdapter adapter;
        private SqlConnection myCon;
        private string connectionString;

        public CreditForm()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BankingSolutionsDatabase.mdf;Integrated Security=True";
            myCon = new SqlConnection(connectionString);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        public void getInfoCurrentUser(string username, string password)
        {
            myCon.Open();

            myCon.Close();
        }

        private void getUserBtn_Click(object sender, EventArgs e)
        {

        }

        

        private void secondOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayAdditionalDetails();

        }

        private void creditTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySecondOptions();
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {

        }

        private void showCreditOption()
        {
            if (comboBox_CreditType.Text.Equals("Personal Needs"))
            {
                comboBox_CreditOption.Items.Add("Guaranteed with mortgage");
                comboBox_CreditOption.Items.Add("With real estate purposes");
            }

            if (comboBox_CreditType.Text.Equals("Real Estate Investment"))
            {
                comboBox_CreditOption.Items.Add("First house");
                comboBox_CreditOption.Items.Add("Real estate - Mortgage");
            }

            if (comboBox_CreditType.Text.Equals("Auto"))
            {
                comboBox_CreditOption.Items.Add("First car");
                comboBox_CreditOption.Items.Add("Auto");
            }
        }

        private void displaySecondOptions()
        {
            comboBox_CreditOption.Items.Clear();

            comboBox_CreditOption.Enabled = true;

            showCreditOption();

            
        }

        private void displayAdditionalDetails()
        {
            if (comboBox_CreditOption.Text.Equals("Guaranteed with mortgage"))
                descriptionLabel.Text = "(low credit rate)";

            if (comboBox_CreditOption.Text.Equals("With real estate purposes"))
                descriptionLabel.Text = "(convenable, without mortgage)";
        }

        private void enableRemainingOptions()
        {

        }
    }


}
