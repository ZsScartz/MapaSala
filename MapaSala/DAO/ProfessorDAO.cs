using System;
using Model.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
