using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmBuscarHabitacion : Form
    {
        HabitacionesBL objbl =
    new HabitacionesBL();

        public int IdHabitacion;

        public string Habitacion;

        public decimal Precio;

        public FrmBuscarHabitacion()
        {
            InitializeComponent();
        }

        private void FrmBuscarHabitacion_Load(object sender, EventArgs e)
        {
            DiseñoTabla(dataGridView1);
            MostrarHabitaciones();

            dataGridView1.ClearSelection();

            dataGridView1.ReadOnly = true;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
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
        public void MostrarHabitaciones()
        {
            dataGridView1.DataSource =
                objbl.MostrarHabitaciones();

            dataGridView1.Columns[0].Visible =
                false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string estado =
                    dataGridView1.SelectedRows[0]
                    .Cells["Estado"]
                    .Value
                    .ToString();

                if
                (
                    estado == "Ocupada"
                    ||
                    estado == "Limpieza"
                )
                {
                    MessageBox.Show
                    (
                        "No puede seleccionar esta habitación"
                    );

                    return;
                }

                IdHabitacion =
                    Convert.ToInt32
                    (
                        dataGridView1.SelectedRows[0]
                        .Cells[0]
                        .Value
                    );

                Habitacion =
                    dataGridView1.SelectedRows[0]
                    .Cells[1]
                    .Value
                    .ToString();

                Precio =
                    Convert.ToDecimal
                    (
                        dataGridView1.SelectedRows[0]
                        .Cells["Precio"]
                        .Value
                    );

                this.Close();
            }
            else
            {
                MessageBox.Show
                (
                    "Seleccione una habitación"
                );
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
   (
       dataGridView1.Columns[e.ColumnIndex]
       .Name == "Estado"
   )
            {
                if (e.Value != null)
                {
                    var estado =
                    e.Value.ToString();

                    if (estado == "Disponible")
                    {
                        dataGridView1.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex]
                        .Style.BackColor =
                        Color.LightGreen;

                        dataGridView1.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex]
                        .Style.ForeColor =
                        Color.Black;
                    }

                    else if (estado == "Ocupada")
                    {
                        dataGridView1.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex]
                        .Style.BackColor =
                        Color.IndianRed;

                        dataGridView1.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex]
                        .Style.ForeColor =
                        Color.White;
                    }

                    else if (estado == "Limpieza")
                    {
                        dataGridView1.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex]
                        .Style.BackColor =
                        Color.Khaki;

                        dataGridView1.Rows[e.RowIndex]
                        .Cells[e.ColumnIndex]
                        .Style.ForeColor =
                        Color.Black;
                    }
                }
            }
        }
    }
}