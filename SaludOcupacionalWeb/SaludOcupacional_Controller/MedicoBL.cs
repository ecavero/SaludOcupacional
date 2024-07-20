using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludOcupacional_Model;
using SaludOcupacional_Entities;

namespace SaludOcupacional_Controller
{
    public class MedicoBL
    {
        MedicoADO objMedicoADO = new MedicoADO();

        public List<MedicoBE> ListarMedicos()
        {
            return objMedicoADO.ListarMedicos();
        }
    }
}
