using SaludOcupacional_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Model
{
    public class EmpresaADO
    {
        public List<EmpresaBE> ListraEmpresas()
        {
            try
            {
                SaludOcupacionalEntities MisTablas = new SaludOcupacionalEntities();
                List<EmpresaBE> objListaEmpresasBE = new List<EmpresaBE>();
                var query = (from empresa in MisTablas.Empresa
                             join ubigeo in MisTablas.Ubigeo on empresa.idUbigeo equals ubigeo.idUbigeo
                             select new
                             {
                                 Empresa = empresa,
                                 Ubigeo = ubigeo
                             }).ToList();

                foreach (var resultado in query)
                {
                    EmpresaBE objEmpresaBE = new EmpresaBE();
                    objEmpresaBE.nombre = resultado.Empresa.nombre;
                    objEmpresaBE.RUC = Convert.ToInt32(resultado.Empresa.RUC);
                    objEmpresaBE.departamento = resultado.Ubigeo.departamento;
                    objEmpresaBE.provincia = resultado.Ubigeo.provincia;
                    objEmpresaBE.distrito = resultado.Ubigeo.distrito;
                    objEmpresaBE.estado = (bool) resultado.Empresa.estado;
                    objListaEmpresasBE.Add(objEmpresaBE);
                }
                return objListaEmpresasBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
