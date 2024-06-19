using Model.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmProfessores : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmProfessores()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(ProfessoresEntidades).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            
            dtGridProfessores.DataSource = dados;
        }
        private void limparCampos()
        {
            txtNome.Text = "";
            txtApelido.Text = "";
            numId.Value = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidades professores = new ProfessoresEntidades();
            professores.Id = Convert.ToInt32(numId.Value);
            professores.Nome = txtNome.Text;
            professores.Apelido = txtApelido.Text;

            dados.Rows.Add(professores.Linha());

            limparCampos();
        }

        private void tbnEditar_Click(object sender, EventArgs e)
        {
            {
                DataGridViewRow editar = dtGridProfessores.Rows[LinhaSelecionada];
                editar.Cells[0].Value = numId.Value;
                editar.Cells[1].Value = txtNome.Text;
                editar.Cells[2].Value = txtApelido.Text;

            }
        }

        private void dtGridProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtApelido.Text = dtGridProfessores.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            numId.Value = Convert.ToInt32(dtGridProfessores.Rows[LinhaSelecionada].Cells[0].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridProfessores.Rows.RemoveAt(LinhaSelecionada);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
    }

