using CapaNegocio;
using System;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmBuscarAlquiler : Form
    {
        PagosBL objbl = new PagosBL();

        public string MetodoPago { get; set; }
        public int IdAlquiler { get; set; }

        public decimal Total { get; set; }
        public FrmBuscarAlquiler()
        {
            InitializeComponent();
        }

        private void FrmBuscarAlquiler_Load(object sender, EventArgs e)
        {
            MostrarAlquileres();

            dataGridView1.ClearSelection();

            dataGridView1.ReadOnly = true;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;


        }

        public void MostrarAlquileres()
        {
            dataGridView1.DataSource =
                objbl.MostrarAlquileres();

            dataGridView1.Columns[0].Visible =
          false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
       objbl.BuscarAlquiler
       (
           textBox1.Text
       );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IdAlquiler =
Convert.ToInt32
(
    dataGridView1.CurrentRow.Cells[0].Value
);

            Total =
            Convert.ToDecimal
            (
                dataGridView1.CurrentRow.Cells["Total"].Value
            );

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
                objbl.BuscarAlquiler
                (
                    textBox1.Text
                );
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdAlquiler =
    Convert.ToInt32
    (
        dataGridView1.CurrentRow.Cells[0].Value
    );

            Total =
            Convert.ToDecimal
            (
                dataGridView1.CurrentRow.Cells["Total"].Value
            );

            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
