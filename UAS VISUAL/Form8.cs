using System;
using System.Windows.Forms;
using UASVISUAL.UAS_VISUAL;

namespace UASVISUAL
{
    public partial class Form8 : Form
    {
        readonly string username = "ayu@gmail.com";
        readonly string password = "12345678";
        public Form8()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username && textBox2.Text == password)
            {
                Form10 form10 = new Form10();
                form10.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email atau password anda salah");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
