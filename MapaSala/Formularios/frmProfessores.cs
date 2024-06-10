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
    public partial class frmProfessores : Form
    {
        BindingSource dados;
        public frmProfessores()
            
           
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridProfessores.DataSource = dados;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidades professores = new  ProfessoresEntidades();
            professores.Id = Convert.ToInt32(numId.Value);

            professores.Nome = txtNome.Text;
            professores.Apelido = txtApelido.Text;

            dados.Add(professores);

        }

        private void frmProfessores_Load(object sender, EventArgs e)
        {

        }

        private void dtGridProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

