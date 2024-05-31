using SaludOcupacional_Entity;
using SaludOcupacional_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Controller
{
    public class MedicoController
    {
        MedicoModel model = new MedicoModel();

        public DataTable ListarMedicos()
        {
            return model.ListarMedicos();
        }

        public void InsertarMedico(Medico medico)
        {
            model.InsertarMedico(medico);
        }

        public void EditarMedico(Medico medico)
        {
            model.EditarMedico(medico);
        }

        public Medico BuscarMedico(int idPersona)
        {
            return model.BuscarMedico(idPersona);
        }
    }
}
