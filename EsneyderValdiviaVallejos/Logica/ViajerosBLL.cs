using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EsneyderValdiviaVallejos.Logica
{
    public class ViajeroBLL
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public void RegistrarViajero(string nombre, DateTime fechaNacimiento, string nacionalidad, string documentoIdentidad)
        {
            string query = "INSERT INTO Viajeros (Nombre, FechaNacimiento, Nacionalidad, DocumentoIdentidad) VALUES (@Nombre, @FechaNacimiento, @Nacionalidad, @DocumentoIdentidad)";
            SqlParameter[] parameters = {
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@FechaNacimiento", fechaNacimiento),
                new SqlParameter("@Nacionalidad", nacionalidad),
                new SqlParameter("@DocumentoIdentidad", documentoIdentidad)
            };
            dbHelper.ExecuteNonQuery(query, parameters);
        }

        public DataTable ObtenerViajeros()
        {
            string query = "SELECT * FROM Viajeros";
            return dbHelper.ExecuteQuery(query);
        }
    }
}
