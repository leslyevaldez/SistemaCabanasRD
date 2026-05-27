using CapaEntidades;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmUsuarios : Form
    {
        UsuariosBL objbl =
    new UsuariosBL();

        E_Usuarios objent =
            new E_Usuarios();

        int id = 0;

        public int IdUsuario;

        public string NombreUsuario;

        public string RolUsuario;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                DiseñoTabla(dataGridView1);

                MostrarUsuarios();

                MostrarRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarUsuarios()
        {
            dataGridView1.DataSource =
                objbl.MostrarUsuarios();

            dataGridView1.ClearSelection();
        }

        public void MostrarRoles()
        {
            comboBox1.DataSource =
                objbl.MostrarRoles();

            comboBox1.DisplayMember =
                "Nombre";

            comboBox1.ValueMember =
                "Id_Rol";

            comboBox1.SelectedIndex = -1;
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
        public void Limpiar()
        {
            textBox1.Clear();

            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

            comboBox1.SelectedIndex = -1;

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
                    "Ingrese el usuario"
                );

                return;
            }

            if (textBox3.Text == "")
            {
                MessageBox.Show
                (
                    "Ingrese la clave"
                );

                return;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show
                (
                    "Seleccione el rol"
                );

                return;
            }

            try
            {
                objent.Nombre =
                    textBox1.Text;

                objent.Usuario =
                    textBox2.Text;

                objent.Clave =
                    textBox3.Text;

                objent.Id_Rol =
                    Convert.ToInt32
                    (
                        comboBox1.SelectedValue
                    );

                if (id == 0)
                {
                    objbl.InsertarUsuario
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Usuario guardado"
                    );
                }
                else
                {
                    objent.Id_Usuario = id;

                    objbl.EditarUsuario
                    (
                        objent
                    );

                    MessageBox.Show
                    (
                        "Usuario actualizado"
                    );
                }

                MostrarUsuarios();

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
                    "Seleccione usuario"
                );

                return;
            }

            DialogResult r =
            MessageBox.Show
            (
                "¿Eliminar usuario?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                objbl.EliminarUsuario(id);

                MessageBox.Show
                (
                    "Usuario eliminado"
                );

                MostrarUsuarios();

                Limpiar();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource =
                    objbl.BuscarUsuario
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

                comboBox1.Text =
                    dataGridView1.CurrentRow.Cells[4].Value.ToString();
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

        private void button6_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frm = new FrmHabitaciones();

            frm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();

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
