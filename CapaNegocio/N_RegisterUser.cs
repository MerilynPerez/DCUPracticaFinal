using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class N_RegisterUser
    {
        CD_RegisterUser objDato = new CD_RegisterUser();

        public void InsertandoUser(E_RegisterUser obju)
        {
            objDato.InsertarUsuarios(obju);
        }
    }
    

    
}
