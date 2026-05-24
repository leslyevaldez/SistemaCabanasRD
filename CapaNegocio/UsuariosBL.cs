using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class UsuariosBL
    {
        UsuariosDAL objdal =
            new UsuariosDAL();

        public DataTable MostrarUsuarios()
        {
            return objdal.MostrarUsuarios();
        }

        public DataTable MostrarRoles()
        {
            return objdal.MostrarRoles();
        }

        public void InsertarUsuario(E_Usuarios obj)
        {
            objdal.InsertarUsuario(obj);
        }

        public void EditarUsuario(E_Usuarios obj)
        {
            objdal.EditarUsuario(obj);
        }

        public void EliminarUsuario(int id)
        {
            objdal.EliminarUsuario(id);
        }

        public DataTable BuscarUsuario(string buscar)
        {
            return objdal.BuscarUsuario(buscar);
        }

        public DataTable Login
(
    string usuario,
    string contraseña
)
        {
            return objdal.Login
            (
                usuario,
                contraseña
            );
        }
    }
}