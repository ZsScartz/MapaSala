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
    public partial class frmDisciplinas : Form
    {
        DataTable dados;
        int LinhaSelecionada;

        public frmDisciplinas()
        {
            InitializeComponent();
            dados = new DataTable();
            
            foreach (var atributos in typeof(DisciplinasEntidades).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dtGridDisciplinas.DataSource = dados;
            dados.Rows.Add(1, "Matemática", "MAT");
            dados.Rows.Add(2, "Português", "PORT");
            dados.Rows.Add(3, "Física", "FIS");

            dtGridDisciplinas.DataSource = dados;

        }
        private void LimparCampos()
        {
            numId.Value = 0;
            txtSigla.Text = "";
            txtNome.Text = "";
            chkAtivo.Checked = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDisciplinas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DisciplinasEntidades disciplinas = new DisciplinasEntidades();
            disciplinas.Id = Convert.ToInt32(numId.Value);
            disciplinas.Nome = txtNome.Text;
            disciplinas.Sigla = txtSigla.Text;
            disciplinas.Ativo = chkAtivo.Checked;

            dados.Rows.Add( disciplinas.Linha() );

            LimparCampos();
          
        }

        private void chkAtivo_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void dtGridDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisciplinas.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
