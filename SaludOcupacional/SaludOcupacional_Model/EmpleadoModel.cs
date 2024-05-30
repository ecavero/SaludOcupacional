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
            cmd.Parameters.AddWithValue("@nombre", empleado.nombreEmpleado);
            cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
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

        public void EditarEmpleado(Empleado empleado)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_editarEmpleado";
            cmd.Parameters.AddWithValue("@idPersona", empleado.IdPersona);
            cmd.Parameters.AddWithValue("@dni", empleado.dni);
            cmd.Parameters.AddWithValue("@apellidoPaterno", empleado.apellidoPaterno);
            cmd.Parameters.AddWithValue("@apellidoMaterno", empleado.apellidoMaterno);
            cmd.Parameters.AddWithValue("@nombreEmpleado", empleado.nombreEmpleado);
            cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
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

        public Empleado BusarEmpleado(int idPersona)
        {
            Empleado empleado = null;
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_buscarEmpleado";
            cmd.Parameters.AddWithValue("@idPersona", idPersona);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    empleado = new Empleado();
                    empleado.dni = (string)reader["dni"];
                    empleado.apellidoPaterno = (string)reader["apellidoPaterno"];
                    empleado.apellidoMaterno = (string)reader["apellidoMaterno"];
                    empleado.nombreEmpleado = (string)reader["nombre"];
                    empleado.usuario = (string)reader["nombreEmpleado"];
                    empleado.clave = (string)reader["clave"];
                    empleado.codDepartamento = (string)reader["codDepartamento"];
                    empleado.codProvincia = (string)reader["codProvincia"];
                    empleado.codDistrito = (string)reader["codDistrito"];
                    empleado.estado = (bool)reader["estado"];
                }

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
            return empleado;
        }





    }
}
