using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Model
{
    public class Class1
    {
       void prueba() 
        {
            SaludOcupacionalEntities em = new SaludOcupacionalEntities();
            var query = from cita in em.Cita
                        select cita;
            foreach (var rs in query)
            {
                
            }

        }

    }
}
