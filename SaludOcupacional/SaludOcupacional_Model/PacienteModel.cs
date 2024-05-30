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
    public class PacienteModel
    {
        public DataTable ListarPacientes() { 
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var dataSet = new DataSet();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_listarPacientes";
            try
            {
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Pacientes");
                return dataSet.Tables["Pacientes"];
            } catch (SqlException ex)
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

        public void InsertarPaciente(Paciente paciente)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_insertarPaciente";
            cmd.Parameters.AddWithValue("@dni", paciente.dni);
            cmd.Parameters.AddWithValue("@apellidoPaterno", paciente.apellidoPaterno);
            cmd.Parameters.AddWithValue("@apellidoMaterno", paciente.apellidoMaterno);
            cmd.Parameters.AddWithValue("@nombre", paciente.nombre);
            cmd.Parameters.AddWithValue("@idUbigeo", paciente.idUbigeo);
            cmd.Parameters.AddWithValue("@numeroDeHistoria", paciente.numeroDeHistoria);
            cmd.Parameters.AddWithValue("@estado", paciente.estado);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
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

        public void EditarPaciente(Paciente paciente)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_editarPaciente";
            cmd.Parameters.AddWithValue("@idPersona", paciente.IdPersona);
            cmd.Parameters.AddWithValue("@dni", paciente.dni);
            cmd.Parameters.AddWithValue("@apellidoPaterno", paciente.apellidoPaterno);
            cmd.Parameters.AddWithValue("@apellidoMaterno", paciente.apellidoMaterno);
            cmd.Parameters.AddWithValue("@nombre", paciente.nombre);
            cmd.Parameters.AddWithValue("@idUbigeo", paciente.idUbigeo);
            cmd.Parameters.AddWithValue("@numeroDeHistoria", paciente.numeroDeHistoria);
            cmd.Parameters.AddWithValue("@estado", paciente.estado);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
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

        public Paciente BuscarPaciente(int idPersona)
        {
            Paciente paciente = null;
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_buscarPaciente";
            cmd.Parameters.AddWithValue("@idPersona", idPersona);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    paciente = new Paciente();
                    paciente.IdPersona = (int)reader["idPersona"];
                    paciente.dni = (string)reader["dni"];
                    paciente.apellidoPaterno = (string)reader["apellidoPaterno"];
                    paciente.apellidoMaterno = (string)reader["apellidoMaterno"];
                    paciente.nombre = (string)reader["nombre"];
                    paciente.codDepartamento = (string)reader["codDepartamento"];
                    paciente.codProvincia = (string)reader["codProvincia"];
                    paciente.codDistrito = (string)reader["codDistrito"];
                    paciente.numeroDeHistoria = (string)reader["numeroDeHistoria"];
                    paciente.estado = (bool)reader["estado"];
                    
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

            return paciente;
        }
    }
}
