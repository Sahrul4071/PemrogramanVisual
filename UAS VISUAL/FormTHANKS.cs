using System;
using System.Windows.Forms;

namespace UASVISUAL
{
    public partial class FormTHANKS : Form
    {
        public FormTHANKS()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void KadoPanti_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
