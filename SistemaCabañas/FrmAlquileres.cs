using CapaEntidades;
using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;



namespace SistemaCabañas
{
    public partial class FrmAlquileres : Form
    {
        AlquileresBL objbl =
      new AlquileresBL();

        E_Alquileres objent =
            new E_Alquileres();

        int id = 0;

        public int IdCliente;

        public int IdUsuario;

        public int IdHabitacion;


        decimal precioHabitacion = 0;

        public string NombreUsuario;
        public string RolUsuario;
        public FrmAlquileres()
        {
            InitializeComponent();
            button8.Enabled = false;
        }

        private void EstiloBoton(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;

            boton.BackColor = Color.Transparent;
            boton.ForeColor = Color.White;

            boton.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            boton.Height = 55;
            boton.Width = 230;

            boton.TextAlign = ContentAlignment.MiddleLeft;

            boton.Cursor = Cursors.Hand;

            boton.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            boton.FlatAppearance.MouseDownBackColor = Color.DarkRed;
        }
        private void CentrarPanel()
        {
            panelContenido.Left = (this.ClientSize.Width - panelContenido.Width) / 2;
            panelContenido.Top = (this.ClientSize.Height - panelContenido.Height) / 2;
        }
        private void FrmAlquileres_Load(object sender, EventArgs e)
        {
      


            dataGridView2.EnableHeadersVisualStyles = false;

            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Firebrick;

            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;




            comboBoxMetodoPago.Items.Add("Efectivo");
            comboBoxMetodoPago.Items.Add("Tarjeta");
            comboBoxMetodoPago.Items.Add("Transferencia");

            comboBoxMetodoPago.SelectedIndex = 0;
            comboBox1.Items.Add("Activo");

            comboBox1.Items.Add("Finalizado");

            dataGridView2.Columns.Add
            (
                "IdServicio",
                "IdServicio"
            );

            dataGridView2.Columns.Add
            (
                "Servicio",
                "Servicio"
            );

            dataGridView2.Columns.Add
            (
                "Precio",
                "Precio"
            );

            dataGridView2.Columns.Add
           (
               "Cantidad",
               "Cantidad"
           );

             dataGridView2.Columns.Add
            (
                "SubTotal",
                "SubTotal"
            );

            dataGridView2.Columns["Precio"]
.DefaultCellStyle.Format = "N2";

            dataGridView2.Columns["SubTotal"]
            .DefaultCellStyle.Format = "N2";

            dataGridView2.Columns[1].Width = 120;

            dataGridView2.Columns[2].Width = 80;

            dataGridView2.Columns[3].Width = 80;

            dataGridView2.Columns[4].Width = 100;

            dataGridView2.Columns[0].Visible =
                false;

            comboBox1.SelectedIndex = -1;


            dataGridView2.ClearSelection();


            if (RolUsuario == "Empleado")
            {
                button4.Visible = false;
                button5.Visible = false;
                btnReportes.Visible = true;
            }

            if (RolUsuario == "Usuario")
            {
                button4.Visible = false;
                button5.Visible = false;
                btnReportes.Visible = true;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frm =
        new FrmBuscarCliente();

            frm.ShowDialog();

            IdCliente =
                frm.IdCliente;

            textBox1.Text =
                frm.Cliente;
        }


        private void button3_Click(object sender, EventArgs e)
        {

            FrmBuscarHabitacion frm =
                new FrmBuscarHabitacion();

            frm.ShowDialog();

            IdHabitacion =
                frm.IdHabitacion;

            textBox3.Text =
                frm.Habitacion;

            precioHabitacion =
                frm.Precio;
        }

         private void button4_Click(object sender, EventArgs e)
         {

            FrmBuscarServicios frm =
  new FrmBuscarServicios();

            frm.tabla = dataGridView2;

            frm.ShowDialog();

            CalcularTotal();
        }

        public void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row
            in dataGridView2.Rows)
            {
                if (row.Cells["SubTotal"].Value != null)
                {
                    total += Convert.ToDecimal
                    (
                        row.Cells["SubTotal"].Value
                    );
                }
            }

            total += precioHabitacion;

            textBox4.Text =
            total.ToString("N2");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show
                    (
                        "Seleccione cliente"
                    );

                    return;
                }

                if (textBox3.Text == "")
                {
                    MessageBox.Show
                    (
                        "Seleccione habitación"
                    );

                    return;
                }

                if (textBox4.Text == "")
                {
                    MessageBox.Show
                    (
                        "Agregue servicios"
                    );

                    return;
                }

                if (comboBox1.Text == "")
                {
                    MessageBox.Show
                    (
                        "Seleccione estado"
                    );

                    return;
                }

                if (textBox4.Text == "")
                {
                    MessageBox.Show("Calcule el total");
                    return;
                }

                if
(
    dateTimePicker3.Value
    <=
    dateTimePicker2.Value
)
                {
                    MessageBox.Show
                    (
                        "La hora salida debe ser mayor"
                    );

                    return;
                }

                objent.Id_Cliente =
     IdCliente;

                objent.Id_Usuario =
    IdUsuario;
                
                objent.Id_Habitacion =
      IdHabitacion;

                objent.Fecha =
                    dateTimePicker1.Value;

                objent.Hora_Entrada =
                    dateTimePicker2.Value.TimeOfDay;

                objent.Hora_Salida =
                    dateTimePicker3.Value.TimeOfDay;

                objent.Total =
                    Convert.ToDecimal
                    (
                        textBox4.Text
                    );

                objent.Estado =
                    comboBox1.Text;

                if (id == 0)
                {
                    int idAlquiler =
 objbl.InsertarAlquiler
 (
     objent
 );

                    foreach (DataGridViewRow row
                    in dataGridView2.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            int idServicio =
                            Convert.ToInt32
                            (
                                row.Cells["IdServicio"].Value
                            );

                            int cantidad =
                            Convert.ToInt32
                            (
                                row.Cells["Cantidad"].Value
                            );

                            decimal subtotal =
                            Convert.ToDecimal
                            (
                                row.Cells["SubTotal"].Value
                            );

                            objbl.InsertarDetalle
                            (
                                idAlquiler,
                                idServicio,
                                cantidad,
                                subtotal
                            );
                        }
                    }

                    MessageBox.Show
                    (
                        "Alquiler guardado"
                    );
                    button8.Enabled = true;
                }
                else
                {
                    objent.Id_Alquiler = id;

                    objbl.EditarAlquiler
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Alquiler actualizado"
                    );
                }

            Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (comboBoxMetodoPago.Text == "")
            {
                MessageBox.Show(
                "Seleccione método de pago");

                return;
            }
        }
        public void Limpiar()
        {
            textBox1.Clear();

            textBox3.Clear();

            textBox4.Clear();

            comboBox1.SelectedIndex = -1;

            dataGridView2.Rows.Clear();

            id = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show
                (
                    "Agregue servicios"
                );

                return;
            }

            FrmFactura frm = new FrmFactura();

            // =====================
            // CABECERA
            // =====================
            DataTable dtCabecera = new DataTable();

            dtCabecera.Columns.Add("FacturaNo");
            dtCabecera.Columns.Add("Cliente");
            dtCabecera.Columns.Add("Habitacion");
            dtCabecera.Columns.Add("Fecha");
            dtCabecera.Columns.Add("HoraEntrada");
            dtCabecera.Columns.Add("HoraSalida");
            dtCabecera.Columns.Add("Estado");
            dtCabecera.Columns.Add("Empleado");
            dtCabecera.Columns.Add("MetodoPago");
            dtCabecera.Columns.Add("Total");

            string numeroFactura =
            DateTime.Now.ToString("yyyyMMddHHmmss");


            dtCabecera.Rows.Add(
               numeroFactura,
                textBox1.Text,
               textBox3.Text,
               dateTimePicker1.Text,
                dateTimePicker2.Text,
                dateTimePicker3.Text,
               comboBox1.Text,
                Sesion.Usuario,
               comboBoxMetodoPago.Text,
               textBox4.Text
            );

            // =====================
            // DETALLE
            // =====================
            DataTable dtDetalle = new DataTable();

            dtDetalle.Columns.Add("Servicio");
            dtDetalle.Columns.Add("Precio");
            dtDetalle.Columns.Add("Cantidad");
            dtDetalle.Columns.Add("Subtotal");

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["Servicio"].Value != null)
                {
                    decimal precio =
                        Convert.ToDecimal(row.Cells["Precio"].Value);

                    int cantidad =
                        Convert.ToInt32(row.Cells["Cantidad"].Value);

                    decimal subtotal = precio * cantidad;

                    dtDetalle.Rows.Add(
                        row.Cells["Servicio"].Value.ToString(),
                        precio,
                        cantidad,
                        subtotal
                    );
                }
            }

            // ENVIAR DATOS AL REPORTE
            frm.dtCabecera = dtCabecera;
            frm.dtDetalle = dtDetalle;

            frm.ShowDialog();
            Limpiar();

            button8.Enabled = false;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradiente = new LinearGradientBrush(
       panelMenu.ClientRectangle,
       Color.FromArgb(15, 15, 15),
       Color.FromArgb(45, 45, 45),
       90F);

            e.Graphics.FillRectangle(gradiente, panelMenu.ClientRectangle);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();

            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmTiposHabitaciones frm = new FrmTiposHabitaciones();

            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frm = new FrmHabitaciones();

            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();

            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmAlquileres frm = new FrmAlquileres();

            frm.IdUsuario = this.IdUsuario;

            frm.NombreUsuario = this.NombreUsuario;

            frm.RolUsuario = this.RolUsuario;

            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FrmServicios frm = new FrmServicios();

            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FrmRoles frm = new FrmRoles();

            frm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FrmPagos frm = new FrmPagos();

            frm.MetodoPago =
            comboBoxMetodoPago.Text;

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAlquileres_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();

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
    }
}
