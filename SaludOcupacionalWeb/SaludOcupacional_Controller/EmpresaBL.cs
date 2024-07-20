using SaludOcupacional_Entities;
using SaludOcupacional_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Controller
{
    public class EmpresaBL
    {
        EmpresaADO objEmpresaADO = new EmpresaADO();

        public List<EmpresaBE> ListarEmpresas(){
            return objEmpresaADO.ListraEmpresas();
        }
    }
}
