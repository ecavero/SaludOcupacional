using SaludOcupacional_Controller;
using SaludOcupacional_Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb_SaludOcupacional_GUI.Consultas
{
    public partial class Audiometria : System.Web.UI.Page
    {
        public ResultadosController controller = new ResultadosController();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                llenarCitas();
                llenerAudiograma();


           }
        }

        private void llenarCitas() 
        {
            var citas = controller.ObtenerCitasParaAudiometria();
            foreach (var cita in citas)
            {
                cboCitas.Items.Add(new ListItem($"{cita.IdCita} - {cita.nombrePaciente}", $"{cita.IdCita}"));
            }
        }

        private void llenerAudiograma()
        {
                List<ExamenComponenteEntity> listaExamenComponentes = controller.ObtenerComponentesParaAudionetria();
                List<CitaExamenResultadoEntity> listaResultados = controller.ObtenerAudiometria(Convert.ToInt16(cboCitas.SelectedValue));
                foreach(var componente in listaExamenComponentes)
                {
                    var partes = componente.DescripcionComponente.Split('|');
                    var examenComponente = listaResultados.Where(r => r.IdExamenComponente == componente.IdExamenComponente).FirstOrDefault();
                    if (examenComponente != null)
                    {
                        var resultado = examenComponente.Resultatado;
                        chtAudiograma.Series[partes[1]].Points.AddXY(partes[2], resultado);
                    }
                }
        }

        protected void cboCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenerAudiograma();
        }
    }
}