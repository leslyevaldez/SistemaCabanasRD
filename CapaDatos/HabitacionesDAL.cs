using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class HabitacionesDAL
    {
        Conexion cn = new Conexion();

        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarHabitaciones()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText = "SP_MostrarHabitaciones";

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }

        public void InsertarHabitacion(E_Habitaciones obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText = "SP_InsertarHabitacion";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Numero", obj.Numero);
            cmd.Parameters.AddWithValue("@Id_Tipo", obj.Id_Tipo);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EditarHabitacion(E_Habitaciones obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText = "SP_EditarHabitacion";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Habitacion", obj.Id_Habitacion);
            cmd.Parameters.AddWithValue("@Numero", obj.Numero);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
            cmd.Parameters.AddWithValue("@Id_Tipo", obj.Id_Tipo);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EliminarHabitacion(int id)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText = "SP_EliminarHabitacion";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Habitacion", id);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public DataTable MostrarTiposHabitaciones()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText = "SP_MostrarTiposHabitaciones";

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }

        public void DisponibleHabitacion
(
    int id
)
        {
            cmd.Connection =
                cn.AbrirConexion();

            cmd.CommandText =
                "SP_DisponibleHabitacion";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Habitacion",
                id
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

    }
}