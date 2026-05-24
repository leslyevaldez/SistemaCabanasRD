using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class TiposHabitacionesDAL
    {
        Conexion cn = new Conexion();

        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarTiposHabitaciones()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_MostrarTiposHabitaciones";

            cmd.CommandType =
                CommandType.StoredProcedure;

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }

        public void InsertarTipoHabitacion
        (
            E_TiposHabitaciones obj
        )
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_InsertarTipoHabitacion";

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

            cmd.Parameters.AddWithValue
            (
                "@Descripcion",
                obj.Descripcion
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EditarTipoHabitacion
        (
            E_TiposHabitaciones obj
        )
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EditarTipoHabitacion";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Tipo",
                obj.Id_Tipo
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

            cmd.Parameters.AddWithValue
            (
                "@Descripcion",
                obj.Descripcion
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EliminarTipoHabitacion
        (
            int id
        )
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EliminarTipoHabitacion";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Tipo",
                id
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public DataTable BuscarTipoHabitacion
        (
            string buscar
        )
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_BuscarTipoHabitacion";

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