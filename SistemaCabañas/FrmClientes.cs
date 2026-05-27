using CapaEntidades;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmClientes : Form
    {
        ClientesBL objbl =
    new ClientesBL();

        E_Clientes objent =
            new E_Clientes();

        int id = 0;
        public string NombreUsuario;
        public string RolUsuario;
        public FrmClientes()
        {
            InitializeComponent();
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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            foreach (Button btn in panelMenu.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
                btn.UseVisualStyleBackColor = false;
            }
            btnDashboard.BackColor = Color.Firebrick;





            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.None;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
            Color.Firebrick;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.ColumnHeadersHeight = 35;

            dataGridView1.DefaultCellStyle.Font =
new Font("Segoe UI", 10);

            dataGridView1.RowTemplate.Height = 30;

            dataGridView1.DefaultCellStyle.SelectionBackColor =
            Color.Firebrick;

            dataGridView1.DefaultCellStyle.SelectionForeColor =
            Color.White;




            try
            {
                DiseñoTabla(dataGridView1);
                MostrarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (RolUsuario == "Empleado")
            {
                btnConfiguracion.Visible = false;
                btnUsuarios.Visible = false;
            }

            if (RolUsuario == "Recepcionista")
            {
                btnConfiguracion.Visible = false;
                btnUsuarios.Visible = false;
            }

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
        public void MostrarClientes()
        {
            dataGridView1.DataSource =
                objbl.MostrarClientes();

            dataGridView1.ClearSelection();
        }

        public void Limpiar()
        {
            textBox1.Clear();

            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

            id = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if
   (
       !char.IsLetter(e.KeyChar)
       &&
       !char.IsWhiteSpace(e.KeyChar)
       &&
       e.KeyChar != (char)8
   )
            {
                e.Handled = true;

                MessageBox.Show
                (
                    "Solo letras"
                );
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if
   (
       !char.IsDigit(e.KeyChar)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if
    (
        !char.IsDigit(e.KeyChar)
        &&
        e.KeyChar != '-'
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show
                (
                    "Ingrese el nombre"
                );

                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show
                (
                    "Ingrese el teléfono"
                );

                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show
                (
                    "Ingrese la cédula"
                );

                return;
            }

            try
            {
                objent.Nombre =
                    textBox1.Text;

                objent.Telefono =
                    textBox2.Text;

                objent.Cedula =
                    textBox3.Text;

                if (id == 0)
                {
                    objbl.InsertarCliente
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Cliente guardado"
                    );
                }
                else
                {
                    objent.Id_Cliente = id;

                    objbl.EditarCliente
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Cliente actualizado"
                    );
                }

                MostrarClientes();

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show
                (
                    "Seleccione un cliente"
                );

                return;
            }

            DialogResult r =
            MessageBox.Show
            (
                "¿Desea eliminar este cliente?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                objbl.EliminarCliente(id);

                MessageBox.Show
                (
                    "Cliente eliminado"
                );

                MostrarClientes();

                Limpiar();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource =
                    objbl.BuscarCliente
                    (
                        textBox4.Text
                    );

                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                textBox2.Text =
                    dataGridView1.CurrentRow.Cells[2].Value.ToString();

                textBox3.Text =
                    dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();

            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frm = new FrmHabitaciones();

            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmTiposHabitaciones frm = new FrmTiposHabitaciones();

            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();

            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAlquileres frm = new FrmAlquileres();

            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmServicios frm = new FrmServicios();

            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmRoles frm = new FrmRoles();

            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradiente = new LinearGradientBrush(
        panelMenu.ClientRectangle,
        Color.FromArgb(15, 15, 15),
        Color.FromArgb(45, 45, 45),
        90F);

            e.Graphics.FillRectangle(gradiente, panelMenu.ClientRectangle);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
