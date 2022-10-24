namespace SIMED_V1.Forms_Para_ABM
{
    partial class ConsultarViaje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarViaje = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnModificar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblConsultarViaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaViaje = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbMoviles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCerrarApp = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gbViajes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarPorPatente = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBuscarPorDatos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chkIncluirFechas = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtMatriculaEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatriculaMedico = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.txtConsultaApellidoEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConsultaNombreEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConsultaApellidoMedico = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConsultaNombreMedico = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscarPorMatricula = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiarGrilla = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarViaje
            // 
            this.btnBuscarViaje.Animated = true;
            this.btnBuscarViaje.AutoRoundedCorners = true;
            this.btnBuscarViaje.BorderRadius = 18;
            this.btnBuscarViaje.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarViaje.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarViaje.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarViaje.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarViaje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarViaje.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnBuscarViaje.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnBuscarViaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarViaje.ForeColor = System.Drawing.Color.White;
            this.btnBuscarViaje.Location = new System.Drawing.Point(52, 398);
            this.btnBuscarViaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarViaje.Name = "btnBuscarViaje";
            this.btnBuscarViaje.Size = new System.Drawing.Size(370, 39);
            this.btnBuscarViaje.TabIndex = 60;
            this.btnBuscarViaje.Text = "Buscar";
            this.btnBuscarViaje.Click += new System.EventHandler(this.btnBuscarViaje_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Animated = true;
            this.btnEliminar.AutoRoundedCorners = true;
            this.btnEliminar.BorderRadius = 21;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnEliminar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(760, 773);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(643, 44);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar viaje";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Animated = true;
            this.btnModificar.AutoRoundedCorners = true;
            this.btnModificar.BorderRadius = 21;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnModificar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(80, 773);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(636, 44);
            this.btnModificar.TabIndex = 57;
            this.btnModificar.Text = "Modificar datos ";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(47, 266);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(267, 23);
            this.lblBusqueda.TabIndex = 54;
            this.lblBusqueda.Text = "Búsqueda solo por fecha del viaje";
            // 
            // lblConsultarViaje
            // 
            this.lblConsultarViaje.AutoSize = true;
            this.lblConsultarViaje.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarViaje.Location = new System.Drawing.Point(47, 22);
            this.lblConsultarViaje.Name = "lblConsultarViaje";
            this.lblConsultarViaje.Size = new System.Drawing.Size(227, 41);
            this.lblConsultarViaje.TabIndex = 52;
            this.lblConsultarViaje.Text = "Consultar viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "Fecha viaje";
            // 
            // dtFechaViaje
            // 
            this.dtFechaViaje.Animated = true;
            this.dtFechaViaje.AutoRoundedCorners = true;
            this.dtFechaViaje.BorderRadius = 17;
            this.dtFechaViaje.Checked = true;
            this.dtFechaViaje.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dtFechaViaje.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFechaViaje.Location = new System.Drawing.Point(52, 338);
            this.dtFechaViaje.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaViaje.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFechaViaje.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFechaViaje.Name = "dtFechaViaje";
            this.dtFechaViaje.Size = new System.Drawing.Size(370, 36);
            this.dtFechaViaje.TabIndex = 61;
            this.dtFechaViaje.Value = new System.DateTime(2022, 9, 14, 0, 0, 0, 0);
            this.dtFechaViaje.ValueChanged += new System.EventHandler(this.dtFechaViaje_ValueChanged);
            // 
            // cmbMoviles
            // 
            this.cmbMoviles.AutoRoundedCorners = true;
            this.cmbMoviles.BackColor = System.Drawing.Color.Transparent;
            this.cmbMoviles.BorderRadius = 17;
            this.cmbMoviles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMoviles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoviles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cmbMoviles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMoviles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMoviles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMoviles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMoviles.ItemHeight = 30;
            this.cmbMoviles.Location = new System.Drawing.Point(493, 338);
            this.cmbMoviles.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMoviles.Name = "cmbMoviles";
            this.cmbMoviles.Size = new System.Drawing.Size(346, 36);
            this.cmbMoviles.TabIndex = 63;
            this.cmbMoviles.SelectedIndexChanged += new System.EventHandler(this.cmbMoviles_SelectedIndexChanged);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.IconColor = System.Drawing.Color.DimGray;
            this.btnCerrarApp.Location = new System.Drawing.Point(1472, 14);
            this.btnCerrarApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(45, 22);
            this.btnCerrarApp.TabIndex = 66;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.Location = new System.Drawing.Point(1420, 14);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 22);
            this.btnMinimizar.TabIndex = 67;
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
            // gbViajes
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gbViajes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gbViajes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.gbViajes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gbViajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gbViajes.ColumnHeadersHeight = 20;
            this.gbViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gbViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.Sexo,
            this.IdUsuario,
            this.NombreUsuario});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gbViajes.DefaultCellStyle = dataGridViewCellStyle9;
            this.gbViajes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.gbViajes.Location = new System.Drawing.Point(40, 67);
            this.gbViajes.Margin = new System.Windows.Forms.Padding(4);
            this.gbViajes.Name = "gbViajes";
            this.gbViajes.ReadOnly = true;
            this.gbViajes.RowHeadersVisible = false;
            this.gbViajes.RowHeadersWidth = 51;
            this.gbViajes.Size = new System.Drawing.Size(1466, 132);
            this.gbViajes.TabIndex = 68;
            this.gbViajes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gbViajes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gbViajes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gbViajes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gbViajes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gbViajes.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.gbViajes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.gbViajes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbViajes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gbViajes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbViajes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gbViajes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gbViajes.ThemeStyle.HeaderStyle.Height = 20;
            this.gbViajes.ThemeStyle.ReadOnly = true;
            this.gbViajes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gbViajes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gbViajes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbViajes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gbViajes.ThemeStyle.RowsStyle.Height = 22;
            this.gbViajes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gbViajes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gbViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gbViajes_CellClick);
            this.gbViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gbViajes_CellContentClick);
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Fecha";
            this.Legajo.MinimumWidth = 6;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Hora de salida";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Tipo de viaje";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Patente del móvil";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Turno rotativo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Matrícula médico";
            this.IdUsuario.MinimumWidth = 6;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Matrícula enfermero";
            this.NombreUsuario.MinimumWidth = 6;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(918, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "Enfermero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1179, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "Médico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 73;
            this.label5.Text = "Patente móvil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 23);
            this.label6.TabIndex = 74;
            this.label6.Text = "Búsqueda solo por patente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(899, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 23);
            this.label7.TabIndex = 76;
            this.label7.Text = "Búsqueda solo por matrículas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBuscarPorPatente
            // 
            this.btnBuscarPorPatente.Animated = true;
            this.btnBuscarPorPatente.AutoRoundedCorners = true;
            this.btnBuscarPorPatente.BorderRadius = 18;
            this.btnBuscarPorPatente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPorPatente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPorPatente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarPorPatente.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarPorPatente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarPorPatente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnBuscarPorPatente.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnBuscarPorPatente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPorPatente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorPatente.Location = new System.Drawing.Point(493, 398);
            this.btnBuscarPorPatente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarPorPatente.Name = "btnBuscarPorPatente";
            this.btnBuscarPorPatente.Size = new System.Drawing.Size(346, 39);
            this.btnBuscarPorPatente.TabIndex = 80;
            this.btnBuscarPorPatente.Text = "Buscar";
            this.btnBuscarPorPatente.Click += new System.EventHandler(this.btnBuscarPorPatente_Click);
            // 
            // btnBuscarPorDatos
            // 
            this.btnBuscarPorDatos.Animated = true;
            this.btnBuscarPorDatos.AutoRoundedCorners = true;
            this.btnBuscarPorDatos.BorderRadius = 18;
            this.btnBuscarPorDatos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPorDatos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPorDatos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarPorDatos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarPorDatos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarPorDatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnBuscarPorDatos.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnBuscarPorDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPorDatos.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorDatos.Location = new System.Drawing.Point(162, 697);
            this.btnBuscarPorDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarPorDatos.Name = "btnBuscarPorDatos";
            this.btnBuscarPorDatos.Size = new System.Drawing.Size(1112, 39);
            this.btnBuscarPorDatos.TabIndex = 81;
            this.btnBuscarPorDatos.Text = "Buscar";
            this.btnBuscarPorDatos.Click += new System.EventHandler(this.btnBuscarPorDatosPersonales_Click);
            // 
            // chkIncluirFechas
            // 
            this.chkIncluirFechas.AutoSize = true;
            this.chkIncluirFechas.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIncluirFechas.CheckedState.BorderRadius = 0;
            this.chkIncluirFechas.CheckedState.BorderThickness = 0;
            this.chkIncluirFechas.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIncluirFechas.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.chkIncluirFechas.Location = new System.Drawing.Point(56, 470);
            this.chkIncluirFechas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIncluirFechas.Name = "chkIncluirFechas";
            this.chkIncluirFechas.Size = new System.Drawing.Size(366, 27);
            this.chkIncluirFechas.TabIndex = 82;
            this.chkIncluirFechas.Text = "Deseo incluir la fecha en las otras búsquedas";
            this.chkIncluirFechas.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIncluirFechas.UncheckedState.BorderRadius = 0;
            this.chkIncluirFechas.UncheckedState.BorderThickness = 0;
            this.chkIncluirFechas.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // txtMatriculaEnfermero
            // 
            this.txtMatriculaEnfermero.Animated = true;
            this.txtMatriculaEnfermero.AutoRoundedCorners = true;
            this.txtMatriculaEnfermero.BorderRadius = 17;
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
            this.txtMatriculaEnfermero.Location = new System.Drawing.Point(911, 338);
            this.txtMatriculaEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatriculaEnfermero.MaxLength = 10;
            this.txtMatriculaEnfermero.Name = "txtMatriculaEnfermero";
            this.txtMatriculaEnfermero.PasswordChar = '\0';
            this.txtMatriculaEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMatriculaEnfermero.PlaceholderText = "Número de matrícula";
            this.txtMatriculaEnfermero.SelectedText = "";
            this.txtMatriculaEnfermero.Size = new System.Drawing.Size(247, 36);
            this.txtMatriculaEnfermero.TabIndex = 72;
            this.txtMatriculaEnfermero.TextChanged += new System.EventHandler(this.txtMatriculaMedico_TextChanged);
            // 
            // txtMatriculaMedico
            // 
            this.txtMatriculaMedico.Animated = true;
            this.txtMatriculaMedico.AutoRoundedCorners = true;
            this.txtMatriculaMedico.BorderRadius = 17;
            this.txtMatriculaMedico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatriculaMedico.DefaultText = "";
            this.txtMatriculaMedico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatriculaMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatriculaMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatriculaMedico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatriculaMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtMatriculaMedico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatriculaMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtMatriculaMedico.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatriculaMedico.IconLeft = global::SIMED_V1.Properties.Resources.numbers;
            this.txtMatriculaMedico.IconLeftSize = new System.Drawing.Size(30, 20);
            this.txtMatriculaMedico.Location = new System.Drawing.Point(1183, 338);
            this.txtMatriculaMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatriculaMedico.MaxLength = 10;
            this.txtMatriculaMedico.Name = "txtMatriculaMedico";
            this.txtMatriculaMedico.PasswordChar = '\0';
            this.txtMatriculaMedico.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtMatriculaMedico.PlaceholderText = "Número de matrícula";
            this.txtMatriculaMedico.SelectedText = "";
            this.txtMatriculaMedico.Size = new System.Drawing.Size(253, 36);
            this.txtMatriculaMedico.TabIndex = 70;
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
            this.btnVolver.Location = new System.Drawing.Point(43, 820);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 46);
            this.btnVolver.TabIndex = 59;
            // 
            // txtConsultaApellidoEnfermero
            // 
            this.txtConsultaApellidoEnfermero.Animated = true;
            this.txtConsultaApellidoEnfermero.AutoRoundedCorners = true;
            this.txtConsultaApellidoEnfermero.BorderRadius = 17;
            this.txtConsultaApellidoEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsultaApellidoEnfermero.DefaultText = "";
            this.txtConsultaApellidoEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsultaApellidoEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsultaApellidoEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaApellidoEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaApellidoEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtConsultaApellidoEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaApellidoEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtConsultaApellidoEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaApellidoEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtConsultaApellidoEnfermero.Location = new System.Drawing.Point(169, 631);
            this.txtConsultaApellidoEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaApellidoEnfermero.Name = "txtConsultaApellidoEnfermero";
            this.txtConsultaApellidoEnfermero.PasswordChar = '\0';
            this.txtConsultaApellidoEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaApellidoEnfermero.PlaceholderText = "Apellido del enfermero";
            this.txtConsultaApellidoEnfermero.SelectedText = "";
            this.txtConsultaApellidoEnfermero.Size = new System.Drawing.Size(525, 37);
            this.txtConsultaApellidoEnfermero.TabIndex = 84;
            // 
            // txtConsultaNombreEnfermero
            // 
            this.txtConsultaNombreEnfermero.Animated = true;
            this.txtConsultaNombreEnfermero.AutoRoundedCorners = true;
            this.txtConsultaNombreEnfermero.BorderRadius = 18;
            this.txtConsultaNombreEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsultaNombreEnfermero.DefaultText = "";
            this.txtConsultaNombreEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsultaNombreEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsultaNombreEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaNombreEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaNombreEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtConsultaNombreEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaNombreEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtConsultaNombreEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaNombreEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtConsultaNombreEnfermero.Location = new System.Drawing.Point(168, 566);
            this.txtConsultaNombreEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaNombreEnfermero.Name = "txtConsultaNombreEnfermero";
            this.txtConsultaNombreEnfermero.PasswordChar = '\0';
            this.txtConsultaNombreEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaNombreEnfermero.PlaceholderText = "Nombre del enfermero";
            this.txtConsultaNombreEnfermero.SelectedText = "";
            this.txtConsultaNombreEnfermero.Size = new System.Drawing.Size(526, 38);
            this.txtConsultaNombreEnfermero.TabIndex = 83;
            // 
            // txtConsultaApellidoMedico
            // 
            this.txtConsultaApellidoMedico.Animated = true;
            this.txtConsultaApellidoMedico.AutoRoundedCorners = true;
            this.txtConsultaApellidoMedico.BorderRadius = 18;
            this.txtConsultaApellidoMedico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsultaApellidoMedico.DefaultText = "";
            this.txtConsultaApellidoMedico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsultaApellidoMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsultaApellidoMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaApellidoMedico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaApellidoMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtConsultaApellidoMedico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaApellidoMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtConsultaApellidoMedico.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaApellidoMedico.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtConsultaApellidoMedico.Location = new System.Drawing.Point(732, 630);
            this.txtConsultaApellidoMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaApellidoMedico.MaxLength = 30;
            this.txtConsultaApellidoMedico.Name = "txtConsultaApellidoMedico";
            this.txtConsultaApellidoMedico.PasswordChar = '\0';
            this.txtConsultaApellidoMedico.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaApellidoMedico.PlaceholderText = "Apellido del médico";
            this.txtConsultaApellidoMedico.SelectedText = "";
            this.txtConsultaApellidoMedico.Size = new System.Drawing.Size(535, 38);
            this.txtConsultaApellidoMedico.TabIndex = 86;
            // 
            // txtConsultaNombreMedico
            // 
            this.txtConsultaNombreMedico.Animated = true;
            this.txtConsultaNombreMedico.AutoRoundedCorners = true;
            this.txtConsultaNombreMedico.BorderRadius = 18;
            this.txtConsultaNombreMedico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsultaNombreMedico.DefaultText = "";
            this.txtConsultaNombreMedico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsultaNombreMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsultaNombreMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaNombreMedico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaNombreMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtConsultaNombreMedico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaNombreMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtConsultaNombreMedico.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaNombreMedico.IconLeft = global::SIMED_V1.Properties.Resources.user;
            this.txtConsultaNombreMedico.Location = new System.Drawing.Point(732, 566);
            this.txtConsultaNombreMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaNombreMedico.MaxLength = 30;
            this.txtConsultaNombreMedico.Name = "txtConsultaNombreMedico";
            this.txtConsultaNombreMedico.PasswordChar = '\0';
            this.txtConsultaNombreMedico.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaNombreMedico.PlaceholderText = "Nombre del médico";
            this.txtConsultaNombreMedico.SelectedText = "";
            this.txtConsultaNombreMedico.Size = new System.Drawing.Size(535, 38);
            this.txtConsultaNombreMedico.TabIndex = 85;
            // 
            // btnBuscarPorMatricula
            // 
            this.btnBuscarPorMatricula.Animated = true;
            this.btnBuscarPorMatricula.AutoRoundedCorners = true;
            this.btnBuscarPorMatricula.BorderRadius = 18;
            this.btnBuscarPorMatricula.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPorMatricula.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarPorMatricula.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarPorMatricula.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarPorMatricula.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarPorMatricula.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnBuscarPorMatricula.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnBuscarPorMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarPorMatricula.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorMatricula.Location = new System.Drawing.Point(903, 398);
            this.btnBuscarPorMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarPorMatricula.Name = "btnBuscarPorMatricula";
            this.btnBuscarPorMatricula.Size = new System.Drawing.Size(533, 39);
            this.btnBuscarPorMatricula.TabIndex = 87;
            this.btnBuscarPorMatricula.Text = "Buscar";
            this.btnBuscarPorMatricula.Click += new System.EventHandler(this.btnBuscarPorMatricula_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 23);
            this.label3.TabIndex = 88;
            this.label3.Text = "Búsqueda solo por datos personales";
            // 
            // btnLimpiarGrilla
            // 
            this.btnLimpiarGrilla.Animated = true;
            this.btnLimpiarGrilla.AutoRoundedCorners = true;
            this.btnLimpiarGrilla.BorderRadius = 18;
            this.btnLimpiarGrilla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarGrilla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarGrilla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarGrilla.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimpiarGrilla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimpiarGrilla.FillColor = System.Drawing.Color.Transparent;
            this.btnLimpiarGrilla.FillColor2 = System.Drawing.Color.Transparent;
            this.btnLimpiarGrilla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarGrilla.ForeColor = System.Drawing.Color.DimGray;
            this.btnLimpiarGrilla.Location = new System.Drawing.Point(644, 205);
            this.btnLimpiarGrilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarGrilla.Name = "btnLimpiarGrilla";
            this.btnLimpiarGrilla.Size = new System.Drawing.Size(224, 39);
            this.btnLimpiarGrilla.TabIndex = 89;
            this.btnLimpiarGrilla.Text = "Limpiar Grilla";
            this.btnLimpiarGrilla.Click += new System.EventHandler(this.btnLimpiarGrilla_Click);
            // 
            // ConsultarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 1028);
            this.Controls.Add(this.btnLimpiarGrilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarPorMatricula);
            this.Controls.Add(this.txtConsultaApellidoMedico);
            this.Controls.Add(this.txtConsultaNombreMedico);
            this.Controls.Add(this.txtConsultaApellidoEnfermero);
            this.Controls.Add(this.txtConsultaNombreEnfermero);
            this.Controls.Add(this.chkIncluirFechas);
            this.Controls.Add(this.btnBuscarPorDatos);
            this.Controls.Add(this.btnBuscarPorPatente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatriculaEnfermero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatriculaMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbViajes);
            this.Controls.Add(this.btnCerrarApp);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.cmbMoviles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFechaViaje);
            this.Controls.Add(this.btnBuscarViaje);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblConsultarViaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1374, 1028);
            this.Name = "ConsultarViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarViaje";
            ((System.ComponentModel.ISupportInitialize)(this.gbViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnBuscarViaje;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private Guna.UI2.WinForms.Guna2GradientButton btnEliminar;
        private Guna.UI2.WinForms.Guna2GradientButton btnModificar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblConsultarViaje;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFechaViaje;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMoviles;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrarApp;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView gbViajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox txtMatriculaEnfermero;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox txtMatriculaMedico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuscarPorDatos;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuscarPorPatente;
        private Guna.UI2.WinForms.Guna2CheckBox chkIncluirFechas;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaApellidoEnfermero;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaNombreEnfermero;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaApellidoMedico;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaNombreMedico;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuscarPorMatricula;
        private Guna.UI2.WinForms.Guna2GradientButton btnLimpiarGrilla;
    }
}