using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EsneyderValdiviaVallejos.Datos
{
    public class EntradasySalidas_Dal
    {
        public static int IdViajero { get; set; }
        public static DateTime? FechaEntrada { get; set; }
        public static string LugarEntrada { get; set; }
        public static DateTime? FechaSalida { get; set; }
        public static string LugarSalida { get; set; }

        public Viajeros_Dal Viajero { get; set; } 
    }
}

