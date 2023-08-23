namespace Neumavalid
{
    partial class frmPOC
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
            this.lstPuertos = new System.Windows.Forms.ListBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtRecived = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCOM1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPuertos
            // 
            this.lstPuertos.FormattingEnabled = true;
            this.lstPuertos.ItemHeight = 16;
            this.lstPuertos.Location = new System.Drawing.Point(26, 64);
            this.lstPuertos.Name = "lstPuertos";
            this.lstPuertos.Size = new System.Drawing.Size(120, 100);
            this.lstPuertos.TabIndex = 0;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(26, 170);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(292, 22);
            this.txtSend.TabIndex = 1;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // txtRecived
            // 
            this.txtRecived.Location = new System.Drawing.Point(356, 26);
            this.txtRecived.Multiline = true;
            this.txtRecived.Name = "txtRecived";
            this.txtRecived.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRecived.Size = new System.Drawing.Size(432, 389);
            this.txtRecived.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(26, 211);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(292, 65);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCOM1
            // 
            this.btnCOM1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCOM1.Enabled = false;
            this.btnCOM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOM1.Location = new System.Drawing.Point(26, 339);
            this.btnCOM1.Name = "btnCOM1";
            this.btnCOM1.Size = new System.Drawing.Size(292, 65);
            this.btnCOM1.TabIndex = 4;
            this.btnCOM1.Text = "COM 1";
            this.btnCOM1.UseVisualStyleBackColor = false;
            // 
            // frmPOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCOM1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRecived);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.lstPuertos);
            this.Name = "frmPOC";
            this.Text = "frmPOC";
            this.Load += new System.EventHandler(this.frmPOC_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPOC_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPuertos;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtRecived;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCOM1;
    }
}