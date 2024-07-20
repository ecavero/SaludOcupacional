using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Entities
{
    public class MedicoBE
    {
        public Int32 dni { get; set; }
        public String apellidoPaterno { get; set; }
        public String apellidoMaterno { get; set; }
        public String nombre { get; set; }
        public String departamento { get; set; }
        public String provincia { get; set; }
        public String distrito { get; set; }
        public Int32 nroColegiatura { get; set; }
        public String especialidad {  get; set; }
        public String estado { get; set; }
    }
}
