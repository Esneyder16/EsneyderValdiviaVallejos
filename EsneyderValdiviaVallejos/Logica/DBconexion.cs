using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EsneyderValdiviaVallejos.Logica
{
    public class DBconexion
    {
        public static SqlConnection obtenerConexion()
        {
            string rutaconexion = System.Configuration.ConfigurationManager.ConnectionStrings["ControlMigrantesconnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(rutaconexion);
            conexion.Open();
            return conexion;
        }

    }
}
   