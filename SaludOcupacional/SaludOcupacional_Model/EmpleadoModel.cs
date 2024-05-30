using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludOcupacional_Entity;

namespace SaludOcupacional_Model
{
    public class EmpleadoModel
    {

        public DataTable ListarEmpleados()
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var dataSet = new DataSet();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_listarEmpleados";
            try
            {
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Empleados");
                return dataSet.Tables["Empleados"];
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

        public void InsertarEmpleado(Empleado empleado)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_insertarEmpleado";
            cmd.Parameters.AddWithValue("@dni", empleado.dni);
            cmd.Parameters.AddWithValue("@apellidoPaterno", empleado.apellidoPaterno);
            cmd.Parameters.AddWithValue("@apellidoMaterno", empleado.apellidoMaterno);
            cmd.Parameters.AddWithValue("@nombreEmpleado", empleado.nombreEmpleado);
            cmd.Parameters.AddWithValue("@clave", empleado.clave);
            cmd.Parameters.AddWithValue("@idUbigeo", empleado.idUbigeo);
            cmd.Parameters.AddWithValue("@estado", empleado.estado);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
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
