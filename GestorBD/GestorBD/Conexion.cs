using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace GestorBD
{
    class Conexion
    {
        public SqlConnection Enlase { get; set; }

        public Conexion(string Llave)
        {
            Enlase = new SqlConnection(ConfigurationManager.ConnectionStrings[Llave].ConnectionString);
        }


        public bool Conectar()
        {
            
            Enlase.Open();
            return Enlase.State == ConnectionState.Open;
        }
        public bool Desconectar()
        {
            Enlase.Close();
            return Enlase.State == ConnectionState.Closed;
        }
    }
}
