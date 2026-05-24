using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        SqlConnection cn =
new SqlConnection
(
    "Data Source=LAPTOP-1MHMN15C;Initial Catalog=SistemaCabaña;Integrated Security=True"
);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save =
                    new SaveFileDialog();

                save.Filter =
                    "Backup (*.bak)|*.bak";

                save.FileName =
                    "SistemaCabaña.bak";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string backup =
                    "BACKUP DATABASE SistemaCabaña TO DISK='" +
                    save.FileName + "'";

                    SqlCommand cmd =
                        new SqlCommand
                        (
                            backup,
                            cn
                        );

                    cn.Open();

                    cmd.ExecuteNonQuery();

                    cn.Close();

                    MessageBox.Show
                    (
                        "Backup creado correctamente"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open =
                    new OpenFileDialog();

                open.Filter =
                    "Backup (*.bak)|*.bak";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    cn.Open();

                    SqlCommand cmd =
                        new SqlCommand
                        (
                            "ALTER DATABASE SistemaCabaña SET SINGLE_USER WITH ROLLBACK IMMEDIATE",
                            cn
                        );

                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 =
                        new SqlCommand
                        (
                            "USE MASTER RESTORE DATABASE SistemaCabaña FROM DISK='" +
                            open.FileName +
                            "' WITH REPLACE",
                            cn
                        );

                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 =
                        new SqlCommand
                        (
                            "ALTER DATABASE SistemaCabaña SET MULTI_USER",
                            cn
                        );

                    cmd3.ExecuteNonQuery();

                    cn.Close();

                    MessageBox.Show
                    (
                        "Base de datos restaurada"
                    );
                }
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

        private void button6_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frm = new FrmHabitaciones();
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
