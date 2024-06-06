using SaludOcupacional_Controller;
using SaludOcupacional_GUI;
using System.Data;

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
            ListarMedicos("");
        }
        private void ListarMedicos(String strFiltro)
        {
            try
            {
                var dataTable = medicoController.ListarMedicos();
                var dataView = new DataView(dataTable);
                dataView.RowFilter = $"apellidoPaterno like '%{strFiltro}%' or apellidoMaterno like '%{strFiltro}%' or nombre like '%{strFiltro}%'"; //interpolación

                dgMedicos.DataSource = dataView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
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
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                ListarMedicos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
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
