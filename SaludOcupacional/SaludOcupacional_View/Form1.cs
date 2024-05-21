namespace SaludOcupacional_View;
using SaludOcupacional_Controller;
using System.Data;

public partial class Form1 : Form
{
    PacienteController pacienteController = new PacienteController();
    public Form1()
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
}
