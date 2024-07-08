namespace SaludOcupacional_GUI;
using SaludOcupacional_Controller;
using System.Data;

public partial class frmPaciente : Form
{
    PacienteController pacienteController = new PacienteController();
    public frmPaciente()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ListarPacientes();
    }

   

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        var frm = new FrmPacienteEditar();
        frm.Text = "Paciente - Agregar";
        frm.editar = false;
        frm.ShowDialog();
        ListarPacientes();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
        var frm = new FrmPacienteEditar();
        frm.Text = "Paciente - Modificar";
        frm.editar = true;
        frm.idPaciente = (int)dgPacientes.CurrentRow.Cells[0].Value;
        frm.ShowDialog();
        ListarPacientes();
    }

    private void ListarPacientes()
    {
        ListarPacientes("");
    }
    private void ListarPacientes(String strFiltro)
    {
        var dataTable = pacienteController.ListarPacientes();
        var dataView = new DataView(dataTable);
        dataView.RowFilter = $"apellidoPaterno like '%{strFiltro}%' or apellidoMaterno like '%{strFiltro}%' or nombre like '%{strFiltro}%'or dni like '%{strFiltro}%'"; //interpolación

        dgPacientes.DataSource = dataView;
    }


    private void txtFiltro_TextChanged(object sender, EventArgs e)
    {
        try
        {
            // Pasaremos al metodo CargarDatos el texto que se va escribiendo
            // en la caja de texto 
            ListarPacientes(txtFiltro.Text.Trim());
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error:" + ex.Message);
        }
    }
}
