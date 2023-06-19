using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASVISUAL.UAS_VISUAL
{
    public partial class FormTRANSAKSI : Form
    {
        public FormTRANSAKSI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
        public void SetAngka(int angka)
        {
            label6.Text = angka.ToString();
        }

        private void DonasiSekarang_Click(object sender, EventArgs e)
        {
            FormFINALTRANSAKSI formFINALTRANSAKSI = new FormFINALTRANSAKSI();
            formFINALTRANSAKSI.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
