using System;
using System.Linq;
using System.Windows.Forms;
using UASVISUAL.UAS_VISUAL;

namespace UASVISUAL
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DonasiSekarang_Click(object sender, EventArgs e)
        {
            string input = textBox2.Text;
            int angka;

            if (int.TryParse(input, out angka))
            {
                FormTRANSAKSI formTransaksi = new FormTRANSAKSI(); // Create an instance of FormTransaksi
                formTransaksi.SetAngka(angka);
                formTransaksi.Show(); // Show the FormTransaksi

                this.Close();
            }
            else
            {
                MessageBox.Show("Input tidak valid! Masukkan angka.");
            }

        }

            private void BACK_Click(object sender, EventArgs e)
        {

        }
    }
}
