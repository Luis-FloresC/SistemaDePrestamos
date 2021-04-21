using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Prestamos_Lf.Dominio
{
    class Empleados
    {
        public Empleados() { }
        private AccesoDatos.DatosUsuario DatosUsuario = new AccesoDatos.DatosUsuario();

        public bool VerificarInicioSesión(string user,string pass )
        {
            try
            {
                return DatosUsuario.InicioDeSesion(user,pass);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
