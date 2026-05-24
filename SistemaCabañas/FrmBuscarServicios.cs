using System;
using CapaNegocio;
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

            MostrarServicios();
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
