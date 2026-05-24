using CapaNegocio;
using System;
using System.Windows.Forms;

namespace SistemaCabañas
{
    public partial class FrmBuscarCliente : Form
    {
        ClientesBL objbl =
    new ClientesBL();

        public int IdCliente;

        public string Cliente;
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();

            dataGridView1.ClearSelection();

            dataGridView1.ReadOnly = true;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
        }

        public void MostrarClientes()
        {
            dataGridView1.DataSource =
                objbl.MostrarClientes();

            dataGridView1.Columns[0].Visible =
                false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show
                (
                    "Seleccione un cliente"
                );

                return;
            }

            IdCliente =
                Convert.ToInt32
                (
                    dataGridView1.CurrentRow.Cells[0].Value
                );

            Cliente =
                dataGridView1.CurrentRow.Cells[1].Value.ToString();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
