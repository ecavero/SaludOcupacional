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

namespace SaludOcupacional_View
{
    public partial class FrmMedico : Form
    {
        public FrmMedico()
        {
            InitializeComponent();
        }

        private void ListarMedicos()
        {
            var dataTable = pacienteController.ListarPacientes();
            var dataView = new DataView(dataTable);
            dgPacientes.DataSource = dataView;

        }


    }
}
