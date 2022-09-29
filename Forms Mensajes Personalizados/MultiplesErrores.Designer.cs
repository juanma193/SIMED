namespace SIMED_V1.Forms_Mensajes_Personalizados
{
    partial class MultiplesErrores
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
            this.components = new System.ComponentModel.Container();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrarApp = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMostrarDetalles = new Guna.UI2.WinForms.Guna2Button();
            this.picWarning = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(156, 81);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(612, 121);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "label1";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnCerrarApp);
            this.guna2Panel1.Controls.Add(this.btnMinimizar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 30);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.IconColor = System.Drawing.Color.DimGray;
            this.btnCerrarApp.Location = new System.Drawing.Point(743, 5);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(45, 22);
            this.btnCerrarApp.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.Location = new System.Drawing.Point(692, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 22);
            this.btnMinimizar.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Animated = true;
            this.btnAceptar.AutoRoundedCorners = true;
            this.btnAceptar.BorderRadius = 30;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnAceptar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(267, 406);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(264, 63);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnMostrarDetalles
            // 
            this.btnMostrarDetalles.Animated = true;
            this.btnMostrarDetalles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMostrarDetalles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMostrarDetalles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMostrarDetalles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMostrarDetalles.FillColor = System.Drawing.Color.Transparent;
            this.btnMostrarDetalles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarDetalles.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarDetalles.Image = global::SIMED_V1.Properties.Resources.triangle_up;
            this.btnMostrarDetalles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMostrarDetalles.ImageOffset = new System.Drawing.Point(0, -1);
            this.btnMostrarDetalles.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMostrarDetalles.Location = new System.Drawing.Point(29, 215);
            this.btnMostrarDetalles.Name = "btnMostrarDetalles";
            this.btnMostrarDetalles.Size = new System.Drawing.Size(180, 45);
            this.btnMostrarDetalles.TabIndex = 1;
            this.btnMostrarDetalles.Text = "Mostrar Detalles";
            this.btnMostrarDetalles.Click += new System.EventHandler(this.mostrarDetalles_Click);
            // 
            // picWarning
            // 
            this.picWarning.Image = global::SIMED_V1.Properties.Resources.icons8_warning_48;
            this.picWarning.ImageRotate = 0F;
            this.picWarning.Location = new System.Drawing.Point(29, 81);
            this.picWarning.Name = "picWarning";
            this.picWarning.Size = new System.Drawing.Size(75, 79);
            this.picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWarning.TabIndex = 7;
            this.picWarning.TabStop = false;
            // 
            // lblDetalles
            // 
            this.lblDetalles.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(95, 263);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(612, 121);
            this.lblDetalles.TabIndex = 2;
            this.lblDetalles.Text = "label1";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MultiplesErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.btnMostrarDetalles);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.picWarning);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MultiplesErrores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiplesErrores";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MultiplesErrores_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btnMostrarDetalles;
        private System.Windows.Forms.Label lblMensaje;
        private Guna.UI2.WinForms.Guna2PictureBox picWarning;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrarApp;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2GradientButton btnAceptar;
        private System.Windows.Forms.Label lblDetalles;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}