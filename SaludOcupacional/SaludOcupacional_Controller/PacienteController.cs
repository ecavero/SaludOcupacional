using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludOcupacional_Model;

namespace SaludOcupacional_Controller
{
    public class PacienteController
    {
        PacienteModel model = new PacienteModel();

        public DataTable ListarPacientes()
        {
            return model.ListarPacientes();
        }
    }
}
