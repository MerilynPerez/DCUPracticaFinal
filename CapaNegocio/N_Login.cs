using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class N_Login
    {
        CD_Login objd = new CD_Login();

        public DataTable N_user(E_Login obje)
        {
            return objd.D_user(obje);
        }

        


    }
}
