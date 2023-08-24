namespace Neumavalid
{
    partial class frmAcerca
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProcesoMedicion2 = new System.Windows.Forms.TextBox();
            this.txtProcesoMedicion1 = new System.Windows.Forms.TextBox();
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
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.btnGuardar);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 375);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(704, 75);
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
            this.btnGuardar.Size = new System.Drawing.Size(704, 60);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnMediciones_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 3;
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
            this.grpSensores.Location = new System.Drawing.Point(12, 201);
            this.grpSensores.Name = "grpSensores";
            this.grpSensores.Size = new System.Drawing.Size(675, 144);
            this.grpSensores.TabIndex = 14;
            this.grpSensores.TabStop = false;
            this.grpSensores.Text = "Sensores";
            this.grpSensores.Enter += new System.EventHandler(this.grpSensores_Enter);
            // 
            // numTemperatura
            // 
            this.numTemperatura.Location = new System.Drawing.Point(495, 67);
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
            this.numPresion.Location = new System.Drawing.Point(495, 27);
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
            this.numPresion.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numHumedad
            // 
            this.numHumedad.Location = new System.Drawing.Point(126, 68);
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
            this.label4.Location = new System.Drawing.Point(390, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Temperatura";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(390, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Presion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Humedad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.groupBox3);
            this.pnlFormulario.Controls.Add(this.groupBox2);
            this.pnlFormulario.Controls.Add(this.groupBox1);
            this.pnlFormulario.Controls.Add(this.grpSensores);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFormulario.ForeColor = System.Drawing.Color.Gainsboro;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(704, 375);
            this.pnlFormulario.TabIndex = 1;
            this.pnlFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormulario_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(12, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 170);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comunicaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Puerto COM ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProcesoMedicion2);
            this.groupBox2.Controls.Add(this.txtProcesoMedicion1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(475, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 170);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comandos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtProcesoMedicion2
            // 
            this.txtProcesoMedicion2.Location = new System.Drawing.Point(9, 121);
            this.txtProcesoMedicion2.Name = "txtProcesoMedicion2";
            this.txtProcesoMedicion2.Size = new System.Drawing.Size(130, 23);
            this.txtProcesoMedicion2.TabIndex = 24;
            // 
            // txtProcesoMedicion1
            // 
            this.txtProcesoMedicion1.Location = new System.Drawing.Point(9, 48);
            this.txtProcesoMedicion1.Name = "txtProcesoMedicion1";
            this.txtProcesoMedicion1.Size = new System.Drawing.Size(130, 23);
            this.txtProcesoMedicion1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Proceso Medicion 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Proceso Medicion 1";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.groupBox1.Size = new System.Drawing.Size(212, 169);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rx Tx";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.chkEnviar_r.CheckedChanged += new System.EventHandler(this.chkTx_n_CheckedChanged);
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
            // frmAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlInferior);
            this.Name = "frmAcerca";
            this.Text = "Acerca de Neumo Valid";
            this.pnlInferior.ResumeLayout(false);
            this.grpSensores.ResumeLayout(false);
            this.grpSensores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHumedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumen)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.TextBox txtProcesoMedicion2;
        private System.Windows.Forms.TextBox txtProcesoMedicion1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
    }
}