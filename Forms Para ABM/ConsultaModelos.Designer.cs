namespace SIMED_V1.Forms_Para_ABM
{
    partial class ConsultaModelos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gdrModelos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nombreModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarModelo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtNombreModelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbMarcaModelo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNroIdModelo = new System.Windows.Forms.Label();
            this.lblIdModelo = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnBuscarModelo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEliminarModelo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblConsultarModelos = new System.Windows.Forms.Label();
            this.lblNombreModelo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrModelos)).BeginInit();
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
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(396, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 7;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(438, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // gdrModelos
            // 
            this.gdrModelos.AllowUserToAddRows = false;
            this.gdrModelos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gdrModelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrModelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gdrModelos.ColumnHeadersHeight = 20;
            this.gdrModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdrModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreModelo,
            this.marcaModelo});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdrModelos.DefaultCellStyle = dataGridViewCellStyle12;
            this.gdrModelos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdrModelos.Location = new System.Drawing.Point(243, 35);
            this.gdrModelos.Name = "gdrModelos";
            this.gdrModelos.ReadOnly = true;
            this.gdrModelos.RowHeadersVisible = false;
            this.gdrModelos.RowHeadersWidth = 51;
            this.gdrModelos.Size = new System.Drawing.Size(226, 250);
            this.gdrModelos.TabIndex = 54;
            this.gdrModelos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdrModelos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdrModelos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdrModelos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdrModelos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdrModelos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdrModelos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdrModelos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdrModelos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdrModelos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdrModelos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdrModelos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdrModelos.ThemeStyle.HeaderStyle.Height = 20;
            this.gdrModelos.ThemeStyle.ReadOnly = true;
            this.gdrModelos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdrModelos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdrModelos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdrModelos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdrModelos.ThemeStyle.RowsStyle.Height = 22;
            this.gdrModelos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdrModelos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdrModelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrModelos_CellClick);
            // 
            // nombreModelo
            // 
            this.nombreModelo.DataPropertyName = "nombre_modelo";
            this.nombreModelo.HeaderText = "Nombre";
            this.nombreModelo.Name = "nombreModelo";
            this.nombreModelo.ReadOnly = true;
            // 
            // marcaModelo
            // 
            this.marcaModelo.DataPropertyName = "nombre_marca";
            this.marcaModelo.HeaderText = "Marca";
            this.marcaModelo.Name = "marcaModelo";
            this.marcaModelo.ReadOnly = true;
            // 
            // btnActualizarModelo
            // 
            this.btnActualizarModelo.Animated = true;
            this.btnActualizarModelo.AutoRoundedCorners = true;
            this.btnActualizarModelo.BorderRadius = 17;
            this.btnActualizarModelo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarModelo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnActualizarModelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarModelo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnActualizarModelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnActualizarModelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnActualizarModelo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnActualizarModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnActualizarModelo.ForeColor = System.Drawing.Color.White;
            this.btnActualizarModelo.Location = new System.Drawing.Point(26, 205);
            this.btnActualizarModelo.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarModelo.Name = "btnActualizarModelo";
            this.btnActualizarModelo.Size = new System.Drawing.Size(187, 37);
            this.btnActualizarModelo.TabIndex = 56;
            this.btnActualizarModelo.Text = "Actualizar Modelo";
            this.btnActualizarModelo.Click += new System.EventHandler(this.btnActualizarModelo_Click);
            // 
            // txtNombreModelo
            // 
            this.txtNombreModelo.Animated = true;
            this.txtNombreModelo.AutoRoundedCorners = true;
            this.txtNombreModelo.BorderRadius = 13;
            this.txtNombreModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreModelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreModelo.DefaultText = "";
            this.txtNombreModelo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreModelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreModelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreModelo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreModelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtNombreModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtNombreModelo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreModelo.IconLeft = global::SIMED_V1.Properties.Resources._4918887_document_edit_file_format_name_icon_1_;
            this.txtNombreModelo.Location = new System.Drawing.Point(13, 18);
            this.txtNombreModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreModelo.Name = "txtNombreModelo";
            this.txtNombreModelo.PasswordChar = '\0';
            this.txtNombreModelo.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtNombreModelo.PlaceholderText = "Nombre de modelo";
            this.txtNombreModelo.SelectedText = "";
            this.txtNombreModelo.Size = new System.Drawing.Size(187, 29);
            this.txtNombreModelo.TabIndex = 57;
            this.txtNombreModelo.TextChanged += new System.EventHandler(this.txtNombreModelo_TextChanged);
            // 
            // cmbMarcaModelo
            // 
            this.cmbMarcaModelo.AutoRoundedCorners = true;
            this.cmbMarcaModelo.BackColor = System.Drawing.Color.Transparent;
            this.cmbMarcaModelo.BorderRadius = 17;
            this.cmbMarcaModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMarcaModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaModelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cmbMarcaModelo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMarcaModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMarcaModelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMarcaModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMarcaModelo.ItemHeight = 30;
            this.cmbMarcaModelo.Location = new System.Drawing.Point(13, 69);
            this.cmbMarcaModelo.Name = "cmbMarcaModelo";
            this.cmbMarcaModelo.Size = new System.Drawing.Size(187, 36);
            this.cmbMarcaModelo.TabIndex = 58;
            // 
            // lblNroIdModelo
            // 
            this.lblNroIdModelo.AutoSize = true;
            this.lblNroIdModelo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroIdModelo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNroIdModelo.Location = new System.Drawing.Point(373, 289);
            this.lblNroIdModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroIdModelo.Name = "lblNroIdModelo";
            this.lblNroIdModelo.Size = new System.Drawing.Size(81, 13);
            this.lblNroIdModelo.TabIndex = 60;
            this.lblNroIdModelo.Text = "ID de Modelo:";
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdModelo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblIdModelo.Location = new System.Drawing.Point(450, 289);
            this.lblIdModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.Size = new System.Drawing.Size(38, 13);
            this.lblIdModelo.TabIndex = 61;
            this.lblIdModelo.Text = "label1";
            this.lblIdModelo.Visible = false;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblNombreModelo);
            this.guna2ShadowPanel1.Controls.Add(this.cmbMarcaModelo);
            this.guna2ShadowPanel1.Controls.Add(this.txtNombreModelo);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(13, 34);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(214, 123);
            this.guna2ShadowPanel1.TabIndex = 62;
            // 
            // btnBuscarModelo
            // 
            this.btnBuscarModelo.Animated = true;
            this.btnBuscarModelo.AutoRoundedCorners = true;
            this.btnBuscarModelo.BorderRadius = 17;
            this.btnBuscarModelo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarModelo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscarModelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarModelo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscarModelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscarModelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnBuscarModelo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnBuscarModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscarModelo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarModelo.Location = new System.Drawing.Point(26, 162);
            this.btnBuscarModelo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarModelo.Name = "btnBuscarModelo";
            this.btnBuscarModelo.Size = new System.Drawing.Size(187, 37);
            this.btnBuscarModelo.TabIndex = 63;
            this.btnBuscarModelo.Text = "Buscar Modelo";
            this.btnBuscarModelo.Click += new System.EventHandler(this.btnBuscarModelo_Click);
            // 
            // btnEliminarModelo
            // 
            this.btnEliminarModelo.Animated = true;
            this.btnEliminarModelo.AutoRoundedCorners = true;
            this.btnEliminarModelo.BorderRadius = 17;
            this.btnEliminarModelo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarModelo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarModelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarModelo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarModelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarModelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btnEliminarModelo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnEliminarModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarModelo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarModelo.Location = new System.Drawing.Point(26, 248);
            this.btnEliminarModelo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarModelo.Name = "btnEliminarModelo";
            this.btnEliminarModelo.Size = new System.Drawing.Size(187, 37);
            this.btnEliminarModelo.TabIndex = 64;
            this.btnEliminarModelo.Text = "Eliminar Modelo";
            this.btnEliminarModelo.Click += new System.EventHandler(this.btnEliminarModelo_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox3.Location = new System.Drawing.Point(355, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 8;
            // 
            // lblConsultarModelos
            // 
            this.lblConsultarModelos.AutoSize = true;
            this.lblConsultarModelos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarModelos.Location = new System.Drawing.Point(8, 0);
            this.lblConsultarModelos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultarModelos.Name = "lblConsultarModelos";
            this.lblConsultarModelos.Size = new System.Drawing.Size(179, 25);
            this.lblConsultarModelos.TabIndex = 55;
            this.lblConsultarModelos.Text = "Consultar modelos";
            // 
            // lblNombreModelo
            // 
            this.lblNombreModelo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreModelo.ForeColor = System.Drawing.Color.Red;
            this.lblNombreModelo.Location = new System.Drawing.Point(17, 47);
            this.lblNombreModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreModelo.Name = "lblNombreModelo";
            this.lblNombreModelo.Size = new System.Drawing.Size(183, 19);
            this.lblNombreModelo.TabIndex = 65;
            this.lblNombreModelo.Text = "label1";
            // 
            // ConsultaModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 313);
            this.Controls.Add(this.btnEliminarModelo);
            this.Controls.Add(this.lblConsultarModelos);
            this.Controls.Add(this.btnBuscarModelo);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.lblIdModelo);
            this.Controls.Add(this.lblNroIdModelo);
            this.Controls.Add(this.btnActualizarModelo);
            this.Controls.Add(this.gdrModelos);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaModelos";
            this.Text = "ConsultaModelos";
            this.Load += new System.EventHandler(this.ConsultaModelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrModelos)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DataGridView gdrModelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaModelo;
        private Guna.UI2.WinForms.Guna2GradientButton btnActualizarModelo;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreModelo;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMarcaModelo;
        private System.Windows.Forms.Label lblIdModelo;
        private System.Windows.Forms.Label lblNroIdModelo;
        private Guna.UI2.WinForms.Guna2GradientButton btnEliminarModelo;
        private System.Windows.Forms.Label lblConsultarModelos;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuscarModelo;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Label lblNombreModelo;
    }
}