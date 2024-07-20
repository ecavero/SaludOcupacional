using SaludOcupacional_Entities;
using SaludOcupacional_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Controller
{
    public class PacienteBL
    {
        PacienteADO objPacienteADO = new PacienteADO();

        public List<PacienteBE> ListarPacientes()
        {
            return objPacienteADO.ListarPacientes();
        }
    }
}
