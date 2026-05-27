using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class TiposHabitacionesBL
    {
        TiposHabitacionesDAL objdal =
            new TiposHabitacionesDAL();

        public DataTable MostrarTiposHabitaciones()
        {
            return objdal.MostrarTiposHabitaciones();
        }

        public void InsertarTipoHabitacion
        (
            E_TiposHabitaciones obj
        )
        {
            objdal.InsertarTipoHabitacion(obj);
        }

        public void EditarTipoHabitacion
        (
            E_TiposHabitaciones obj
        )
        {
            objdal.EditarTipoHabitacion(obj);
        }

        public void EliminarTipoHabitacion
        (
            int id
        )
        {
            objdal.EliminarTipoHabitacion(id);
        }

        public DataTable BuscarTipoHabitacion
        (
            string buscar
        )
        {
            return objdal.BuscarTipoHabitacion(buscar);
        }

        public DataTable MostrarTiposHabitaciones2()
        {
            return objdal.MostrarTiposHabitaciones2();
        }

        public DataTable MostrarServiciosVisitante2()
        {
            return objdal.MostrarServiciosVisitante2();
        }
    }
}
