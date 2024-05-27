using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class SalasEntidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumeroComputadores { get; set; }
        public bool IsLab { get; set; }
        public int NumeroCadeira { get; set; }
        public bool Disponível { get; set; }
    }
}
