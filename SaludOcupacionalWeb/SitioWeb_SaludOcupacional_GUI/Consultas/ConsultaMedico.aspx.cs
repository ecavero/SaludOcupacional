using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SaludOcupacional_Controller;
using SaludOcupacional_Entities;

namespace SitioWeb_SaludOcupacional_GUI.Consultas
{
    public partial class ConsultaMedico : System.Web.UI.Page
    {

        MedicoBL objMedicoBL = new MedicoBL();

        List<MedicoBE> medicos = new List<MedicoBE>();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Page.IsPostBack == false)
                {
                    CargarDatosMedicos("");
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        private void CargarDatosMedicos(string strFiltro)
        {
            try
            {
                lblMensaje.Text = "";

                if (string.IsNullOrEmpty(strFiltro))
                {
                    grvMedicos.DataSource = objMedicoBL.ListarMedicos();
                }
                else
                {
                    medicos = objMedicoBL.ListarMedicos().Where(medico =>
                        medico.especialidad.Equals(strFiltro, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (medicos.Count == 0)
                    {
                        lblMensaje.Text = "No se encontraron doctores";
                    }

                    grvMedicos.DataSource = medicos;
                }
                grvMedicos.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatosMedicos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void grvMedicos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Codifique
            grvMedicos.PageIndex = e.NewPageIndex;
            CargarDatosMedicos(txtFiltro.Text.Trim());

        }

    }
}