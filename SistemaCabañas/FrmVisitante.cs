using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmVisitante : Form
    {
        TiposHabitacionesBL objHabitacion =
new TiposHabitacionesBL();

        TiposHabitacionesBL objServicio =
        new TiposHabitacionesBL();
        public FrmVisitante()
        {
            InitializeComponent();
        }

        private void FrmVisitante_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
        objServicio
        .MostrarServiciosVisitante2();

            dataGridView2.DataSource =
                objHabitacion
                .MostrarTiposHabitaciones2();

            DiseñoTablas();
        }


        private void DiseñoTablas()
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
                Color.Firebrick;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView1.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dataGridView1.RowTemplate.Height = 30;

            dataGridView2.EnableHeadersVisualStyles = false;

            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor =
                Color.Firebrick;

            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dataGridView2.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dataGridView2.RowTemplate.Height = 30;

            dataGridView1.AutoSizeColumnsMode =
    DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.ReadOnly = true;

            dataGridView1.BorderStyle =
                BorderStyle.None;

            dataGridView1.BackgroundColor =
                Color.White;

            dataGridView1.RowHeadersVisible = false;



            dataGridView2.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView2.ReadOnly = true;

            dataGridView2.BorderStyle =
                BorderStyle.None;

            dataGridView2.BackgroundColor =
                Color.White;

            dataGridView2.RowHeadersVisible = false;

            this.BackColor = Color.WhiteSmoke;

            this.WindowState =
    FormWindowState.Maximized;
        }
    }
}
