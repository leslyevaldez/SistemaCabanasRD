using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

        }

        private void btnClientefrecuente_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
           "Server=LAPTOP-AAMNP1F2;Database=SistemaCabaña;Integrated Security=true");

            SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT
    C.Nombre,
    COUNT(A.Id_Alquiler) AS TotalVisitas
    FROM Clientes C
    INNER JOIN Alquileres A
    ON C.Id_Cliente = A.Id_Cliente
    GROUP BY C.Nombre
    ORDER BY TotalVisitas DESC", cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            reportViewer1.LocalReport.ReportPath =
            @"../../Reportes/RptClientesFrecuentes.rdlc";

            ReportDataSource rds =
            new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
       "Server=LAPTOP-AAMNP1F2;Database=SistemaCabaña;Integrated Security=true");

            SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT
U.Nombre,
COUNT(A.Id_Alquiler) AS TotalAlquileres
FROM Usuarios U
INNER JOIN Alquileres A
ON U.Id_Usuario = A.Id_Usuario
GROUP BY U.Nombre
ORDER BY TotalAlquileres DESC", cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            reportViewer1.LocalReport.ReportPath =
            @"../../Reportes/RptUsuariosFrecuentes.rdlc";

            ReportDataSource rds =
            new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();

            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frm = new FrmHabitaciones();

            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmTiposHabitaciones frm = new FrmTiposHabitaciones();

            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();

            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmAlquileres frm = new FrmAlquileres();

            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmServicios frm = new FrmServicios();

            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmRoles frm = new FrmRoles();

            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmPagos frm = new FrmPagos();

            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();

            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();

            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frm = new FrmConfiguracion();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
"Server=LAPTOP-AAMNP1F2;Database=SistemaCabaña;Integrated Security=true");

            SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT
S.Nombre,
SUM(D.Cantidad) AS TotalConsumido
FROM Servicios S
INNER JOIN Detalle_Alquiler D
ON S.Id_Servicio = D.Id_Servicio
GROUP BY S.Nombre
ORDER BY TotalConsumido DESC", cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            reportViewer1.LocalReport.ReportPath =
            @"../../Reportes/RptServiciosConsumidos.rdlc";

            ReportDataSource rds =
            new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(
"Server=LAPTOP-AAMNP1F2;Database=SistemaCabaña;Integrated Security=true");

            SqlDataAdapter da = new SqlDataAdapter(
            @"SELECT
Fecha,
SUM(Total) AS Ganancias
FROM Alquileres
WHERE Fecha BETWEEN @Desde AND @Hasta
GROUP BY Fecha
ORDER BY Fecha", cn);

            da.SelectCommand.Parameters.AddWithValue
            (
                "@Desde",
                dtDesde.Value.Date
            );

            da.SelectCommand.Parameters.AddWithValue
            (
                "@Hasta",
                dtHasta.Value.Date
            );

            DataTable dt = new DataTable();

            da.Fill(dt);

            reportViewer1.LocalReport.ReportPath =
            @"../../Reportes/RptGananciasFecha.rdlc";

            ReportDataSource rds =
            new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void FrmReportes_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
