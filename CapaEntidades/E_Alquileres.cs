using System;

namespace CapaEntidades
{
    public class E_Alquileres
    {
        public int Id_Alquiler { get; set; }

        public int Id_Cliente { get; set; }

        public int Id_Usuario { get; set; }

        public int Id_Habitacion { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora_Entrada { get; set; }

        public TimeSpan Hora_Salida { get; set; }

        public decimal Total { get; set; }

        public string Estado { get; set; }
    }
}