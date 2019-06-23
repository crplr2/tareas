using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    //Clase para calcular el area del rectangulo
    class CalculoRectangulo
    {
        public double perimetro(double bas, double altura)
        {
            return (2*bas) + (2*altura);
        }

        public double area(double bas, double altura)
        {
            return bas * altura;
        }
    }
}
