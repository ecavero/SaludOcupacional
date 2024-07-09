using SaludOcupacional_Controller;
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
    public partial class FrmEmpleado : Form
    {
        EmpleadoController empleadoController = new EmpleadoController();


        public FrmEmpleado()
        {
            InitializeComponent();
        }

       

        private void dgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

            dgEmpleado.AutoGenerateColumns = false;

            ListarEmpleados();
        }

        private void ListarEmpleados()
        {
            ListarEmpleados("");
        }
        private void ListarEmpleados(String strFiltro)
        {
            var dataTable = empleadoController.ListarEmpleados();
            var dataView = new DataView(dataTable);
            dataView.RowFilter = $"apellidoPaterno like '%{strFiltro}%' or apellidoMaterno like '%{strFiltro}%' or nombre like '%{strFiltro}%'or dni like '%{strFiltro}%'"; //interpolación

            dgEmpleado.DataSource = dataView;
            lblRegistros.Text = dgEmpleado.Rows.Count.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new FrmEmpleadoEditar();
            frm.Text = "Empleado - Agregar";
            frm.ShowDialog();
            ListarEmpleados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var frm = new FrmEmpleadoEditar();
            frm.Text = "Empleado - Modificar";
            frm.editar = true;
            frm.idEmpleado = (int)dgEmpleado.CurrentRow.Cells[0].Value;
            frm.ShowDialog();
            ListarEmpleados();

        }




        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                ListarEmpleados(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
