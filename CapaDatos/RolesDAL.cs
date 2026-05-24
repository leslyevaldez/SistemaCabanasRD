using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class RolesDAL
    {
        Conexion cn = new Conexion();

        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarRoles()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_MostrarRoles";

            cmd.CommandType =
                CommandType.StoredProcedure;

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }

        public void InsertarRol(E_Roles obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_InsertarRol";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Nombre",
                obj.Nombre
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EditarRol(E_Roles obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EditarRol";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Rol",
                obj.Id_Rol
            );

            cmd.Parameters.AddWithValue
            (
                "@Nombre",
                obj.Nombre
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EliminarRol(int id)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EliminarRol";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Rol",
                id
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public DataTable BuscarRol(string buscar)
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_BuscarRol";

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
    }
}