namespace SIMED_V1
{
    partial class UEnfermeros
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
            this.btnConsultaEnfermero = new Guna.UI2.WinForms.Guna2Button();
            this.btnAltaEnfermero = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Seleccione una de las siguientes opciones";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 51);
            this.label1.TabIndex = 21;
            this.label1.Text = "ENFERMEROS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConsultaEnfermero
            // 
            this.btnConsultaEnfermero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultaEnfermero.Animated = true;
            this.btnConsultaEnfermero.AutoRoundedCorners = true;
            this.btnConsultaEnfermero.BorderRadius = 33;
            this.btnConsultaEnfermero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaEnfermero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultaEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultaEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnConsultaEnfermero.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultaEnfermero.ForeColor = System.Drawing.Color.White;
            this.btnConsultaEnfermero.Location = new System.Drawing.Point(386, 276);
            this.btnConsultaEnfermero.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaEnfermero.Name = "btnConsultaEnfermero";
            this.btnConsultaEnfermero.Size = new System.Drawing.Size(190, 68);
            this.btnConsultaEnfermero.TabIndex = 18;
            this.btnConsultaEnfermero.Text = "Consultar datos ";
            this.btnConsultaEnfermero.Click += new System.EventHandler(this.btnConsultaEnfermero_Click);
            // 
            // btnAltaEnfermero
            // 
            this.btnAltaEnfermero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaEnfermero.Animated = true;
            this.btnAltaEnfermero.AutoRoundedCorners = true;
            this.btnAltaEnfermero.BorderRadius = 33;
            this.btnAltaEnfermero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAltaEnfermero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAltaEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAltaEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAltaEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnAltaEnfermero.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnAltaEnfermero.ForeColor = System.Drawing.Color.White;
            this.btnAltaEnfermero.Location = new System.Drawing.Point(100, 276);
            this.btnAltaEnfermero.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltaEnfermero.Name = "btnAltaEnfermero";
            this.btnAltaEnfermero.Size = new System.Drawing.Size(190, 68);
            this.btnAltaEnfermero.TabIndex = 17;
            this.btnAltaEnfermero.Text = "Dar de alta a un enfermero";
            this.btnAltaEnfermero.Click += new System.EventHandler(this.btnAltaEnfermero_Click);
            // 
            // UEnfermeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultaEnfermero);
            this.Controls.Add(this.btnAltaEnfermero);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UEnfermeros";
            this.Size = new System.Drawing.Size(679, 518);
            this.Load += new System.EventHandler(this.UEnfermeros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnConsultaEnfermero;
        private Guna.UI2.WinForms.Guna2Button btnAltaEnfermero;
    }
}
