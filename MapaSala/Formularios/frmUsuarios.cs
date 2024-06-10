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
    public partial class frmUsuarios : Form
    {
        BindingSource dados;
        public frmUsuarios()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridUsuarios.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosEntidade usuarios = new UsuariosEntidade();
            usuarios.Id = Convert.ToInt32(txtId.Text);
            usuarios.Nome = txtNome.Text;
            usuarios.Login = txtLogin.Text;
            usuarios.Senha = txtSenha.Text;
            usuarios.Ativo = chkAtivo.Checked;

            dados.Add(usuarios);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
