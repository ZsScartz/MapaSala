using Model.Entidades;
using System;

using System.Windows.Forms;


namespace MapaSala.Formularios
{
    public partial class frmCursos : Form
    {
        
        BindingSource dados;
        public frmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridCursos.DataSource = dados;
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

            dados.Add(curso);

            LimparCampos();
        }

        private void dtGridCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        
    }
}
