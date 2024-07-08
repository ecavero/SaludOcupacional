using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Entity
{
    public class Empleado
    {

        public static string nombreEmpleadoLogueado { get; set; } = "";
        public int IdPersona { get; set; }
        public int idTipoPersona { get; set; }
        public string dni { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string nombreEmpleado { get; set; }
        public string idUbigeo { get; set; }
        public string codDepartamento {  get; set; }
        public string codProvincia {  get; set; }
        public string codDistrito {  get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public bool estado { get; set; }
        public byte[] foto {  get; set; }



    }
}
