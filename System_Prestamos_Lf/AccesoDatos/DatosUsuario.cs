using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace System_Prestamos_Lf.AccesoDatos
{
    public class DatosUsuario : Conexion
    {

        public DatosUsuario() { }

        AccesoComun.Cache.CacheUsuario cache = new AccesoComun.Cache.CacheUsuario();
       
        /// <summary>
        /// Metodo para verificar el inicio de sesion
        /// </summary>
        /// <param name="user">nombre de Usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns></returns>
        public bool InicioDeSesion(string user, string pass)
        {
            try
            {
                
                using (var conexion = GetConnection())
                {
                    conexion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "IniciarSesion";
                        comando.Parameters.AddWithValue("@user", user);
                        comando.Parameters.AddWithValue("@password", pass);
                        comando.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = comando.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
      
                                AccesoComun.Cache.CacheUsuario.COD_EMPLEADO = reader.GetString(0);
                                AccesoComun.Cache.CacheUsuario.NOMBRE_EMPLEADO = reader.GetString(1);
                                AccesoComun.Cache.CacheUsuario.APELLIDO_EMPLEADO = reader.GetString(2);
                                AccesoComun.Cache.CacheUsuario.TELEFONO_EMPLEADO = reader.GetString(3);
                                AccesoComun.Cache.CacheUsuario.EMAIL_EMPLEADO = reader.GetString(4);
                                AccesoComun.Cache.CacheUsuario.NOMBRE_USUARIO = reader.GetString(5);
                                AccesoComun.Cache.CacheUsuario.CONTRASEÑA = reader.GetString(6);
                                AccesoComun.Cache.CacheUsuario.SUELDO = reader.GetDecimal(7);
                                AccesoComun.Cache.CacheUsuario.PUESTO = reader.GetString(8);
                                AccesoComun.Cache.CacheUsuario.ESTADO = reader.GetString(9);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Metodo para llenar el datagrid del Formulario de Clientes
        /// </summary>
        /// <returns></returns>
        public DataTable DataTableClientes()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conexion = GetConnection())
                {
                    string query = @"SELECT  [COD_CLIENTE] [#]
                                  ,[IDENTIDAD_DEL_CLIENTE] [Identidad]
                                   ,CONCAT(NOMBRE_CLIENTE,' ',APELLIDO_CLIENTE)[Nombre]
                                  ,[SEXO] [Genero]
                                  ,[TELEFONO_CLIENTE] [Telefono]
                                  ,case when COD_ESTADO = 1 then 'Activo' else 'Inactivo' end 'Estado'
                                  FROM [SYSTEM_PRESTAMOS_LF].[dbo].[CLIENTES]";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
