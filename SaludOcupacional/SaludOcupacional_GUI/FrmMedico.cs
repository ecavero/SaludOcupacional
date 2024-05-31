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

namespace SaludOcupacional_View
{
    public partial class FrmMedico : Form
    {

        MedicoController medicoController = new MedicoController();

        public FrmMedico()
        {
            InitializeComponent();
        }


        private void FrmMedico_Load(object sender, EventArgs e)
        {
            ListarMedicos();
        }

        private void ListarMedicos()
        {
            ListarMedicos("");
        }
        private void ListarMedicos(String strFiltro)
        {
            var dataTable = medicoController.ListarMedicos();
            var dataView = new DataView(dataTable);
            dataView.RowFilter = $"apellidoPaterno like '%{strFiltro}%' or apellidoMaterno like '%{strFiltro}%' or nombre like '%{strFiltro}%'"; //interpolación

            dgMedicos.DataSource = dataView;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
