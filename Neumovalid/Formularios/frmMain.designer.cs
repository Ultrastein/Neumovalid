namespace NeumoValid
{
    partial class Validador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtPresion = new System.Windows.Forms.TextBox();
            this.txtHumedad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chartLitros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnEmulador = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoProceso = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDetener = new System.Windows.Forms.Button();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlChartVolumen = new System.Windows.Forms.Panel();
            this.chartVolumen = new CircularProgressBar.CircularProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.txtMensajeSerial = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLitros)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlChartVolumen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(148, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 92);
            this.panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 54);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(13, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Referente";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(359, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 92);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Neumavalid.Properties.Resources.Basica_del_validador;
            this.pictureBox1.Location = new System.Drawing.Point(20, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 53);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Cornsilk;
            this.label10.Location = new System.Drawing.Point(22, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "fecha de medicion";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panel5.Controls.Add(this.txtTemperatura);
            this.panel5.Controls.Add(this.txtPresion);
            this.panel5.Controls.Add(this.txtHumedad);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(559, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(394, 261);
            this.panel5.TabIndex = 2;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(190, 62);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(85, 13);
            this.txtTemperatura.TabIndex = 23;
            // 
            // txtPresion
            // 
            this.txtPresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresion.Location = new System.Drawing.Point(190, 123);
            this.txtPresion.Name = "txtPresion";
            this.txtPresion.Size = new System.Drawing.Size(85, 13);
            this.txtPresion.TabIndex = 22;
            // 
            // txtHumedad
            // 
            this.txtHumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHumedad.Location = new System.Drawing.Point(190, 195);
            this.txtHumedad.Name = "txtHumedad";
            this.txtHumedad.Size = new System.Drawing.Size(85, 13);
            this.txtHumedad.TabIndex = 20;
            this.txtHumedad.TextChanged += new System.EventHandler(this.txtHmedad_TextChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Cornsilk;
            this.label12.Location = new System.Drawing.Point(21, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 21);
            this.label12.TabIndex = 21;
            this.label12.Text = "Humedad";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Cornsilk;
            this.label11.Location = new System.Drawing.Point(21, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Pression";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(21, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Temperatura";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panel8.Controls.Add(this.chartLitros);
            this.panel8.Location = new System.Drawing.Point(148, 266);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(386, 240);
            this.panel8.TabIndex = 2;
            // 
            // chartLitros
            // 
            this.chartLitros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Cornsilk;
            chartArea1.AxisY.Maximum = 3000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            chartArea1.Name = "ChartArea1";
            this.chartLitros.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.Cornsilk;
            legend1.InterlacedRowsColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.White;
            this.chartLitros.Legends.Add(legend1);
            this.chartLitros.Location = new System.Drawing.Point(1, 0);
            this.chartLitros.Name = "chartLitros";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Lx.";
            this.chartLitros.Series.Add(series1);
            this.chartLitros.Size = new System.Drawing.Size(385, 236);
            this.chartLitros.TabIndex = 3;
            this.chartLitros.Text = "chart4";
            this.chartLitros.Click += new System.EventHandler(this.chart4_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label4.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(642, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Condiciones de medicion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIniciar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnIniciar.Location = new System.Drawing.Point(10, 19);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(108, 47);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panel14.Controls.Add(this.btnEmulador);
            this.panel14.Controls.Add(this.label9);
            this.panel14.Controls.Add(this.label5);
            this.panel14.Controls.Add(this.cmbTipoProceso);
            this.panel14.Controls.Add(this.pictureBox2);
            this.panel14.Controls.Add(this.btnDetener);
            this.panel14.Controls.Add(this.cmbComPort);
            this.panel14.Controls.Add(this.btnIniciar);
            this.panel14.Location = new System.Drawing.Point(1, -1);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(130, 536);
            this.panel14.TabIndex = 12;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // btnEmulador
            // 
            this.btnEmulador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEmulador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmulador.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEmulador.Location = new System.Drawing.Point(10, 459);
            this.btnEmulador.Name = "btnEmulador";
            this.btnEmulador.Size = new System.Drawing.Size(108, 47);
            this.btnEmulador.TabIndex = 20;
            this.btnEmulador.Text = "Emular Serial";
            this.btnEmulador.UseVisualStyleBackColor = false;
            this.btnEmulador.Click += new System.EventHandler(this.btnEmulador_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Cornsilk;
            this.label9.Location = new System.Drawing.Point(6, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Comunicacion";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(6, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Proceso Medicion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTipoProceso
            // 
            this.cmbTipoProceso.FormattingEnabled = true;
            this.cmbTipoProceso.Location = new System.Drawing.Point(10, 334);
            this.cmbTipoProceso.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoProceso.Name = "cmbTipoProceso";
            this.cmbTipoProceso.Size = new System.Drawing.Size(108, 21);
            this.cmbTipoProceso.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Neumavalid.Properties.Resources.Colegio_León_XIII_logo_escudo;
            this.pictureBox2.Location = new System.Drawing.Point(19, 174);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 94);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDetener.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnDetener.Location = new System.Drawing.Point(10, 87);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(108, 47);
            this.btnDetener.TabIndex = 16;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(6, 421);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(121, 21);
            this.cmbComPort.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(691, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Volumen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlChartVolumen
            // 
            this.pnlChartVolumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.pnlChartVolumen.Controls.Add(this.chartVolumen);
            this.pnlChartVolumen.Location = new System.Drawing.Point(659, 360);
            this.pnlChartVolumen.Name = "pnlChartVolumen";
            this.pnlChartVolumen.Size = new System.Drawing.Size(160, 149);
            this.pnlChartVolumen.TabIndex = 15;
            // 
            // chartVolumen
            // 
            this.chartVolumen.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.chartVolumen.AnimationSpeed = 500;
            this.chartVolumen.BackColor = System.Drawing.Color.Transparent;
            this.chartVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartVolumen.ForeColor = System.Drawing.Color.Cornsilk;
            this.chartVolumen.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.chartVolumen.InnerMargin = 2;
            this.chartVolumen.InnerWidth = -1;
            this.chartVolumen.Location = new System.Drawing.Point(20, 16);
            this.chartVolumen.MarqueeAnimationSpeed = 2000;
            this.chartVolumen.Maximum = 2500;
            this.chartVolumen.Name = "chartVolumen";
            this.chartVolumen.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartVolumen.OuterMargin = -25;
            this.chartVolumen.OuterWidth = 26;
            this.chartVolumen.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(255)))));
            this.chartVolumen.ProgressWidth = 25;
            this.chartVolumen.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartVolumen.Size = new System.Drawing.Size(125, 125);
            this.chartVolumen.StartAngle = 270;
            this.chartVolumen.SubscriptColor = System.Drawing.Color.Cornsilk;
            this.chartVolumen.SubscriptMargin = new System.Windows.Forms.Padding(10, -30, 0, 0);
            this.chartVolumen.SubscriptText = "";
            this.chartVolumen.SuperscriptColor = System.Drawing.Color.Cornsilk;
            this.chartVolumen.SuperscriptMargin = new System.Windows.Forms.Padding(10, 17, 0, 0);
            this.chartVolumen.SuperscriptText = "Litros";
            this.chartVolumen.TabIndex = 3;
            this.chartVolumen.Text = "1025";
            this.chartVolumen.TextMargin = new System.Windows.Forms.Padding(0);
            this.chartVolumen.Value = 1025;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(293, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Litros";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDescargar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnDescargar.Location = new System.Drawing.Point(844, 474);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(108, 47);
            this.btnDescargar.TabIndex = 16;
            this.btnDescargar.Text = "descargar datos";
            this.btnDescargar.UseVisualStyleBackColor = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Marca de la jeringa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(148, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 92);
            this.panel2.TabIndex = 17;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(26, 54);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(149, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(16, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Modelo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboBox4);
            this.panel4.Location = new System.Drawing.Point(359, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 92);
            this.panel4.TabIndex = 17;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(26, 54);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(149, 21);
            this.comboBox4.TabIndex = 0;
            // 
            // txtMensajeSerial
            // 
            this.txtMensajeSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensajeSerial.Location = new System.Drawing.Point(148, 512);
            this.txtMensajeSerial.Name = "txtMensajeSerial";
            this.txtMensajeSerial.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensajeSerial.Size = new System.Drawing.Size(389, 19);
            this.txtMensajeSerial.TabIndex = 14;
            // 
            // Validador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(965, 538);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlChartVolumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMensajeSerial);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Validador";
            this.Text = "Neumo-valid";
            this.Load += new System.EventHandler(this.Validador_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLitros)).EndInit();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlChartVolumen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLitros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlChartVolumen;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoProceso;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtPresion;
        private System.Windows.Forms.TextBox txtHumedad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private CircularProgressBar.CircularProgressBar chartVolumen;
        private System.Windows.Forms.TextBox txtMensajeSerial;
        private System.Windows.Forms.Button btnEmulador;
    }
}

