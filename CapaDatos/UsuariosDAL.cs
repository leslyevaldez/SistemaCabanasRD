using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class UsuariosDAL
    {
        Conexion cn = new Conexion();

        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_MostrarUsuarios";

            cmd.CommandType =
                CommandType.StoredProcedure;

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }

        public DataTable MostrarRoles()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_MostrarRolesCombo";

            cmd.CommandType =
                CommandType.StoredProcedure;

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }

        public void InsertarUsuario(E_Usuarios obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_InsertarUsuario";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Nombre",
                obj.Nombre
            );

            cmd.Parameters.AddWithValue
            (
                "@Usuario",
                obj.Usuario
            );

            cmd.Parameters.AddWithValue
            (
                "@Clave",
                obj.Clave
            );

            cmd.Parameters.AddWithValue
            (
                "@Id_Rol",
                obj.Id_Rol
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EditarUsuario(E_Usuarios obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EditarUsuario";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Usuario",
                obj.Id_Usuario
            );

            cmd.Parameters.AddWithValue
            (
                "@Nombre",
                obj.Nombre
            );

            cmd.Parameters.AddWithValue
            (
                "@Usuario",
                obj.Usuario
            );

            cmd.Parameters.AddWithValue
            (
                "@Clave",
                obj.Clave
            );

            cmd.Parameters.AddWithValue
            (
                "@Id_Rol",
                obj.Id_Rol
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EliminarUsuario(int id)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EliminarUsuario";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Usuario",
                id
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public DataTable BuscarUsuario(string buscar)
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_BuscarUsuario";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Buscar",
                buscar
            );

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cmd.Parameters.Clear();

            cn.CerrarConexion();

            return tabla;
        }

        public DataTable Login
(
    string usuario,
    string contraseña
)
        {
            DataTable tabla =
                new DataTable();

            cmd.Connection =
                cn.AbrirConexion();

            cmd.CommandText =
                "SP_Login";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Usuario",
                usuario
            );

            cmd.Parameters.AddWithValue
            (
                "@Clave",
                contraseña
            );

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cmd.Parameters.Clear();

            cn.CerrarConexion();

            return tabla;
        }
    }
}
