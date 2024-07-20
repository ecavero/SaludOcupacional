using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Entities
{
    public class CitaExamenResultadoEntity
    {
        public int IdCitaExamenResultado {  get; set; }
        public int IdCita {  get; set; }
        public int IdExamenComponente { get; set; }
        public string Resultatado { get; set; }

    }
}
