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

    }
}
