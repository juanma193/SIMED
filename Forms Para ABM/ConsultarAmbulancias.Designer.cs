namespace SIMED_V1.Forms_Para_ABM
{
    partial class ConsultarAmbulancias
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
            this.gdr_ambulancias = new Guna.UI2.WinForms.Guna2DataGridView();
            this.patenteAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_buscar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_eliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_modificar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbModelo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rbAltaComplejidad = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbBajaComplejidad = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblIdMovil = new System.Windows.Forms.Label();
            this.lblNroIdMovil = new System.Windows.Forms.Label();
            this.txt_patente = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_ambulancias)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdr_ambulancias
            // 
            this.gdr_ambulancias.AllowUserToAddRows = false;
            this.gdr_ambulancias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdr_ambulancias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdr_ambulancias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdr_ambulancias.ColumnHeadersHeight = 15;
            this.gdr_ambulancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdr_ambulancias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patenteAm,
            this.modeloAm,
            this.categoriaAm});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdr_ambulancias.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdr_ambulancias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdr_ambulancias.Location = new System.Drawing.Point(67, 80);
            this.gdr_ambulancias.Name = "gdr_ambulancias";
            this.gdr_ambulancias.ReadOnly = true;
            this.gdr_ambulancias.RowHeadersVisible = false;
            this.gdr_ambulancias.Size = new System.Drawing.Size(527, 149);
            this.gdr_ambulancias.TabIndex = 0;
            this.gdr_ambulancias.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdr_ambulancias.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdr_ambulancias.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdr_ambulancias.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdr_ambulancias.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdr_ambulancias.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gdr_ambulancias.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdr_ambulancias.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdr_ambulancias.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdr_ambulancias.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdr_ambulancias.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdr_ambulancias.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdr_ambulancias.ThemeStyle.HeaderStyle.Height = 15;
            this.gdr_ambulancias.ThemeStyle.ReadOnly = true;
            this.gdr_ambulancias.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdr_ambulancias.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdr_ambulancias.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdr_ambulancias.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdr_ambulancias.ThemeStyle.RowsStyle.Height = 22;
            this.gdr_ambulancias.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdr_ambulancias.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdr_ambulancias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_ambulancias_CellClick);
            // 
            // patenteAm
            // 
            this.patenteAm.DataPropertyName = "patente";
            this.patenteAm.HeaderText = "Patente";
            this.patenteAm.Name = "patenteAm";
            this.patenteAm.ReadOnly = true;
            // 
            // modeloAm
            // 
            this.modeloAm.DataPropertyName = "nombre_modelo";
            this.modeloAm.HeaderText = "Modelo";
            this.modeloAm.Name = "modeloAm";
            this.modeloAm.ReadOnly = true;
            // 
            // categoriaAm
            // 
            this.categoriaAm.DataPropertyName = "descripcion";
            this.categoriaAm.HeaderText = "Categoria";
            this.categoriaAm.Name = "categoriaAm";
            this.categoriaAm.ReadOnly = true;
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.Location = new System.Drawing.Point(62, 29);
            this.lblCrearCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(274, 32);
            this.lblCrearCuenta.TabIndex = 2;
            this.lblCrearCuenta.Text = "Consultar ambulancias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Búsqueda de ambulancia";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Animated = true;
            this.btn_buscar.AutoRoundedCorners = true;
            this.btn_buscar.BorderRadius = 15;
            this.btn_buscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buscar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btn_buscar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btn_buscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(67, 457);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(526, 32);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.Text = "Buscar por patente";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Animated = true;
            this.btn_eliminar.AutoRoundedCorners = true;
            this.btn_eliminar.BorderRadius = 17;
            this.btn_eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btn_eliminar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(359, 503);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(234, 36);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar ambulancia";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Animated = true;
            this.btn_modificar.AutoRoundedCorners = true;
            this.btn_modificar.BorderRadius = 17;
            this.btn_modificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_modificar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_modificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_modificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(103)))), ((int)(((byte)(198)))));
            this.btn_modificar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(66, 503);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(235, 36);
            this.btn_modificar.TabIndex = 6;
            this.btn_modificar.Text = "Actualizar datos ";
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
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
            this.cmbModelo.Location = new System.Drawing.Point(68, 307);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(526, 36);
            this.cmbModelo.TabIndex = 2;
            // 
            // rbAltaComplejidad
            // 
            this.rbAltaComplejidad.AutoSize = true;
            this.rbAltaComplejidad.BackColor = System.Drawing.Color.Transparent;
            this.rbAltaComplejidad.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAltaComplejidad.CheckedState.BorderThickness = 0;
            this.rbAltaComplejidad.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAltaComplejidad.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAltaComplejidad.CheckedState.InnerOffset = -4;
            this.rbAltaComplejidad.Location = new System.Drawing.Point(7, 46);
            this.rbAltaComplejidad.Name = "rbAltaComplejidad";
            this.rbAltaComplejidad.Size = new System.Drawing.Size(117, 19);
            this.rbAltaComplejidad.TabIndex = 3;
            this.rbAltaComplejidad.Text = "Alta Complejidad";
            this.rbAltaComplejidad.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAltaComplejidad.UncheckedState.BorderThickness = 2;
            this.rbAltaComplejidad.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAltaComplejidad.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAltaComplejidad.UseVisualStyleBackColor = false;
            // 
            // rbBajaComplejidad
            // 
            this.rbBajaComplejidad.AutoSize = true;
            this.rbBajaComplejidad.BackColor = System.Drawing.Color.Transparent;
            this.rbBajaComplejidad.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbBajaComplejidad.CheckedState.BorderThickness = 0;
            this.rbBajaComplejidad.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbBajaComplejidad.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbBajaComplejidad.CheckedState.InnerOffset = -4;
            this.rbBajaComplejidad.Location = new System.Drawing.Point(7, 67);
            this.rbBajaComplejidad.Name = "rbBajaComplejidad";
            this.rbBajaComplejidad.Size = new System.Drawing.Size(118, 19);
            this.rbBajaComplejidad.TabIndex = 4;
            this.rbBajaComplejidad.Text = "Baja Complejidad";
            this.rbBajaComplejidad.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbBajaComplejidad.UncheckedState.BorderThickness = 2;
            this.rbBajaComplejidad.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbBajaComplejidad.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbBajaComplejidad.UseVisualStyleBackColor = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.rbAltaComplejidad);
            this.guna2GroupBox1.Controls.Add(this.rbBajaComplejidad);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(76, 355);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(516, 89);
            this.guna2GroupBox1.TabIndex = 62;
            this.guna2GroupBox1.Text = "Complejidad";
            // 
            // lblIdMovil
            // 
            this.lblIdMovil.AutoSize = true;
            this.lblIdMovil.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMovil.ForeColor = System.Drawing.Color.DarkGray;
            this.lblIdMovil.Location = new System.Drawing.Point(563, 232);
            this.lblIdMovil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdMovil.Name = "lblIdMovil";
            this.lblIdMovil.Size = new System.Drawing.Size(38, 13);
            this.lblIdMovil.TabIndex = 64;
            this.lblIdMovil.Text = "label1";
            this.lblIdMovil.Visible = false;
            // 
            // lblNroIdMovil
            // 
            this.lblNroIdMovil.AutoSize = true;
            this.lblNroIdMovil.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroIdMovil.ForeColor = System.Drawing.Color.DarkGray;
            this.lblNroIdMovil.Location = new System.Drawing.Point(494, 232);
            this.lblNroIdMovil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroIdMovil.Name = "lblNroIdMovil";
            this.lblNroIdMovil.Size = new System.Drawing.Size(70, 13);
            this.lblNroIdMovil.TabIndex = 63;
            this.lblNroIdMovil.Text = "ID de Movil:";
            // 
            // txt_patente
            // 
            this.txt_patente.Animated = true;
            this.txt_patente.AutoRoundedCorners = true;
            this.txt_patente.BorderRadius = 17;
            this.txt_patente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_patente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_patente.DefaultText = "";
            this.txt_patente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_patente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_patente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_patente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_patente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_patente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_patente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txt_patente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_patente.IconLeft = global::SIMED_V1.Properties.Resources.numbers;
            this.txt_patente.IconLeftSize = new System.Drawing.Size(30, 20);
            this.txt_patente.Location = new System.Drawing.Point(68, 266);
            this.txt_patente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_patente.MaxLength = 15;
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.PasswordChar = '\0';
            this.txt_patente.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txt_patente.PlaceholderText = "Patente";
            this.txt_patente.SelectedText = "";
            this.txt_patente.Size = new System.Drawing.Size(527, 36);
            this.txt_patente.TabIndex = 1;
            this.txt_patente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_patente_KeyPress);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(663, -1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 18);
            this.guna2ControlBox1.TabIndex = 65;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox3.Location = new System.Drawing.Point(634, -1);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 18);
            this.guna2ControlBox3.TabIndex = 66;
            // 
            // btnVolver
            // 
            this.btnVolver.Animated = true;
            this.btnVolver.AutoRoundedCorners = true;
            this.btnVolver.BorderRadius = 12;
            this.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolver.FillColor = System.Drawing.Color.Transparent;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Image = global::SIMED_V1.Properties.Resources.left_arrow;
            this.btnVolver.Location = new System.Drawing.Point(-2, 544);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(43, 27);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ConsultarAmbulancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 570);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.lblIdMovil);
            this.Controls.Add(this.lblNroIdMovil);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_patente);
            this.Controls.Add(this.lblCrearCuenta);
            this.Controls.Add(this.gdr_ambulancias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarAmbulancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarAmbulancias";
            this.Load += new System.EventHandler(this.ConsultarAmbulancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdr_ambulancias)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gdr_ambulancias;
        private System.Windows.Forms.Label lblCrearCuenta;
        private Guna.UI2.WinForms.Guna2TextBox txt_patente;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_buscar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_eliminar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteAm;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloAm;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaAm;
        private Guna.UI2.WinForms.Guna2ComboBox cmbModelo;
        private Guna.UI2.WinForms.Guna2RadioButton rbBajaComplejidad;
        private Guna.UI2.WinForms.Guna2RadioButton rbAltaComplejidad;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblIdMovil;
        private System.Windows.Forms.Label lblNroIdMovil;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
    }
}