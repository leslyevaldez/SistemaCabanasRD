using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class PagosBL
    {
        PagosDAL objdal = new PagosDAL();

        public DataTable MostrarPagos()
        {
            return objdal.MostrarPagos();
        }

        public DataTable MostrarAlquileres()
        {
            return objdal.MostrarAlquileres();
        }

        public void InsertarPago(E_Pagos obj)
        {
            objdal.InsertarPago(obj);
        }

        public void EditarPago(E_Pagos obj)
        {
            objdal.EditarPago(obj);
        }

        public void EliminarPago(int id)
        {
            objdal.EliminarPago(id);
        }

        public DataTable BuscarAlquiler(string buscar)
        {
            return objdal.BuscarAlquiler(buscar);
        }
    }
}