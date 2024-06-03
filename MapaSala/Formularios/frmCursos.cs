using Model.Entidades;
using System;

using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CursoEntidades curso = new CursoEntidades();
            curso.Id = Convert.ToInt32(txtId.Text);
            curso.Ativo = chkAtivo.Checked;
            curso.Nome = txtNome.Text;
            
        }
    }
}
