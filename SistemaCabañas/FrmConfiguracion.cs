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
                    cn.Close();

                    SqlConnection cn2 =
                        new SqlConnection
                        (
                            "Data Source=LAPTOP-1MHMN15C;Initial Catalog=master;Integrated Security=True"
                        );

                    cn2.Open();

                    string query = @"
ALTER DATABASE SistemaCabaña
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE;

RESTORE DATABASE SistemaCabaña
FROM DISK = '" + open.FileName + @"'
WITH REPLACE;

ALTER DATABASE SistemaCabaña
SET MULTI_USER;
";

                    SqlCommand cmd =
                        new SqlCommand(query, cn2);

                    cmd.ExecuteNonQuery();

                    cn2.Close();

                    MessageBox.Show
                    (
                        "Base de datos restaurada correctamente"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    

        private void FrmConfiguracion_Load(object sender, EventArgs e)
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
