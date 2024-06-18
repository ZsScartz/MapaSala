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

        DataTable dados;
        int LinhaSelecionada;
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(SalasEntidades).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
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


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidades sala = new SalasEntidades();
            sala.Id = Convert.ToInt32(numId.Value);
            sala.Nome = TxtNomeSala.Text;
            sala.IsLab = chkIsLab.Checked;
            sala.NumCadeiras = Convert.ToInt32(numCadeiras.Value);
            sala.NumComputadores = Convert.ToInt32(NumComputadores.Value);
            sala.Disponivel = chkDisponivel.Checked;

            dados.Rows.Add(sala.Linha());

            LimparCampos();
        }


        private void dtGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            numId.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value);
            TxtNomeSala.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            NumComputadores.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value);
            numCadeiras.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value);
            chkDisponivel.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow editar = dtGridSalas.Rows[LinhaSelecionada];
            editar.Cells[0].Value = numId.Value;
            editar.Cells[1].Value = TxtNomeSala.Text;
            editar.Cells[2].Value = NumComputadores.Value;
            editar.Cells[3].Value = numCadeiras.Value;
            editar.Cells[4].Value = chkDisponivel.Checked;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void chkDisponivel_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
