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
            this.cmb_modelo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2RadioButton_altacom = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton_bajacom = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblPatenteAmbulancia = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_patente = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCrearAmbulancia = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnCerrarApp = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
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
            // cmb_modelo
            // 
            this.cmb_modelo.AutoRoundedCorners = true;
            this.cmb_modelo.BackColor = System.Drawing.Color.Transparent;
            this.cmb_modelo.BorderRadius = 17;
            this.cmb_modelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cmb_modelo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_modelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_modelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_modelo.ItemHeight = 30;
            this.cmb_modelo.Location = new System.Drawing.Point(23, 78);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(229, 36);
            this.cmb_modelo.TabIndex = 2;
            // 
            // guna2RadioButton_altacom
            // 
            this.guna2RadioButton_altacom.AutoSize = true;
            this.guna2RadioButton_altacom.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.guna2RadioButton_altacom.CheckedState.BorderThickness = 0;
            this.guna2RadioButton_altacom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.guna2RadioButton_altacom.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton_altacom.CheckedState.InnerOffset = -4;
            this.guna2RadioButton_altacom.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2RadioButton_altacom.Location = new System.Drawing.Point(13, 53);
            this.guna2RadioButton_altacom.Name = "guna2RadioButton_altacom";
            this.guna2RadioButton_altacom.Size = new System.Drawing.Size(111, 17);
            this.guna2RadioButton_altacom.TabIndex = 3;
            this.guna2RadioButton_altacom.Text = "Alta complejidad";
            this.guna2RadioButton_altacom.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2RadioButton_altacom.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton_altacom.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton_altacom.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2RadioButton_bajacom
            // 
            this.guna2RadioButton_bajacom.AutoSize = true;
            this.guna2RadioButton_bajacom.CheckedState.BorderColor = System.Drawing.Color.DimGray;
            this.guna2RadioButton_bajacom.CheckedState.BorderThickness = 0;
            this.guna2RadioButton_bajacom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.guna2RadioButton_bajacom.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton_bajacom.CheckedState.InnerOffset = -4;
            this.guna2RadioButton_bajacom.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.guna2RadioButton_bajacom.Location = new System.Drawing.Point(13, 76);
            this.guna2RadioButton_bajacom.Name = "guna2RadioButton_bajacom";
            this.guna2RadioButton_bajacom.Size = new System.Drawing.Size(112, 17);
            this.guna2RadioButton_bajacom.TabIndex = 4;
            this.guna2RadioButton_bajacom.Text = "Baja complejidad";
            this.guna2RadioButton_bajacom.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2RadioButton_bajacom.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton_bajacom.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton_bajacom.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblPatenteAmbulancia);
            this.guna2ShadowPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2ShadowPanel1.Controls.Add(this.txt_patente);
            this.guna2ShadowPanel1.Controls.Add(this.cmb_modelo);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(45, 70);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.guna2ShadowPanel1.ShadowDepth = 80;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(283, 281);
            this.guna2ShadowPanel1.TabIndex = 7;
            // 
            // lblPatenteAmbulancia
            // 
            this.lblPatenteAmbulancia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatenteAmbulancia.ForeColor = System.Drawing.Color.Red;
            this.lblPatenteAmbulancia.Location = new System.Drawing.Point(33, 56);
            this.lblPatenteAmbulancia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatenteAmbulancia.Name = "lblPatenteAmbulancia";
            this.lblPatenteAmbulancia.Size = new System.Drawing.Size(214, 19);
            this.lblPatenteAmbulancia.TabIndex = 38;
            this.lblPatenteAmbulancia.Text = "label1";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2RadioButton_altacom);
            this.guna2GroupBox1.Controls.Add(this.guna2RadioButton_bajacom);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(23, 145);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(229, 102);
            this.guna2GroupBox1.TabIndex = 20;
            this.guna2GroupBox1.Text = "Complejidad ";
            // 
            // txt_patente
            // 
            this.txt_patente.Animated = true;
            this.txt_patente.AutoRoundedCorners = true;
            this.txt_patente.BorderRadius = 13;
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
            this.txt_patente.Location = new System.Drawing.Point(23, 21);
            this.txt_patente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_patente.MaxLength = 15;
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.PasswordChar = '\0';
            this.txt_patente.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txt_patente.PlaceholderText = "Patente";
            this.txt_patente.SelectedText = "";
            this.txt_patente.Size = new System.Drawing.Size(229, 29);
            this.txt_patente.TabIndex = 1;
            this.txt_patente.TextChanged += new System.EventHandler(this.txt_patente_TextChanged);
            this.txt_patente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_patente_KeyPress_1);
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
            this.btnCrearAmbulancia.TabIndex = 5;
            this.btnCrearAmbulancia.Text = "Crear Ambulancia";
            this.btnCrearAmbulancia.Click += new System.EventHandler(this.btnCrearAmbulancia_Click_1);
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
            this.btnCerrarApp.Location = new System.Drawing.Point(345, 1);
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
            this.btnMinimizar.Location = new System.Drawing.Point(284, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 18);
            this.btnMinimizar.TabIndex = 21;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(309, -4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 22;
            // 
            // btnVolver
            // 
            this.btnVolver.Animated = true;
            this.btnVolver.AutoRoundedCorners = true;
            this.btnVolver.BorderRadius = 10;
            this.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolver.FillColor = System.Drawing.Color.Transparent;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Image = global::SIMED_V1.Properties.Resources.left_arrow;
            this.btnVolver.Location = new System.Drawing.Point(1, 396);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(38, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // AltaAmbulancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 420);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.btnCerrarApp);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCrearAmbulancia);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.lblCrearCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaAmbulancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaAmbulancias";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AltaAmbulancias_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrearCuenta;
        private Guna.UI2.WinForms.Guna2TextBox txt_patente;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_modelo;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton_altacom;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton_bajacom;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCrearAmbulancia;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrarApp;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private System.Windows.Forms.Label lblPatenteAmbulancia;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
    }
}