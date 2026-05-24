using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ServiciosBL
    {
        ServiciosDAL objdal =
            new ServiciosDAL();

        public DataTable MostrarServicios()
        {
            return objdal.MostrarServicios();
        }

        public void InsertarServicio(E_Servicios obj)
        {
            objdal.InsertarServicio(obj);
        }

        public void EditarServicio(E_Servicios obj)
        {
            objdal.EditarServicio(obj);
        }

        public void EliminarServicio(int id)
        {
            objdal.EliminarServicio(id);
        }

        public DataTable BuscarServicio(string buscar)
        {
            return objdal.BuscarServicio(buscar);
        }
    }
}
