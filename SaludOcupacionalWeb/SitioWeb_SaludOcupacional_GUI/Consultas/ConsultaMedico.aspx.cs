using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SaludOcupacional_Controller;

namespace SitioWeb_SaludOcupacional_GUI.Consultas
{
    public partial class ConsultaMedico : System.Web.UI.Page
    {

        MedicoBL objMedicoBL = new MedicoBL();

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
                lblMensajePopup.Text = "Error: " + ex.Message;
                //PopMensaje.Show();
            }
        }

        private void CargarDatosMedicos(string strFiltro)
        {
            //System.Threading.Thread.Sleep(2000);

            if(strFiltro == String.Empty)
            {
                grvMedicos.DataSource = objMedicoBL.ListarMedicos();
            }
            else
            {
                grvMedicos.DataSource = objMedicoBL.ListarMedicos().Where(medico => 
                medico.especialidad.Contains(strFiltro)).ToList();
            }
            grvMedicos.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatosMedicos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
            }
        }

        protected void grvVendedores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Codifique
            grvMedicos.PageIndex = e.NewPageIndex;
            CargarDatosMedicos(txtFiltro.Text.Trim());

        }
    }
}