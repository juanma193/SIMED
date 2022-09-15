namespace SIMED_V1
{
    partial class VerificarMailForm
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCrearCuenta = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo1.Location = new System.Drawing.Point(6, 24);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(624, 109);
            this.lblCodigo1.TabIndex = 7;
            this.lblCodigo1.Text = "Te hemos enviado un correo con el código de verificación. Ingresalo a continuació" +
    "n para poder crear el usuario";
            this.lblCodigo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.Location = new System.Drawing.Point(36, 59);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(200, 41);
            this.lblCrearCuenta.TabIndex = 8;
            this.lblCrearCuenta.Text = "Crear Cuenta";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.Location = new System.Drawing.Point(616, 11);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 22);
            this.btnMinimizar.TabIndex = 11;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.btnMinimizar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(734, 36);
            this.guna2Panel1.TabIndex = 9;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(677, 11);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 22);
            this.guna2ControlBox1.TabIndex = 12;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Animated = true;
            this.btnCrearCuenta.AutoRoundedCorners = true;
            this.btnCrearCuenta.BorderRadius = 21;
            this.btnCrearCuenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearCuenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearCuenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearCuenta.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearCuenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearCuenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnCrearCuenta.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Location = new System.Drawing.Point(91, 227);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(428, 45);
            this.btnCrearCuenta.TabIndex = 11;
            this.btnCrearCuenta.Text = "Confirmar creación de cuenta";
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblCodigo1);
            this.guna2ShadowPanel1.Controls.Add(this.btnCrearCuenta);
            this.guna2ShadowPanel1.Controls.Add(this.txtCodigo);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(31, 115);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.guna2ShadowPanel1.ShadowDepth = 80;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(650, 305);
            this.guna2ShadowPanel1.TabIndex = 12;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Image = global::SIMED_V1.Properties.Resources.home;
            this.guna2Button1.Location = new System.Drawing.Point(260, 442);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Home";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Animated = true;
            this.txtCodigo.AutoRoundedCorners = true;
            this.txtCodigo.BorderRadius = 23;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.IconLeft = global::SIMED_V1.Properties.Resources.numeros;
            this.txtCodigo.Location = new System.Drawing.Point(170, 147);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.PlaceholderText = "Ingresa el codigo";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(272, 48);
            this.txtCodigo.TabIndex = 10;
            // 
            // btnVolver
            // 
            this.btnVolver.Animated = true;
            this.btnVolver.AutoRoundedCorners = true;
            this.btnVolver.BorderRadius = 21;
            this.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolver.FillColor = System.Drawing.Color.Transparent;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Image = global::SIMED_V1.Properties.Resources.left_arrow;
            this.btnVolver.Location = new System.Drawing.Point(31, 442);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 45);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // VerificarMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 532);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblCrearCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerificarMailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerificarMailForm";
            this.Load += new System.EventHandler(this.VerificarMailForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Label lblCrearCuenta;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2GradientButton btnCrearCuenta;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
    }
}