using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            reportViewer1.LocalReport.ReportPath =
               @"C:\proyecto2\Sistema2\SistemaCabañas\Reportes\FacturaAlquiler.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rdsCabecera =
                new ReportDataSource("DataSet1", dtCabecera);

            ReportDataSource rdsDetalle =
                new ReportDataSource("DataSet2", dtDetalle);

            reportViewer1.LocalReport.DataSources.Add(rdsCabecera);
            reportViewer1.LocalReport.DataSources.Add(rdsDetalle);

            reportViewer1.RefreshReport();
        }
    }
}
