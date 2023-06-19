using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace UASVISUAL.UAS_VISUAL
{
    public partial class FormFINALTRANSAKSI : Form
    {
        public FormFINALTRANSAKSI()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DonasiSekarang_Click(object sender, EventArgs e)
        {
            string ImageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageLocation = dialog.FileName;
                    pictureBox2.ImageLocation = ImageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pictureBox2.ImageLocation))
            {
                MessageBox.Show("Gambar belum dipilih!");
            }
            else
            {
                FormTHANKS formTHANKS = new FormTHANKS();
                formTHANKS.Show();
                this.Close();
            }
        }
    }
}
