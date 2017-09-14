using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Proiect
{
    public partial class Exchange : Form
    {
       
        public int IdClient { get; private set; }

        public Exchange()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ll = new Login();
            ll.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Operatiuni op = new Operatiuni(IdClient);
            op.Show();

        }

        private void Exchange_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("http://www.bnr.ro/Cursul-de-schimb-524.aspx");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
