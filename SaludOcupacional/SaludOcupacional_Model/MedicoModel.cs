using SaludOcupacional_Entity;
using SaludOcupacional_Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludOcupacional_Model
{
    public class MedicoModel
    {
        public DataTable ListarMedicos()
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            var dataSet = new DataSet();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_listarMedicos";
            try
            {
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Medicos");
                return dataSet.Tables["Medicos"];
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

        public void InsertarMedico(Medico medico)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_insertarMedico";
            cmd.Parameters.AddWithValue("@dni", medico.dni);
            cmd.Parameters.AddWithValue("@apellidoPaterno", medico.apellidoPaterno);
            cmd.Parameters.AddWithValue("@apellidoMaterno", medico.apellidoMaterno);
            cmd.Parameters.AddWithValue("@nombre", medico.nombre);
            cmd.Parameters.AddWithValue("@nroColegiatura", medico.nroColegiatura);
            cmd.Parameters.AddWithValue("@especialidad", medico.especialidad);
            cmd.Parameters.AddWithValue("@idUbigeo", medico.idUbigeo);
            cmd.Parameters.AddWithValue("@estado", medico.estado);
            SqlParameter paramImagen = new SqlParameter("@foto", SqlDbType.VarBinary, -1);
            if (medico.foto == null)
            {
                paramImagen.Value = DBNull.Value;
            }
            else
            {
                paramImagen.Value = medico.foto;
            }
            cmd.Parameters.Add(paramImagen);

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

        public void EditarMedico(Medico medico)
        {
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_editarMedico";
            cmd.Parameters.AddWithValue("@idPersona", medico.IdPersona);
            cmd.Parameters.AddWithValue("@dni", medico.dni);
            cmd.Parameters.AddWithValue("@apellidoPaterno", medico.apellidoPaterno);
            cmd.Parameters.AddWithValue("@apellidoMaterno", medico.apellidoMaterno);
            cmd.Parameters.AddWithValue("@nombre", medico.nombre);
            cmd.Parameters.AddWithValue("@nroColegiatura", medico.nroColegiatura);
            cmd.Parameters.AddWithValue("@especialidad", medico.especialidad);
            cmd.Parameters.AddWithValue("@idUbigeo", medico.idUbigeo);
            cmd.Parameters.AddWithValue("@estado", medico.estado);
            SqlParameter paramImagen = new SqlParameter("@foto", SqlDbType.VarBinary, -1);
            if (medico.foto == null)
            {
                paramImagen.Value = DBNull.Value;
            }
            else
            {
                paramImagen.Value = medico.foto;
            }
            cmd.Parameters.Add(paramImagen);
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

        public Medico BuscarMedico(int idPersona)
        {
            Medico medico = null;
            string cadenaConexion = new Conexion().ObtenerCadenaConexion();
            var conn = new SqlConnection();
            var cmd = new SqlCommand();
            conn.ConnectionString = cadenaConexion;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_buscarMedico";
            cmd.Parameters.AddWithValue("@idPersona", idPersona);
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    medico = new Medico();
                    medico.dni = (string)reader["dni"];
                    medico.apellidoPaterno = (string)reader["apellidoPaterno"];
                    medico.apellidoMaterno = (string)reader["apellidoMaterno"];
                    medico.nombre = (string)reader["nombre"];
                    medico.nroColegiatura = (int)reader["nroColegiatura"];
                    medico.especialidad = (string)reader["especialidad"];
                    medico.codDepartamento = (string)reader["codDepartamento"];
                    medico.codProvincia = (string)reader["codProvincia"];
                    medico.codDistrito = (string)reader["codDistrito"];
                    medico.estado = (bool)reader["estado"];
                    medico.foto = reader["foto"] != DBNull.Value ? (byte[])reader["foto"] : null;
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
            return medico;
        }

    }

}



