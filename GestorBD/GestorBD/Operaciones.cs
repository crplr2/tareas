using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestorBD
{
    public class Operaciones
    {
        private Conexion BD { get; set; }

        public Tabla Entidad { get; set; }
        
        public Operaciones(string llave)
        {
            BD = new Conexion(llave);
        }
        public bool Insertar()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            //Creacion de la sentencia SQL para el comando
            var textoComando = "INSERT INTO " + Entidad.Nombre + " (";
            foreach( var campo in Entidad.Campos)
            {
                textoComando += campo.Nombre + ", ";
            }
            textoComando = textoComando.Remove(textoComando.Length - 2, 2);
            textoComando += ") Values (";
            foreach (var campo in Entidad.Campos)
            {
                textoComando += "@" + campo.Nombre + ", ";
            }
            textoComando = textoComando.Remove(textoComando.Length - 2, 2);
            textoComando += ")";
            comando.CommandText = textoComando;
            //Asignacion de parametros al comandos
            foreach (var campo in Entidad.Campos)
            {
                comando.Parameters.AddWithValue("@" + campo.Nombre, campo.Valor);
            }
            comando.Connection = BD.Enlase;
            BD.Conectar();
            var result = comando.ExecuteNonQuery();
            BD.Desconectar();
            return result > 0;

        }
    }
}
