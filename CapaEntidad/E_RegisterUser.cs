using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class E_RegisterUser
    {
        private string id_area;
        private string id_empleado;
        private string nombre;
        private string apellido;
        private string nacimiento;
        private string usuario;
        private string contraseña;

        public string Id_area { get => id_area; set => id_area = value; }
        public string Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nacimiento { get => nacimiento; set => nacimiento = value; }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

    }
}
