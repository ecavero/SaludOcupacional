using SaludOcupacional_Controller;
using SaludOcupacional_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb_SaludOcupacional_GUI.Consultas
{
    public partial class ConsultaPacientes : System.Web.UI.Page
    {
        PacienteBL objPacienteBL = new PacienteBL();
        List<PacienteBE> pacientes = new List<PacienteBE>();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    CargarDatosPacientes("");
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        private void CargarDatosPacientes(string strFiltro)
        {
            try
            {
                lblMensaje.Text = "";

                if (string.IsNullOrEmpty(strFiltro))
                {
                    pacientes = objPacienteBL.ListarPacientes();
                }
                else
                {
                    pacientes = objPacienteBL.ListarPacientes().Where(paciente =>
                    paciente.departamento.Equals(strFiltro, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (pacientes.Count == 0)
                    {
                        lblMensaje.Text = "No se encontraron pacientes";
                    }
                }

                grvPacientes.DataSource = pacientes;
                grvPacientes.DataBind();
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
                CargarDatosPacientes(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void grvPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grvPacientes.PageIndex = e.NewPageIndex;
                CargarDatosPacientes(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}
