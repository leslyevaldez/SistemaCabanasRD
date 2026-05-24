using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class HabitacionesBL
    {
        HabitacionesDAL objdal = new HabitacionesDAL();

        public DataTable MostrarHabitaciones()
        {
            return objdal.MostrarHabitaciones();
        }

        public void InsertarHabitacion(E_Habitaciones obj)
        {
            objdal.InsertarHabitacion(obj);
        }

        public void EditarHabitacion(E_Habitaciones obj)
        {
            objdal.EditarHabitacion(obj);
        }

        public void EliminarHabitacion(int id)
        {
            objdal.EliminarHabitacion(id);
        }

        public DataTable MostrarTiposHabitaciones()
        {
            return objdal.MostrarTiposHabitaciones();
        }

        public void DisponibleHabitacion (int id)
        {
            objdal.DisponibleHabitacion(id);
        }
    }
}