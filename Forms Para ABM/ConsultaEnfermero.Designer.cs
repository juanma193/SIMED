namespace SIMED_V1.Forms_Para_ABM
{
    partial class ConsultaEnfermero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.bD3K3G052022DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2022DataSet = new SIMED_V1.BD3K3G05_2022DataSet();
            this.btnBuscarEnfermero = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEliminarEnfermero = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnModificarEnfermero = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCerrarApp = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.chkEnfermeros = new Guna.UI2.WinForms.Guna2CheckBox();
            this.grdConsultaEnfermero = new Guna.UI2.WinForms.Guna2DataGridView();
            this.matriculaEnfermero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEnfermero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEnfermero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.txtConsultaApellidoEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConsultaNombreEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConsultaMatriculaEnfermero = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052022DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaEnfermero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Búsqueda de enfermero";
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.Location = new System.Drawing.Point(76, 21);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(308, 41);
            this.lblCrearCuenta.TabIndex = 40;
            this.lblCrearCuenta.Text = "Consultar enfermero";
            // 
            // bD3K3G052022DataSetBindingSource
            // 
            this.bD3K3G052022DataSetBindingSource.DataSource = this.bD3K3G05_2022DataSet;
            this.bD3K3G052022DataSetBindingSource.Position = 0;
            // 
            // bD3K3G05_2022DataSet
            // 
            this.bD3K3G05_2022DataSet.DataSetName = "BD3K3G05_2022DataSet";
            this.bD3K3G05_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscarEnfermero
            // 
            this.btnBuscarEnfermero.Animated = true;
            this.btnBuscarEnfermero.AutoRoundedCorners = true;
            this.btnBuscarEnfermero.BorderRadius = 18;
            this.btnBuscarEnfermero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarEnfermero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarEnfermero.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnBuscarEnfermero.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnBuscarEnfermero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarEnfermero.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEnfermero.Location = new System.Drawing.Point(84, 522);
            this.btnBuscarEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarEnfermero.Name = "btnBuscarEnfermero";
            this.btnBuscarEnfermero.Size = new System.Drawing.Size(701, 39);
            this.btnBuscarEnfermero.TabIndex = 4;
            this.btnBuscarEnfermero.Text = "Buscar";
            this.btnBuscarEnfermero.Click += new System.EventHandler(this.btnBuscarEnfermero_Click);
            // 
            // btnEliminarEnfermero
            // 
            this.btnEliminarEnfermero.Animated = true;
            this.btnEliminarEnfermero.AutoRoundedCorners = true;
            this.btnEliminarEnfermero.BorderRadius = 21;
            this.btnEliminarEnfermero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarEnfermero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarEnfermero.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarEnfermero.Enabled = false;
            this.btnEliminarEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnEliminarEnfermero.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnEliminarEnfermero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEnfermero.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEnfermero.Location = new System.Drawing.Point(473, 578);
            this.btnEliminarEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarEnfermero.Name = "btnEliminarEnfermero";
            this.btnEliminarEnfermero.Size = new System.Drawing.Size(312, 44);
            this.btnEliminarEnfermero.TabIndex = 6;
            this.btnEliminarEnfermero.Text = "Eliminar enfermero";
            this.btnEliminarEnfermero.Click += new System.EventHandler(this.btnEliminarEnfermero_Click);
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
            this.btnModificarEnfermero.Enabled = false;
            this.btnModificarEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnModificarEnfermero.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnModificarEnfermero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificarEnfermero.ForeColor = System.Drawing.Color.White;
            this.btnModificarEnfermero.Location = new System.Drawing.Point(83, 578);
            this.btnModificarEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarEnfermero.Name = "btnModificarEnfermero";
            this.btnModificarEnfermero.Size = new System.Drawing.Size(313, 44);
            this.btnModificarEnfermero.TabIndex = 5;
            this.btnModificarEnfermero.Text = "Modificar datos ";
            this.btnModificarEnfermero.Click += new System.EventHandler(this.btnModificarEnfermero_Click);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.CustomClick = true;
            this.btnCerrarApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.IconColor = System.Drawing.Color.DimGray;
            this.btnCerrarApp.Location = new System.Drawing.Point(817, 11);
            this.btnCerrarApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(45, 22);
            this.btnCerrarApp.TabIndex = 51;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.Location = new System.Drawing.Point(765, 11);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 22);
            this.btnMinimizar.TabIndex = 52;
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
            // chkEnfermeros
            // 
            this.chkEnfermeros.AutoSize = true;
            this.chkEnfermeros.Checked = true;
            this.chkEnfermeros.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.chkEnfermeros.CheckedState.BorderRadius = 0;
            this.chkEnfermeros.CheckedState.BorderThickness = 0;
            this.chkEnfermeros.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.chkEnfermeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnfermeros.Location = new System.Drawing.Point(83, 254);
            this.chkEnfermeros.Name = "chkEnfermeros";
            this.chkEnfermeros.Size = new System.Drawing.Size(111, 20);
            this.chkEnfermeros.TabIndex = 54;
            this.chkEnfermeros.Text = "Mostrar todos";
            this.chkEnfermeros.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.chkEnfermeros.UncheckedState.BorderRadius = 0;
            this.chkEnfermeros.UncheckedState.BorderThickness = 0;
            this.chkEnfermeros.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.chkEnfermeros.Visible = false;
            this.chkEnfermeros.CheckedChanged += new System.EventHandler(this.chkEnfermeros_CheckedChanged);
            // 
            // grdConsultaEnfermero
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdConsultaEnfermero.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdConsultaEnfermero.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsultaEnfermero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdConsultaEnfermero.ColumnHeadersHeight = 18;
            this.grdConsultaEnfermero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdConsultaEnfermero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaEnfermero,
            this.nombreEnfermero,
            this.apellidoEnfermero});
            this.grdConsultaEnfermero.DataSource = this.bD3K3G05_2022DataSet;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsultaEnfermero.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdConsultaEnfermero.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdConsultaEnfermero.Location = new System.Drawing.Point(83, 65);
            this.grdConsultaEnfermero.MultiSelect = false;
            this.grdConsultaEnfermero.Name = "grdConsultaEnfermero";
            this.grdConsultaEnfermero.ReadOnly = true;
            this.grdConsultaEnfermero.RowHeadersVisible = false;
            this.grdConsultaEnfermero.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grdConsultaEnfermero.RowTemplate.Height = 24;
            this.grdConsultaEnfermero.Size = new System.Drawing.Size(702, 150);
            this.grdConsultaEnfermero.TabIndex = 55;
            this.grdConsultaEnfermero.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdConsultaEnfermero.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdConsultaEnfermero.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdConsultaEnfermero.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdConsultaEnfermero.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdConsultaEnfermero.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdConsultaEnfermero.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdConsultaEnfermero.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdConsultaEnfermero.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdConsultaEnfermero.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdConsultaEnfermero.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdConsultaEnfermero.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdConsultaEnfermero.ThemeStyle.HeaderStyle.Height = 18;
            this.grdConsultaEnfermero.ThemeStyle.ReadOnly = true;
            this.grdConsultaEnfermero.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdConsultaEnfermero.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdConsultaEnfermero.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdConsultaEnfermero.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdConsultaEnfermero.ThemeStyle.RowsStyle.Height = 24;
            this.grdConsultaEnfermero.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdConsultaEnfermero.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdConsultaEnfermero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrConsultaEnfermero_CellClick);
            this.grdConsultaEnfermero.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaEnfermero_CellDoubleClick);
            // 
            // matriculaEnfermero
            // 
            this.matriculaEnfermero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.matriculaEnfermero.DataPropertyName = "numeroMatricula";
            this.matriculaEnfermero.FillWeight = 7.565766F;
            this.matriculaEnfermero.HeaderText = "N° de Matrícula";
            this.matriculaEnfermero.MinimumWidth = 6;
            this.matriculaEnfermero.Name = "matriculaEnfermero";
            this.matriculaEnfermero.ReadOnly = true;
            this.matriculaEnfermero.Width = 180;
            // 
            // nombreEnfermero
            // 
            this.nombreEnfermero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombreEnfermero.DataPropertyName = "nombre";
            this.nombreEnfermero.FillWeight = 11.68558F;
            this.nombreEnfermero.HeaderText = "Nombre";
            this.nombreEnfermero.MinimumWidth = 6;
            this.nombreEnfermero.Name = "nombreEnfermero";
            this.nombreEnfermero.ReadOnly = true;
            this.nombreEnfermero.Width = 261;
            // 
            // apellidoEnfermero
            // 
            this.apellidoEnfermero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.apellidoEnfermero.DataPropertyName = "apellido";
            this.apellidoEnfermero.FillWeight = 280.7487F;
            this.apellidoEnfermero.HeaderText = "Apellido";
            this.apellidoEnfermero.MinimumWidth = 6;
            this.apellidoEnfermero.Name = "apellidoEnfermero";
            this.apellidoEnfermero.ReadOnly = true;
            this.apellidoEnfermero.Width = 261;
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
            this.btnVolver.Location = new System.Drawing.Point(83, 641);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 46);
            this.btnVolver.TabIndex = 49;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtConsultaApellidoEnfermero
            // 
            this.txtConsultaApellidoEnfermero.Animated = true;
            this.txtConsultaApellidoEnfermero.AutoRoundedCorners = true;
            this.txtConsultaApellidoEnfermero.BorderRadius = 21;
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
            this.txtConsultaApellidoEnfermero.Location = new System.Drawing.Point(84, 443);
            this.txtConsultaApellidoEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaApellidoEnfermero.Name = "txtConsultaApellidoEnfermero";
            this.txtConsultaApellidoEnfermero.PasswordChar = '\0';
            this.txtConsultaApellidoEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaApellidoEnfermero.PlaceholderText = "Apellido del enfermero";
            this.txtConsultaApellidoEnfermero.SelectedText = "";
            this.txtConsultaApellidoEnfermero.Size = new System.Drawing.Size(703, 44);
            this.txtConsultaApellidoEnfermero.TabIndex = 3;
            // 
            // txtConsultaNombreEnfermero
            // 
            this.txtConsultaNombreEnfermero.Animated = true;
            this.txtConsultaNombreEnfermero.AutoRoundedCorners = true;
            this.txtConsultaNombreEnfermero.BorderRadius = 21;
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
            this.txtConsultaNombreEnfermero.Location = new System.Drawing.Point(84, 375);
            this.txtConsultaNombreEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaNombreEnfermero.Name = "txtConsultaNombreEnfermero";
            this.txtConsultaNombreEnfermero.PasswordChar = '\0';
            this.txtConsultaNombreEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaNombreEnfermero.PlaceholderText = "Nombre del enfermero";
            this.txtConsultaNombreEnfermero.SelectedText = "";
            this.txtConsultaNombreEnfermero.Size = new System.Drawing.Size(703, 44);
            this.txtConsultaNombreEnfermero.TabIndex = 2;
            // 
            // txtConsultaMatriculaEnfermero
            // 
            this.txtConsultaMatriculaEnfermero.Animated = true;
            this.txtConsultaMatriculaEnfermero.AutoRoundedCorners = true;
            this.txtConsultaMatriculaEnfermero.BorderRadius = 21;
            this.txtConsultaMatriculaEnfermero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsultaMatriculaEnfermero.DefaultText = "";
            this.txtConsultaMatriculaEnfermero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsultaMatriculaEnfermero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsultaMatriculaEnfermero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaMatriculaEnfermero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaMatriculaEnfermero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtConsultaMatriculaEnfermero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaMatriculaEnfermero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtConsultaMatriculaEnfermero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaMatriculaEnfermero.IconLeft = global::SIMED_V1.Properties.Resources.numbers;
            this.txtConsultaMatriculaEnfermero.IconLeftSize = new System.Drawing.Size(30, 20);
            this.txtConsultaMatriculaEnfermero.Location = new System.Drawing.Point(84, 313);
            this.txtConsultaMatriculaEnfermero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsultaMatriculaEnfermero.Name = "txtConsultaMatriculaEnfermero";
            this.txtConsultaMatriculaEnfermero.PasswordChar = '\0';
            this.txtConsultaMatriculaEnfermero.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaMatriculaEnfermero.PlaceholderText = "Número de matrícula";
            this.txtConsultaMatriculaEnfermero.SelectedText = "";
            this.txtConsultaMatriculaEnfermero.Size = new System.Drawing.Size(703, 44);
            this.txtConsultaMatriculaEnfermero.TabIndex = 1;
            // 
            // ConsultaEnfermero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 702);
            this.Controls.Add(this.grdConsultaEnfermero);
            this.Controls.Add(this.chkEnfermeros);
            this.Controls.Add(this.btnCerrarApp);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnBuscarEnfermero);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarEnfermero);
            this.Controls.Add(this.btnModificarEnfermero);
            this.Controls.Add(this.txtConsultaApellidoEnfermero);
            this.Controls.Add(this.txtConsultaNombreEnfermero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsultaMatriculaEnfermero);
            this.Controls.Add(this.lblCrearCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultaEnfermero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaEnfermero";
            this.Load += new System.EventHandler(this.ConsultaEnfermero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052022DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaEnfermero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtConsultaApellidoEnfermero;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaNombreEnfermero;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaMatriculaEnfermero;
        private System.Windows.Forms.Label lblCrearCuenta;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuscarEnfermero;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private Guna.UI2.WinForms.Guna2GradientButton btnEliminarEnfermero;
        private Guna.UI2.WinForms.Guna2GradientButton btnModificarEnfermero;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrarApp;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.BindingSource bD3K3G052022DataSetBindingSource;
        private BD3K3G05_2022DataSet bD3K3G05_2022DataSet;
        private Guna.UI2.WinForms.Guna2CheckBox chkEnfermeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaEnfermero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEnfermero;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEnfermero;
        public Guna.UI2.WinForms.Guna2DataGridView grdConsultaEnfermero;
    }
}