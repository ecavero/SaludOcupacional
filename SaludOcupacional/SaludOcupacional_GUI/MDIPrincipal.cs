using Microsoft.VisualBasic.Devices;
using SaludOcupacional_View;
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
    public partial class MDIPrincipal : Form
    {

        TimeSpan horaEntrada = new TimeSpan();
        Computer miEquipo = new Computer();
        string miRed;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm1 = new FrmEmpleado();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaciente frm2 = new frmPaciente();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedico frm = new FrmMedico();
            frm.MdiParent = this;
            frm.Show();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAuditoria frmAuditoria = new FrmAuditoria();
            frmAuditoria.MdiParent = this;
            frmAuditoria.Show();
        }


        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta = MessageBox.Show("¿Seguro de salir del sistema?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Fecha y hora del sistema
            this.Text = "Menu Principal " + DateTime.Now.ToString();

            //Tiempo segundo a segundo
            lblSesion.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaEntrada).ToString().Substring(0,8);
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            //Datos del equipo
            if (miEquipo.Network.IsAvailable)
            {
                miRed = "Equipo con conexión a red disponible.";
            }
            else
            {
                miRed = "Equipo sin conexión a red disponible";
            }

            lblEquipo.Text = "Equipo: " + miEquipo.Name + ". " + miRed;

            //Hora de inicio
            horaEntrada = DateTime.Now.TimeOfDay;
        }

        
    }
}
