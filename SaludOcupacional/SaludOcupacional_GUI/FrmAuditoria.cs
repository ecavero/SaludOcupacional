using SaludOcupacional_Model;
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
    public partial class FrmAuditoria : Form
    {
        private AuditoriaModel auditoriaModel;

        public FrmAuditoria()
        {
            InitializeComponent();
            auditoriaModel = new AuditoriaModel();
            
        }

        private void CargarDatosAuditoria()
        {
            try
            {
                DataTable auditoriaData = auditoriaModel.ObtenerAuditoria();
                auditDataGrid.DataSource = auditoriaData;
                lblRegistros.Text = auditDataGrid.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de auditoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            auditDataGrid.AutoGenerateColumns = false;
            CargarDatosAuditoria();
        }
    }
}
