using SaludOcupacional_Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Model
{
    public class MedicoADO
    {

        public List<MedicoBE> ListarMedicos()
        {
            try
            {
                SaludOcupacionalEntities MisTablas = new SaludOcupacionalEntities();
                List<MedicoBE> objListaMedicosBE = new List<MedicoBE>();

                var query = (from medicos in MisTablas.Medico
                             join persona in MisTablas.Persona on medicos.idPersona equals persona.idPersona
                             join ubigeo in MisTablas.Ubigeo on persona.idUbigeo equals ubigeo.idUbigeo
                             select new
                             {
                                 Medico = medicos,
                                 Persona = persona,
                                 Ubigeo = ubigeo
                             }).ToList();

                foreach(var resultado in query)
                {
                    MedicoBE objMedicoBE = new MedicoBE();
                    objMedicoBE.dni = Convert.ToInt32(resultado.Persona.dni);
                    objMedicoBE.apellidoPaterno = resultado.Persona.apellidoPaterno;
                    objMedicoBE.apellidoMaterno = resultado.Persona.apellidoMaterno;
                    objMedicoBE.nombre = resultado.Persona.nombre;
                    objMedicoBE.departamento = resultado.Ubigeo.departamento;
                    objMedicoBE.provincia = resultado.Ubigeo.provincia;
                    objMedicoBE.distrito = resultado.Ubigeo.distrito;
                    objMedicoBE.nroColegiatura = Convert.ToInt32(resultado.Medico.nroColegiatura);
                    objMedicoBE.especialidad = resultado.Medico.especialidad;
                    objMedicoBE.estado = (resultado.Medico.estado) == true ? "Activo" : "Inactivo";
                    objListaMedicosBE.Add(objMedicoBE);

                }
                return objListaMedicosBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
