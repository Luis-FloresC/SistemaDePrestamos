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
        /// <summary>
        /// Variable donde se alamcena la conexion
        /// </summary>
        private readonly String Connection_st;

        /// <summary>
        /// Constructor de la clase de Conexion
        /// </summary>
        public Conexion()
        {

            if (VerificarConexion())
            {
                Connection_st = ConfigurationManager.ConnectionStrings["System_Prestamos_Lf.Properties.Settings.PrestamosDb"].ConnectionString;
            }
            else
            {
                Connection_st = ConfigurationManager.ConnectionStrings["System_Prestamos_Lf.Properties.Settings.PrestamosDb2"].ConnectionString;
            }
       

        }
        /// <summary>
        /// Metodo para verificar la conexion
        /// </summary>
        /// <returns></returns>
        public bool VerificarConexion()
        {

            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=SYSTEM_PRESTAMOS_LF;Integrated Security=True";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// Metodo para obtener la conexion
        /// </summary>
        /// <returns></returns>
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Connection_st);
        }
    }
}
