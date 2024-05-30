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
        PacienteController pacienteController = new PacienteController();

        public bool editar {  get; set; }
        public int idPaciente { get; set; }

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
            if (editar)
            {
                txtCodigo.Text = $"{idPaciente}";
                var paciente = pacienteController.BuscarPaciente(idPaciente);
                txtDni.Text = paciente.dni;
                txtApellidoPaterno.Text = paciente.apellidoPaterno;
                txtApellidoMaterno.Text = paciente.apellidoMaterno;
                txtNombre.Text = paciente.nombre;
                SeleccionarDepartamento(paciente.codDepartamento);
                SeleccionarProvincia(paciente.codProvincia);
                SeleccionarDistrito(paciente.codDistrito);
                txtNumeroDeHistoria.Text = paciente.numeroDeHistoria;
                chkActivo.Checked = paciente.estado;
            }
        }

        private void SeleccionarDepartamento(string codDepartamento)
        {
            DataTable dataTable = ubigeoController.ListarDepartamentos();
            int indice = 0;
            foreach(DataRow dataRow in dataTable.Rows )
            {
                indice++;
                if (codDepartamento.Equals((string)dataRow["codDepartamento"]))
                {
                    cboDepartamento.SelectedIndex = indice;
                    break;
                }
            }
        }

        private void SeleccionarProvincia(string codProvinia)
        {
            var cbo = cboDepartamento;
            var ubigeo = new Ubigeo();
            var dataRowViewSeleccionado = (DataRowView)cbo.SelectedItem;
            var dataRowSeleccionado = dataRowViewSeleccionado.Row;
            ubigeo.codDepartamento = (string)dataRowSeleccionado["codDepartamento"];
            DataTable dataTable = ubigeoController.ListarProvincias(ubigeo);
            int indice = 0;
            foreach (DataRow dataRow in dataTable.Rows )
            {
                indice++;
                if (codProvinia.Equals((string)dataRow["codProvincia"]))
                {
                    cboProvincia.SelectedIndex = indice;
                    break;
                }
            }
        }

        private void SeleccionarDistrito(string codDistrito)
        {
            var cbo = cboProvincia;
            var ubigeo = new Ubigeo();
            var dataRowViewSeleccionado = (DataRowView)cbo.SelectedItem;
            var dataRowSeleccionado = dataRowViewSeleccionado.Row;
            var dataRowViewDepartamentoSeleccionado = (DataRowView)cboDepartamento.SelectedItem;
            var dataRowDepartamentoSeleccionado = dataRowViewDepartamentoSeleccionado.Row;
            ubigeo.codDepartamento = (string)dataRowDepartamentoSeleccionado["codDepartamento"];
            ubigeo.codProvincia = (string)dataRowSeleccionado["codProvincia"];
            var dataTable = ubigeoController.ListarDistritos(ubigeo);
            int indice = 0;
            foreach(DataRow dataRow in dataTable.Rows)
            {
                indice++;
                if (codDistrito.Equals((string)dataRow["codDistrito"]))
                {
                    cboDistrito.SelectedIndex = indice;
                    break;
                }
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var paciente = new Paciente();
                paciente.IdPersona = idPaciente;
                paciente.dni = txtDni.Text;
                paciente.apellidoPaterno = txtApellidoPaterno.Text;
                paciente.apellidoMaterno = txtApellidoMaterno.Text;
                paciente.nombre = txtNombre.Text;
                var dataRowViewDistrito = (DataRowView)cboDistrito.SelectedItem;
                var dataRowDistrito = dataRowViewDistrito.Row;
                paciente.idUbigeo = (string)dataRowDistrito["idUbigeo"];
                paciente.numeroDeHistoria = txtNumeroDeHistoria.Text;
                paciente.estado = chkActivo.Checked;
                if (editar)
                {
                    pacienteController.EditarPaciente(paciente);
                } 
                else
                {
                pacienteController.InsertarPaciente(paciente);
                }
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
