using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Pagos
    {
        public int Id_Pago { get; set; }

        public int Id_Alquiler { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public string Metodo_Pago { get; set; }
    }
}
