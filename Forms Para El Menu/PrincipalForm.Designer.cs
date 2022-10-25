namespace SIMED_V1
{
    partial class PrincipalForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.btnOtrasFuncionalidades = new Guna.UI2.WinForms.Guna2Button();
            this.btnViajes = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlanes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAfiliados = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEnfermeros = new Guna.UI2.WinForms.Guna2Button();
            this.btnAmbulancias = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.picSimed = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnContenido = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSimed)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(959, 24);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(888, -2);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 26);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(926, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 26);
            this.guna2ControlBox1.TabIndex = 2;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.guna2Separator1);
            this.panelMenu.Controls.Add(this.picSimed);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 764);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.txtMedicos_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnOtrasFuncionalidades);
            this.panel1.Controls.Add(this.btnViajes);
            this.panel1.Controls.Add(this.btnPlanes);
            this.panel1.Controls.Add(this.btnAfiliados);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnMedicos);
            this.panel1.Controls.Add(this.btnEnfermeros);
            this.panel1.Controls.Add(this.btnAmbulancias);
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 658);
            this.panel1.TabIndex = 10;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Animated = true;
            this.btnCerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::SIMED_V1.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCerrarSesion.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 576);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(246, 72);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // btnOtrasFuncionalidades
            // 
            this.btnOtrasFuncionalidades.Animated = true;
            this.btnOtrasFuncionalidades.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOtrasFuncionalidades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOtrasFuncionalidades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOtrasFuncionalidades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOtrasFuncionalidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOtrasFuncionalidades.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnOtrasFuncionalidades.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnOtrasFuncionalidades.ForeColor = System.Drawing.Color.White;
            this.btnOtrasFuncionalidades.Image = global::SIMED_V1.Properties.Resources._299068_add_sign_icon;
            this.btnOtrasFuncionalidades.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOtrasFuncionalidades.ImageSize = new System.Drawing.Size(40, 40);
            this.btnOtrasFuncionalidades.Location = new System.Drawing.Point(0, 504);
            this.btnOtrasFuncionalidades.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtrasFuncionalidades.Name = "btnOtrasFuncionalidades";
            this.btnOtrasFuncionalidades.Size = new System.Drawing.Size(246, 72);
            this.btnOtrasFuncionalidades.TabIndex = 14;
            this.btnOtrasFuncionalidades.Text = "Otras funcionalidades";
            this.btnOtrasFuncionalidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOtrasFuncionalidades.Click += new System.EventHandler(this.btnOtrasFuncionalidades_Click);
            // 
            // btnViajes
            // 
            this.btnViajes.Animated = true;
            this.btnViajes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViajes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViajes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViajes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViajes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnViajes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViajes.ForeColor = System.Drawing.Color.White;
            this.btnViajes.Image = global::SIMED_V1.Properties.Resources._1061162_care_health_journey_medicine_pill_icon;
            this.btnViajes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViajes.ImageSize = new System.Drawing.Size(40, 40);
            this.btnViajes.Location = new System.Drawing.Point(0, 432);
            this.btnViajes.Margin = new System.Windows.Forms.Padding(2);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(246, 72);
            this.btnViajes.TabIndex = 12;
            this.btnViajes.Text = "Viajes";
            this.btnViajes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Animated = true;
            this.btnPlanes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlanes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlanes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlanes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnPlanes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanes.ForeColor = System.Drawing.Color.White;
            this.btnPlanes.Image = global::SIMED_V1.Properties.Resources.planes_png1;
            this.btnPlanes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlanes.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPlanes.Location = new System.Drawing.Point(0, 360);
            this.btnPlanes.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(246, 72);
            this.btnPlanes.TabIndex = 8;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnAfiliados
            // 
            this.btnAfiliados.Animated = true;
            this.btnAfiliados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAfiliados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAfiliados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAfiliados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAfiliados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAfiliados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnAfiliados.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnAfiliados.ForeColor = System.Drawing.Color.White;
            this.btnAfiliados.Image = global::SIMED_V1.Properties.Resources.afiliados_21;
            this.btnAfiliados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAfiliados.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAfiliados.Location = new System.Drawing.Point(0, 288);
            this.btnAfiliados.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfiliados.Name = "btnAfiliados";
            this.btnAfiliados.Size = new System.Drawing.Size(246, 72);
            this.btnAfiliados.TabIndex = 9;
            this.btnAfiliados.Text = "Afiliados";
            this.btnAfiliados.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAfiliados.Click += new System.EventHandler(this.btnAfiliados_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Animated = true;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::SIMED_V1.Properties.Resources.usuarioss;
            this.btnUsuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarios.ImageSize = new System.Drawing.Size(50, 50);
            this.btnUsuarios.Location = new System.Drawing.Point(0, 216);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(246, 72);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnMedicos
            // 
            this.btnMedicos.Animated = true;
            this.btnMedicos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnMedicos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnMedicos.ForeColor = System.Drawing.Color.White;
            this.btnMedicos.Image = global::SIMED_V1.Properties.Resources.doctor_sin_fondo;
            this.btnMedicos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicos.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMedicos.Location = new System.Drawing.Point(0, 144);
            this.btnMedicos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(246, 72);
            this.btnMedicos.TabIndex = 2;
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnEnfermeros
            // 
            this.btnEnfermeros.Animated = true;
            this.btnEnfermeros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnfermeros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnfermeros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnfermeros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnfermeros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnfermeros.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnEnfermeros.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnfermeros.ForeColor = System.Drawing.Color.White;
            this.btnEnfermeros.Image = global::SIMED_V1.Properties.Resources.enfemeros;
            this.btnEnfermeros.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEnfermeros.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEnfermeros.Location = new System.Drawing.Point(0, 72);
            this.btnEnfermeros.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnfermeros.Name = "btnEnfermeros";
            this.btnEnfermeros.Size = new System.Drawing.Size(246, 72);
            this.btnEnfermeros.TabIndex = 6;
            this.btnEnfermeros.Text = " Enfermeros";
            this.btnEnfermeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEnfermeros.Click += new System.EventHandler(this.btnEnfermeros_Click);
            // 
            // btnAmbulancias
            // 
            this.btnAmbulancias.Animated = true;
            this.btnAmbulancias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAmbulancias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAmbulancias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAmbulancias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAmbulancias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAmbulancias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(175)))), ((int)(((byte)(208)))));
            this.btnAmbulancias.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnAmbulancias.ForeColor = System.Drawing.Color.White;
            this.btnAmbulancias.Image = global::SIMED_V1.Properties.Resources.ambulance;
            this.btnAmbulancias.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAmbulancias.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAmbulancias.Location = new System.Drawing.Point(0, 0);
            this.btnAmbulancias.Margin = new System.Windows.Forms.Padding(2);
            this.btnAmbulancias.Name = "btnAmbulancias";
            this.btnAmbulancias.Size = new System.Drawing.Size(246, 72);
            this.btnAmbulancias.TabIndex = 5;
            this.btnAmbulancias.Text = " Ambulancias";
            this.btnAmbulancias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAmbulancias.Click += new System.EventHandler(this.btnAmbulancias_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(-2, 89);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(252, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // picSimed
            // 
            this.picSimed.BackColor = System.Drawing.Color.Transparent;
            this.picSimed.FillColor = System.Drawing.Color.Transparent;
            this.picSimed.Image = global::SIMED_V1.Properties.Resources.logo_simed_3;
            this.picSimed.ImageRotate = 0F;
            this.picSimed.Location = new System.Drawing.Point(-19, -14);
            this.picSimed.Margin = new System.Windows.Forms.Padding(2);
            this.picSimed.Name = "picSimed";
            this.picSimed.Size = new System.Drawing.Size(276, 125);
            this.picSimed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSimed.TabIndex = 3;
            this.picSimed.TabStop = false;
            this.picSimed.UseTransparentBackground = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnContenido
            // 
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(250, 24);
            this.pnContenido.Margin = new System.Windows.Forms.Padding(2);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(709, 764);
            this.pnContenido.TabIndex = 2;
            this.pnContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContenido_Paint);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 788);
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(719, 562);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSimed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox picSimed;
        private Guna.UI2.WinForms.Guna2Button btnMedicos;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnEnfermeros;
        private Guna.UI2.WinForms.Guna2Button btnAmbulancias;
        private System.Windows.Forms.Panel pnContenido;
        private Guna.UI2.WinForms.Guna2Button btnPlanes;
        private Guna.UI2.WinForms.Guna2Button btnAfiliados;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCerrarSesion;
        private Guna.UI2.WinForms.Guna2Button btnOtrasFuncionalidades;
        private Guna.UI2.WinForms.Guna2Button btnViajes;
    }
}