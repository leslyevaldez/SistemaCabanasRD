using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public SqlConnection AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            return cn;
        }

        public SqlConnection CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }

            return cn;
        }
    }
}
