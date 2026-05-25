using CapaEntidades;
using CapaNegocio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
namespace SistemaCabañas
{
    public partial class FrmHabitaciones : Form
    {
        bool cargando = false;
        public string NombreUsuario;
        HabitacionesBL objbl = new HabitacionesBL();

        E_Habitaciones objent = new E_Habitaciones();

        int id = 0;


        public string RolUsuario;
        public FrmHabitaciones()
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

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            EstiloBoton(button4);
            EstiloBoton(button6);
            EstiloBoton(button7);
            EstiloBoton(button8);
            EstiloBoton(button12);
            EstiloBoton(button9);
            EstiloBoton(button13);
            EstiloBoton(button5);
            EstiloBoton(button10);
            EstiloBoton(button11);





            lblUsuarioSuperior.Text =
" " + NombreUsuario;
            lblUsuarioSuperior.Text =
         NombreUsuario;
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

            dataGridView1.DefaultCellStyle.SelectionBackColor =
            Color.Firebrick;

            dataGridView1.DefaultCellStyle.SelectionForeColor =
            Color.White;


            dataGridView1.CellBorderStyle =
DataGridViewCellBorderStyle.SingleHorizontal;




            MostrarHabitaciones();

            MostrarTiposHabitaciones();

            dataGridView1.ClearSelection();

            if (RolUsuario == "Empleado")
            {
                button4.Visible = false;
                button5.Visible = false;
                button11.Visible = false;
            }

            if (RolUsuario == "Usuario")
            {
                button4.Visible = false;
                button5.Visible = false;
                button11.Visible = false;
            }



        }

        public void MostrarHabitaciones()
        {
            dataGridView1.DataSource =
                objbl.MostrarHabitaciones();
        }

        public void MostrarTiposHabitaciones()
        {
            comboBox2.DataSource =
                objbl.MostrarTiposHabitaciones();

            comboBox2.DisplayMember = "Nombre";

            comboBox2.ValueMember = "Id_Tipo";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show
                (
                    "Ingrese el número"
                );

                return;
            }


            if (comboBox2.Text == "")
            {
                MessageBox.Show
                (
                    "Seleccione el tipo"
                );

                return;
            }

            try
            {
                objent.Numero =
                    textBox1.Text;


                objent.Id_Tipo =
                    Convert.ToInt32
                    (
                        comboBox2.SelectedValue
                    );

                if (id == 0)
                {
                    objbl.InsertarHabitacion
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Habitación guardada"
                    );
                }
                else
                {
                    objent.Id_Habitacion = id;

                    objbl.EditarHabitacion
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Habitación actualizada"
                    );
                }

                MostrarHabitaciones();

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
                    "Seleccione habitación"
                );

                return;
            }

            DialogResult r =
            MessageBox.Show
            (
                "¿Eliminar habitación?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                objbl.EliminarHabitacion(id);

                MessageBox.Show
                (
                    "Habitación eliminada"
                );

                MostrarHabitaciones();

                Limpiar();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                cargando = true;

                id = Convert.ToInt32
                (
                    dataGridView1.CurrentRow.Cells[0].Value
                );

                textBox1.Text =
                    dataGridView1.CurrentRow.Cells[1].Value.ToString();

                comboBox2.Text =
                    dataGridView1.CurrentRow.Cells[3].Value.ToString();

                cargando = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpiar()
        {
            id = 0;

            textBox1.Clear();

            comboBox2.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();

            frm.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    string estado = e.Value.ToString();

                    if (estado == "Disponible")
                    {
                        e.CellStyle.BackColor = Color.ForestGreen;
                        e.CellStyle.ForeColor = Color.White;
                    }

                    else if (estado == "Ocupada")
                    {
                        e.CellStyle.BackColor = Color.Firebrick;
                        e.CellStyle.ForeColor = Color.White;
                    }

                    else if (estado == "Limpieza")
                    {
                        e.CellStyle.BackColor = Color.Goldenrod;
                        e.CellStyle.ForeColor = Color.Black;
                    }

                    e.CellStyle.Font =
                    new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando)
                return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(
                "Seleccione una habitación");

                return;
            }

            int idHabitacion =
            Convert.ToInt32(
            dataGridView1.CurrentRow.Cells[0].Value);

            objbl.DisponibleHabitacion
            (
                idHabitacion
            );

            MostrarHabitaciones();

            MessageBox.Show(
            "Habitación disponible");
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
    }
}
