﻿namespace Neumavalid
{
    partial class frmConfiguracion
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
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.grpSensores = new System.Windows.Forms.GroupBox();
            this.numTemperatura = new System.Windows.Forms.NumericUpDown();
            this.numPresion = new System.Windows.Forms.NumericUpDown();
            this.numHumedad = new System.Windows.Forms.NumericUpDown();
            this.numVolumen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstMarcas = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstModelos = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstReferentes = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComandoDetener = new System.Windows.Forms.TextBox();
            this.txtComandoIniciar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnviar_n = new System.Windows.Forms.CheckBox();
            this.chkEliminar_n = new System.Windows.Forms.CheckBox();
            this.chkEnviar_r = new System.Windows.Forms.CheckBox();
            this.chkEliminar_r = new System.Windows.Forms.CheckBox();
            this.pnlInferior.SuspendLayout();
            this.grpSensores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumen)).BeginInit();
            this.pnlFormulario.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.btnGuardar);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 427);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(864, 75);
            this.pnlInferior.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(0, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(864, 60);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbComPort
            // 
            this.cmbComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(9, 69);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(196, 25);
            this.cmbComPort.TabIndex = 3;
            // 
            // grpSensores
            // 
            this.grpSensores.Controls.Add(this.numTemperatura);
            this.grpSensores.Controls.Add(this.numPresion);
            this.grpSensores.Controls.Add(this.numHumedad);
            this.grpSensores.Controls.Add(this.numVolumen);
            this.grpSensores.Controls.Add(this.label4);
            this.grpSensores.Controls.Add(this.label3);
            this.grpSensores.Controls.Add(this.label2);
            this.grpSensores.Controls.Add(this.label1);
            this.grpSensores.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSensores.Location = new System.Drawing.Point(12, 238);
            this.grpSensores.Name = "grpSensores";
            this.grpSensores.Size = new System.Drawing.Size(227, 186);
            this.grpSensores.TabIndex = 14;
            this.grpSensores.TabStop = false;
            this.grpSensores.Text = "Sensores";
            // 
            // numTemperatura
            // 
            this.numTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTemperatura.Location = new System.Drawing.Point(126, 138);
            this.numTemperatura.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTemperatura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTemperatura.Name = "numTemperatura";
            this.numTemperatura.Size = new System.Drawing.Size(42, 23);
            this.numTemperatura.TabIndex = 24;
            this.numTemperatura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPresion
            // 
            this.numPresion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPresion.Location = new System.Drawing.Point(126, 101);
            this.numPresion.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPresion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPresion.Name = "numPresion";
            this.numPresion.Size = new System.Drawing.Size(42, 23);
            this.numPresion.TabIndex = 23;
            this.numPresion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHumedad
            // 
            this.numHumedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numHumedad.Location = new System.Drawing.Point(126, 64);
            this.numHumedad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHumedad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHumedad.Name = "numHumedad";
            this.numHumedad.Size = new System.Drawing.Size(42, 23);
            this.numHumedad.TabIndex = 22;
            this.numHumedad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numVolumen
            // 
            this.numVolumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numVolumen.Location = new System.Drawing.Point(126, 27);
            this.numVolumen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVolumen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVolumen.Name = "numVolumen";
            this.numVolumen.Size = new System.Drawing.Size(42, 23);
            this.numVolumen.TabIndex = 21;
            this.numVolumen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(21, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Presion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Humedad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Volumen";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.groupBox6);
            this.pnlFormulario.Controls.Add(this.groupBox5);
            this.pnlFormulario.Controls.Add(this.groupBox4);
            this.pnlFormulario.Controls.Add(this.groupBox3);
            this.pnlFormulario.Controls.Add(this.groupBox2);
            this.pnlFormulario.Controls.Add(this.groupBox1);
            this.pnlFormulario.Controls.Add(this.grpSensores);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFormulario.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(864, 427);
            this.pnlFormulario.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.lstMarcas);
            this.groupBox6.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox6.Location = new System.Drawing.Point(553, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(299, 169);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Marca Jeringas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(76, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Separar valores por  ;";
            // 
            // lstMarcas
            // 
            this.lstMarcas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMarcas.Location = new System.Drawing.Point(6, 18);
            this.lstMarcas.Multiline = true;
            this.lstMarcas.Name = "lstMarcas";
            this.lstMarcas.Size = new System.Drawing.Size(287, 121);
            this.lstMarcas.TabIndex = 25;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.lstModelos);
            this.groupBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox5.Location = new System.Drawing.Point(553, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 234);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modelo Jeringas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(76, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Separar valores por  ;";
            // 
            // lstModelos
            // 
            this.lstModelos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstModelos.Location = new System.Drawing.Point(6, 18);
            this.lstModelos.Multiline = true;
            this.lstModelos.Name = "lstModelos";
            this.lstModelos.Size = new System.Drawing.Size(287, 191);
            this.lstModelos.TabIndex = 25;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lstReferentes);
            this.groupBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Location = new System.Drawing.Point(245, 189);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 234);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Referentes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(71, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Separar valores por  ;";
            // 
            // lstReferentes
            // 
            this.lstReferentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstReferentes.Location = new System.Drawing.Point(6, 18);
            this.lstReferentes.Multiline = true;
            this.lstReferentes.Name = "lstReferentes";
            this.lstReferentes.Size = new System.Drawing.Size(290, 193);
            this.lstReferentes.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbComPort);
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(12, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 118);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comunicaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Puerto COM ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComandoDetener);
            this.groupBox2.Controls.Add(this.txtComandoIniciar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 94);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comandos Manual";
            // 
            // txtComandoDetener
            // 
            this.txtComandoDetener.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComandoDetener.Location = new System.Drawing.Point(125, 60);
            this.txtComandoDetener.MaxLength = 1;
            this.txtComandoDetener.Name = "txtComandoDetener";
            this.txtComandoDetener.Size = new System.Drawing.Size(43, 23);
            this.txtComandoDetener.TabIndex = 24;
            // 
            // txtComandoIniciar
            // 
            this.txtComandoIniciar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComandoIniciar.Location = new System.Drawing.Point(126, 28);
            this.txtComandoIniciar.MaxLength = 1;
            this.txtComandoIniciar.Name = "txtComandoIniciar";
            this.txtComandoIniciar.Size = new System.Drawing.Size(43, 23);
            this.txtComandoIniciar.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Detender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Iniciar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEnviar_n);
            this.groupBox1.Controls.Add(this.chkEliminar_n);
            this.groupBox1.Controls.Add(this.chkEnviar_r);
            this.groupBox1.Controls.Add(this.chkEliminar_r);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(245, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 169);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rx Tx";
            // 
            // chkEnviar_n
            // 
            this.chkEnviar_n.AutoSize = true;
            this.chkEnviar_n.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnviar_n.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkEnviar_n.Location = new System.Drawing.Point(16, 96);
            this.chkEnviar_n.Name = "chkEnviar_n";
            this.chkEnviar_n.Size = new System.Drawing.Size(84, 21);
            this.chkEnviar_n.TabIndex = 12;
            this.chkEnviar_n.Text = "Enviar /n";
            this.chkEnviar_n.UseVisualStyleBackColor = true;
            // 
            // chkEliminar_n
            // 
            this.chkEliminar_n.AutoSize = true;
            this.chkEliminar_n.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar_n.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkEliminar_n.Location = new System.Drawing.Point(16, 73);
            this.chkEliminar_n.Name = "chkEliminar_n";
            this.chkEliminar_n.Size = new System.Drawing.Size(95, 21);
            this.chkEliminar_n.TabIndex = 11;
            this.chkEliminar_n.Text = "Eliminar /n";
            this.chkEliminar_n.UseVisualStyleBackColor = true;
            // 
            // chkEnviar_r
            // 
            this.chkEnviar_r.AutoSize = true;
            this.chkEnviar_r.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnviar_r.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkEnviar_r.Location = new System.Drawing.Point(16, 46);
            this.chkEnviar_r.Name = "chkEnviar_r";
            this.chkEnviar_r.Size = new System.Drawing.Size(80, 21);
            this.chkEnviar_r.TabIndex = 10;
            this.chkEnviar_r.Text = "Enviar /r";
            this.chkEnviar_r.UseVisualStyleBackColor = true;
            // 
            // chkEliminar_r
            // 
            this.chkEliminar_r.AutoSize = true;
            this.chkEliminar_r.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar_r.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkEliminar_r.Location = new System.Drawing.Point(16, 23);
            this.chkEliminar_r.Name = "chkEliminar_r";
            this.chkEliminar_r.Size = new System.Drawing.Size(91, 21);
            this.chkEliminar_r.TabIndex = 9;
            this.chkEliminar_r.Text = "Eliminar /r";
            this.chkEliminar_r.UseVisualStyleBackColor = true;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(864, 502);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlInferior);
            this.Name = "frmConfiguracion";
            this.Text = "Configuracion";
            this.pnlInferior.ResumeLayout(false);
            this.grpSensores.ResumeLayout(false);
            this.grpSensores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumen)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInferior;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.GroupBox grpSensores;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numVolumen;
        private System.Windows.Forms.NumericUpDown numPresion;
        private System.Windows.Forms.NumericUpDown numHumedad;
        private System.Windows.Forms.NumericUpDown numTemperatura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEnviar_r;
        private System.Windows.Forms.CheckBox chkEliminar_r;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkEnviar_n;
        private System.Windows.Forms.CheckBox chkEliminar_n;
        private System.Windows.Forms.TextBox txtComandoDetener;
        private System.Windows.Forms.TextBox txtComandoIniciar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox lstReferentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lstModelos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lstMarcas;
    }
}