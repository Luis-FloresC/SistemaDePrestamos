using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace System_Prestamos_Lf.AccesoDatos
{
   public abstract class Conexion
    {
        private readonly String Connection_st;

        public Conexion()
        {
            Connection_st = ConfigurationManager.ConnectionStrings["System_Prestamos_Lf.Properties.Settings.PrestamosDb"].ConnectionString;

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Connection_st);
        }
    }
}
