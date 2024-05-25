using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaludOcupacional_Controller;
using SaludOcupacional_Entity;

namespace SaludOcupacional_View
{
    public partial class FrmPacienteEditar : Form
    {
        UbigeoController ubigeoController = new UbigeoController();
        public FrmPacienteEditar()
        {
            InitializeComponent();
        }

        private void FrmPacienteEditar_Load(object sender, EventArgs e)
        {
            var dataTable = ubigeoController.ListarDepartamentos();
            var dataRow = dataTable.NewRow();
            dataRow["codDepartamento"] = "null";
            dataRow["departamento"] = "--Seleccione--";
            dataTable.Rows.InsertAt(dataRow, 0);
            cboDepartamento.DataSource = dataTable;
            cboDepartamento.ValueMember = "codDepartamento";
            cboDepartamento.DisplayMember = "departamento";
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbo = (ComboBox)sender;
            var ubigeo = new Ubigeo();
            var dataRowViewSeleccionado = (DataRowView)cbo.SelectedItem;
            var dataRowSeleccionado = dataRowViewSeleccionado.Row;
            ubigeo.codDepartamento = (string)dataRowSeleccionado["codDepartamento"];
            var dataTable = ubigeoController.ListarProvincias(ubigeo);
            var dataRow = dataTable.NewRow();
            dataRow["codProvincia"] = "null";
            dataRow["provincia"] = "--Seleccione--";
            dataTable.Rows.InsertAt(dataRow, 0);
            cboProvincia.DataSource = dataTable;
            cboProvincia.ValueMember = "codProvincia";
            cboProvincia.DisplayMember = "provincia";
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbo = (ComboBox)sender;
            var ubigeo = new Ubigeo();
            var dataRowViewSeleccionado = (DataRowView)cbo.SelectedItem;
            var dataRowSeleccionado = dataRowViewSeleccionado.Row;
            var dataRowViewDepartamentoSeleccionado = (DataRowView)cboDepartamento.SelectedItem;
            var dataRowDepartamentoSeleccionado = dataRowViewDepartamentoSeleccionado.Row;
            ubigeo.codDepartamento = (string)dataRowDepartamentoSeleccionado["codDepartamento"];
            ubigeo.codProvincia = (string)dataRowSeleccionado["codProvincia"];
            var dataTable = ubigeoController.ListarDistritos(ubigeo);
            var dataRow = dataTable.NewRow();
            dataRow["codDistrito"] = "null";
            dataRow["distrito"] = "--Seleccione--";
            dataTable.Rows.InsertAt(dataRow, 0);
            cboDistrito.DataSource = dataTable;
            cboDistrito.ValueMember = "codDistrito";
            cboDistrito.DisplayMember = "distrito";
        }
    }
}
