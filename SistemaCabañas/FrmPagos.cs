using CapaEntidades;
using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmPagos : Form
    {
        PagosBL objbl = new PagosBL();

        AlquileresBL objAlquiler =
new AlquileresBL();

        E_Pagos objent = new E_Pagos();

        int id = 0;
       public int idAlquilerSeleccionado = 0;
        public string NombreUsuario;
        public string RolUsuario;
        public string MetodoPago;
        public int IdAlquilerRecibido;

        public string TotalRecibido;
        public FrmPagos()
        {
            InitializeComponent();
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
        private void FrmPagos_Load(object sender, EventArgs e)
        {
            textBox3.Text = MetodoPago;

            textBox1.Text =
            IdAlquilerRecibido.ToString();

            textBox2.Text =
            TotalRecibido;

            MostrarPagos();
            DiseñoTabla(dataGridView1);

            dataGridView1.ClearSelection();

            if (RolUsuario == "Empleado")
            {
                button4.Visible = false;
                btnConfiguracion.Visible = false;
                btnUsuarios.Visible = false;
            }

            if (RolUsuario == "Recepcionista")
            {
                button4.Visible = false;
                btnConfiguracion.Visible = false;
                btnUsuarios.Visible = false;
            }

        }

        public void MostrarPagos()
        {
            dataGridView1.DataSource =
                objbl.MostrarPagos();

            dataGridView1.ClearSelection();
        }
     

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32
                (
                    dataGridView1.CurrentRow.Cells[0].Value
                );

                textBox1.Text =
                    dataGridView1.CurrentRow.Cells[1].Value.ToString();

                dateTimePicker1.Text =
                    dataGridView1.CurrentRow.Cells[2].Value.ToString();

                textBox2.Text =
                    dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Limpiar()
        {
            textBox1.Clear();

            textBox2.Clear();

            id = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBuscarAlquiler frm =
    new FrmBuscarAlquiler();

            frm.ShowDialog();

            idAlquilerSeleccionado =
            frm.IdAlquiler;

            textBox1.Text =
            frm.IdAlquiler.ToString();

            textBox2.Text =
            frm.Total.ToString("N2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show
                (
                    "Seleccione un alquiler"
                );

                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show
                (
                    "Ingrese el monto"
                );

                return;
            }

            decimal monto;

            if (!decimal.TryParse
            (
                textBox2.Text,
                out monto
            ))
            {
                MessageBox.Show
                (
                    "Monto inválido"
                );

                return;
            }

            try
            {
                objent.Id_Alquiler =
                    Convert.ToInt32
                    (
                        textBox1.Text
                    );

                objent.Fecha =
                    dateTimePicker1.Value;

                objent.Monto = monto;

                objent.Metodo_Pago =
                textBox3.Text;


                if (id == 0)
                {
                    objbl.InsertarPago
                    (
                        objent
                    );

                    objAlquiler.FinalizarAlquiler
                    (
                        Convert.ToInt32(textBox1.Text)
                    );

                    MessageBox.Show
                    (
                        "Pago guardado"
                    );

                    FrmFactura frm =
                    new FrmFactura();

                    frm.dtCabecera =
                    objAlquiler.FacturaCabecera
                    (
                        Convert.ToInt32(textBox1.Text)
                    );

                    frm.dtDetalle =
                    objAlquiler.FacturaDetalle
                    (
                        Convert.ToInt32(textBox1.Text)
                    );

                    frm.ShowDialog();
                }
                else
                {
                    objent.Id_Pago = id;

                    objbl.EditarPago
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Pago actualizado"
                    );
                }

                MostrarPagos();

                dataGridView1.ClearSelection();

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if
   (
       !char.IsDigit(e.KeyChar)
       &&
       e.KeyChar != '.'
       &&
       e.KeyChar != (char)8
   )
            {
                e.Handled = true;

                MessageBox.Show
                (
                    "Solo números"
                );
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;

            dataGridView1.AllowUserToAddRows = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();

            frm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();

            frm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();

            frm.Show();
        }

        private void btnTiposHabitaciones_Click(object sender, EventArgs e)
        {
            FrmTiposHabitaciones frm = new FrmTiposHabitaciones();

            frm.Show();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frm = new FrmHabitaciones();

            frm.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            FrmServicios frm = new FrmServicios();

            frm.Show();
        }

        private void btnAlquileres_Click(object sender, EventArgs e)
        {
            FrmAlquileres frm = new FrmAlquileres();
            frm.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FrmPagos frm = new FrmPagos();

            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();

            frm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmRoles frm = new FrmRoles();

            frm.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frm = new FrmConfiguracion();

            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();

            frm.Show();
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show
                    (
                        "Seleccione un alquiler"
                    );

                    return;
                }

                int idAlquiler =
                Convert.ToInt32
                (
                    textBox1.Text
                );

                DataTable dtCabecera =
                objAlquiler.FacturaCabecera
                (
                    idAlquiler
                );

                DataTable dtDetalle =
                objAlquiler.FacturaDetalle
                (
                    idAlquiler
                );

                FrmFactura frm =
                new FrmFactura();

                frm.dtCabecera =
                dtCabecera;

                frm.dtDetalle =
                dtDetalle;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
