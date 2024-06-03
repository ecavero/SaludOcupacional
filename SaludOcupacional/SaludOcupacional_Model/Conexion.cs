using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaludOcupacional_Model
{
    public class Conexion
    {
        public string ObtenerCadenaConexion()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["Ventas"].ConnectionString;
            return cadenaConexion;
        }
    }
}
