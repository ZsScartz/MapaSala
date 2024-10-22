using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.Classes
{
    class Usuarios
    {

        private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public void inserir()
        {
            Conexao.Open();
            string query = "insert into Salas (Id, Login, Senha, Nome, Ativo) values (@, @) ";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@Id", usuarios.Id);
            SqlParameter parametro2 = new SqlParameter("@Login", usuarios.Login);
            SqlParameter parametro3 = new SqlParameter("@Senha", usuarios.Senha);
            SqlParameter parametro4 = new SqlParameter("@Nome", usuarios.Nome);
            SqlParameter parametro5 = new SqlParameter("@Ativo", usuarios.Ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
    }
}
