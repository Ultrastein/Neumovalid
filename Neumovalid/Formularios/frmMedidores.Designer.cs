namespace Neumavalid
{
    partial class frmMedidores
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
            CodeArtEng.Gauge.Themes.ThemeColors themeColors1 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors2 = new CodeArtEng.Gauge.Themes.ThemeColors();
            CodeArtEng.Gauge.Themes.ThemeColors themeColors3 = new CodeArtEng.Gauge.Themes.ThemeColors();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.btnStartEmulador = new FontAwesome.Sharp.IconButton();
            this.btnEndManual = new FontAwesome.Sharp.IconButton();
            this.btnStartManual = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.btnDetener = new FontAwesome.Sharp.IconButton();
            this.btnIniciar = new FontAwesome.Sharp.IconButton();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gaugePresion = new CodeArtEng.Gauge.CircularGauge();
            this.gaugeHumedad = new CodeArtEng.Gauge.CircularGauge();
            this.gaugeTemperatura = new CodeArtEng.Gauge.CircularGauge();
            this.grpSensores = new System.Windows.Forms.GroupBox();
            this.chartLitros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmboperador = new System.Windows.Forms.ComboBox();
            this.cmbpropieterio = new System.Windows.Forms.ComboBox();
            this.cmbmarca = new System.Windows.Forms.ComboBox();
            this.cmbNdeserie = new System.Windows.Forms.ComboBox();
            this.cmbmodelo = new System.Windows.Forms.ComboBox();
            this.Ndeensayo = new System.Windows.Forms.GroupBox();
            this.numensayo = new System.Windows.Forms.NumericUpDown();
            this.pnlDerecho.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpSensores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLitros)).BeginInit();
            this.Ndeensayo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numensayo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.Controls.Add(this.Ndeensayo);
            this.pnlDerecho.Controls.Add(this.btnStartEmulador);
            this.pnlDerecho.Controls.Add(this.btnEndManual);
            this.pnlDerecho.Controls.Add(this.btnStartManual);
            this.pnlDerecho.Controls.Add(this.iconButton1);
            this.pnlDerecho.Controls.Add(this.btnExportar);
            this.pnlDerecho.Controls.Add(this.btnDetener);
            this.pnlDerecho.Controls.Add(this.btnIniciar);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDerecho.Location = new System.Drawing.Point(940, 0);
            this.pnlDerecho.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(212, 618);
            this.pnlDerecho.TabIndex = 0;
            this.pnlDerecho.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDerecho_Paint);
            // 
            // btnStartEmulador
            // 
            this.btnStartEmulador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartEmulador.FlatAppearance.BorderSize = 0;
            this.btnStartEmulador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartEmulador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartEmulador.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStartEmulador.IconChar = FontAwesome.Sharp.IconChar.Golang;
            this.btnStartEmulador.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStartEmulador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStartEmulador.IconSize = 32;
            this.btnStartEmulador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartEmulador.Location = new System.Drawing.Point(0, 563);
            this.btnStartEmulador.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartEmulador.Name = "btnStartEmulador";
            this.btnStartEmulador.Size = new System.Drawing.Size(212, 55);
            this.btnStartEmulador.TabIndex = 10;
            this.btnStartEmulador.Text = "Iniciar Emulador";
            this.btnStartEmulador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartEmulador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartEmulador.UseVisualStyleBackColor = true;
            this.btnStartEmulador.Click += new System.EventHandler(this.btnStartEmulador_Click);
            // 
            // btnEndManual
            // 
            this.btnEndManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEndManual.FlatAppearance.BorderSize = 0;
            this.btnEndManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndManual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndManual.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEndManual.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnEndManual.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEndManual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEndManual.IconSize = 32;
            this.btnEndManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndManual.Location = new System.Drawing.Point(0, 275);
            this.btnEndManual.Margin = new System.Windows.Forms.Padding(4);
            this.btnEndManual.Name = "btnEndManual";
            this.btnEndManual.Size = new System.Drawing.Size(212, 55);
            this.btnEndManual.TabIndex = 9;
            this.btnEndManual.Text = "Detener Lectura";
            this.btnEndManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEndManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEndManual.UseVisualStyleBackColor = true;
            this.btnEndManual.Click += new System.EventHandler(this.btnEndManual_Click);
            // 
            // btnStartManual
            // 
            this.btnStartManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartManual.FlatAppearance.BorderSize = 0;
            this.btnStartManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartManual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartManual.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStartManual.IconChar = FontAwesome.Sharp.IconChar.Terminal;
            this.btnStartManual.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStartManual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStartManual.IconSize = 32;
            this.btnStartManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartManual.Location = new System.Drawing.Point(0, 220);
            this.btnStartManual.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartManual.Name = "btnStartManual";
            this.btnStartManual.Size = new System.Drawing.Size(212, 55);
            this.btnStartManual.TabIndex = 7;
            this.btnStartManual.Text = "Lectura";
            this.btnStartManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStartManual.UseVisualStyleBackColor = true;
            this.btnStartManual.Click += new System.EventHandler(this.btnStartManual_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.Enabled = false;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.iconButton1.IconColor = System.Drawing.Color.GhostWhite;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.Location = new System.Drawing.Point(0, 165);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(212, 55);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnExportar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 32;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(0, 110);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(212, 55);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar Datos";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetener.FlatAppearance.BorderSize = 0;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetener.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.btnDetener.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDetener.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetener.IconSize = 32;
            this.btnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetener.Location = new System.Drawing.Point(0, 55);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(212, 55);
            this.btnDetener.TabIndex = 3;
            this.btnDetener.Text = "Detener";
            this.btnDetener.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetener.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIniciar.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnIniciar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciar.IconSize = 32;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(0, 0);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(212, 55);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnMediciones_Click);
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.groupBox7);
            this.pnlFormulario.Controls.Add(this.groupBox6);
            this.pnlFormulario.Controls.Add(this.groupBox5);
            this.pnlFormulario.Controls.Add(this.groupBox1);
            this.pnlFormulario.Controls.Add(this.groupBox4);
            this.pnlFormulario.Controls.Add(this.groupBox2);
            this.pnlFormulario.Controls.Add(this.groupBox3);
            this.pnlFormulario.Controls.Add(this.grpSensores);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFormulario.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(940, 618);
            this.pnlFormulario.TabIndex = 2;
            this.pnlFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormulario_Paint);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbpropieterio);
            this.groupBox7.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox7.Location = new System.Drawing.Point(236, 110);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(229, 87);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Dueño";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox6.Location = new System.Drawing.Point(489, 338);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(433, 267);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tabla";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbComPort);
            this.groupBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Location = new System.Drawing.Point(236, 15);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(229, 80);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Puerto";
            // 
            // cmbComPort
            // 
            this.cmbComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(8, 36);
            this.cmbComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(212, 29);
            this.cmbComPort.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(212, 80);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha Medicion";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblFecha.Location = new System.Drawing.Point(8, 41);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(128, 25);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "12/12/2023";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbmodelo);
            this.groupBox4.Controls.Add(this.cmbNdeserie);
            this.groupBox4.Controls.Add(this.cmbmarca);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Location = new System.Drawing.Point(16, 209);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(916, 121);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Jeringa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nº de serie";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marca";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmboperador);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(16, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(212, 87);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operador";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.gaugePresion);
            this.groupBox3.Controls.Add(this.gaugeHumedad);
            this.groupBox3.Controls.Add(this.gaugeTemperatura);
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(473, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(459, 183);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Condiciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Presion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Humedad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatura";
            // 
            // gaugePresion
            // 
            this.gaugePresion.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.SegmentMultiColor;
            this.gaugePresion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugePresion.FontTitle = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gaugePresion.FontUnitLabel = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gaugePresion.Location = new System.Drawing.Point(336, 41);
            this.gaugePresion.Margin = new System.Windows.Forms.Padding(4);
            this.gaugePresion.Maximum = 100D;
            this.gaugePresion.Name = "gaugePresion";
            this.gaugePresion.ScaleFactor = 1D;
            this.gaugePresion.Size = new System.Drawing.Size(107, 98);
            this.gaugePresion.TabIndex = 2;
            this.gaugePresion.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.gaugePresion.Title = "";
            this.gaugePresion.Unit = "bar";
            this.gaugePresion.UserDefinedColors.Base = themeColors1;
            themeColors2.PointerColor = System.Drawing.Color.Red;
            this.gaugePresion.UserDefinedColors.Error = themeColors2;
            themeColors3.PointerColor = System.Drawing.Color.Orange;
            this.gaugePresion.UserDefinedColors.Warning = themeColors3;
            this.gaugePresion.Value = 0D;
            // 
            // gaugeHumedad
            // 
            this.gaugeHumedad.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.gaugeHumedad.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.gaugeHumedad.FontTitle = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gaugeHumedad.FontUnitLabel = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gaugeHumedad.Location = new System.Drawing.Point(177, 41);
            this.gaugeHumedad.Margin = new System.Windows.Forms.Padding(4);
            this.gaugeHumedad.Maximum = 100D;
            this.gaugeHumedad.Name = "gaugeHumedad";
            this.gaugeHumedad.ScaleFactor = 1D;
            this.gaugeHumedad.Size = new System.Drawing.Size(107, 98);
            this.gaugeHumedad.TabIndex = 1;
            this.gaugeHumedad.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.gaugeHumedad.Title = "";
            this.gaugeHumedad.Unit = "%";
            this.gaugeHumedad.Value = 0D;
            this.gaugeHumedad.WarningLimit = 80D;
            // 
            // gaugeTemperatura
            // 
            this.gaugeTemperatura.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.Segment;
            this.gaugeTemperatura.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.gaugeTemperatura.FontTitle = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gaugeTemperatura.FontUnitLabel = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gaugeTemperatura.Location = new System.Drawing.Point(19, 41);
            this.gaugeTemperatura.Margin = new System.Windows.Forms.Padding(4);
            this.gaugeTemperatura.Maximum = 50D;
            this.gaugeTemperatura.Name = "gaugeTemperatura";
            this.gaugeTemperatura.ScaleFactor = 1D;
            this.gaugeTemperatura.Size = new System.Drawing.Size(107, 98);
            this.gaugeTemperatura.TabIndex = 0;
            this.gaugeTemperatura.Theme = CodeArtEng.Gauge.GaugeTheme.Dark;
            this.gaugeTemperatura.Title = "";
            this.gaugeTemperatura.Unit = "°C";
            this.gaugeTemperatura.Value = 0D;
            this.gaugeTemperatura.WarningLimit = 60D;
            this.gaugeTemperatura.Load += new System.EventHandler(this.gaugeTemperatura_Load);
            // 
            // grpSensores
            // 
            this.grpSensores.Controls.Add(this.chartLitros);
            this.grpSensores.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSensores.Location = new System.Drawing.Point(16, 338);
            this.grpSensores.Margin = new System.Windows.Forms.Padding(4);
            this.grpSensores.Name = "grpSensores";
            this.grpSensores.Padding = new System.Windows.Forms.Padding(4);
            this.grpSensores.Size = new System.Drawing.Size(468, 267);
            this.grpSensores.TabIndex = 14;
            this.grpSensores.TabStop = false;
            this.grpSensores.Text = "Lecturas sensor";
            // 
            // chartLitros
            // 
            this.chartLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Century Gothic", 6F);
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 6F);
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Century Gothic", 6F);
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            chartArea1.Name = "ChartArea1";
            this.chartLitros.ChartAreas.Add(chartArea1);
            this.chartLitros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartLitros.Location = new System.Drawing.Point(4, 24);
            this.chartLitros.Margin = new System.Windows.Forms.Padding(4);
            this.chartLitros.Name = "chartLitros";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Cyan;
            series1.Font = new System.Drawing.Font("Century Gothic", 6F);
            series1.Name = "Series1";
            this.chartLitros.Series.Add(series1);
            this.chartLitros.Size = new System.Drawing.Size(460, 239);
            this.chartLitros.TabIndex = 29;
            this.chartLitros.Text = "chart4";
            this.chartLitros.Click += new System.EventHandler(this.chartLitros_Click);
            // 
            // cmboperador
            // 
            this.cmboperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmboperador.FormattingEnabled = true;
            this.cmboperador.Location = new System.Drawing.Point(8, 40);
            this.cmboperador.Margin = new System.Windows.Forms.Padding(4);
            this.cmboperador.Name = "cmboperador";
            this.cmboperador.Size = new System.Drawing.Size(196, 29);
            this.cmboperador.TabIndex = 5;
            // 
            // cmbpropieterio
            // 
            this.cmbpropieterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbpropieterio.FormattingEnabled = true;
            this.cmbpropieterio.Location = new System.Drawing.Point(8, 41);
            this.cmbpropieterio.Margin = new System.Windows.Forms.Padding(4);
            this.cmbpropieterio.Name = "cmbpropieterio";
            this.cmbpropieterio.Size = new System.Drawing.Size(196, 29);
            this.cmbpropieterio.TabIndex = 6;
            this.cmbpropieterio.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbmarca
            // 
            this.cmbmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbmarca.FormattingEnabled = true;
            this.cmbmarca.Location = new System.Drawing.Point(90, 25);
            this.cmbmarca.Margin = new System.Windows.Forms.Padding(4);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(350, 29);
            this.cmbmarca.TabIndex = 10;
            // 
            // cmbNdeserie
            // 
            this.cmbNdeserie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNdeserie.FormattingEnabled = true;
            this.cmbNdeserie.Location = new System.Drawing.Point(294, 75);
            this.cmbNdeserie.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNdeserie.Name = "cmbNdeserie";
            this.cmbNdeserie.Size = new System.Drawing.Size(378, 29);
            this.cmbNdeserie.TabIndex = 11;
            // 
            // cmbmodelo
            // 
            this.cmbmodelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbmodelo.FormattingEnabled = true;
            this.cmbmodelo.Location = new System.Drawing.Point(552, 25);
            this.cmbmodelo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbmodelo.Name = "cmbmodelo";
            this.cmbmodelo.Size = new System.Drawing.Size(329, 29);
            this.cmbmodelo.TabIndex = 12;
            // 
            // Ndeensayo
            // 
            this.Ndeensayo.Controls.Add(this.numensayo);
            this.Ndeensayo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Ndeensayo.Location = new System.Drawing.Point(8, 362);
            this.Ndeensayo.Margin = new System.Windows.Forms.Padding(4);
            this.Ndeensayo.Name = "Ndeensayo";
            this.Ndeensayo.Padding = new System.Windows.Forms.Padding(4);
            this.Ndeensayo.Size = new System.Drawing.Size(191, 64);
            this.Ndeensayo.TabIndex = 35;
            this.Ndeensayo.TabStop = false;
            this.Ndeensayo.Text = "Nº de ensayo";
            // 
            // numensayo
            // 
            this.numensayo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numensayo.Location = new System.Drawing.Point(23, 29);
            this.numensayo.Margin = new System.Windows.Forms.Padding(4);
            this.numensayo.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numensayo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numensayo.Name = "numensayo";
            this.numensayo.Size = new System.Drawing.Size(142, 22);
            this.numensayo.TabIndex = 22;
            this.numensayo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numensayo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmMedidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1152, 618);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlDerecho);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMedidores";
            this.Text = "Medidores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMedidores_FormClosed);
            this.Load += new System.EventHandler(this.frmMedidores_Load);
            this.pnlDerecho.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpSensores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLitros)).EndInit();
            this.Ndeensayo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numensayo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDerecho;
        private FontAwesome.Sharp.IconButton btnIniciar;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnDetener;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnEndEmulador;
        private CodeArtEng.Gauge.CircularGauge gaugePresion;
        private CodeArtEng.Gauge.CircularGauge gaugeHumedad;
        private CodeArtEng.Gauge.CircularGauge gaugeTemperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnStartManual;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnEndManual;
        private FontAwesome.Sharp.IconButton btnStartEmulador;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox grpSensores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLitros;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbpropieterio;
        private System.Windows.Forms.ComboBox cmboperador;
        private System.Windows.Forms.ComboBox cmbmodelo;
        private System.Windows.Forms.ComboBox cmbNdeserie;
        private System.Windows.Forms.ComboBox cmbmarca;
        private System.Windows.Forms.GroupBox Ndeensayo;
        private System.Windows.Forms.NumericUpDown numensayo;
    }
}