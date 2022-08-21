using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Login
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
        
        public DataTable D_user(E_Login obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logeo_ez", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@clave", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        




    }
       
}
