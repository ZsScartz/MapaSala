using Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmSalas : Form
    {

        BindingSource dados;
        public frmSalas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridSalas.DataSource = dados;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSalas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidades sala = new SalasEntidades();
            sala.Id = Convert.ToInt32(TxtId.Text);
            sala.Nome = TxtNomeSala.Text;
            sala.IsLab = chkIsLab.Checked;
            sala.NumeroCadeiras = Convert.ToInt32(numCadeiras.Value);
            sala.NumeroComputadores = Convert.ToInt32(NumComputadores.Value);
            sala.Disponivel = chkDisponivel.Checked;

            dados.Add(sala);
        }

        private void chkIsLab_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
