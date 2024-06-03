using SaludOcupacional_Controller;
using SaludOcupacional_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludOcupacional_View
{
    public partial class FrmMedico : Form
    {

        MedicoController medicoController = new MedicoController();

        public FrmMedico()
        {
            InitializeComponent();
        }



        private void ListarMedicos()
        {
            var dataTable = medicoController.ListarMedicos();
            var dataView = new DataView(dataTable);
            dgMedicos.DataSource = dataView;

        }

        private void FrmMedico_Load(object sender, EventArgs e)
        {
            ListarMedicos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var frm = new FrmMedicoEditar();
            frm.Text = "Medico - Agegar";
            frm.ShowDialog();
            ListarMedicos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var frm = new FrmMedicoEditar();
            frm.Text = "Médico - Modificar";
            frm.editar = true;
            frm.idMedico = (int)dgMedicos.CurrentRow.Cells[0].Value;
            frm.ShowDialog();
            ListarMedicos();
        }
    }
}
