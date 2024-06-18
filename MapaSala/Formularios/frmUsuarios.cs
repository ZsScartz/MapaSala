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
        DataTable dados;
        int LinhaSelecionada;
        public frmUsuarios()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(UsuariosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
        }
            private void LimparCampos()
        {
            txtLogin.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            chkAtivo.Checked = false;
            numId.Value = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosEntidade usuarios = new UsuariosEntidade();
            usuarios.Id = Convert.ToInt32(numId.Value);
            usuarios.Nome = txtNome.Text;
            usuarios.Login = txtLogin.Text;
            usuarios.Senha = txtSenha.Text;
            usuarios.Ativo = chkAtivo.Checked;

            dados.Rows.Add(usuarios.Linha());

            LimparCampos();
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

       

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridUsuarios.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numId.Value = Convert.ToInt32(dtGridUsuarios.Rows[LinhaSelecionada].Cells[0].Value);
            txtNome.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtLogin.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtSenha.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridUsuarios.Rows[LinhaSelecionada].Cells[4].Value);

        }

        private void tbnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow editar = dtGridUsuarios.Rows[LinhaSelecionada];
            editar.Cells[0].Value = numId.Value;
            editar.Cells[1].Value = txtNome.Text;
            editar.Cells[2].Value = txtLogin.Text;
            editar.Cells[3].Value = txtSenha.Text;
            editar.Cells[4].Value = chkAtivo.Checked;
        }

    }
}
