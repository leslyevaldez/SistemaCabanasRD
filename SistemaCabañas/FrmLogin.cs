using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmLogin : Form
    {
        UsuariosBL objbl =
    new UsuariosBL();

        public int IdUsuario;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            panelPrincipal.Left =
        (this.ClientSize.Width - panelPrincipal.Width) / 2;

            panelPrincipal.Top =
                (this.ClientSize.Height - panelPrincipal.Height) / 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show
                    (
                        "Ingrese usuario"
                    );

                    return;
                }

                if (textBox2.Text == "")
                {
                    MessageBox.Show
                    (
                        "Ingrese contraseña"
                    );

                    return;
                }

                DataTable tabla =
                    objbl.Login
                    (
                        textBox1.Text,
                        textBox2.Text
                    );

                if (tabla.Rows.Count > 0)
                {
                    Sesion.IdUsuario = Convert.ToInt32(tabla.Rows[0]["Id_Usuario"]);
                    Sesion.Usuario = tabla.Rows[0]["Nombre"].ToString();
                    Sesion.Rol = tabla.Rows[0]["Rol"].ToString();

                    FrmMenu frm = new FrmMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show
                    (
                        "Usuario o contraseña incorrectos"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.PasswordChar = '*';
        }
    }
}
