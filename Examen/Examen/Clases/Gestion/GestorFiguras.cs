using System;
using GestorBD;
using Examen.Clases.POCO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases.Gestion
{
    //Gestor para la insercion en la base datos
    class GestorFiguras
    {

        public Figura instancia;
        public Tabla tabla;
        Operaciones operaciones;

        public GestorFiguras(Figura figura)
        {
            instancia = figura;
            operaciones = new Operaciones("bdtest");
            tabla = new Tabla();
            tabla.Nombre = "Figuras";
            tabla.Campos = new List<Campo>()

            {
                new Campo()
                {
                    Nombre = "Figura",
                    Valor = instancia.figura,
                },
                new Campo()
                {
                    Nombre = "Calculo",
                    Valor = instancia.calculo,
                },
                new Campo()
                {
                    Nombre = "Formula",
                    Valor = instancia.formula,
                },
                new Campo()
                {
                    Nombre = "Datos",
                    Valor = instancia.datos,
                },
                new Campo()
                {
                    Nombre = "Resultado",
                    Valor = instancia.resultado,
                }
            };
            operaciones.Entidad = tabla;
        }

        public bool insertarFigura()
        {
            return operaciones.Insertar();
        }
    }
}
