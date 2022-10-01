namespace SIMED_V1.Forms_Para_ABM
{
    partial class ModificarEmpleado
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEdad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSexo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnModEmpleado = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnModificarUsuario = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.chkUsuario = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkEmpleado = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCerrarApp = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.Location = new System.Drawing.Point(182, 103);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(442, 41);
            this.lblCrearCuenta.TabIndex = 23;
            this.lblCrearCuenta.Text = "Modificar datos del empleado";
            this.lblCrearCuenta.Click += new System.EventHandler(this.lblCrearCuenta_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Animated = true;
            this.txtApellido.AutoRoundedCorners = true;
            this.txtApellido.BorderRadius = 17;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.DefaultText = "";
            this.txtApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellido.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellido.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtApellido.Location = new System.Drawing.Point(55, 265);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(305, 36);
            this.txtApellido.TabIndex = 26;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Animated = true;
            this.txtNombre.AutoRoundedCorners = true;
            this.txtNombre.BorderRadius = 17;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtNombre.Location = new System.Drawing.Point(55, 168);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(305, 36);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Animated = true;
            this.txtEdad.AutoRoundedCorners = true;
            this.txtEdad.BorderRadius = 17;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.DefaultText = "";
            this.txtEdad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEdad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEdad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtEdad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtEdad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdad.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtEdad.Location = new System.Drawing.Point(409, 168);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtEdad.PlaceholderText = "Edad";
            this.txtEdad.SelectedText = "";
            this.txtEdad.Size = new System.Drawing.Size(305, 36);
            this.txtEdad.TabIndex = 27;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtSexo
            // 
            this.txtSexo.Animated = true;
            this.txtSexo.AutoRoundedCorners = true;
            this.txtSexo.BorderRadius = 17;
            this.txtSexo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSexo.DefaultText = "";
            this.txtSexo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSexo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSexo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSexo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSexo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSexo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtSexo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSexo.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtSexo.Location = new System.Drawing.Point(409, 265);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.PasswordChar = '\0';
            this.txtSexo.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSexo.PlaceholderText = "Sexo";
            this.txtSexo.SelectedText = "";
            this.txtSexo.Size = new System.Drawing.Size(305, 36);
            this.txtSexo.TabIndex = 28;
            this.txtSexo.TextChanged += new System.EventHandler(this.txtSexo_TextChanged);
            this.txtSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSexo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 41);
            this.label1.TabIndex = 29;
            this.label1.Text = "Modificar datos del usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMail
            // 
            this.txtMail.Animated = true;
            this.txtMail.AutoRoundedCorners = true;
            this.txtMail.BorderRadius = 17;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.IconLeft = global::SIMED_V1.Properties.Resources.icono_mail;
            this.txtMail.Location = new System.Drawing.Point(409, 510);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMail.PlaceholderText = "Email";
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(305, 36);
            this.txtMail.TabIndex = 31;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Animated = true;
            this.txtNombreUsuario.AutoRoundedCorners = true;
            this.txtNombreUsuario.BorderRadius = 17;
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
            this.txtNombreUsuario.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtNombreUsuario.Location = new System.Drawing.Point(38, 510);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtNombreUsuario.PlaceholderText = "Nombre De Usuario";
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.Size = new System.Drawing.Size(305, 36);
            this.txtNombreUsuario.TabIndex = 30;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // btnModEmpleado
            // 
            this.btnModEmpleado.Animated = true;
            this.btnModEmpleado.AutoRoundedCorners = true;
            this.btnModEmpleado.BorderRadius = 21;
            this.btnModEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModEmpleado.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnModEmpleado.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnModEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnModEmpleado.Location = new System.Drawing.Point(38, 365);
            this.btnModEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModEmpleado.Name = "btnModEmpleado";
            this.btnModEmpleado.Size = new System.Drawing.Size(676, 44);
            this.btnModEmpleado.TabIndex = 41;
            this.btnModEmpleado.Text = "Modificar empleado";
            this.btnModEmpleado.Click += new System.EventHandler(this.btnModEmpleado_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Animated = true;
            this.btnModificarUsuario.AutoRoundedCorners = true;
            this.btnModificarUsuario.BorderRadius = 21;
            this.btnModificarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarUsuario.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnModificarUsuario.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnModificarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnModificarUsuario.Location = new System.Drawing.Point(38, 614);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(676, 44);
            this.btnModificarUsuario.TabIndex = 42;
            this.btnModificarUsuario.Text = "Modificar usuario";
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.chkUsuario);
            this.guna2ShadowPanel1.Controls.Add(this.chkEmpleado);
            this.guna2ShadowPanel1.Controls.Add(this.lblEmail);
            this.guna2ShadowPanel1.Controls.Add(this.lblNombreUsuario);
            this.guna2ShadowPanel1.Controls.Add(this.lblSexo);
            this.guna2ShadowPanel1.Controls.Add(this.lblApellido);
            this.guna2ShadowPanel1.Controls.Add(this.lblEdad);
            this.guna2ShadowPanel1.Controls.Add(this.lblNombre);
            this.guna2ShadowPanel1.Controls.Add(this.lblCrearCuenta);
            this.guna2ShadowPanel1.Controls.Add(this.btnModificarUsuario);
            this.guna2ShadowPanel1.Controls.Add(this.txtNombre);
            this.guna2ShadowPanel1.Controls.Add(this.btnModEmpleado);
            this.guna2ShadowPanel1.Controls.Add(this.txtApellido);
            this.guna2ShadowPanel1.Controls.Add(this.txtMail);
            this.guna2ShadowPanel1.Controls.Add(this.txtEdad);
            this.guna2ShadowPanel1.Controls.Add(this.txtNombreUsuario);
            this.guna2ShadowPanel1.Controls.Add(this.txtSexo);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(78, 59);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.guna2ShadowPanel1.ShadowDepth = 80;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(799, 710);
            this.guna2ShadowPanel1.TabIndex = 43;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.chkUsuario_Paint);
            // 
            // chkUsuario
            // 
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkUsuario.CheckedState.BorderRadius = 0;
            this.chkUsuario.CheckedState.BorderThickness = 0;
            this.chkUsuario.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkUsuario.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.chkUsuario.Location = new System.Drawing.Point(437, 48);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(235, 27);
            this.chkUsuario.TabIndex = 50;
            this.chkUsuario.Text = "Quiero modificar el usuario";
            this.chkUsuario.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.chkUsuario.UncheckedState.BorderRadius = 0;
            this.chkUsuario.UncheckedState.BorderThickness = 0;
            this.chkUsuario.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.chkUsuario.CheckedChanged += new System.EventHandler(this.chkUsuario_CheckedChanged);
            // 
            // chkEmpleado
            // 
            this.chkEmpleado.AutoSize = true;
            this.chkEmpleado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEmpleado.CheckedState.BorderRadius = 0;
            this.chkEmpleado.CheckedState.BorderThickness = 0;
            this.chkEmpleado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEmpleado.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F);
            this.chkEmpleado.Location = new System.Drawing.Point(109, 48);
            this.chkEmpleado.Name = "chkEmpleado";
            this.chkEmpleado.Size = new System.Drawing.Size(256, 27);
            this.chkEmpleado.TabIndex = 49;
            this.chkEmpleado.Text = "Quiero modificar el empleado";
            this.chkEmpleado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkEmpleado.UncheckedState.BorderRadius = 0;
            this.chkEmpleado.UncheckedState.BorderThickness = 0;
            this.chkEmpleado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.chkEmpleado.CheckedChanged += new System.EventHandler(this.chkEmpleado_CheckedChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(412, 562);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(302, 23);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "label1";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblNombreUsuario.Location = new System.Drawing.Point(41, 562);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(302, 23);
            this.lblNombreUsuario.TabIndex = 47;
            this.lblNombreUsuario.Text = "label1";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.Red;
            this.lblSexo.Location = new System.Drawing.Point(412, 321);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(302, 23);
            this.lblSexo.TabIndex = 46;
            this.lblSexo.Text = "label1";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Red;
            this.lblApellido.Location = new System.Drawing.Point(58, 321);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(302, 23);
            this.lblApellido.TabIndex = 45;
            this.lblApellido.Text = "label1";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.Red;
            this.lblEdad.Location = new System.Drawing.Point(412, 225);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(302, 23);
            this.lblEdad.TabIndex = 44;
            this.lblEdad.Text = "label1";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Red;
            this.lblNombre.Location = new System.Drawing.Point(58, 225);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(302, 23);
            this.lblNombre.TabIndex = 43;
            this.lblNombre.Text = "label1";
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.IconColor = System.Drawing.Color.DimGray;
            this.btnCerrarApp.Location = new System.Drawing.Point(912, 11);
            this.btnCerrarApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(45, 22);
            this.btnCerrarApp.TabIndex = 46;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.Location = new System.Drawing.Point(860, 11);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 22);
            this.btnMinimizar.TabIndex = 47;
            // 
            // btnVolver
            // 
            this.btnVolver.Animated = true;
            this.btnVolver.AutoRoundedCorners = true;
            this.btnVolver.BorderRadius = 22;
            this.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolver.FillColor = System.Drawing.Color.Transparent;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Image = global::SIMED_V1.Properties.Resources.left_arrow;
            this.btnVolver.Location = new System.Drawing.Point(419, 774);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 46);
            this.btnVolver.TabIndex = 48;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 828);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCerrarApp);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarEmpleado";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ModificarEmpleado_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label lblCrearCuenta;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSexo;
        private Guna.UI2.WinForms.Guna2TextBox txtEdad;
        private Guna.UI2.WinForms.Guna2TextBox txtApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnModificarUsuario;
        private Guna.UI2.WinForms.Guna2GradientButton btnModEmpleado;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrarApp;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2CheckBox chkEmpleado;
        private Guna.UI2.WinForms.Guna2CheckBox chkUsuario;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
    }
}