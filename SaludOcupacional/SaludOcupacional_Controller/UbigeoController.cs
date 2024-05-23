using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludOcupacional_Model;

namespace SaludOcupacional_Controller
{
    public class UbigeoController
    {
        UbigeoModel model = new UbigeoModel();

        public DataTable ListarDepartamentos() {  
            return model.ListarDepartamentos();
        }

    }
}
