namespace SistemaCabañas
{
    partial class FrmPagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFactura = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alquiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Metodo de Pago";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(350, 554);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(888, 256);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(228, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 30);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(215, 212);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 87);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 30);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(320, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Buscar Alquiler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(725, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 55);
            this.button2.TabIndex = 19;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(725, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 55);
            this.button3.TabIndex = 20;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(725, 77);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 55);
            this.button4.TabIndex = 21;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Firebrick;
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Location = new System.Drawing.Point(228, 6);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1129, 140);
            this.panelTop.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(105, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "PAGOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.buttonFactura);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(350, 206);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 314);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonFactura
            // 
            this.buttonFactura.BackColor = System.Drawing.Color.Gray;
            this.buttonFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFactura.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFactura.ForeColor = System.Drawing.Color.White;
            this.buttonFactura.Location = new System.Drawing.Point(725, 240);
            this.buttonFactura.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFactura.Name = "buttonFactura";
            this.buttonFactura.Size = new System.Drawing.Size(125, 55);
            this.buttonFactura.TabIndex = 33;
            this.buttonFactura.Text = "Factura";
            this.buttonFactura.UseVisualStyleBackColor = false;
            this.buttonFactura.Click += new System.EventHandler(this.buttonFactura_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.iconButton1);
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
            this.panelMenu.Size = new System.Drawing.Size(222, 913);
            this.panelMenu.TabIndex = 42;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 578);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(222, 58);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Roles";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(0, 783);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(222, 65);
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
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 848);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(222, 65);
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
            this.btnReportes.Size = new System.Drawing.Size(222, 58);
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
            this.btnPagos.Size = new System.Drawing.Size(222, 65);
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
            this.btnAlquileres.Size = new System.Drawing.Size(222, 65);
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
            this.btnServicios.Size = new System.Drawing.Size(222, 65);
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
            this.btnHabitaciones.Size = new System.Drawing.Size(222, 65);
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
            this.btnTiposHabitaciones.Size = new System.Drawing.Size(222, 65);
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
            this.btnClientes.Size = new System.Drawing.Size(222, 65);
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
            this.btnUsuarios.Size = new System.Drawing.Size(222, 65);
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
            this.btnDashboard.Size = new System.Drawing.Size(222, 65);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 34;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1353, 901);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
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
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Button buttonFactura;
        private System.Windows.Forms.TextBox textBox3;
    }
}