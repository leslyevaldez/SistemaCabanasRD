using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace SistemaCabañas
{
    public partial class FrmFactura : Form
    {
        public int IdAlquiler;
        public DataTable dtCabecera;
        public DataTable dtDetalle;
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.ProcessingMode = ProcessingMode.Local;

            string ruta = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Reportes",
                "FacturaAlquiler2.rdlc"
            );

            reportViewer1.LocalReport.ReportPath = ruta;

            AlquileresBL bl = new AlquileresBL();

            DataTable cabecera = bl.ObtenerCabeceraFactura(IdAlquiler);
            DataTable detalle = bl.ObtenerDetalleFactura(IdAlquiler);

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("CabeceraFactura2", cabecera));

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DetalleFactura2", detalle));

            reportViewer1.RefreshReport();
        }
    }
}
