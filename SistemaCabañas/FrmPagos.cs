using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmPagos : Form
    {

        PagosBL objbl = new PagosBL();

        E_Pagos objent = new E_Pagos();

        int id = 0;
        public string NombreUsuario;
        public string RolUsuario;
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            MostrarPagos();

            comboBox1.Items.Add("Efectivo");
            comboBox1.Items.Add("Tarjeta");
            comboBox1.Items.Add("Transferencia");


            /*
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
            }*/

        }

        public void MostrarPagos()
        {
            dataGridView1.DataSource =
                objbl.MostrarPagos();
        }

        public void MostrarAlquileres()
        {
           
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

                comboBox1.Text =
                    dataGridView1.CurrentRow.Cells[4].Value.ToString();
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

            comboBox1.SelectedIndex = -1;

            id = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBuscarAlquiler frm =
       new FrmBuscarAlquiler();

            frm.ShowDialog();

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

            if (comboBox1.Text == "")
            {
                MessageBox.Show
                (
                    "Seleccione el método de pago"
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
                    comboBox1.Text;

                if (id == 0)
                {
                    objbl.InsertarPago
 (
     objent
 );

                    AlquileresBL objAlquiler =
                    new AlquileresBL();

                    objAlquiler.FinalizarAlquiler
                    (
                        Convert.ToInt32(textBox1.Text)
                    );

                    MessageBox.Show
                    (
                        "Pago guardado"
                    );
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
    }
}
