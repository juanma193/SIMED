namespace SIMED_V1.Forms_Para_El_Menu
{
    partial class UViajes
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
            this.lblViajes = new System.Windows.Forms.Label();
            this.btnConsultarViaje = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarViaje = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Seleccione una de las siguientes opciones";
            // 
            // lblViajes
            // 
            this.lblViajes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblViajes.AutoSize = true;
            this.lblViajes.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViajes.Location = new System.Drawing.Point(266, 119);
            this.lblViajes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViajes.Name = "lblViajes";
            this.lblViajes.Size = new System.Drawing.Size(145, 51);
            this.lblViajes.TabIndex = 25;
            this.lblViajes.Text = "VIAJES";
            // 
            // btnConsultarViaje
            // 
            this.btnConsultarViaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarViaje.Animated = true;
            this.btnConsultarViaje.AutoRoundedCorners = true;
            this.btnConsultarViaje.BorderRadius = 33;
            this.btnConsultarViaje.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarViaje.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultarViaje.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultarViaje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultarViaje.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnConsultarViaje.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultarViaje.ForeColor = System.Drawing.Color.White;
            this.btnConsultarViaje.Location = new System.Drawing.Point(392, 281);
            this.btnConsultarViaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultarViaje.Name = "btnConsultarViaje";
            this.btnConsultarViaje.Size = new System.Drawing.Size(190, 68);
            this.btnConsultarViaje.TabIndex = 24;
            this.btnConsultarViaje.Text = "Consultar viajes";
            this.btnConsultarViaje.Click += new System.EventHandler(this.btnConsultarViaje_Click);
            // 
            // btnRegistrarViaje
            // 
            this.btnRegistrarViaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarViaje.Animated = true;
            this.btnRegistrarViaje.AutoRoundedCorners = true;
            this.btnRegistrarViaje.BorderRadius = 33;
            this.btnRegistrarViaje.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarViaje.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarViaje.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrarViaje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarViaje.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnRegistrarViaje.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarViaje.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarViaje.Location = new System.Drawing.Point(96, 281);
            this.btnRegistrarViaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarViaje.Name = "btnRegistrarViaje";
            this.btnRegistrarViaje.Size = new System.Drawing.Size(190, 68);
            this.btnRegistrarViaje.TabIndex = 23;
            this.btnRegistrarViaje.Text = "Registrar viaje";
            this.btnRegistrarViaje.Click += new System.EventHandler(this.btnRegistrarViaje_Click);
            // 
            // UViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblViajes);
            this.Controls.Add(this.btnConsultarViaje);
            this.Controls.Add(this.btnRegistrarViaje);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UViajes";
            this.Size = new System.Drawing.Size(679, 518);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblViajes;
        private Guna.UI2.WinForms.Guna2Button btnConsultarViaje;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarViaje;
    }
}
