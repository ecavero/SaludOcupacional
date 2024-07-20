using SaludOcupacional_Controller;
using SaludOcupacional_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb_SaludOcupacional_GUI
{
    public partial class ConsultaEmpresa : System.Web.UI.Page
    {

        EmpresaBL objEmpresaBL = new EmpresaBL();  
        List<EmpresaBE> empresas = new List<EmpresaBE>();   

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    CargarDatosEmpresas("");
                }
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        private void CargarDatosEmpresas(string strFiltro)
        {
            try
            {
                lblMensajeError.Text = "";

                if (string.IsNullOrEmpty(strFiltro))
                {
                    empresas = objEmpresaBL.ListarEmpresas();
                }
                else
                {
                    int ruc;
                    if (int.TryParse(strFiltro, out ruc))
                    {
                        empresas = objEmpresaBL.ListarEmpresas().Where(empresa =>
                        empresa.RUC == ruc).ToList();

                        if (empresas.Count == 0)
                        {
                            lblMensajeError.Text = "No se encontraron empresas";
                        }
                    }
                    else
                    {
                        lblMensajeError.Text = "El filtro debe ser un número válido.";
                    }
                }

                grvEmpresas.DataSource = empresas;
                grvEmpresas.DataBind();
            }
            catch(Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatosEmpresas(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        protected void grvPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                grvEmpresas.PageIndex = e.NewPageIndex;
                CargarDatosEmpresas(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }
    }

}