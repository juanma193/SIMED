namespace SIMED_V1.Forms_Para_Reportes
{
    partial class UAfiliadoRep
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
            this.btnGenerarEst = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenerarReportes = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Seleccione una de las siguientes opciones";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 51);
            this.label1.TabIndex = 29;
            this.label1.Text = "AFILIADOS";
            // 
            // btnGenerarEst
            // 
            this.btnGenerarEst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerarEst.Animated = true;
            this.btnGenerarEst.AutoRoundedCorners = true;
            this.btnGenerarEst.BorderRadius = 33;
            this.btnGenerarEst.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarEst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarEst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarEst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarEst.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnGenerarEst.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnGenerarEst.ForeColor = System.Drawing.Color.White;
            this.btnGenerarEst.Location = new System.Drawing.Point(613, 429);
            this.btnGenerarEst.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarEst.Name = "btnGenerarEst";
            this.btnGenerarEst.Size = new System.Drawing.Size(190, 68);
            this.btnGenerarEst.TabIndex = 28;
            this.btnGenerarEst.Text = "Generar estadísticas";
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerarReportes.Animated = true;
            this.btnGenerarReportes.AutoRoundedCorners = true;
            this.btnGenerarReportes.BorderRadius = 33;
            this.btnGenerarReportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarReportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerarReportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerarReportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerarReportes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnGenerarReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnGenerarReportes.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReportes.Location = new System.Drawing.Point(327, 429);
            this.btnGenerarReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(190, 68);
            this.btnGenerarReportes.TabIndex = 27;
            this.btnGenerarReportes.Text = "Generar reportes";
            // 
            // UAfiliadoRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerarEst);
            this.Controls.Add(this.btnGenerarReportes);
            this.Name = "UAfiliadoRep";
            this.Size = new System.Drawing.Size(1130, 764);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnGenerarEst;
        private Guna.UI2.WinForms.Guna2Button btnGenerarReportes;
    }
}
