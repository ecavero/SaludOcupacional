using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludOcupacional_Model;
using SaludOcupacional_Entity;

namespace SaludOcupacional_Controller
{
    public class PacienteController
    {
        PacienteModel model = new PacienteModel();

        public DataTable ListarPacientes()
        {
            return model.ListarPacientes();
        }

        public void InsertarPaciente(Paciente paciente)
        {
            model.InsertarPaciente(paciente);
        }
    }
}
