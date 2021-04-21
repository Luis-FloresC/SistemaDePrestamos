using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Prestamos_Lf.AccesoComun.Cache
{
   public class CacheUsuario
    {
        public CacheUsuario() { }

        public static string COD_EMPLEADO { get; set; }
        public static string NOMBRE_EMPLEADO { get; set; }
        public static string APELLIDO_EMPLEADO { get; set; }
        public static string TELEFONO_EMPLEADO { get; set; }
        public static string EMAIL_EMPLEADO { get; set; }
        public static string NOMBRE_USUARIO { get; set; }
        public static string CONTRASEÑA { get; set; }
        public static decimal SUELDO { get; set; }
        public static string PUESTO { get; set; }
        public static string ESTADO { get; set; }

    }
}
