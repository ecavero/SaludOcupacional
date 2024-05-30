using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludOcupacional_Model;
using SaludOcupacional_Entity;

namespace SaludOcupacional_Controller
{
    public class EmpleadoController
    {
        EmpleadoModel model = new EmpleadoModel();

       

        public DataTable ListarEmpleados()
        {
            return model.ListarEmpleados();

        }


        public void InsertarEmpleado(Empleado empleado)
            {
                model.InsertarEmpleado(empleado);
            }



    }
}
