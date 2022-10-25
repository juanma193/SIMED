namespace SIMED_V1.Forms_Mensajes_Personalizados
{
    partial class Cerrar_Sesion
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
            this.btnCerrarApp = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.picWarning = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.IconColor = System.Drawing.Color.DimGray;
            this.btnCerrarApp.Location = new System.Drawing.Point(476, 4);
            this.btnCerrarApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(34, 18);
            this.btnCerrarApp.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.Location = new System.Drawing.Point(437, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 18);
            this.btnMinimizar.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(123, 68);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(316, 42);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "¿Está seguro de que desea cerrar su sesión y salir del programa?";
            // 
            // picWarning
            // 
            this.picWarning.Image = global::SIMED_V1.Properties.Resources.icons8_warning_48;
            this.picWarning.ImageRotate = 0F;
            this.picWarning.Location = new System.Drawing.Point(27, 46);
            this.picWarning.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picWarning.Name = "picWarning";
            this.picWarning.Size = new System.Drawing.Size(56, 64);
            this.picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWarning.TabIndex = 7;
            this.picWarning.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnCerrarApp);
            this.guna2Panel1.Controls.Add(this.btnMinimizar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(518, 24);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Animated = true;
            this.btnCerrarSesion.AutoRoundedCorners = true;
            this.btnCerrarSesion.BorderRadius = 16;
            this.btnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnCerrarSesion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(106, 141);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(146, 35);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Animated = true;
            this.btnCancelar.AutoRoundedCorners = true;
            this.btnCancelar.BorderRadius = 16;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnCancelar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(280, 141);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 35);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Cerrar_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 222);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.picWarning);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnCerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cerrar_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CerrarSesion";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picWarning)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnCerrarApp;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private System.Windows.Forms.Label lblMensaje;
        private Guna.UI2.WinForms.Guna2PictureBox picWarning;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCerrarSesion;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancelar;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}