using CapaDatos;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class PagosDAL
    {
        Conexion cn = new Conexion();

        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarPagos()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText = "SP_MostrarPagos";

            cmd.CommandType =
                CommandType.StoredProcedure;

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }

        public DataTable MostrarAlquileres()
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

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

        public void InsertarPago(E_Pagos obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_InsertarPago";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Alquiler",
                obj.Id_Alquiler
            );

            cmd.Parameters.AddWithValue
            (
                "@Fecha",
                obj.Fecha
            );

            cmd.Parameters.AddWithValue
            (
                "@Monto",
                obj.Monto
            );

            cmd.Parameters.AddWithValue
            (
                "@Metodo_Pago",
                obj.Metodo_Pago
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EditarPago(E_Pagos obj)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EditarPago";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Pago",
                obj.Id_Pago
            );

            cmd.Parameters.AddWithValue
            (
                "@Id_Alquiler",
                obj.Id_Alquiler
            );

            cmd.Parameters.AddWithValue
            (
                "@Fecha",
                obj.Fecha
            );

            cmd.Parameters.AddWithValue
            (
                "@Monto",
                obj.Monto
            );

            cmd.Parameters.AddWithValue
            (
                "@Metodo_Pago",
                obj.Metodo_Pago
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public void EliminarPago(int id)
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_EliminarPago";

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue
            (
                "@Id_Pago",
                id
            );

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            cn.CerrarConexion();
        }

        public DataTable BuscarAlquiler(string buscar)
        {
            DataTable tabla = new DataTable();

            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText = "SP_BuscarAlquiler";

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