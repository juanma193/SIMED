namespace SIMED_V1.Forms_Para_ABM
{
    partial class ConsultaMedico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConsultaEliminarMedico = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnConsultaModificarMedico = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.grdConsultaMedico = new Guna.UI2.WinForms.Guna2DataGridView();
            this.matriculaMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bD3K3G052022DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K3G05_2022DataSet = new SIMED_V1.BD3K3G05_2022DataSet();
            this.btnBuscarMedico = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtConsultaApellidoMedico = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConsultaNombreMedico = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVolverConsulta = new Guna.UI2.WinForms.Guna2Button();
            this.txtConsultaMatriculaMedico = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCerrarApp = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.chkMedicos = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052022DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2022DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultaEliminarMedico
            // 
            this.btnConsultaEliminarMedico.Animated = true;
            this.btnConsultaEliminarMedico.AutoRoundedCorners = true;
            this.btnConsultaEliminarMedico.BorderRadius = 17;
            this.btnConsultaEliminarMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaEliminarMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaEliminarMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultaEliminarMedico.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultaEliminarMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultaEliminarMedico.Enabled = false;
            this.btnConsultaEliminarMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnConsultaEliminarMedico.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnConsultaEliminarMedico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultaEliminarMedico.ForeColor = System.Drawing.Color.White;
            this.btnConsultaEliminarMedico.Location = new System.Drawing.Point(360, 493);
            this.btnConsultaEliminarMedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaEliminarMedico.Name = "btnConsultaEliminarMedico";
            this.btnConsultaEliminarMedico.Size = new System.Drawing.Size(234, 36);
            this.btnConsultaEliminarMedico.TabIndex = 6;
            this.btnConsultaEliminarMedico.Text = "Eliminar médico";
            this.btnConsultaEliminarMedico.Click += new System.EventHandler(this.btnConsultaEliminarMedico_Click);
            // 
            // btnConsultaModificarMedico
            // 
            this.btnConsultaModificarMedico.Animated = true;
            this.btnConsultaModificarMedico.AutoRoundedCorners = true;
            this.btnConsultaModificarMedico.BorderRadius = 17;
            this.btnConsultaModificarMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaModificarMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaModificarMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultaModificarMedico.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultaModificarMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultaModificarMedico.Enabled = false;
            this.btnConsultaModificarMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnConsultaModificarMedico.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnConsultaModificarMedico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultaModificarMedico.ForeColor = System.Drawing.Color.White;
            this.btnConsultaModificarMedico.Location = new System.Drawing.Point(68, 493);
            this.btnConsultaModificarMedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultaModificarMedico.Name = "btnConsultaModificarMedico";
            this.btnConsultaModificarMedico.Size = new System.Drawing.Size(235, 36);
            this.btnConsultaModificarMedico.TabIndex = 5;
            this.btnConsultaModificarMedico.Text = "Modificar datos ";
            this.btnConsultaModificarMedico.Click += new System.EventHandler(this.btnConsultaModificarMedico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Búsqueda de médico";
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.Location = new System.Drawing.Point(62, 33);
            this.lblCrearCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(215, 32);
            this.lblCrearCuenta.TabIndex = 31;
            this.lblCrearCuenta.Text = "Consultar médico";
            // 
            // grdConsultaMedico
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.grdConsultaMedico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdConsultaMedico.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsultaMedico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdConsultaMedico.ColumnHeadersHeight = 15;
            this.grdConsultaMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdConsultaMedico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaMedico,
            this.nombreMedico,
            this.apellidoMedico});
            this.grdConsultaMedico.DataSource = this.bD3K3G052022DataSetBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsultaMedico.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdConsultaMedico.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdConsultaMedico.Location = new System.Drawing.Point(68, 68);
            this.grdConsultaMedico.MultiSelect = false;
            this.grdConsultaMedico.Name = "grdConsultaMedico";
            this.grdConsultaMedico.ReadOnly = true;
            this.grdConsultaMedico.RowHeadersVisible = false;
            this.grdConsultaMedico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.grdConsultaMedico.Size = new System.Drawing.Size(527, 149);
            this.grdConsultaMedico.TabIndex = 8;
            this.grdConsultaMedico.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdConsultaMedico.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdConsultaMedico.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdConsultaMedico.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdConsultaMedico.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdConsultaMedico.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdConsultaMedico.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdConsultaMedico.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdConsultaMedico.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdConsultaMedico.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdConsultaMedico.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdConsultaMedico.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdConsultaMedico.ThemeStyle.HeaderStyle.Height = 15;
            this.grdConsultaMedico.ThemeStyle.ReadOnly = true;
            this.grdConsultaMedico.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdConsultaMedico.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdConsultaMedico.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdConsultaMedico.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdConsultaMedico.ThemeStyle.RowsStyle.Height = 22;
            this.grdConsultaMedico.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdConsultaMedico.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdConsultaMedico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaMedico_CellClick);
            this.grdConsultaMedico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultaMedico_CellDoubleClick);
            // 
            // matriculaMedico
            // 
            this.matriculaMedico.DataPropertyName = "numeroMatricula";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matriculaMedico.DefaultCellStyle = dataGridViewCellStyle7;
            this.matriculaMedico.HeaderText = "N° de Matrícula";
            this.matriculaMedico.MinimumWidth = 6;
            this.matriculaMedico.Name = "matriculaMedico";
            this.matriculaMedico.ReadOnly = true;
            // 
            // nombreMedico
            // 
            this.nombreMedico.DataPropertyName = "nombre";
            this.nombreMedico.FillWeight = 59.34696F;
            this.nombreMedico.HeaderText = "Nombre";
            this.nombreMedico.Name = "nombreMedico";
            this.nombreMedico.ReadOnly = true;
            // 
            // apellidoMedico
            // 
            this.apellidoMedico.DataPropertyName = "apellido";
            this.apellidoMedico.HeaderText = "Apellido";
            this.apellidoMedico.MinimumWidth = 6;
            this.apellidoMedico.Name = "apellidoMedico";
            this.apellidoMedico.ReadOnly = true;
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
            // btnBuscarMedico
            // 
            this.btnBuscarMedico.Animated = true;
            this.btnBuscarMedico.AutoRoundedCorners = true;
            this.btnBuscarMedico.BorderRadius = 15;
            this.btnBuscarMedico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMedico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarMedico.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnBuscarMedico.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnBuscarMedico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarMedico.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMedico.Location = new System.Drawing.Point(68, 446);
            this.btnBuscarMedico.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarMedico.Name = "btnBuscarMedico";
            this.btnBuscarMedico.Size = new System.Drawing.Size(526, 32);
            this.btnBuscarMedico.TabIndex = 4;
            this.btnBuscarMedico.Text = "Buscar";
            this.btnBuscarMedico.Click += new System.EventHandler(this.btnBuscarMedico_Click);
            // 
            // txtConsultaApellidoMedico
            // 
            this.txtConsultaApellidoMedico.Animated = true;
            this.txtConsultaApellidoMedico.AutoRoundedCorners = true;
            this.txtConsultaApellidoMedico.BorderRadius = 17;
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
            this.txtConsultaApellidoMedico.Location = new System.Drawing.Point(68, 396);
            this.txtConsultaApellidoMedico.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultaApellidoMedico.Name = "txtConsultaApellidoMedico";
            this.txtConsultaApellidoMedico.PasswordChar = '\0';
            this.txtConsultaApellidoMedico.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaApellidoMedico.PlaceholderText = "Apellido del médico";
            this.txtConsultaApellidoMedico.SelectedText = "";
            this.txtConsultaApellidoMedico.Size = new System.Drawing.Size(527, 36);
            this.txtConsultaApellidoMedico.TabIndex = 3;
            this.txtConsultaApellidoMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultaApellidoMedico_KeyPress);
            // 
            // txtConsultaNombreMedico
            // 
            this.txtConsultaNombreMedico.Animated = true;
            this.txtConsultaNombreMedico.AutoRoundedCorners = true;
            this.txtConsultaNombreMedico.BorderRadius = 17;
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
            this.txtConsultaNombreMedico.Location = new System.Drawing.Point(68, 341);
            this.txtConsultaNombreMedico.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultaNombreMedico.Name = "txtConsultaNombreMedico";
            this.txtConsultaNombreMedico.PasswordChar = '\0';
            this.txtConsultaNombreMedico.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaNombreMedico.PlaceholderText = "Nombre del médico";
            this.txtConsultaNombreMedico.SelectedText = "";
            this.txtConsultaNombreMedico.Size = new System.Drawing.Size(527, 36);
            this.txtConsultaNombreMedico.TabIndex = 2;
            this.txtConsultaNombreMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultaNombreMedico_KeyPress);
            // 
            // btnVolverConsulta
            // 
            this.btnVolverConsulta.Animated = true;
            this.btnVolverConsulta.AutoRoundedCorners = true;
            this.btnVolverConsulta.BorderRadius = 17;
            this.btnVolverConsulta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolverConsulta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolverConsulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolverConsulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolverConsulta.FillColor = System.Drawing.Color.Transparent;
            this.btnVolverConsulta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolverConsulta.ForeColor = System.Drawing.Color.White;
            this.btnVolverConsulta.Image = global::SIMED_V1.Properties.Resources.left_arrow;
            this.btnVolverConsulta.Location = new System.Drawing.Point(45, 561);
            this.btnVolverConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverConsulta.Name = "btnVolverConsulta";
            this.btnVolverConsulta.Size = new System.Drawing.Size(63, 37);
            this.btnVolverConsulta.TabIndex = 7;
            this.btnVolverConsulta.Click += new System.EventHandler(this.btnVolverConsulta_Click);
            // 
            // txtConsultaMatriculaMedico
            // 
            this.txtConsultaMatriculaMedico.Animated = true;
            this.txtConsultaMatriculaMedico.AutoRoundedCorners = true;
            this.txtConsultaMatriculaMedico.BorderRadius = 17;
            this.txtConsultaMatriculaMedico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConsultaMatriculaMedico.DefaultText = "";
            this.txtConsultaMatriculaMedico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConsultaMatriculaMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConsultaMatriculaMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaMatriculaMedico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConsultaMatriculaMedico.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtConsultaMatriculaMedico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaMatriculaMedico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtConsultaMatriculaMedico.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConsultaMatriculaMedico.IconLeft = global::SIMED_V1.Properties.Resources.numbers;
            this.txtConsultaMatriculaMedico.IconLeftSize = new System.Drawing.Size(30, 20);
            this.txtConsultaMatriculaMedico.Location = new System.Drawing.Point(68, 286);
            this.txtConsultaMatriculaMedico.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsultaMatriculaMedico.Name = "txtConsultaMatriculaMedico";
            this.txtConsultaMatriculaMedico.PasswordChar = '\0';
            this.txtConsultaMatriculaMedico.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaMatriculaMedico.PlaceholderText = "Número de matrícula";
            this.txtConsultaMatriculaMedico.SelectedText = "";
            this.txtConsultaMatriculaMedico.Size = new System.Drawing.Size(527, 36);
            this.txtConsultaMatriculaMedico.TabIndex = 1;
            this.txtConsultaMatriculaMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultaMatriculaMedico_KeyPress);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.IconColor = System.Drawing.Color.DimGray;
            this.btnCerrarApp.Location = new System.Drawing.Point(620, 9);
            this.btnCerrarApp.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(34, 18);
            this.btnCerrarApp.TabIndex = 40;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.Location = new System.Drawing.Point(581, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 18);
            this.btnMinimizar.TabIndex = 41;
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
            // chkMedicos
            // 
            this.chkMedicos.AutoSize = true;
            this.chkMedicos.Checked = true;
            this.chkMedicos.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.chkMedicos.CheckedState.BorderRadius = 0;
            this.chkMedicos.CheckedState.BorderThickness = 0;
            this.chkMedicos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.chkMedicos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMedicos.Location = new System.Drawing.Point(68, 223);
            this.chkMedicos.Name = "chkMedicos";
            this.chkMedicos.Size = new System.Drawing.Size(90, 17);
            this.chkMedicos.TabIndex = 42;
            this.chkMedicos.Text = "Mostrar todos";
            this.chkMedicos.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.chkMedicos.UncheckedState.BorderRadius = 0;
            this.chkMedicos.UncheckedState.BorderThickness = 0;
            this.chkMedicos.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.chkMedicos.Visible = false;
            this.chkMedicos.CheckedChanged += new System.EventHandler(this.chkMedicos_CheckedChanged);
            // 
            // ConsultaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 609);
            this.Controls.Add(this.chkMedicos);
            this.Controls.Add(this.btnCerrarApp);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnBuscarMedico);
            this.Controls.Add(this.txtConsultaApellidoMedico);
            this.Controls.Add(this.txtConsultaNombreMedico);
            this.Controls.Add(this.btnVolverConsulta);
            this.Controls.Add(this.btnConsultaEliminarMedico);
            this.Controls.Add(this.btnConsultaModificarMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsultaMatriculaMedico);
            this.Controls.Add(this.lblCrearCuenta);
            this.Controls.Add(this.grdConsultaMedico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaMédico";
            this.Load += new System.EventHandler(this.ConsultaMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052022DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G05_2022DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaApellidoMedico;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaNombreMedico;
        private Guna.UI2.WinForms.Guna2Button btnVolverConsulta;
        private Guna.UI2.WinForms.Guna2GradientButton btnConsultaEliminarMedico;
        private Guna.UI2.WinForms.Guna2GradientButton btnConsultaModificarMedico;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtConsultaMatriculaMedico;
        private System.Windows.Forms.Label lblCrearCuenta;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuscarMedico;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrarApp;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CheckBox chkMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMedico;
        private System.Windows.Forms.BindingSource bD3K3G052022DataSetBindingSource;
        private BD3K3G05_2022DataSet bD3K3G05_2022DataSet;
        public Guna.UI2.WinForms.Guna2DataGridView grdConsultaMedico;
    }
}