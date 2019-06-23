using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen.Clases
{
    //Clase para crear y guardar el contenido en un nuevo archivo de texto
    class Archivo
    {
        public bool escribir(string nombre, string contenido)
        {
            var ruta = nombre + ".txt";
            if (!File.Exists(ruta))
            {
                using (var escritor = new StreamWriter(nombre + ".txt"))
                {
                    escritor.WriteLine(contenido);
                    return true;
                }

            }

            return false;
        }
    }
}
