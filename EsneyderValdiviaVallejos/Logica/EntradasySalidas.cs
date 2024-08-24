using EsneyderValdiviaVallejos.Datos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EsneyderValdiviaVallejos.Logica
{
    public class EntradasySalidas
    {
        public static int Agregar(EntradasySalidas_Dal entradasySalidas)
        {
            int resultado = 0;
            string constr = ConfigurationManager.ConnectionStrings["ControlMigracionconnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "INSERT INTO EntradasySalidas (IdViajero, operacion, resultado, fecha_operacion) VALUES (@usuario_id, @operacion, @resultado, @fecha_operacion)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdViajero", entradasySalidas.IdViajero);
                    cmd.Parameters.AddWithValue("@FechaEntrada", entradasySalidas.FechaEntrada);
                    cmd.Parameters.AddWithValue("@resultado", operacion.resultado);
                    cmd.Parameters.AddWithValue("@fecha_operacion", operacion.fecha_operacion);

                    con.Open();
                    resultado = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            return resultado;
        }
    }
}