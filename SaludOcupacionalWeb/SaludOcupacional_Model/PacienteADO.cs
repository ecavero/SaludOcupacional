using SaludOcupacional_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Model
{
    public class PacienteADO
    {
        public List<PacienteBE> ListarPacientes()
        {

            try
            {
                SaludOcupacionalEntities MisTablas = new SaludOcupacionalEntities();
                List<PacienteBE> objListaPacientesBE = new List<PacienteBE>();
                var query = (from paciente in MisTablas.Paciente
                             join persona in MisTablas.Persona on paciente.idPersona equals persona.idPersona
                             join ubigeo in MisTablas.Ubigeo on persona.idUbigeo equals ubigeo.idUbigeo
                             select new
                             {
                                 Paciente = paciente,
                                 Persona = persona,
                                 Ubigeo = ubigeo
                             }).ToList();

                foreach (var resultado in query)
                {
                    PacienteBE objPacienteBE = new PacienteBE();
                    objPacienteBE.dni = Convert.ToInt32(resultado.Persona.dni);
                    objPacienteBE.apellidoPaterno = resultado.Persona.apellidoPaterno;
                    objPacienteBE.apellidoMaterno = resultado.Persona.apellidoMaterno;
                    objPacienteBE.nombre = resultado.Persona.nombre;
                    objPacienteBE.departamento = resultado.Ubigeo.departamento;
                    objPacienteBE.provincia = resultado.Ubigeo.provincia;
                    objPacienteBE.distrito = resultado.Ubigeo.distrito;
                    objPacienteBE.numeroDeHistoria = Convert.ToInt32(resultado.Paciente.numeroDeHistoria);
                    objListaPacientesBE.Add(objPacienteBE);
                }
                return objListaPacientesBE;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
