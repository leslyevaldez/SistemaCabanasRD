using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace SistemaCabañas
{
    public partial class FrmFactura : Form
    {

        public DataTable dtCabecera;
        public DataTable dtDetalle;
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            dtCabecera.Columns["id_Alquiler"].ColumnName = "FacturaNo";

            dtCabecera.Columns["Cliente"].ColumnName = "Cliente";

            dtCabecera.Columns["Habitacion"].ColumnName = "Habitacion";

            dtCabecera.Columns["TipoHabitacion"].ColumnName = "TipoHabitacion";

            dtCabecera.Columns["Fecha"].ColumnName = "Fecha";

            dtCabecera.Columns["Hora_Entrada"].ColumnName = "Hora_Entrada";

            dtCabecera.Columns["Hora_Salida"].ColumnName = "Hora_Salida";

            dtCabecera.Columns["Total"].ColumnName = "Total";

            dtCabecera.Columns["Estado"].ColumnName = "Estado";

            dtCabecera.Columns["Usuario"].ColumnName = "Usuario";
            this.CenterToScreen();
            foreach (DataColumn col in dtCabecera.Columns)
            {
                MessageBox.Show(col.ColumnName);
            }


            reportViewer1.LocalReport.ReportPath =
            Application.StartupPath +
            @"\Reportes\FacturaAlquiler.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rdsCabecera =
            new ReportDataSource
            (
                "DataSet1",
                dtCabecera
            );

            ReportDataSource rdsDetalle =
            new ReportDataSource
            (
                "DataSet2",
                dtDetalle
            );

            reportViewer1.LocalReport.DataSources.Add(rdsCabecera);

            reportViewer1.LocalReport.DataSources.Add(rdsDetalle);

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
