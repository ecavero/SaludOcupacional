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
            ListarEmpleados();
        }

        private void ListarEmpleados()
        {
            var dataTable = empleadoController.ListarEmpleados();
            var dataView = new DataView(dataTable);
            dgEmpleado.DataSource = dataView;
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
    }
}
