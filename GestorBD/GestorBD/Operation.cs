using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBD
{
    class Operation
    {

        private Conexion bd { get; set; }

        public Tabla entidad { get; set; }

        public Operation(string llave)
        {
            bd = new Conexion(llave);
        }

        public bool insertar()
        {

        }
    }
}
