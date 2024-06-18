using Model.Entidades;
using System;
using System.Data;
using System.Windows.Forms;
namespace MapaSala.Formularios
{
    public partial class frmCursos : Form
    {

        DataTable dados;
        int LinhaSelecionada;
        public frmCursos()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(CursoEntidades).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            numId.Value = 0;
            txtSigla.Text = "";
            chkAtivo.Checked = false;
        }
        private void frmCursos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CursoEntidades curso = new CursoEntidades();
            curso.Id = Convert.ToInt32(numId.Value);
            curso.Ativo = chkAtivo.Checked;
            curso.Nome = txtNome.Text;

            dados.Rows.Add(curso.Linha());

            LimparCampos();
        }
        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dtGridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtSigla.Text = dtGridDisciplinas.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            numId.Value = Convert.ToInt32(dtGridDisciplinas.Rows[LinhaSelecionada].Cells[0].Value);
        }
    }
}
