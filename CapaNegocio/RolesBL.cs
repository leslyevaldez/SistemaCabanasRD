using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class RolesBL
    {
        RolesDAL objdal =
            new RolesDAL();

        public DataTable MostrarRoles()
        {
            return objdal.MostrarRoles();
        }

        public void InsertarRol(E_Roles obj)
        {
            objdal.InsertarRol(obj);
        }

        public void EditarRol(E_Roles obj)
        {
            objdal.EditarRol(obj);
        }

        public void EliminarRol(int id)
        {
            objdal.EliminarRol(id);
        }

        public DataTable BuscarRol(string buscar)
        {
            return objdal.BuscarRol(buscar);
        }
    }
}