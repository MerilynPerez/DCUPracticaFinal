using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Registrar
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);

        private ConexionBD Conexion = new  ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarEdificios()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarEdificios";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarAulas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarAulas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarRegistros()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarVisitas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarRegistros(E_Registrar registrar)
        {
            SqlCommand cmd = new SqlCommand("InsertarVisitas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDAU", registrar.IdAu);
            cmd.Parameters.AddWithValue("@IDED", registrar.IdEd);
            cmd.Parameters.AddWithValue("@NOMBRE", registrar.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", registrar.Apellido);
            cmd.Parameters.AddWithValue("@MOTIVO", registrar.Motivo);
            cmd.Parameters.AddWithValue("@HORAENTRADA", registrar.HoraEntrada);
            cmd.Parameters.AddWithValue("@HORASALIDA", registrar.HoraSalida);
            cmd.Parameters.AddWithValue("@CARRERA", registrar.Carrera);


            cmd.ExecuteNonQuery();

            conexion.Close();

        }
        /*public void InsertarVisitas(E_Registrar obje)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarVisitas";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDAU", obje.IdAu);
            Comando.Parameters.AddWithValue("@IDED", obje.IdEd);
            Comando.Parameters.AddWithValue("@NOMBRE", obje.Nombre);
            Comando.Parameters.AddWithValue("@APELLIDO", obje.Apellido);
            Comando.Parameters.AddWithValue("@MOTIVO", obje.Motivo);
            Comando.Parameters.AddWithValue("@HORAENTRADA", obje.HoraEntrada);
            Comando.Parameters.AddWithValue("@HORASALIDA", obje.HoraSalida);
            Comando.Parameters.AddWithValue("@CARRERA", obje.Carrera);

            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            
        }*/
    }
}
