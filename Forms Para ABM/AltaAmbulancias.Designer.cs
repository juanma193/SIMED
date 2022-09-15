namespace SIMED_V1.Forms_Para_ABM
{
    partial class AltaAmbulancias
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
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.cmbModelo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnCrearAmbulancia = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnCerrarApp = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.txtNombreUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.Location = new System.Drawing.Point(39, 22);
            this.lblCrearCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(214, 32);
            this.lblCrearCuenta.TabIndex = 1;
            this.lblCrearCuenta.Text = "Crear ambulancia";
            // 
            // cmbModelo
            // 
            this.cmbModelo.AutoRoundedCorners = true;
            this.cmbModelo.BackColor = System.Drawing.Color.Transparent;
            this.cmbModelo.BorderRadius = 17;
            this.cmbModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cmbModelo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbModelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbModelo.ItemHeight = 30;
            this.cmbModelo.Location = new System.Drawing.Point(23, 78);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(229, 36);
            this.cmbModelo.TabIndex = 3;
            this.cmbModelo.SelectedIndexChanged += new System.EventHandler(this.cmbModelo_SelectedIndexChanged);
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2RadioButton1.Location = new System.Drawing.Point(13, 53);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(111, 17);
            this.guna2RadioButton1.TabIndex = 4;
            this.guna2RadioButton1.Text = "Alta complejidad";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2RadioButton2.Location = new System.Drawing.Point(13, 76);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(112, 17);
            this.guna2RadioButton2.TabIndex = 5;
            this.guna2RadioButton2.Text = "Baja complejidad";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2ShadowPanel1.Controls.Add(this.txtNombreUsuario);
            this.guna2ShadowPanel1.Controls.Add(this.cmbModelo);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(45, 70);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.guna2ShadowPanel1.ShadowDepth = 80;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(283, 281);
            this.guna2ShadowPanel1.TabIndex = 7;
            // 
            // btnCrearAmbulancia
            // 
            this.btnCrearAmbulancia.Animated = true;
            this.btnCrearAmbulancia.AutoRoundedCorners = true;
            this.btnCrearAmbulancia.BorderRadius = 17;
            this.btnCrearAmbulancia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearAmbulancia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCrearAmbulancia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearAmbulancia.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCrearAmbulancia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCrearAmbulancia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnCrearAmbulancia.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnCrearAmbulancia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCrearAmbulancia.ForeColor = System.Drawing.Color.White;
            this.btnCrearAmbulancia.Location = new System.Drawing.Point(141, 365);
            this.btnCrearAmbulancia.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearAmbulancia.Name = "btnCrearAmbulancia";
            this.btnCrearAmbulancia.Size = new System.Drawing.Size(187, 37);
            this.btnCrearAmbulancia.TabIndex = 8;
            this.btnCrearAmbulancia.Text = "Crear Ambulancia";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2RadioButton1);
            this.guna2GroupBox1.Controls.Add(this.guna2RadioButton2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(23, 145);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(229, 102);
            this.guna2GroupBox1.TabIndex = 20;
            this.guna2GroupBox1.Text = "Complejidad ";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.IconColor = System.Drawing.Color.DimGray;
            this.btnCerrarApp.Location = new System.Drawing.Point(333, 1);
            this.btnCerrarApp.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(34, 18);
            this.btnCerrarApp.TabIndex = 20;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.Location = new System.Drawing.Point(294, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 18);
            this.btnMinimizar.TabIndex = 21;
            // 
            // btnVolver
            // 
            this.btnVolver.Animated = true;
            this.btnVolver.AutoRoundedCorners = true;
            this.btnVolver.BorderRadius = 17;
            this.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolver.FillColor = System.Drawing.Color.Transparent;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Image = global::SIMED_V1.Properties.Resources.left_arrow;
            this.btnVolver.Location = new System.Drawing.Point(45, 365);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 37);
            this.btnVolver.TabIndex = 19;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Animated = true;
            this.txtNombreUsuario.AutoRoundedCorners = true;
            this.txtNombreUsuario.BorderRadius = 13;
            this.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUsuario.DefaultText = "";
            this.txtNombreUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtNombreUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtNombreUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreUsuario.IconLeft = global::SIMED_V1.Properties.Resources.numbers;
            this.txtNombreUsuario.IconLeftSize = new System.Drawing.Size(30, 20);
            this.txtNombreUsuario.Location = new System.Drawing.Point(23, 21);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtNombreUsuario.PlaceholderText = "Patente";
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.Size = new System.Drawing.Size(229, 29);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // AltaAmbulancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 420);
            this.Controls.Add(this.btnCerrarApp);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrearAmbulancia);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.lblCrearCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaAmbulancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaAmbulancias";
            this.TopMost = true;
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrearCuenta;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModelo;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCrearAmbulancia;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrarApp;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
    }
}