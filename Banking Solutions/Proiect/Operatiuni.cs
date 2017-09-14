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
    public partial class Operatiuni : Form
    {
        int IdClient;


        public Operatiuni(int i)
        {
            InitializeComponent();
            IdClient = i;
        }

        public Operatiuni()
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conturi con = new Conturi(IdClient);
            con.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sold sld = new Sold(IdClient);
            sld.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           Depunere dep = new Depunere();
            dep.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer tr = new Transfer(IdClient);
            tr.Show();
        }

        private void Operatiuni_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ll = new Login();
            ll.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exchange ee = new Exchange();
            ee.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAQ fu = new FAQ();
            fu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalii_banca dd = new Detalii_banca();
            dd.Show();
        }
    }
}
