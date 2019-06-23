using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBD
{
    public class Campo
    {
        public string Nombre { get; set; }

        public object Valor { get; set; }

        public object Filtro { get; set; }

        public bool Actualizable { get; set; }
    }
}
