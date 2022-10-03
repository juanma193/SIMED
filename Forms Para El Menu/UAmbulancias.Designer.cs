namespace SIMED_V1
{
    partial class UAmbulancias
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
            this.btnConsultar = new Guna.UI2.WinForms.Guna2Button();
            this.btnDarDeAltaAmbulancia = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Seleccione una de las siguientes opciones";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "AMBULANCIAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultar.Animated = true;
            this.btnConsultar.AutoRoundedCorners = true;
            this.btnConsultar.BorderRadius = 28;
            this.btnConsultar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(244, 181);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(182, 58);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar datos ";
            this.btnConsultar.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnDarDeAltaAmbulancia
            // 
            this.btnDarDeAltaAmbulancia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDarDeAltaAmbulancia.Animated = true;
            this.btnDarDeAltaAmbulancia.AutoRoundedCorners = true;
            this.btnDarDeAltaAmbulancia.BorderRadius = 28;
            this.btnDarDeAltaAmbulancia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDarDeAltaAmbulancia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDarDeAltaAmbulancia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDarDeAltaAmbulancia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDarDeAltaAmbulancia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(191)))));
            this.btnDarDeAltaAmbulancia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDarDeAltaAmbulancia.ForeColor = System.Drawing.Color.White;
            this.btnDarDeAltaAmbulancia.Location = new System.Drawing.Point(14, 181);
            this.btnDarDeAltaAmbulancia.Margin = new System.Windows.Forms.Padding(2);
            this.btnDarDeAltaAmbulancia.Name = "btnDarDeAltaAmbulancia";
            this.btnDarDeAltaAmbulancia.Size = new System.Drawing.Size(182, 58);
            this.btnDarDeAltaAmbulancia.TabIndex = 1;
            this.btnDarDeAltaAmbulancia.Text = "Dar de alta una ambulancia";
            this.btnDarDeAltaAmbulancia.Click += new System.EventHandler(this.btnDarDeAltaUnaAmbulancia_Click);
            // 
            // UAmbulancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnDarDeAltaAmbulancia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UAmbulancias";
            this.Size = new System.Drawing.Size(459, 297);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnConsultar;
        private Guna.UI2.WinForms.Guna2Button btnDarDeAltaAmbulancia;
    }
}
