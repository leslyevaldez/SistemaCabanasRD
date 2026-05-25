namespace SistemaCabañas
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAlquileres = new System.Windows.Forms.DataGridView();
            this.panelAlquileres = new System.Windows.Forms.Panel();
            this.lblAlquileres = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelOcupadas = new System.Windows.Forms.Panel();
            this.lblOcupadas = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelDisponible = new System.Windows.Forms.Panel();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.lblTextoDisponible = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnPagos = new FontAwesome.Sharp.IconButton();
            this.btnAlquileres = new FontAwesome.Sharp.IconButton();
            this.btnServicios = new FontAwesome.Sharp.IconButton();
            this.btnHabitaciones = new FontAwesome.Sharp.IconButton();
            this.btnTiposHabitaciones = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenido.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            this.panelAlquileres.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelOcupadas.SuspendLayout();
            this.panelDisponible.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Location = new System.Drawing.Point(246, 3);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1218, 55);
            this.panelTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCabañas.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(1293, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 34);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(207, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "CABAÑA";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Controls.Add(this.button9);
            this.panelContenido.Controls.Add(this.panel2);
            this.panelContenido.Controls.Add(this.panel1);
            this.panelContenido.Controls.Add(this.label5);
            this.panelContenido.Controls.Add(this.dgvAlquileres);
            this.panelContenido.Controls.Add(this.panelAlquileres);
            this.panelContenido.Controls.Add(this.panelClientes);
            this.panelContenido.Controls.Add(this.panelOcupadas);
            this.panelContenido.Controls.Add(this.panelDisponible);
            this.panelContenido.Controls.Add(this.label4);
            this.panelContenido.Controls.Add(this.lblBienvenida);
            this.panelContenido.Location = new System.Drawing.Point(246, 62);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1218, 698);
            this.panelContenido.TabIndex = 11;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(27, 871);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "login";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Location = new System.Drawing.Point(885, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 68);
            this.panel2.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(27, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(108, 25);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "00/00/0000";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblGanancias);
            this.panel1.Location = new System.Drawing.Point(24, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 160);
            this.panel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 35);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ganancias Del Dia";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancias.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGanancias.Location = new System.Drawing.Point(19, 75);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(34, 37);
            this.lblGanancias.TabIndex = 7;
            this.lblGanancias.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(391, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alquileres Recientes";
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.AllowUserToAddRows = false;
            this.dgvAlquileres.AllowUserToDeleteRows = false;
            this.dgvAlquileres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlquileres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Location = new System.Drawing.Point(403, 427);
            this.dgvAlquileres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.ReadOnly = true;
            this.dgvAlquileres.RowHeadersVisible = false;
            this.dgvAlquileres.RowHeadersWidth = 51;
            this.dgvAlquileres.RowTemplate.Height = 24;
            this.dgvAlquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlquileres.Size = new System.Drawing.Size(601, 269);
            this.dgvAlquileres.TabIndex = 8;
            // 
            // panelAlquileres
            // 
            this.panelAlquileres.BackColor = System.Drawing.Color.DimGray;
            this.panelAlquileres.Controls.Add(this.lblAlquileres);
            this.panelAlquileres.Controls.Add(this.label10);
            this.panelAlquileres.Location = new System.Drawing.Point(814, 205);
            this.panelAlquileres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAlquileres.Name = "panelAlquileres";
            this.panelAlquileres.Size = new System.Drawing.Size(240, 160);
            this.panelAlquileres.TabIndex = 6;
            // 
            // lblAlquileres
            // 
            this.lblAlquileres.AutoSize = true;
            this.lblAlquileres.BackColor = System.Drawing.Color.Transparent;
            this.lblAlquileres.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquileres.ForeColor = System.Drawing.Color.White;
            this.lblAlquileres.Location = new System.Drawing.Point(105, 66);
            this.lblAlquileres.Name = "lblAlquileres";
            this.lblAlquileres.Size = new System.Drawing.Size(29, 35);
            this.lblAlquileres.TabIndex = 5;
            this.lblAlquileres.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Alquileres Activos\r\n";
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.Firebrick;
            this.panelClientes.Controls.Add(this.lblClientes);
            this.panelClientes.Controls.Add(this.label6);
            this.panelClientes.Location = new System.Drawing.Point(552, 205);
            this.panelClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(240, 160);
            this.panelClientes.TabIndex = 6;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(100, 78);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(29, 35);
            this.lblClientes.TabIndex = 5;
            this.lblClientes.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clientes Registrados";
            // 
            // panelOcupadas
            // 
            this.panelOcupadas.BackColor = System.Drawing.Color.DimGray;
            this.panelOcupadas.Controls.Add(this.lblOcupadas);
            this.panelOcupadas.Controls.Add(this.label8);
            this.panelOcupadas.Location = new System.Drawing.Point(280, 205);
            this.panelOcupadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOcupadas.Name = "panelOcupadas";
            this.panelOcupadas.Size = new System.Drawing.Size(240, 160);
            this.panelOcupadas.TabIndex = 6;
            // 
            // lblOcupadas
            // 
            this.lblOcupadas.AutoSize = true;
            this.lblOcupadas.BackColor = System.Drawing.Color.Transparent;
            this.lblOcupadas.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupadas.ForeColor = System.Drawing.Color.White;
            this.lblOcupadas.Location = new System.Drawing.Point(111, 69);
            this.lblOcupadas.Name = "lblOcupadas";
            this.lblOcupadas.Size = new System.Drawing.Size(29, 35);
            this.lblOcupadas.TabIndex = 5;
            this.lblOcupadas.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Habitaciones Ocupadas";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panelDisponible
            // 
            this.panelDisponible.BackColor = System.Drawing.Color.Firebrick;
            this.panelDisponible.Controls.Add(this.lblDisponibles);
            this.panelDisponible.Controls.Add(this.lblTextoDisponible);
            this.panelDisponible.Location = new System.Drawing.Point(16, 205);
            this.panelDisponible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDisponible.Name = "panelDisponible";
            this.panelDisponible.Size = new System.Drawing.Size(240, 160);
            this.panelDisponible.TabIndex = 4;
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.BackColor = System.Drawing.Color.Transparent;
            this.lblDisponibles.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblDisponibles.Location = new System.Drawing.Point(100, 69);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(29, 35);
            this.lblDisponibles.TabIndex = 5;
            this.lblDisponibles.Text = "0";
            // 
            // lblTextoDisponible
            // 
            this.lblTextoDisponible.AutoSize = true;
            this.lblTextoDisponible.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoDisponible.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoDisponible.ForeColor = System.Drawing.Color.White;
            this.lblTextoDisponible.Location = new System.Drawing.Point(3, 14);
            this.lblTextoDisponible.Name = "lblTextoDisponible";
            this.lblTextoDisponible.Size = new System.Drawing.Size(235, 25);
            this.lblTextoDisponible.TabIndex = 5;
            this.lblTextoDisponible.Text = "Habitaciones Disponibles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(43, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Panel de control general del sistema";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(39, 32);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(271, 57);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Bienvenido ";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.panelMenu);
            this.panel3.Controls.Add(this.panelContenido);
            this.panel3.Controls.Add(this.panelTop);
            this.panel3.Location = new System.Drawing.Point(4, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1300, 760);
            this.panel3.TabIndex = 12;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnConfiguracion);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnPagos);
            this.panelMenu.Controls.Add(this.btnAlquileres);
            this.panelMenu.Controls.Add(this.btnServicios);
            this.panelMenu.Controls.Add(this.btnHabitaciones);
            this.panelMenu.Controls.Add(this.btnTiposHabitaciones);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 760);
            this.panelMenu.TabIndex = 11;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 24;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 630);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(240, 65);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnConfiguracion.IconColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracion.IconSize = 24;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 695);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(240, 65);
            this.btnConfiguracion.TabIndex = 9;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnReportes.IconColor = System.Drawing.Color.White;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 24;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 520);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(240, 58);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnPagos.IconColor = System.Drawing.Color.White;
            this.btnPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagos.IconSize = 24;
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(0, 455);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(240, 65);
            this.btnPagos.TabIndex = 7;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnAlquileres
            // 
            this.btnAlquileres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlquileres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlquileres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquileres.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquileres.ForeColor = System.Drawing.Color.White;
            this.btnAlquileres.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnAlquileres.IconColor = System.Drawing.Color.White;
            this.btnAlquileres.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlquileres.IconSize = 24;
            this.btnAlquileres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlquileres.Location = new System.Drawing.Point(0, 390);
            this.btnAlquileres.Name = "btnAlquileres";
            this.btnAlquileres.Size = new System.Drawing.Size(240, 65);
            this.btnAlquileres.TabIndex = 6;
            this.btnAlquileres.Text = "Alquileres";
            this.btnAlquileres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlquileres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlquileres.UseVisualStyleBackColor = true;
            this.btnAlquileres.Click += new System.EventHandler(this.btnAlquileres_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.Color.White;
            this.btnServicios.IconChar = FontAwesome.Sharp.IconChar.Tooth;
            this.btnServicios.IconColor = System.Drawing.Color.White;
            this.btnServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicios.IconSize = 24;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(0, 325);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(240, 65);
            this.btnServicios.TabIndex = 5;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitaciones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnHabitaciones.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.btnHabitaciones.IconColor = System.Drawing.Color.White;
            this.btnHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHabitaciones.IconSize = 24;
            this.btnHabitaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabitaciones.Location = new System.Drawing.Point(0, 260);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(240, 65);
            this.btnHabitaciones.TabIndex = 4;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHabitaciones.UseVisualStyleBackColor = true;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnTiposHabitaciones
            // 
            this.btnTiposHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiposHabitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTiposHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposHabitaciones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiposHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnTiposHabitaciones.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.btnTiposHabitaciones.IconColor = System.Drawing.Color.White;
            this.btnTiposHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTiposHabitaciones.IconSize = 24;
            this.btnTiposHabitaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiposHabitaciones.Location = new System.Drawing.Point(0, 195);
            this.btnTiposHabitaciones.Name = "btnTiposHabitaciones";
            this.btnTiposHabitaciones.Size = new System.Drawing.Size(240, 65);
            this.btnTiposHabitaciones.TabIndex = 3;
            this.btnTiposHabitaciones.Text = "Tipos Habitaciones";
            this.btnTiposHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiposHabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTiposHabitaciones.UseVisualStyleBackColor = true;
            this.btnTiposHabitaciones.Click += new System.EventHandler(this.btnTiposHabitaciones_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 24;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 130);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(240, 65);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 24;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 65);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(240, 65);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.HouseLock;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 24;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(240, 65);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 1055);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.Resize += new System.EventHandler(this.FrmMenu_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            this.panelAlquileres.ResumeLayout(false);
            this.panelAlquileres.PerformLayout();
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            this.panelOcupadas.ResumeLayout(false);
            this.panelOcupadas.PerformLayout();
            this.panelDisponible.ResumeLayout(false);
            this.panelDisponible.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Panel panelDisponible;
        private System.Windows.Forms.Label lblTextoDisponible;
        private System.Windows.Forms.Panel panelAlquileres;
        private System.Windows.Forms.Label lblAlquileres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelOcupadas;
        private System.Windows.Forms.Label lblOcupadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.DataGridView dgvAlquileres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnPagos;
        private FontAwesome.Sharp.IconButton btnAlquileres;
        private FontAwesome.Sharp.IconButton btnServicios;
        private FontAwesome.Sharp.IconButton btnHabitaciones;
        private FontAwesome.Sharp.IconButton btnTiposHabitaciones;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnUsuarios;
    }
}