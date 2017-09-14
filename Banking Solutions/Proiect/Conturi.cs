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
    public partial class Conturi : Form
    {
        int IdClient;
        public Conturi(int IdClient)
        {
            InitializeComponent();
            this.IdClient = IdClient; 
         
        }

        private void Conturi_Load(object sender, EventArgs e)
        {

        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operatiuni op = new Operatiuni(IdClient); 
            op.Show(); 
            


           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAQ fu = new FAQ();
            fu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            cc c = new cc(IdClient);
                c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalii_banca dd = new Detalii_banca();
            dd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Home command
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ll = new Login();
            ll.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
