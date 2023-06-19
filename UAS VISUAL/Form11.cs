
using System;
using System.Data;
using System.Windows.Forms;


namespace UASVISUAL.UAS_VISUAL
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tampilData();
        }

        private void tampilData()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tampilData();

        }
    }
}



       