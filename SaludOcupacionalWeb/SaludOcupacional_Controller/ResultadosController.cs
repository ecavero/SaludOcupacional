using SaludOcupacional_Model;
using SaludOcupacional_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Controller
{
    public class ResultadosController
    {
        public ResultadoModel model = new ResultadoModel();

        public List<ExamenComponenteEntity> ObtenerComponentesParaAudionetria()
        {
            return model.ObtenerComponentesParaAudiometria();
        }

        public List<CitaExamenResultadoEntity> ObtenerAudiometria(int idCita)
        {
            return model.obtenerAudiometria(idCita);
        }

        public List<CitaEntity> ObtenerCitasParaAudiometria()
        {
            return model.ObtenerCitasParaAudiometria();
        }
    }
}
