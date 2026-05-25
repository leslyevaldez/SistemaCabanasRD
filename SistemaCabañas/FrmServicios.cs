using CapaEntidades;
using CapaNegocio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmServicios : Form
    {
        ServiciosBL objbl = new ServiciosBL();

        E_Servicios objent =
            new E_Servicios();

        int id = 0;

        public string NombreUsuario;
        public string RolUsuario;
        public FrmServicios()
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

        private void FrmServicios_Load(object sender, EventArgs e)
        {
         









            try
            {
                MostrarServicios();

                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            if (RolUsuario == "Empleado")
            {
               
                btnConfiguracion.Visible = false;
                iconButton2.Visible = false;
            }

            if (RolUsuario == "Usuario")
            {
              
                btnConfiguracion.Visible = false;
                iconButton2.Visible = false;
            }

        }

        public void MostrarServicios()
        {
            dataGridView1.DataSource =
                objbl.MostrarServicios();
        }

        public void Limpiar()
        {
            textBox1.Clear();

            textBox2.Clear();

            textBox3.Clear();

            id = 0;
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
                    "Ingrese el precio"
                );

                return;
            }

            decimal precio;

            if (!decimal.TryParse
            (
                textBox2.Text,
                out precio
            ))
            {
                MessageBox.Show
                (
                    "Precio inválido"
                );

                return;
            }

            try
            {
                objent.Nombre =
                    textBox1.Text;

                objent.Precio = precio;

                if (id == 0)
                {
                    objbl.InsertarServicio
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Servicio guardado"
                    );
                }
                else
                {
                    objent.Id_Servicio = id;

                    objbl.EditarServicio
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Servicio actualizado"
                    );
                }

                MostrarServicios();

                dataGridView1.ClearSelection();

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
                    "Seleccione servicio"
                );

                return;
            }

            DialogResult r =
            MessageBox.Show
            (
                "¿Eliminar servicio?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                objbl.EliminarServicio(id);

                MessageBox.Show
                (
                    "Servicio eliminado"
                );

                MostrarServicios();

                Limpiar();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Limpiar();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource =
                    objbl.BuscarServicio
                    (
                        textBox3.Text
                    );

                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();

            frm.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();

            frm.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frm = new FrmConfiguracion();

            frm.Show();
        }
    }
}
