using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace System_Prestamos_Lf.Dominio
{
    class Clientes
    {
        private AccesoDatos.DatosUsuario DatosUsuario = new AccesoDatos.DatosUsuario();
        public Clientes() { }

        /// <summary>
        /// Metodo para obtener los datos de los clientes
        /// </summary>
        /// <returns></returns>
        public DataTable DatagridClientes()
        {
            try
            {
                return DatosUsuario.DataTableClientes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Validar Cadenas vacias
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        private bool CadenaSoloEspacios(string cadena)
        {
            String source = cadena; //Original text

            if (source.Trim().Length <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
