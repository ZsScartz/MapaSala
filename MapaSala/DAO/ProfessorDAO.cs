using System;
using Model.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MapaSala.DAO
{
    class ProfessorDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public ProfessorDAO() 
        { 
        Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(ProfessoresEntidades professor)
        {
            Conexao.Open();
            string query = "insert into Professores (Nome, Apelido) values (@nome, @apelido) ";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome",professor.Nome);
            SqlParameter parametro2 = new SqlParameter("@apelido",professor.Apelido);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterProfessores()
        {

            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * from Professores";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(ProfessoresEntidades).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    ProfessoresEntidades p = new ProfessoresEntidades();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Apelido = Leitura[2].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
               
            return dt;
        }

    }
}
