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
            using (var conn = new SqlConnection(cadenaConexion))
            {
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
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                // Establecer la variable de sesión
                using (var setContextCmd = new SqlCommand("sp_set_session_context", conn))
                {
                    setContextCmd.CommandType = CommandType.StoredProcedure;
                    setContextCmd.Parameters.AddWithValue("@key", "UserName");
                    setContextCmd.Parameters.AddWithValue("@value", Empleado.nombreEmpleadoLogueado);
                    setContextCmd.ExecuteNonQuery();
                }

                // Ejecutar la inserción del empleado
                using (var cmd = new SqlCommand("usp_insertarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dni", empleado.dni);
                    cmd.Parameters.AddWithValue("@apellidoPaterno", empleado.apellidoPaterno);
                    cmd.Parameters.AddWithValue("@apellidoMaterno", empleado.apellidoMaterno);
                    cmd.Parameters.AddWithValue("@nombreEmpleado", empleado.nombreEmpleado);
                    cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
                    cmd.Parameters.AddWithValue("@clave", empleado.clave);
                    cmd.Parameters.AddWithValue("@idUbigeo", empleado.idUbigeo);
                    cmd.Parameters.AddWithValue("@estado", empleado.estado);
                    SqlParameter paramImagen = new SqlParameter("@foto", SqlDbType.VarBinary, -1);
                    if (empleado.foto == null)
                    {
                        paramImagen.Value = DBNull.Value;
                    }
                    else
                    {
                        paramImagen.Value = empleado.foto;
                    }
                    cmd.Parameters.Add(paramImagen);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void EditarEmpleado(Empleado empleado)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();

                // Establecer la variable de sesión
                using (var setContextCmd = new SqlCommand("sp_set_session_context", conn))
                {
                    setContextCmd.CommandType = CommandType.StoredProcedure;
                    setContextCmd.Parameters.AddWithValue("@key", "UserName");
                    setContextCmd.Parameters.AddWithValue("@value", Empleado.nombreEmpleadoLogueado);
                    setContextCmd.ExecuteNonQuery();
                }

                // Ejecutar la actualización del empleado
                using (var cmd = new SqlCommand("usp_editarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPersona", empleado.IdPersona);
                    cmd.Parameters.AddWithValue("@dni", empleado.dni);
                    cmd.Parameters.AddWithValue("@apellidoPaterno", empleado.apellidoPaterno);
                    cmd.Parameters.AddWithValue("@apellidoMaterno", empleado.apellidoMaterno);
                    cmd.Parameters.AddWithValue("@nombreEmpleado", empleado.nombreEmpleado);
                    cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
                    cmd.Parameters.AddWithValue("@clave", empleado.clave);
                    cmd.Parameters.AddWithValue("@idUbigeo", empleado.idUbigeo);
                    cmd.Parameters.AddWithValue("@estado", empleado.estado);
                    SqlParameter paramImagen = new SqlParameter("@foto", SqlDbType.VarBinary, -1);
                    if (empleado.foto == null)
                    {
                        paramImagen.Value = DBNull.Value;
                    }
                    else
                    {
                        paramImagen.Value = empleado.foto;
                    }
                    cmd.Parameters.Add(paramImagen);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public Empleado BusarEmpleado(int idPersona)
        {
            Empleado empleado = null;
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            using (var conn = new SqlConnection(cadenaConexion))
            {
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
                        empleado.foto = reader["foto"] != DBNull.Value ? (byte[])reader["foto"] : null;
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
            }
            return empleado;
        }

        public Boolean validarLoginEmpleado(String usuario, String clave)
        {
            Empleado empleado = null;
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                var cmd = new SqlCommand();
                conn.ConnectionString = cadenaConexion;
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_validarLoginEmpleado";
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                try
                {
                    conn.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Empleado.nombreEmpleadoLogueado = reader["nombreEmpleado"].ToString();

                        return true;
                    }
                    else
                    {
                        return false;
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
            }
        }

        public void SetSessionContext(string userName)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                var cmd = new SqlCommand("sp_set_session_context", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@key", "UserName");
                cmd.Parameters.AddWithValue("@value", userName);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
