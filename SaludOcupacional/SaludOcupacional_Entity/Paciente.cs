using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Entity
{
    public class Paciente
    {
        public int IdPersona { get; set; }
        public int idTipoPersona { get; set; }
        public string dni {  get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno {  get; set; }
        public string nombre {  get; set; }
        public string idUbigeo { get; set; }
        public string numeroDeHistoria { get; set; }
        public bool estado {  get; set; }

    }
}
