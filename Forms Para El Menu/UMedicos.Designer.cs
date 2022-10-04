namespace SIMED_V1
{
    partial class UMedicos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarDatosMedico = new Guna.UI2.WinForms.Guna2Button();
            this.btnDarAltaMedico = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Seleccione una de las siguientes opciones";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 51);
            this.label1.TabIndex = 15;
            this.label1.Text = "MÉDICOS";
            // 
            // btnConsultarDatosMedico
            // 
            this.btnConsultarDatosMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarDatosMedico.Animated = true;
            this.btnConsultarDatosMedico.AutoRoundedCorners = true;
            this.btnConsultarDatosMedico.BorderRadius = 33;
            this.btnConsultarDatosMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarDatosMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarDatosMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultarDatosMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultarDatosMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnConsultarDatosMedico.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultarDatosMedico.ForeColor = System.Drawing.Color.White;
            this.btnConsultarDatosMedico.Location = new System.Drawing.Point(396, 265);
            this.btnConsultarDatosMedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarDatosMedico.Name = "btnConsultarDatosMedico";
            this.btnConsultarDatosMedico.Size = new System.Drawing.Size(190, 68);
            this.btnConsultarDatosMedico.TabIndex = 13;
            this.btnConsultarDatosMedico.Text = "Consultar médico";
            this.btnConsultarDatosMedico.Click += new System.EventHandler(this.btnConsultarDatosMedico_Click);
            // 
            // btnDarAltaMedico
            // 
            this.btnDarAltaMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDarAltaMedico.Animated = true;
            this.btnDarAltaMedico.AutoRoundedCorners = true;
            this.btnDarAltaMedico.BorderRadius = 33;
            this.btnDarAltaMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDarAltaMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDarAltaMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDarAltaMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDarAltaMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnDarAltaMedico.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnDarAltaMedico.ForeColor = System.Drawing.Color.White;
            this.btnDarAltaMedico.Location = new System.Drawing.Point(91, 265);
            this.btnDarAltaMedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnDarAltaMedico.Name = "btnDarAltaMedico";
            this.btnDarAltaMedico.Size = new System.Drawing.Size(190, 68);
            this.btnDarAltaMedico.TabIndex = 11;
            this.btnDarAltaMedico.Text = "Dar de alta a un médico";
            this.btnDarAltaMedico.Click += new System.EventHandler(this.btnDarAltaMedico_Click);
            // 
            // UMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultarDatosMedico);
            this.Controls.Add(this.btnDarAltaMedico);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UMedicos";
            this.Size = new System.Drawing.Size(679, 518);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnConsultarDatosMedico;
        private Guna.UI2.WinForms.Guna2Button btnDarAltaMedico;
    }
}