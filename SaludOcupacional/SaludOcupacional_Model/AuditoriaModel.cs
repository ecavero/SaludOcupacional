using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Model
{
    public class AuditoriaModel
    {
        public DataTable ObtenerAuditoria()
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                var cmd = new SqlCommand("SELECT * FROM AuditLog", conn);
                var dataTable = new DataTable();
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                return dataTable;
            }
        }
    }
}
