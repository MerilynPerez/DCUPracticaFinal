using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_RegisterUser
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);

        public void InsertarUsuarios(E_RegisterUser registrar)
        {
            SqlCommand cmd = new SqlCommand("InsertarUser", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID_AREA", registrar.Id_area);
            cmd.Parameters.AddWithValue("@ID_EMPLEADO", registrar.Id_empleado);
            cmd.Parameters.AddWithValue("@NOMBRE", registrar.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", registrar.Apellido);

            cmd.Parameters.AddWithValue("@NACIMIENTO", registrar.Nacimiento);
            cmd.Parameters.AddWithValue("@USUARIO", registrar.Usuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", registrar.Contraseña);


            cmd.ExecuteNonQuery();

            conexion.Close();

        }


    }
}
