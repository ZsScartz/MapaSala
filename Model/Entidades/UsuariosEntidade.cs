using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    class UsuariosEntidade
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senhas { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
