using System.Configuration;


namespace Datos
{
     public class ConexionDL
    {
        public enum EConexion
        {
            north = 0
        }

        private static readonly string xConexion = ConfigurationManager.ConnectionStrings["Cnx"].ConnectionString;

        public static string Conexion(EConexion eConexion)
        {
            string wCadenaConexion = string.Empty;

            switch (eConexion)
            {
                case EConexion.north:
                    wCadenaConexion = xConexion;
                    break;

            }
            return wCadenaConexion;
        }
    }
}

