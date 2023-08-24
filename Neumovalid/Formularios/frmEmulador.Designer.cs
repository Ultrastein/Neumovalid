namespace Neumavalid
{
    partial class frmEmulador
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
            this.btnMediciones = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnMediciones
            // 
            this.btnMediciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMediciones.FlatAppearance.BorderSize = 0;
            this.btnMediciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMediciones.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnMediciones.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMediciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMediciones.IconSize = 32;
            this.btnMediciones.Location = new System.Drawing.Point(0, 0);
            this.btnMediciones.Name = "btnMediciones";
            this.btnMediciones.Size = new System.Drawing.Size(357, 60);
            this.btnMediciones.TabIndex = 5;
            this.btnMediciones.Text = "Mediciones";
            this.btnMediciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMediciones.UseVisualStyleBackColor = true;
            this.btnMediciones.Click += new System.EventHandler(this.btnMediciones_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnSalir.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 32;
            this.btnSalir.Location = new System.Drawing.Point(0, 60);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(357, 60);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEmulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(357, 134);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMediciones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEmulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPOC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPOC_Closed);
            this.Load += new System.EventHandler(this.frmPOC_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnMediciones;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}