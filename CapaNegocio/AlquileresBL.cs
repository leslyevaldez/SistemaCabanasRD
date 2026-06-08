using CapaDatos;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaNegocio
{
    public class AlquileresBL
    {
        AlquileresDAL objdal =
            new AlquileresDAL();

        public DataTable MostrarAlquileres()
        {
            return objdal.MostrarAlquileres();
        }
        public int InsertarAlquiler
        (E_Alquileres obj)
        {
            return objdal.InsertarAlquiler(obj);
        }

        public void InsertarDetalle
(
int idAlquiler,
int idServicio,
int cantidad,
decimal subtotal
)
        {
            objdal.InsertarDetalle
            (
                idAlquiler,
                idServicio,
                cantidad,
                subtotal
            );
        }

        public void EditarAlquiler
        (
            E_Alquileres obj
        )
        {
            objdal.EditarAlquiler(obj);
        }

        public void EliminarAlquiler
        (
            int id
        )
        {
            objdal.EliminarAlquiler(id);
        }

        public DataTable BuscarAlquiler
        (
            string buscar
        )
        {
            return objdal.BuscarAlquiler(buscar);
        }

        public void FinalizarAlquiler
(int idAlquiler)
        {
            objdal.FinalizarAlquiler
            (
                idAlquiler
            );
        }

        public DataTable ObtenerCabeceraFactura(int idAlquiler)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
            {
                string query = @"
SELECT 
    a.Id_Alquiler AS FacturaNo,
    c.Nombre AS Cliente,
    h.Numero AS Habitacion,
    t.Nombre AS TipoHabitacion,
    t.Precio AS PrecioHabitacion,
    a.Fecha,
    CONVERT(VARCHAR(8), a.Hora_Entrada, 108) AS HoraEntrada,
    CONVERT(VARCHAR(8), a.Hora_Salida, 108) AS HoraSalida,
    a.Estado,
    u.Nombre AS Empleado,
    a.Total,
    p.Metodo_Pago
FROM Alquileres a
INNER JOIN Clientes c ON a.Id_Cliente = c.Id_Cliente
INNER JOIN Habitaciones h ON a.Id_Habitacion = h.Id_Habitacion
INNER JOIN Tipos_Habitaciones t ON h.Id_Tipo = t.Id_Tipo
INNER JOIN Usuarios u ON a.Id_Usuario = u.Id_Usuario
LEFT JOIN Pagos p ON p.Id_Alquiler = a.Id_Alquiler
WHERE a.Id_Alquiler = @Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", idAlquiler);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
        public DataTable ObtenerDetalleFactura(int idAlquiler)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
            {
                string query = @"
SELECT 
    s.Nombre AS Servicio,
    s.Precio,
    d.Cantidad,
    d.SubTotal
FROM Detalle_Alquiler d
INNER JOIN Servicios s ON d.Id_Servicio = s.Id_Servicio
WHERE d.Id_Alquiler = @Id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", idAlquiler);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    }
}