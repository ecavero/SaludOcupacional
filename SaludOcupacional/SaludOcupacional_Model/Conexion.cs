using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Model
{
    public class Conexion
    {
        public string ObtenerCadenaConexion()
        {

            //Conexión con variable de Entorno
            //string cadenaConexion = ConfigurationManager.AppSettings["db"];
            //cadenaConexion = System.Environment.ExpandEnvironmentVariables(cadenaConexion);
            //return cadenaConexion;

            //Conexión sin Variable de Entorno
            string strCnx =
                ConfigurationManager.ConnectionStrings["SaludOcupacional"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strCnx;
            }
        }
    }
}
