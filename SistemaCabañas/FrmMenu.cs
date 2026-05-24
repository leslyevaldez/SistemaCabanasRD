using CapaNegocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaCabañas
{
    public partial class FrmMenu : Form
    {
        public int IdUsuario;
        public string NombreUsuario;
        public string RolUsuario;

        DashboardBL objbl =
    new DashboardBL();
        public FrmMenu()
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frm = new FrmHabitaciones();

            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPagos frm = new FrmPagos();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FrmServicios frm = new FrmServicios();

            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRoles frm = new FrmRoles();

            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios(); 
            
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmTiposHabitaciones frm = new FrmTiposHabitaciones ();

            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();

            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAlquileres frm =
 new FrmAlquileres();

            frm.IdUsuario = IdUsuario;

            frm.NombreUsuario = NombreUsuario;

            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

            EstiloBoton(button1);
            EstiloBoton(button6);
            EstiloBoton(button7);
            EstiloBoton(button8);
            EstiloBoton(button3);
            EstiloBoton(button4);
            EstiloBoton(button2);
            EstiloBoton(button5);
            EstiloBoton(button10);
            EstiloBoton(button11);




            lblBienvenida.Text =
   "Bienvenido, " + NombreUsuario + " 👋";

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


            lblFecha.Text =
            DateTime.Now.ToString("dd/MM/yyyy");
            CargarDashboard();
            CargarAlquileresRecientes();

            foreach (Button btn in panelMenu.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
                btn.UseVisualStyleBackColor = false;
            }
            btnDashboard.BackColor = Color.Firebrick;
        }

        private void CargarDashboard()
        {
            lblDisponibles.Text =
                objbl.HabitacionesDisponibles().ToString();

            lblOcupadas.Text =
                objbl.HabitacionesOcupadas().ToString();

            lblClientes.Text =
                objbl.TotalClientes().ToString();

            lblAlquileres.Text =
                objbl.AlquileresActivos().ToString();

            lblGanancias.Text =
                "RD$ " +
                objbl.GananciasDia().ToString("N2");
        }
        private void CargarAlquileresRecientes()
        {
            dgvAlquileres.DataSource =
       objbl.AlquileresRecientes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();

            frm.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();

            frm.Show();
          
        }

        private void lblUsuarioSuperior_Click(object sender, EventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

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

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult r =
    MessageBox.Show
    (
        "¿Cerrar sesión?",
        "Sistema",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (r == DialogResult.Yes)
            {
                this.Hide();

                FrmLogin frm =
                new FrmLogin();

                frm.Show();
            }
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r =
   MessageBox.Show
   (
       "¿Salir del sistema?",
       "Confirmar",
       MessageBoxButtons.YesNo
   );

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

