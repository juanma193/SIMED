namespace SIMED_V1.Forms_Para_ABM
{
    partial class ModificarEnfermero
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCerrarApp = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cmbCiudadesEnfermero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCiudadEnfermero = new System.Windows.Forms.Label();
            this.lblCalleEnfermero = new System.Windows.Forms.Label();
            this.lblNumeroCalleEnfermero = new System.Windows.Forms.Label();
            this.lblNumeroDocEnfermero = new System.Windows.Forms.Label();
            this.lblTelefonoEnfermero = new System.Windows.Forms.Label();
            this.lblApellidoEnfermero = new System.Windows.Forms.Label();
            this.lblNombreEnfermero = new System.Windows.Forms.Label();
            this.lblMatriculaEnfermero = new System.Windows.Forms.Label();
            this.lblTipoDocumentoEnfermero = new System.Windows.Forms.Label();
            this.lblEspecialidadEnfermero = new System.Windows.Forms.Label();
            this.lblBarrioEnfermero = new System.Windows.Forms.Label();
            this.txtNumeroDocEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefonoEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbEspecialidadEnfermero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbTipoDocEnfermero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnModificarEnfermero = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaNacimientoEnfermero = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbBarrioEnfermero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNumeroCalleEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCalleEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbSexoEnfermero = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdOtroEnfermero = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdFemeninoEnfermero = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdMasculinoEnfermero = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtApellidoEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatriculaEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblModificarCuenta = new System.Windows.Forms.Label();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.gbSexoEnfermero.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.CustomClick = true;
            this.btnCerrarApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.IconColor = System.Drawing.Color.DimGray;
            this.btnCerrarApp.Location = new System.Drawing.Point(1091, 11);
            this.btnCerrarApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(45, 22);
            this.btnCerrarApp.TabIndex = 30;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.Location = new System.Drawing.Point(1039, 11);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 22);
            this.btnMinimizar.TabIndex = 31;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.cmbCiudadesEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblCiudadEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblCalleEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblNumeroCalleEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblNumeroDocEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblTelefonoEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblApellidoEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblNombreEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblMatriculaEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblTipoDocumentoEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblEspecialidadEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.lblBarrioEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.txtNumeroDocEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.txtTelefonoEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.cmbEspecialidadEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.cmbTipoDocEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.btnModificarEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.dtFechaNacimientoEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.cmbBarrioEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.txtNumeroCalleEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.txtCalleEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.gbSexoEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.txtApellidoEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.txtNombreEnfermero);
            this.guna2ShadowPanel1.Controls.Add(this.txtMatriculaEnfermero);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(36, 75);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.guna2ShadowPanel1.ShadowDepth = 80;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1080, 424);
            this.guna2ShadowPanel1.TabIndex = 29;
            // 
            // cmbCiudadesEnfermero
            // 
            this.cmbCiudadesEnfermero.AutoRoundedCorners = true;
            this.cmbCiudadesEnfermero.BackColor = System.Drawing.Color.Transparent;
            this.cmbCiudadesEnfermero.BorderRadius = 17;
            this.cmbCiudadesEnfermero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCiudadesEnfermero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudadesEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cmbCiudadesEnfermero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudadesEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCiudadesEnfermero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCiudadesEnfermero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCiudadesEnfermero.ItemHeight = 30;
            this.cmbCiudadesEnfermero.Location = new System.Drawing.Point(719, 168);
            this.cmbCiudadesEnfermero.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCiudadesEnfermero.Name = "cmbCiudadesEnfermero";
            this.cmbCiudadesEnfermero.Size = new System.Drawing.Size(305, 36);
            this.cmbCiudadesEnfermero.TabIndex = 13;
            this.cmbCiudadesEnfermero.TextChanged += new System.EventHandler(this.cmbCiudadesEnfermero_SelectedIndexChanged);
            // 
            // lblCiudadEnfermero
            // 
            this.lblCiudadEnfermero.AutoSize = true;
            this.lblCiudadEnfermero.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadEnfermero.Location = new System.Drawing.Point(721, 141);
            this.lblCiudadEnfermero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudadEnfermero.Name = "lblCiudadEnfermero";
            this.lblCiudadEnfermero.Size = new System.Drawing.Size(64, 23);
            this.lblCiudadEnfermero.TabIndex = 53;
            this.lblCiudadEnfermero.Text = "Ciudad";
            // 
            // lblCalleEnfermero
            // 
            this.lblCalleEnfermero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalleEnfermero.ForeColor = System.Drawing.Color.Red;
            this.lblCalleEnfermero.Location = new System.Drawing.Point(739, 63);
            this.lblCalleEnfermero.Name = "lblCalleEnfermero";
            this.lblCalleEnfermero.Size = new System.Drawing.Size(285, 17);
            this.lblCalleEnfermero.TabIndex = 52;
            this.lblCalleEnfermero.Text = "label1";
            this.lblCalleEnfermero.Visible = false;
            // 
            // lblNumeroCalleEnfermero
            // 
            this.lblNumeroCalleEnfermero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCalleEnfermero.ForeColor = System.Drawing.Color.Red;
            this.lblNumeroCalleEnfermero.Location = new System.Drawing.Point(739, 119);
            this.lblNumeroCalleEnfermero.Name = "lblNumeroCalleEnfermero";
            this.lblNumeroCalleEnfermero.Size = new System.Drawing.Size(285, 17);
            this.lblNumeroCalleEnfermero.TabIndex = 49;
            this.lblNumeroCalleEnfermero.Text = "label1";
            this.lblNumeroCalleEnfermero.Visible = false;
            // 
            // lblNumeroDocEnfermero
            // 
            this.lblNumeroDocEnfermero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocEnfermero.ForeColor = System.Drawing.Color.Red;
            this.lblNumeroDocEnfermero.Location = new System.Drawing.Point(388, 365);
            this.lblNumeroDocEnfermero.Name = "lblNumeroDocEnfermero";
            this.lblNumeroDocEnfermero.Size = new System.Drawing.Size(285, 23);
            this.lblNumeroDocEnfermero.TabIndex = 47;
            this.lblNumeroDocEnfermero.Text = "label1";
            this.lblNumeroDocEnfermero.Visible = false;
            // 
            // lblTelefonoEnfermero
            // 
            this.lblTelefonoEnfermero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoEnfermero.ForeColor = System.Drawing.Color.Red;
            this.lblTelefonoEnfermero.Location = new System.Drawing.Point(54, 277);
            this.lblTelefonoEnfermero.Name = "lblTelefonoEnfermero";
            this.lblTelefonoEnfermero.Size = new System.Drawing.Size(285, 23);
            this.lblTelefonoEnfermero.TabIndex = 46;
            this.lblTelefonoEnfermero.Text = "label1";
            this.lblTelefonoEnfermero.Visible = false;
            // 
            // lblApellidoEnfermero
            // 
            this.lblApellidoEnfermero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEnfermero.ForeColor = System.Drawing.Color.Red;
            this.lblApellidoEnfermero.Location = new System.Drawing.Point(54, 208);
            this.lblApellidoEnfermero.Name = "lblApellidoEnfermero";
            this.lblApellidoEnfermero.Size = new System.Drawing.Size(285, 23);
            this.lblApellidoEnfermero.TabIndex = 45;
            this.lblApellidoEnfermero.Text = "label1";
            this.lblApellidoEnfermero.Visible = false;
            // 
            // lblNombreEnfermero
            // 
            this.lblNombreEnfermero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEnfermero.ForeColor = System.Drawing.Color.Red;
            this.lblNombreEnfermero.Location = new System.Drawing.Point(54, 139);
            this.lblNombreEnfermero.Name = "lblNombreEnfermero";
            this.lblNombreEnfermero.Size = new System.Drawing.Size(285, 23);
            this.lblNombreEnfermero.TabIndex = 44;
            this.lblNombreEnfermero.Text = "label1";
            this.lblNombreEnfermero.Visible = false;
            // 
            // lblMatriculaEnfermero
            // 
            this.lblMatriculaEnfermero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriculaEnfermero.ForeColor = System.Drawing.Color.Red;
            this.lblMatriculaEnfermero.Location = new System.Drawing.Point(54, 70);
            this.lblMatriculaEnfermero.Name = "lblMatriculaEnfermero";
            this.lblMatriculaEnfermero.Size = new System.Drawing.Size(285, 23);
            this.lblMatriculaEnfermero.TabIndex = 43;
            this.lblMatriculaEnfermero.Text = "label1";
            this.lblMatriculaEnfermero.Visible = false;
            // 
            // lblTipoDocumentoEnfermero
            // 
            this.lblTipoDocumentoEnfermero.AutoSize = true;
            this.lblTipoDocumentoEnfermero.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumentoEnfermero.Location = new System.Drawing.Point(370, 237);
            this.lblTipoDocumentoEnfermero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDocumentoEnfermero.Name = "lblTipoDocumentoEnfermero";
            this.lblTipoDocumentoEnfermero.Size = new System.Drawing.Size(160, 23);
            this.lblTipoDocumentoEnfermero.TabIndex = 42;
            this.lblTipoDocumentoEnfermero.Text = "Tipo de documento";
            // 
            // lblEspecialidadEnfermero
            // 
            this.lblEspecialidadEnfermero.AutoSize = true;
            this.lblEspecialidadEnfermero.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadEnfermero.Location = new System.Drawing.Point(721, 288);
            this.lblEspecialidadEnfermero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidadEnfermero.Name = "lblEspecialidadEnfermero";
            this.lblEspecialidadEnfermero.Size = new System.Drawing.Size(103, 23);
            this.lblEspecialidadEnfermero.TabIndex = 41;
            this.lblEspecialidadEnfermero.Text = "Especialidad";
            // 
            // lblBarrioEnfermero
            // 
            this.lblBarrioEnfermero.AutoSize = true;
            this.lblBarrioEnfermero.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrioEnfermero.Location = new System.Drawing.Point(721, 208);
            this.lblBarrioEnfermero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrioEnfermero.Name = "lblBarrioEnfermero";
            this.lblBarrioEnfermero.Size = new System.Drawing.Size(55, 23);
            this.lblBarrioEnfermero.TabIndex = 40;
            this.lblBarrioEnfermero.Text = "Barrio";
            // 
            // txtNumeroDocEnfermero
            // 
            this.txtNumeroDocEnfermero.Animated = true;
            this.txtNumeroDocEnfermero.AutoRoundedCorners = true;
            this.txtNumeroDocEnfermero.BorderRadius = 21;
            this.txtNumeroDocEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroDocEnfermero.DefaultText = "";
            this.txtNumeroDocEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroDocEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroDocEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroDocEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroDocEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtNumeroDocEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroDocEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtNumeroDocEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroDocEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.numeros;
            this.txtNumeroDocEnfermero.Location = new System.Drawing.Point(368, 319);
            this.txtNumeroDocEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroDocEnfermero.Name = "txtNumeroDocEnfermero";
            this.txtNumeroDocEnfermero.PasswordChar = '\0';
            this.txtNumeroDocEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtNumeroDocEnfermero.PlaceholderText = "Número de documento";
            this.txtNumeroDocEnfermero.SelectedText = "";
            this.txtNumeroDocEnfermero.Size = new System.Drawing.Size(305, 44);
            this.txtNumeroDocEnfermero.TabIndex = 10;
            this.txtNumeroDocEnfermero.TextChanged += new System.EventHandler(this.txtNumeroDocEnfermero_TextChanged);
            this.txtNumeroDocEnfermero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocEnfermero_KeyPress);
            // 
            // txtTelefonoEnfermero
            // 
            this.txtTelefonoEnfermero.Animated = true;
            this.txtTelefonoEnfermero.AutoRoundedCorners = true;
            this.txtTelefonoEnfermero.BorderRadius = 21;
            this.txtTelefonoEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefonoEnfermero.DefaultText = "";
            this.txtTelefonoEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefonoEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefonoEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefonoEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefonoEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtTelefonoEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefonoEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtTelefonoEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefonoEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.phone_3;
            this.txtTelefonoEnfermero.Location = new System.Drawing.Point(34, 233);
            this.txtTelefonoEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoEnfermero.MaxLength = 10;
            this.txtTelefonoEnfermero.Name = "txtTelefonoEnfermero";
            this.txtTelefonoEnfermero.PasswordChar = '\0';
            this.txtTelefonoEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTelefonoEnfermero.PlaceholderText = "Número de teléfono";
            this.txtTelefonoEnfermero.SelectedText = "";
            this.txtTelefonoEnfermero.Size = new System.Drawing.Size(305, 44);
            this.txtTelefonoEnfermero.TabIndex = 4;
            this.txtTelefonoEnfermero.TextChanged += new System.EventHandler(this.txtTelefonoEnfermero_TextChanged);
            this.txtTelefonoEnfermero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoEnfermero_KeyPress);
            // 
            // cmbEspecialidadEnfermero
            // 
            this.cmbEspecialidadEnfermero.AutoRoundedCorners = true;
            this.cmbEspecialidadEnfermero.BackColor = System.Drawing.Color.Transparent;
            this.cmbEspecialidadEnfermero.BorderRadius = 17;
            this.cmbEspecialidadEnfermero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEspecialidadEnfermero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cmbEspecialidadEnfermero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEspecialidadEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEspecialidadEnfermero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEspecialidadEnfermero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEspecialidadEnfermero.ItemHeight = 30;
            this.cmbEspecialidadEnfermero.Location = new System.Drawing.Point(719, 315);
            this.cmbEspecialidadEnfermero.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspecialidadEnfermero.Name = "cmbEspecialidadEnfermero";
            this.cmbEspecialidadEnfermero.Size = new System.Drawing.Size(305, 36);
            this.cmbEspecialidadEnfermero.TabIndex = 15;
            // 
            // cmbTipoDocEnfermero
            // 
            this.cmbTipoDocEnfermero.AutoRoundedCorners = true;
            this.cmbTipoDocEnfermero.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoDocEnfermero.BorderRadius = 17;
            this.cmbTipoDocEnfermero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoDocEnfermero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cmbTipoDocEnfermero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDocEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDocEnfermero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoDocEnfermero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoDocEnfermero.ItemHeight = 30;
            this.cmbTipoDocEnfermero.Location = new System.Drawing.Point(368, 264);
            this.cmbTipoDocEnfermero.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoDocEnfermero.Name = "cmbTipoDocEnfermero";
            this.cmbTipoDocEnfermero.Size = new System.Drawing.Size(305, 36);
            this.cmbTipoDocEnfermero.TabIndex = 9;
            this.cmbTipoDocEnfermero.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocEnfermero_SelectedIndexChanged);
            // 
            // btnModificarEnfermero
            // 
            this.btnModificarEnfermero.Animated = true;
            this.btnModificarEnfermero.AutoRoundedCorners = true;
            this.btnModificarEnfermero.BorderRadius = 21;
            this.btnModificarEnfermero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarEnfermero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificarEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarEnfermero.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificarEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificarEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnModificarEnfermero.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnModificarEnfermero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificarEnfermero.ForeColor = System.Drawing.Color.White;
            this.btnModificarEnfermero.Location = new System.Drawing.Point(719, 365);
            this.btnModificarEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarEnfermero.Name = "btnModificarEnfermero";
            this.btnModificarEnfermero.Size = new System.Drawing.Size(305, 44);
            this.btnModificarEnfermero.TabIndex = 16;
            this.btnModificarEnfermero.Text = "Modificar enfermero";
            this.btnModificarEnfermero.Click += new System.EventHandler(this.btnModificarEnfermero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // dtFechaNacimientoEnfermero
            // 
            this.dtFechaNacimientoEnfermero.Animated = true;
            this.dtFechaNacimientoEnfermero.AutoRoundedCorners = true;
            this.dtFechaNacimientoEnfermero.BorderRadius = 21;
            this.dtFechaNacimientoEnfermero.Checked = true;
            this.dtFechaNacimientoEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dtFechaNacimientoEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFechaNacimientoEnfermero.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFechaNacimientoEnfermero.Location = new System.Drawing.Point(34, 329);
            this.dtFechaNacimientoEnfermero.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaNacimientoEnfermero.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.dtFechaNacimientoEnfermero.MinDate = new System.DateTime(1959, 1, 1, 0, 0, 0, 0);
            this.dtFechaNacimientoEnfermero.Name = "dtFechaNacimientoEnfermero";
            this.dtFechaNacimientoEnfermero.Size = new System.Drawing.Size(305, 44);
            this.dtFechaNacimientoEnfermero.TabIndex = 5;
            this.dtFechaNacimientoEnfermero.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // cmbBarrioEnfermero
            // 
            this.cmbBarrioEnfermero.AutoRoundedCorners = true;
            this.cmbBarrioEnfermero.BackColor = System.Drawing.Color.Transparent;
            this.cmbBarrioEnfermero.BorderRadius = 17;
            this.cmbBarrioEnfermero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBarrioEnfermero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrioEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cmbBarrioEnfermero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBarrioEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBarrioEnfermero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBarrioEnfermero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBarrioEnfermero.ItemHeight = 30;
            this.cmbBarrioEnfermero.Location = new System.Drawing.Point(719, 235);
            this.cmbBarrioEnfermero.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBarrioEnfermero.Name = "cmbBarrioEnfermero";
            this.cmbBarrioEnfermero.Size = new System.Drawing.Size(305, 36);
            this.cmbBarrioEnfermero.TabIndex = 14;
            // 
            // txtNumeroCalleEnfermero
            // 
            this.txtNumeroCalleEnfermero.Animated = true;
            this.txtNumeroCalleEnfermero.AutoRoundedCorners = true;
            this.txtNumeroCalleEnfermero.BorderRadius = 16;
            this.txtNumeroCalleEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroCalleEnfermero.DefaultText = "";
            this.txtNumeroCalleEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroCalleEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroCalleEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroCalleEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroCalleEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtNumeroCalleEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroCalleEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtNumeroCalleEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroCalleEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.calle;
            this.txtNumeroCalleEnfermero.Location = new System.Drawing.Point(719, 82);
            this.txtNumeroCalleEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroCalleEnfermero.MaxLength = 5;
            this.txtNumeroCalleEnfermero.Name = "txtNumeroCalleEnfermero";
            this.txtNumeroCalleEnfermero.PasswordChar = '\0';
            this.txtNumeroCalleEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtNumeroCalleEnfermero.PlaceholderText = "Número de calle";
            this.txtNumeroCalleEnfermero.SelectedText = "";
            this.txtNumeroCalleEnfermero.Size = new System.Drawing.Size(305, 35);
            this.txtNumeroCalleEnfermero.TabIndex = 12;
            this.txtNumeroCalleEnfermero.TextChanged += new System.EventHandler(this.txtNumeroCalleEnfermero_TextChanged);
            this.txtNumeroCalleEnfermero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCalleEnfermero_KeyPress);
            // 
            // txtCalleEnfermero
            // 
            this.txtCalleEnfermero.Animated = true;
            this.txtCalleEnfermero.AutoRoundedCorners = true;
            this.txtCalleEnfermero.BorderRadius = 16;
            this.txtCalleEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalleEnfermero.DefaultText = "";
            this.txtCalleEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCalleEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCalleEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCalleEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCalleEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtCalleEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCalleEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtCalleEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCalleEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.calle;
            this.txtCalleEnfermero.Location = new System.Drawing.Point(719, 26);
            this.txtCalleEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalleEnfermero.MaxLength = 30;
            this.txtCalleEnfermero.Name = "txtCalleEnfermero";
            this.txtCalleEnfermero.PasswordChar = '\0';
            this.txtCalleEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtCalleEnfermero.PlaceholderText = "Calle";
            this.txtCalleEnfermero.SelectedText = "";
            this.txtCalleEnfermero.Size = new System.Drawing.Size(305, 35);
            this.txtCalleEnfermero.TabIndex = 11;
            this.txtCalleEnfermero.TextChanged += new System.EventHandler(this.txtCalleEnfermero_TextChanged);
            this.txtCalleEnfermero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalleEnfermero_KeyPress);
            // 
            // gbSexoEnfermero
            // 
            this.gbSexoEnfermero.Controls.Add(this.rdOtroEnfermero);
            this.gbSexoEnfermero.Controls.Add(this.rdFemeninoEnfermero);
            this.gbSexoEnfermero.Controls.Add(this.rdMasculinoEnfermero);
            this.gbSexoEnfermero.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.gbSexoEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbSexoEnfermero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbSexoEnfermero.Location = new System.Drawing.Point(374, 26);
            this.gbSexoEnfermero.Margin = new System.Windows.Forms.Padding(4);
            this.gbSexoEnfermero.Name = "gbSexoEnfermero";
            this.gbSexoEnfermero.Size = new System.Drawing.Size(305, 190);
            this.gbSexoEnfermero.TabIndex = 20;
            this.gbSexoEnfermero.Text = "Sexo";
            // 
            // rdOtroEnfermero
            // 
            this.rdOtroEnfermero.AutoSize = true;
            this.rdOtroEnfermero.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.rdOtroEnfermero.CheckedState.BorderThickness = 0;
            this.rdOtroEnfermero.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.rdOtroEnfermero.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdOtroEnfermero.CheckedState.InnerOffset = -4;
            this.rdOtroEnfermero.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rdOtroEnfermero.Location = new System.Drawing.Point(17, 145);
            this.rdOtroEnfermero.Margin = new System.Windows.Forms.Padding(4);
            this.rdOtroEnfermero.Name = "rdOtroEnfermero";
            this.rdOtroEnfermero.Size = new System.Drawing.Size(59, 23);
            this.rdOtroEnfermero.TabIndex = 8;
            this.rdOtroEnfermero.Text = "Otro";
            this.rdOtroEnfermero.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.rdOtroEnfermero.UncheckedState.BorderThickness = 2;
            this.rdOtroEnfermero.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdOtroEnfermero.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdFemeninoEnfermero
            // 
            this.rdFemeninoEnfermero.AutoSize = true;
            this.rdFemeninoEnfermero.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.rdFemeninoEnfermero.CheckedState.BorderThickness = 0;
            this.rdFemeninoEnfermero.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.rdFemeninoEnfermero.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdFemeninoEnfermero.CheckedState.InnerOffset = -4;
            this.rdFemeninoEnfermero.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rdFemeninoEnfermero.Location = new System.Drawing.Point(17, 65);
            this.rdFemeninoEnfermero.Margin = new System.Windows.Forms.Padding(4);
            this.rdFemeninoEnfermero.Name = "rdFemeninoEnfermero";
            this.rdFemeninoEnfermero.Size = new System.Drawing.Size(90, 23);
            this.rdFemeninoEnfermero.TabIndex = 6;
            this.rdFemeninoEnfermero.Text = "Femenino";
            this.rdFemeninoEnfermero.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.rdFemeninoEnfermero.UncheckedState.BorderThickness = 2;
            this.rdFemeninoEnfermero.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdFemeninoEnfermero.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdMasculinoEnfermero
            // 
            this.rdMasculinoEnfermero.AutoSize = true;
            this.rdMasculinoEnfermero.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.rdMasculinoEnfermero.CheckedState.BorderThickness = 0;
            this.rdMasculinoEnfermero.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.rdMasculinoEnfermero.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdMasculinoEnfermero.CheckedState.InnerOffset = -4;
            this.rdMasculinoEnfermero.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rdMasculinoEnfermero.Location = new System.Drawing.Point(17, 105);
            this.rdMasculinoEnfermero.Margin = new System.Windows.Forms.Padding(4);
            this.rdMasculinoEnfermero.Name = "rdMasculinoEnfermero";
            this.rdMasculinoEnfermero.Size = new System.Drawing.Size(92, 23);
            this.rdMasculinoEnfermero.TabIndex = 7;
            this.rdMasculinoEnfermero.Text = "Masculino";
            this.rdMasculinoEnfermero.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.rdMasculinoEnfermero.UncheckedState.BorderThickness = 2;
            this.rdMasculinoEnfermero.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdMasculinoEnfermero.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txtApellidoEnfermero
            // 
            this.txtApellidoEnfermero.Animated = true;
            this.txtApellidoEnfermero.AutoRoundedCorners = true;
            this.txtApellidoEnfermero.BorderRadius = 21;
            this.txtApellidoEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoEnfermero.DefaultText = "";
            this.txtApellidoEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtApellidoEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtApellidoEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtApellidoEnfermero.Location = new System.Drawing.Point(34, 164);
            this.txtApellidoEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoEnfermero.MaxLength = 30;
            this.txtApellidoEnfermero.Name = "txtApellidoEnfermero";
            this.txtApellidoEnfermero.PasswordChar = '\0';
            this.txtApellidoEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtApellidoEnfermero.PlaceholderText = "Apellido";
            this.txtApellidoEnfermero.SelectedText = "";
            this.txtApellidoEnfermero.Size = new System.Drawing.Size(305, 44);
            this.txtApellidoEnfermero.TabIndex = 3;
            this.txtApellidoEnfermero.TextChanged += new System.EventHandler(this.txtApellidoEnfermero_TextChanged);
            this.txtApellidoEnfermero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoEnfermero_KeyPress);
            // 
            // txtNombreEnfermero
            // 
            this.txtNombreEnfermero.Animated = true;
            this.txtNombreEnfermero.AutoRoundedCorners = true;
            this.txtNombreEnfermero.BorderRadius = 21;
            this.txtNombreEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreEnfermero.DefaultText = "";
            this.txtNombreEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtNombreEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtNombreEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtNombreEnfermero.Location = new System.Drawing.Point(34, 95);
            this.txtNombreEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEnfermero.MaxLength = 30;
            this.txtNombreEnfermero.Name = "txtNombreEnfermero";
            this.txtNombreEnfermero.PasswordChar = '\0';
            this.txtNombreEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtNombreEnfermero.PlaceholderText = "Nombre";
            this.txtNombreEnfermero.SelectedText = "";
            this.txtNombreEnfermero.Size = new System.Drawing.Size(305, 44);
            this.txtNombreEnfermero.TabIndex = 2;
            this.txtNombreEnfermero.TextChanged += new System.EventHandler(this.txtNombreEnfermero_TextChanged);
            this.txtNombreEnfermero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEnfermero_KeyPress);
            // 
            // txtMatriculaEnfermero
            // 
            this.txtMatriculaEnfermero.Animated = true;
            this.txtMatriculaEnfermero.AutoRoundedCorners = true;
            this.txtMatriculaEnfermero.BorderRadius = 21;
            this.txtMatriculaEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatriculaEnfermero.DefaultText = "";
            this.txtMatriculaEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatriculaEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatriculaEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatriculaEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatriculaEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtMatriculaEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatriculaEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtMatriculaEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatriculaEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.numbers;
            this.txtMatriculaEnfermero.IconLeftSize = new System.Drawing.Size(30, 20);
            this.txtMatriculaEnfermero.Location = new System.Drawing.Point(34, 26);
            this.txtMatriculaEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatriculaEnfermero.MaxLength = 10;
            this.txtMatriculaEnfermero.Name = "txtMatriculaEnfermero";
            this.txtMatriculaEnfermero.PasswordChar = '\0';
            this.txtMatriculaEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMatriculaEnfermero.PlaceholderText = "Número de matrícula";
            this.txtMatriculaEnfermero.SelectedText = "";
            this.txtMatriculaEnfermero.Size = new System.Drawing.Size(305, 44);
            this.txtMatriculaEnfermero.TabIndex = 1;
            this.txtMatriculaEnfermero.TextChanged += new System.EventHandler(this.txtMatriculaEnfermero_TextChanged);
            this.txtMatriculaEnfermero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatriculaEnfermero_KeyPress);
            // 
            // lblModificarCuenta
            // 
            this.lblModificarCuenta.AutoSize = true;
            this.lblModificarCuenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCuenta.Location = new System.Drawing.Point(29, 30);
            this.lblModificarCuenta.Name = "lblModificarCuenta";
            this.lblModificarCuenta.Size = new System.Drawing.Size(311, 41);
            this.lblModificarCuenta.TabIndex = 28;
            this.lblModificarCuenta.Text = "Modificar enfermero";
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
            this.btnVolver.Location = new System.Drawing.Point(36, 506);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 46);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ModificarEnfermero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 563);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCerrarApp);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.lblModificarCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarEnfermero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarEnfermero";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.gbSexoEnfermero.ResumeLayout(false);
            this.gbSexoEnfermero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrarApp;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public Guna.UI2.WinForms.Guna2ComboBox cmbCiudadesEnfermero;
        private System.Windows.Forms.Label lblCiudadEnfermero;
        private System.Windows.Forms.Label lblCalleEnfermero;
        private System.Windows.Forms.Label lblNumeroCalleEnfermero;
        private System.Windows.Forms.Label lblNumeroDocEnfermero;
        private System.Windows.Forms.Label lblTelefonoEnfermero;
        private System.Windows.Forms.Label lblApellidoEnfermero;
        private System.Windows.Forms.Label lblNombreEnfermero;
        private System.Windows.Forms.Label lblMatriculaEnfermero;
        private System.Windows.Forms.Label lblTipoDocumentoEnfermero;
        private System.Windows.Forms.Label lblEspecialidadEnfermero;
        private System.Windows.Forms.Label lblBarrioEnfermero;
        public Guna.UI2.WinForms.Guna2TextBox txtNumeroDocEnfermero;
        public Guna.UI2.WinForms.Guna2TextBox txtTelefonoEnfermero;
        public Guna.UI2.WinForms.Guna2ComboBox cmbEspecialidadEnfermero;
        public Guna.UI2.WinForms.Guna2ComboBox cmbTipoDocEnfermero;
        public Guna.UI2.WinForms.Guna2GradientButton btnModificarEnfermero;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtFechaNacimientoEnfermero;
        public Guna.UI2.WinForms.Guna2ComboBox cmbBarrioEnfermero;
        public Guna.UI2.WinForms.Guna2TextBox txtNumeroCalleEnfermero;
        public Guna.UI2.WinForms.Guna2TextBox txtCalleEnfermero;
        private Guna.UI2.WinForms.Guna2GroupBox gbSexoEnfermero;
        public Guna.UI2.WinForms.Guna2RadioButton rdOtroEnfermero;
        public Guna.UI2.WinForms.Guna2RadioButton rdFemeninoEnfermero;
        public Guna.UI2.WinForms.Guna2RadioButton rdMasculinoEnfermero;
        public Guna.UI2.WinForms.Guna2TextBox txtApellidoEnfermero;
        public Guna.UI2.WinForms.Guna2TextBox txtNombreEnfermero;
        public Guna.UI2.WinForms.Guna2TextBox txtMatriculaEnfermero;
        public System.Windows.Forms.Label lblModificarCuenta;
    }
}