using SaludOcupacional_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Model
{
    public class UbigeoModel
    {
        public DataTable ListarDepartamentos()
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var dataSet = new DataSet();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_listarDepartamentos";
            try
            {
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Departamentos");
                return dataSet.Tables["Departamentos"];
            } 
            catch(SqlException ex)
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
        }

        public DataTable ListarProvincias(Ubigeo ubigeo)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var dataSet = new DataSet();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_listarProvincias";
            cmd.Parameters.AddWithValue("@codDepartamento", ubigeo.codDepartamento);
            try
            {
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Provincias");
                return dataSet.Tables["Provincias"];
            }
            catch(SqlException ex)
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
        }

        public DataTable ListarDistritos(Ubigeo ubigeo)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var dataSet = new DataSet(); 
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_listarDistritos";
            cmd.Parameters.AddWithValue("@codDepartamento", ubigeo.codDepartamento);
            cmd.Parameters.AddWithValue("@codProvincia", ubigeo.codProvincia);
            try
            {
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Distritos");
                return dataSet.Tables["Distritos"];
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
        }
    }
}
