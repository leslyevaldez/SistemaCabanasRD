using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class AlquileresBL
    {
        AlquileresDAL objdal =
            new AlquileresDAL();

        public DataTable MostrarAlquileres()
        {
            return objdal.MostrarAlquileres();
        }
        public int InsertarAlquiler
        (E_Alquileres obj)
        {
            return objdal.InsertarAlquiler(obj);
        }

        public void InsertarDetalle
(
int idAlquiler,
int idServicio,
int cantidad,
decimal subtotal
)
        {
            objdal.InsertarDetalle
            (
                idAlquiler,
                idServicio,
                cantidad,
                subtotal
            );
        }

        public void EditarAlquiler
        (
            E_Alquileres obj
        )
        {
            objdal.EditarAlquiler(obj);
        }

        public void EliminarAlquiler
        (
            int id
        )
        {
            objdal.EliminarAlquiler(id);
        }

        public DataTable BuscarAlquiler
        (
            string buscar
        )
        {
            return objdal.BuscarAlquiler(buscar);
        }

        public void FinalizarAlquiler
(int idAlquiler)
        {
            objdal.FinalizarAlquiler
            (
                idAlquiler
            );
        }

        public DataTable FacturaCabecera
 (
     int idAlquiler
 )
        {
            return objdal.FacturaCabecera
            (
                idAlquiler
            );
        }

        public DataTable FacturaDetalle
        (
            int idAlquiler
        )
        {
            return objdal.FacturaDetalle
            (
                idAlquiler
            );
        }
    }
}