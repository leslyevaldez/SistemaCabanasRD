using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DashboardDAL
    {
        Conexion cn = new Conexion();

        SqlCommand cmd = new SqlCommand();

        public int HabitacionesDisponibles()
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_HabitacionesDisponibles";

            cmd.CommandType =
                CommandType.StoredProcedure;

            int total =
                Convert.ToInt32(cmd.ExecuteScalar());

            cn.CerrarConexion();

            return total;
        }

        public int HabitacionesOcupadas()
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_HabitacionesOcupadas";

            cmd.CommandType =
                CommandType.StoredProcedure;

            int total =
                Convert.ToInt32(cmd.ExecuteScalar());

            cn.CerrarConexion();

            return total;
        }

        public int TotalClientes()
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_TotalClientes";

            cmd.CommandType =
                CommandType.StoredProcedure;

            int total =
                Convert.ToInt32(cmd.ExecuteScalar());

            cn.CerrarConexion();

            return total;
        }

        public int AlquileresActivos()
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_AlquileresActivos";

            cmd.CommandType =
                CommandType.StoredProcedure;

            int total =
                Convert.ToInt32(cmd.ExecuteScalar());

            cn.CerrarConexion();

            return total;
        }

        public decimal GananciasDia()
        {
            cmd.Connection = cn.AbrirConexion();

            cmd.CommandText =
                "SP_GananciasDia";

            cmd.CommandType =
                CommandType.StoredProcedure;

            decimal total =
                Convert.ToDecimal(cmd.ExecuteScalar());

            cn.CerrarConexion();

            return total;
        }

        public DataTable AlquileresRecientes()
        {
            DataTable tabla =
                new DataTable();

            cmd.Connection =
                cn.AbrirConexion();

            cmd.CommandText =
                "SP_AlquileresRecientes";

            cmd.CommandType =
                CommandType.StoredProcedure;

            SqlDataReader dr =
                cmd.ExecuteReader();

            tabla.Load(dr);

            cn.CerrarConexion();

            return tabla;
        }
    }
}