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
        private void LimparCampos()
        {
            numId.Value = 0;
            TxtNomeSala.Text = "";
            numCadeiras.Value = 0;
            NumComputadores.Value = 0;
            chkDisponivel.Checked = false;
            chkIsLab.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
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
            sala.Id = Convert.ToInt32(numId.Value);
            sala.Nome = TxtNomeSala.Text;
            sala.IsLab = chkIsLab.Checked;
            sala.NumeroCadeiras = Convert.ToInt32(numCadeiras.Value);
            sala.NumeroComputadores = Convert.ToInt32(NumComputadores.Value);
            sala.Disponivel = chkDisponivel.Checked;

            dados.Add(sala);

            LimparCampos();
        }

        private void chkIsLab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NumComputadores_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtApelido.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            numId.Value = Convert.ToInt32(dtGridProfessores.Rows[LinhaSelecionada].Cells[0].Value);
        }
    }
}
