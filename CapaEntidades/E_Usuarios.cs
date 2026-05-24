using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Usuarios
    {
        public int Id_Usuario { get; set; }

        public string Nombre { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }

        public int Id_Rol { get; set; }
    }
}