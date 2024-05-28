using MapaSala.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MapaSala
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void btnCLiqueAqui_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntCalc2_Click(object sender, EventArgs e)
        {
    
        }

        private void bntSub_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(txtNum1.Text);
            int Num2 = Convert.ToInt32(txtNum2.Text);
            int sub = Num1 - Num2;
            MessageBox.Show(sub.ToString());
        }

        private void btnAdi_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(txtNum1.Text);
            int Num2 = Convert.ToInt32(txtNum2.Text);
            int sub = Num1 + Num2;
            MessageBox.Show(sub.ToString());
        }

        private void bntNum2_Click(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(txtNum1.Text);
            int Num2 = Convert.ToInt32(txtNum2.Text);
            int sub = Num1 * Num2;
            MessageBox.Show(sub.ToString());
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalas s = new frmSalas();
            s.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntDiv_Click_1(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt32(txtNum1.Text);
            int Num2 = Convert.ToInt32(txtNum2.Text);
            int sub = Num1 / Num2;
            MessageBox.Show(sub.ToString());
        }
    }
}
