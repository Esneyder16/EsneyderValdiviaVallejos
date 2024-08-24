using EsneyderValdiviaVallejos.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsneyderValdiviaVallejos.Datos
{
    public class Usuarios_Dal
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string Contrasena { get; set; }
        public static string Rol { get; set; }
        public ICollection<EntradasySalidas> EntradasySalidas { get; set; }
    }
}