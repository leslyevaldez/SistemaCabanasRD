using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class DashboardBL
    {
        DashboardDAL objdal =
            new DashboardDAL();

        public int HabitacionesDisponibles()
        {
            return objdal.HabitacionesDisponibles();
        }

        public int HabitacionesOcupadas()
        {
            return objdal.HabitacionesOcupadas();
        }

        public int TotalClientes()
        {
            return objdal.TotalClientes();
        }

        public int AlquileresActivos()
        {
            return objdal.AlquileresActivos();
        }

        public decimal GananciasDia()
        {
            return objdal.GananciasDia();
        }

        public DataTable AlquileresRecientes()
        {
            return objdal.AlquileresRecientes();
        }
    }
}