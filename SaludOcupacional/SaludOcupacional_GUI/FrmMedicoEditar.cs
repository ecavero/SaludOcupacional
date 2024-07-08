using Microsoft.VisualBasic;
using SaludOcupacional_Controller;
using SaludOcupacional_Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludOcupacional_GUI
{
    public partial class FrmMedicoEditar : Form
    {
        UbigeoController ubigeoController = new UbigeoController();
        MedicoController medicoController = new MedicoController();

        public bool editar { get; set; }
        public int idMedico { get; set; }

        string rutaFoto = "";


        public FrmMedicoEditar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var medico = new Medico();
                medico.IdPersona = idMedico;
                medico.dni = txtDNI.Text;
                medico.apellidoPaterno = txtApellidoPaterno.Text;
                medico.apellidoMaterno = txtApellidoMaterno.Text;
                medico.nombre = txtNombre.Text;
                medico.nroColegiatura = int.Parse(txtColegiatura.Text);
                medico.especialidad = txtEspecialidad.Text;
                var dataRowViewDistrito = (DataRowView)cboDistrito.SelectedItem;
                var dataRowDistrito = dataRowViewDistrito.Row;
                medico.idUbigeo = (string)dataRowDistrito["idUbigeo"];
                medico.estado = chkActivo.Checked;
                if (rutaFoto != string.Empty)
                {
                    medico.foto = File.ReadAllBytes(rutaFoto);
                }
                else
                {
                    var datosAnteriores = medicoController.BuscarMedico(idMedico);
                    medico.foto = datosAnteriores.foto;
                }
                if (editar)
                {
                    medicoController.EditarMedico(medico);
                }
                else
                {
                    medicoController.InsertarMedico(medico);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMedicoEditar_Load(object sender, EventArgs e)
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
                var medico = medicoController.BuscarMedico(idMedico);
                txtDNI.Text = medico.dni;
                txtApellidoPaterno.Text = medico.apellidoPaterno;
                txtApellidoMaterno.Text = medico.apellidoMaterno;
                txtNombre.Text = medico.nombre;
                txtColegiatura.Text = medico.nroColegiatura.ToString();
                txtEspecialidad.Text = medico.especialidad;
                SeleccionarDepartamento(medico.codDepartamento);
                SeleccionarProvincia(medico.codProvincia);
                SeleccionarDistrito(medico.codDistrito);
                chkActivo.Checked = medico.estado;
                mostrarImagen(medico);
            }
        }

        private void mostrarImagen(Medico medico)
        {
            if (medico.foto != null)
            {
                using (MemoryStream ms = new MemoryStream(medico.foto))
                {
                    pbFoto.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbFoto.Image = null;
            }
        }

        private void SeleccionarDepartamento(string codDepartamento)
        {
            DataTable dataTable = ubigeoController.ListarDepartamentos();
            int indice = 0;
            foreach (DataRow dataRow in dataTable.Rows)
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
            foreach (DataRow dataRow in dataTable.Rows)
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
            foreach (DataRow dataRow in dataTable.Rows)
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            fFoto.InitialDirectory = "c:\\";
            fFoto.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            fFoto.FilterIndex = 1;
            fFoto.RestoreDirectory = true;

            if (fFoto.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = fFoto.FileName;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtColegiatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
