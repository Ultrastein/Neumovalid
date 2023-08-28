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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbModelos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbReferentes = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gaugePresion = new CodeArtEng.Gauge.CircularGauge();
            this.gaugeHumedad = new CodeArtEng.Gauge.CircularGauge();
            this.gaugeTemperatura = new CodeArtEng.Gauge.CircularGauge();
            this.grpSensores = new System.Windows.Forms.GroupBox();
            this.chartLitros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlDerecho.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpSensores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLitros)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.Controls.Add(this.btnStartEmulador);
            this.pnlDerecho.Controls.Add(this.btnEndManual);
            this.pnlDerecho.Controls.Add(this.btnStartManual);
            this.pnlDerecho.Controls.Add(this.iconButton1);
            this.pnlDerecho.Controls.Add(this.btnExportar);
            this.pnlDerecho.Controls.Add(this.btnDetener);
            this.pnlDerecho.Controls.Add(this.btnIniciar);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDerecho.Location = new System.Drawing.Point(705, 0);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(159, 502);
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
            this.btnStartEmulador.Location = new System.Drawing.Point(0, 457);
            this.btnStartEmulador.Name = "btnStartEmulador";
            this.btnStartEmulador.Size = new System.Drawing.Size(159, 45);
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
            this.btnEndManual.Location = new System.Drawing.Point(0, 225);
            this.btnEndManual.Name = "btnEndManual";
            this.btnEndManual.Size = new System.Drawing.Size(159, 45);
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
            this.btnStartManual.Location = new System.Drawing.Point(0, 180);
            this.btnStartManual.Name = "btnStartManual";
            this.btnStartManual.Size = new System.Drawing.Size(159, 45);
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
            this.iconButton1.Location = new System.Drawing.Point(0, 135);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(159, 45);
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
            this.btnExportar.Location = new System.Drawing.Point(0, 90);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(159, 45);
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
            this.btnDetener.Location = new System.Drawing.Point(0, 45);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(159, 45);
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
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(159, 45);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnMediciones_Click);
            // 
            // pnlFormulario
            // 
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
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(705, 502);
            this.pnlFormulario.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbComPort);
            this.groupBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Location = new System.Drawing.Point(177, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 65);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Puerto";
            // 
            // cmbComPort
            // 
            this.cmbComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(6, 29);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(160, 40);
            this.cmbComPort.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 65);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha Medicion";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblFecha.Location = new System.Drawing.Point(6, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(199, 40);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "12/12/2023";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbModelos);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbMarcas);
            this.groupBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Location = new System.Drawing.Point(12, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(687, 56);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Jeringa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Modelo";
            // 
            // cmbModelos
            // 
            this.cmbModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbModelos.FormattingEnabled = true;
            this.cmbModelos.Location = new System.Drawing.Point(415, 20);
            this.cmbModelos.Name = "cmbModelos";
            this.cmbModelos.Size = new System.Drawing.Size(266, 40);
            this.cmbModelos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marca";
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(75, 20);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(256, 40);
            this.cmbMarcas.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbReferentes);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 71);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Referente";
            // 
            // cmbReferentes
            // 
            this.cmbReferentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReferentes.FormattingEnabled = true;
            this.cmbReferentes.Location = new System.Drawing.Point(6, 25);
            this.cmbReferentes.Name = "cmbReferentes";
            this.cmbReferentes.Size = new System.Drawing.Size(325, 40);
            this.cmbReferentes.TabIndex = 4;
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
            this.groupBox3.Location = new System.Drawing.Point(355, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 149);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Condiciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Presion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Humedad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperatura";
            // 
            // gaugePresion
            // 
            this.gaugePresion.DrawStyle = CodeArtEng.Gauge.GaugeIndicatorStyle.SegmentMultiColor;
            this.gaugePresion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaugePresion.FontTitle = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gaugePresion.FontUnitLabel = new System.Drawing.Font("Century Gothic", 8.25F);
            this.gaugePresion.Location = new System.Drawing.Point(252, 33);
            this.gaugePresion.Name = "gaugePresion";
            this.gaugePresion.ScaleFactor = 1D;
            this.gaugePresion.Size = new System.Drawing.Size(80, 80);
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
            this.gaugeHumedad.Location = new System.Drawing.Point(133, 33);
            this.gaugeHumedad.Name = "gaugeHumedad";
            this.gaugeHumedad.ScaleFactor = 1D;
            this.gaugeHumedad.Size = new System.Drawing.Size(80, 80);
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
            this.gaugeTemperatura.Location = new System.Drawing.Point(14, 33);
            this.gaugeTemperatura.Maximum = 120D;
            this.gaugeTemperatura.Name = "gaugeTemperatura";
            this.gaugeTemperatura.ScaleFactor = 1D;
            this.gaugeTemperatura.Size = new System.Drawing.Size(80, 80);
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
            this.grpSensores.Location = new System.Drawing.Point(12, 232);
            this.grpSensores.Name = "grpSensores";
            this.grpSensores.Size = new System.Drawing.Size(687, 258);
            this.grpSensores.TabIndex = 14;
            this.grpSensores.TabStop = false;
            this.grpSensores.Text = "Historico de Litros";
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
            this.chartLitros.Location = new System.Drawing.Point(3, 35);
            this.chartLitros.Name = "chartLitros";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Cyan;
            series1.Font = new System.Drawing.Font("Century Gothic", 6F);
            series1.Name = "Series1";
            this.chartLitros.Series.Add(series1);
            this.chartLitros.Size = new System.Drawing.Size(681, 220);
            this.chartLitros.TabIndex = 29;
            this.chartLitros.Text = "chart4";
            // 
            // frmMedidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(864, 502);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlDerecho);
            this.Name = "frmMedidores";
            this.Text = "Medidores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMedidores_FormClosed);
            this.Load += new System.EventHandler(this.frmMedidores_Load);
            this.pnlDerecho.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDerecho;
        private FontAwesome.Sharp.IconButton btnIniciar;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpSensores;
        private FontAwesome.Sharp.IconButton btnDetener;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLitros;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnEndEmulador;
        private CodeArtEng.Gauge.CircularGauge gaugePresion;
        private CodeArtEng.Gauge.CircularGauge gaugeHumedad;
        private CodeArtEng.Gauge.CircularGauge gaugeTemperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbReferentes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbMarcas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbModelos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnStartManual;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnEndManual;
        private FontAwesome.Sharp.IconButton btnStartEmulador;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbComPort;
    }
}