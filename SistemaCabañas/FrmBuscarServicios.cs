using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmBuscarServicios : Form
    {
        ServiciosBL objbl =
new ServiciosBL();
        public DataGridView tabla;
        public FrmBuscarServicios()
        {
            InitializeComponent();
        }

        private void FrmBuscarServicios_Load(object sender, EventArgs e)
        {
            DiseñoTabla(dataGridView1);
            MostrarServicios();
        }

        private void DiseñoTabla
(
    DataGridView tabla
)
        {
            tabla.EnableHeadersVisualStyles = false;

            tabla.ColumnHeadersDefaultCellStyle.BackColor =
                Color.Firebrick;

            tabla.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            tabla.ColumnHeadersDefaultCellStyle.Font =
                new Font
                (
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );

            tabla.DefaultCellStyle.Font =
                new Font
                (
                    "Segoe UI",
                    10
                );

            tabla.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            tabla.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            tabla.RowTemplate.Height = 35;

            tabla.RowHeadersVisible = false;

            tabla.AllowUserToAddRows = false;

            tabla.ReadOnly = true;

            tabla.BorderStyle =
                BorderStyle.None;

            tabla.BackgroundColor =
                Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int idServicio =
    Convert.ToInt32(
    dataGridView1.CurrentRow.Cells[0].Value);

            foreach (DataGridViewRow row
            in tabla.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[0].Value.ToString()
                    == idServicio.ToString())
                    {
                        MessageBox.Show
                        (
                            "Servicio ya agregado"
                        );

                        return;
                    }
                }
            }

            string servicio =
            dataGridView1.CurrentRow.Cells[1].Value.ToString();

            decimal precio =
            Convert.ToDecimal(
            dataGridView1.CurrentRow.Cells[2].Value);

            int cantidad =
            Convert.ToInt32(
            numericUpDown1.Value);

            if (cantidad <= 0)
            {
                MessageBox.Show
                (
                    "Ingrese cantidad válida"
                );

                return;
            }

            decimal subtotal =
            precio * cantidad;

            tabla.Rows.Add
            (
                idServicio,
                servicio,
                precio,
                cantidad,
                subtotal
            );

            numericUpDown1.Value = 0;
        }

        public void MostrarServicios()
        {
           dataGridView1.DataSource =
            objbl.MostrarServicios();

            dataGridView1.Columns[0].Visible =
            false;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
