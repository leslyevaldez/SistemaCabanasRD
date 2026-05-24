using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ClientesBL
    {
        ClientesDAL objdal =
            new ClientesDAL();

        public DataTable MostrarClientes()
        {
            return objdal.MostrarClientes();
        }

        public void InsertarCliente(E_Clientes obj)
        {
            objdal.InsertarCliente(obj);
        }

        public void EditarCliente(E_Clientes obj)
        {
            objdal.EditarCliente(obj);
        }

        public void EliminarCliente(int id)
        {
            objdal.EliminarCliente(id);
        }

        public DataTable BuscarCliente(string buscar)
        {
            return objdal.BuscarCliente(buscar);
        }
    }
}