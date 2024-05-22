namespace SaludOcupacional_View;
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

    private void ListarPacientes()
    {
        var dataTable = pacienteController.ListarPacientes();
        var dataView = new DataView(dataTable);
        dgPacientes.DataSource = dataView;

    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        var frm = new FrmPacienteEditar();
        frm.Text = "Paciente - Agregar";
        frm.ShowDialog();
    }
}
