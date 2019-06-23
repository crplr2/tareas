using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    class ValidacionTexto
    {

        //Metodo para validar el texto solo contenga caracteres alfanumericos
        public bool contieneCarEspeciales(String texto)
        {
            foreach (char c in texto)
            {
                if (!(c >= '0' && c <= '9' || c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z'))
                {
                    return true;
                }
               
            }
            return false;
        }



        //Metodo para validar que contenga solo caracteres alfabeticos
        public bool contieneCarAlfabeticos(String texto)
        {
            foreach (char c in texto)
            {
                if ( c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')
                {
                    return true;
                }

            }
            return false;
        }

       

    }
}
