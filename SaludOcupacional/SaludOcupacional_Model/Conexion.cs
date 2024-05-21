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
            string cadenaConexion = ConfigurationManager.AppSettings["db"];
            cadenaConexion = System.Environment.ExpandEnvironmentVariables(cadenaConexion);
            return cadenaConexion;
        }
    }
}
