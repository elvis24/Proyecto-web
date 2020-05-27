using EntidadNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDL
    {
        public bool getValidarUsuario(UsuarioBE usuarioBE)
        {
            DataSet dsConsulta = new DataSet();
            try
            {
                using (SqlConnection cnx = new SqlConnection(ConexionDL.Conexion(ConexionDL.EConexion.north)))
                {
                    using (SqlCommand cmd = new SqlCommand("uspConsultarUsuario", cnx) { CommandType = CommandType.StoredProcedure})
                    {
                        cmd.Parameters.Add(new SqlParameter("@pLogin", SqlDbType.NVarChar, 15)).Value = usuarioBE.login;
                        cmd.Parameters.Add(new SqlParameter("@pPassword", SqlDbType.NVarChar, 15)).Value = usuarioBE.password;

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }
    }
}
