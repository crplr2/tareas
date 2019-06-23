using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    
    class CalculoCirculo
    {

        public double perimetro(double radio)
        {
            return Math.PI * (radio*2);
        }

        public double area (double radio)
        {
            return Math.PI * (radio * radio);
        }
    }
}
