using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class N_Registrar
    {
        CD_Registrar objDato = new CD_Registrar();
        

        public void InsertandoRegistros(E_Registrar registrar)
        {
            objDato.InsertarRegistros(registrar);
        }
    }
}
