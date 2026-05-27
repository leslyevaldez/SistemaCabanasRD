using CapaEntidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class AlquileresDAL
    {
        Conexion cn = new Conexion();

        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarAlquileres()
        {
            DataTable tabla = new DataTable();

            cmd.Connection =
                cn.AbrirConexion();

            cmd.CommandText =
                "SP_MostrarAlquileres";

            cmd.CommandType =
                CommandType.StoredProcedure;

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }

        public int InsertarAlquiler(E_Alquileres obj)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cn.AbrirConexion();

                cmd.CommandText = "SP_InsertarAlquiler";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cliente", obj.Id_Cliente);

                cmd.Parameters.AddWithValue("@Id_Usuario", obj.Id_Usuario);

                cmd.Parameters.AddWithValue("@Id_Habitacion", obj.Id_Habitacion);

                cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);

                cmd.Parameters.AddWithValue("@Hora_Entrada", obj.Hora_Entrada);

                cmd.Parameters.AddWithValue("@Hora_Salida", obj.Hora_Salida);

                cmd.Parameters.AddWithValue("@Total", obj.Total);

                cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                MessageBox.Show(obj.Id_Usuario.ToString());

                int idAlquiler =
                    Convert.ToInt32(cmd.ExecuteScalar());

                cn.CerrarConexion();

                return idAlquiler;
            }
        }
        public void EditarAlquiler
        (
            E_Alquileres obj
        )
        {
            cmd.Connection =
                cn.AbrirConexion();

            cmd.CommandText =
                "SP_EditarAlquiler";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Alquiler",
                obj.Id_Alquiler
            );

            cmd.Parameters.AddWithValue
            (
                "@Id_Cliente",
                obj.Id_Cliente
            );

            cmd.Parameters.AddWithValue
            (
                "@Id_Usuario",
                obj.Id_Usuario
            );

            cmd.Parameters.AddWithValue
            (
                "@Id_Habitacion",
                obj.Id_Habitacion
            );

            cmd.Parameters.AddWithValue
            (
                "@Fecha",
                obj.Fecha
            );

            cmd.Parameters.AddWithValue
            (
                "@Hora_Entrada",
                obj.Hora_Entrada
            );

            cmd.Parameters.AddWithValue
            (
                "@Hora_Salida",
                obj.Hora_Salida
            );

            cmd.Parameters.AddWithValue
            (
                "@Total",
                obj.Total
            );

            cmd.Parameters.AddWithValue
            (
                "@Estado",
                obj.Estado
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EliminarAlquiler(int id)
        {
            cmd.Connection =
                cn.AbrirConexion();

            cmd.CommandText =
                "SP_EliminarAlquiler";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Alquiler",
                id
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public DataTable BuscarAlquiler
        (
            string buscar
        )
        {
            DataTable tabla =
                new DataTable();

            cmd.Connection =
                cn.AbrirConexion();

            cmd.CommandText =
                "SP_BuscarAlquiler";

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

        public void InsertarDetalle
(
int idAlquiler,
int idServicio,
int cantidad,
decimal subtotal
)
        {
            cmd.Connection =
            cn.AbrirConexion();

            cmd.CommandText =
            "SP_InsertarDetalleAlquiler";

            cmd.CommandType =
            CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Alquiler",
                idAlquiler
            );

            cmd.Parameters.AddWithValue
            (
                "@Id_Servicio",
                idServicio
            );

            cmd.Parameters.AddWithValue
            (
                "@Cantidad",
                cantidad
            );

            cmd.Parameters.AddWithValue
            (
                "@SubTotal",
                subtotal
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void FinalizarAlquiler
(int idAlquiler)
        {
            cmd.Connection =
            cn.AbrirConexion();

            cmd.CommandText =
            "SP_FinalizarAlquiler";

            cmd.CommandType =
            CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Alquiler",
                idAlquiler
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public DataTable FacturaCabecera(int idAlquiler)
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
            "SP_FacturaCabecera";

            cmd.CommandType =
            CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Alquiler",
                idAlquiler
            );

            SqlDataReader dr =
            cmd.ExecuteReader();

            tabla.Load(dr);

            cmd.Parameters.Clear();

            cn.CerrarConexion();

            return tabla;
        }

        public DataTable FacturaDetalle(int idAlquiler)
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
            "SP_FacturaDetalle";

            cmd.CommandType =
            CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Alquiler",
                idAlquiler
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