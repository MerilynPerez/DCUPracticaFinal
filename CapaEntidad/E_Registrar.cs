using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class E_Registrar
    {
       
        public int IdAu { get; set; }
        public int IdEd { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public string Motivo { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }

    }
}
