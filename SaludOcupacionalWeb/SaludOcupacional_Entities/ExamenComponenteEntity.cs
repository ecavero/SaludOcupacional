using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Entities
{
    public class ExamenComponenteEntity
    {
        public int IdExamenComponente {  get; set; }
        public int IdExamen {  get; set; }
        public string DescripcionComponente { get; set; }

    }
}
