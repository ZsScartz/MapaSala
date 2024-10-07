using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios.Editar
{
    public partial class frmEditarDisciplina : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;

        public frmEditarDisciplina( int DisciplinaId)
        {
            InitializeComponent();
            String query = "select Id, Nome, Sigla, Ativo" + "from Discipolinas where Id = @id";
        }
        public DataTable ObterDisciplinas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexao = new SqlConnection(LinhaConexao))
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(Query, )
                string query = "SELECT Id, Nome, Sigla FROM Salas ORDER BY Id DESC";
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    using (SqlDataReader leitura = comando.ExecuteReader())
                    {
                        dt.Columns.Add("Id", typeof(int));
                        dt.Columns.Add("Nome", typeof(string));
                        dt.Columns.Add("Sigla", typeof(string));

                        if (leitura.HasRows)
                        {
                            while (leitura.Read())
                            {
                                label_id.Text row = dt.NewRow();
                                row["Id"] = Convert.ToInt32(leitura["Id"]);
                                row["Nome"] = leitura["Nome"].ToString();
                                row["Sigla"] = leitura["Sigla"].ToString();
                                chkAtivo.Checked = Convert.ToBoolean(leitura)[3];
                                dt.Rows.Add(row);
                            }
                        }
                    }
                }
            }
            return dt;
        }

        private void frmEditarDisciplina_Load(object sender, EventArgs e)
        {

        }
    }
}
