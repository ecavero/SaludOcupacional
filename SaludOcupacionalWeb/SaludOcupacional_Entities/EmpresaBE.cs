using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Entities
{
    public class EmpresaBE
    {
        public String nombre {  get; set; }
        public Int32 RUC { get; set; }
        public String departamento { get; set;}
        public String provincia { get; set;}
        public String distrito { get; set;}
        public Boolean estado { get; set; }
    }
}
