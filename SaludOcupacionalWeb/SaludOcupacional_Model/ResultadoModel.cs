using SaludOcupacional_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Model
{
    public class ResultadoModel
    {
        public const int ID_EXAMEN_AUDIOMETRIA = 5;

        SaludOcupacionalEntities em = new SaludOcupacionalEntities();
        public List<CitaExamenResultadoEntity> obtenerAudiometria(int idCita)
        {
            List<CitaExamenResultadoEntity> listaResultados = new List<CitaExamenResultadoEntity> ();
            var componentes = ObtenerComponentesParaAudiometria().Select(it => it.IdExamenComponente).ToList(); 
            var query = from citaExamenResultado in em.CitaExamenResultado
                        where citaExamenResultado.ExamenComponente.idExamen == ID_EXAMEN_AUDIOMETRIA
                        && citaExamenResultado.idCita == idCita
                        && componentes.Contains(citaExamenResultado.idExamenComponente ?? 0)
                        select citaExamenResultado;
            foreach(var rs in query)
            {
                CitaExamenResultadoEntity cer = new CitaExamenResultadoEntity();
                cer.Resultatado = rs.resultado;
                cer.IdExamenComponente = rs.idExamenComponente ?? 0;
                listaResultados.Add(cer);
            }
            return listaResultados;
        }

        public List<ExamenComponenteEntity> ObtenerComponentesParaAudiometria()
        {
            List<ExamenComponenteEntity> listaComponentes = new List<ExamenComponenteEntity>();
            var query = from examenComponente in em.ExamenComponente
                        where examenComponente.descripcionComponente.StartsWith("Audiograma")
                        && examenComponente.idExamen == ID_EXAMEN_AUDIOMETRIA
                        select examenComponente;
            foreach(var rs in query )
            {
                ExamenComponenteEntity examenComponente = new ExamenComponenteEntity();
                examenComponente.IdExamenComponente = rs.idExamenComponente;
                examenComponente.DescripcionComponente = rs.descripcionComponente;
                listaComponentes.Add(examenComponente);
            }
            return listaComponentes;
        }

        public List<CitaEntity> ObtenerCitasParaAudiometria()
        {
            List<CitaEntity> listaCitas = new List<CitaEntity>();
            var query = from citaExamen in em.CitaExamen
                        where citaExamen.idExamen == ID_EXAMEN_AUDIOMETRIA
                        select citaExamen.Cita;
            foreach( var rs in query )
            {
                CitaEntity cita = new CitaEntity();
                Persona persona = ObtenerPersonaPorId(rs.idPersona ?? 0);
                cita.IdCita = rs.idCita;
                cita.nombrePaciente = $"{persona.apellidoPaterno} {persona.apellidoMaterno}, {persona.nombre}";
                listaCitas.Add(cita);
            }
            return listaCitas;
        }

        private Persona ObtenerPersonaPorId(int id)
        {
            var query = from persona in em.Persona
                        where persona.idPersona == id
                        select persona;
            return query.FirstOrDefault();
        }
    }
}
