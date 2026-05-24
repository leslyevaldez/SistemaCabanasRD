using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ServiciosDAL
    {
        Conexion cn = new Conexion();

        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarServicios()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_MostrarServicios";

            cmd.CommandType =
                CommandType.StoredProcedure;

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }

        public void InsertarServicio(E_Servicios obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_InsertarServicio";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Nombre",
                obj.Nombre
            );

            cmd.Parameters.AddWithValue
            (
                "@Precio",
                obj.Precio
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EditarServicio(E_Servicios obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EditarServicio";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Servicio",
                obj.Id_Servicio
            );

            cmd.Parameters.AddWithValue
            (
                "@Nombre",
                obj.Nombre
            );

            cmd.Parameters.AddWithValue
            (
                "@Precio",
                obj.Precio
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EliminarServicio(int id)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EliminarServicio";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Servicio",
                id
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public DataTable BuscarServicio(string buscar)
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_BuscarServicio";

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