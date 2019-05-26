using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.Clases
{
    class AnalizadorTexto
    {

        public int contarCarEspeciales(String texto)
        {
            int especiales = 0;
            foreach(char c in texto)
            {
                if (!(c >= '0' && c<='9' || c >= 'A' && c <= 'Z'|| c>='a' && c<='z' ))
                    ++especiales;
            }
            return especiales;
        }

        public char[] descomponerPalabra(String texto)
        {
            char[] arregloChar = new char[texto.Length];
            int index = 0;

            foreach(char c in texto)
            {
                arregloChar[index] = c;
                ++index;
            }

            return arregloChar;
        }

    }
}
