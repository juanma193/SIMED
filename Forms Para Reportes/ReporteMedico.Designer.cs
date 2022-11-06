namespace SIMED_V1.Forms_Para_Reportes
{
    partial class ReporteMedico
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mEDICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnNombreMedico = new Guna.UI2.WinForms.Guna2Button();
            this.btnEspecialidadMedico = new Guna.UI2.WinForms.Guna2Button();
            this.btnRelLabMedico = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnFiltrarEspecialidad = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bD3K3G052022DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerMedico = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICOSBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052022DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mEDICOSBindingSource
            // 
            this.mEDICOSBindingSource.DataMember = "MEDICOS";
            // 
            // bD3K3G05_2022DataSet
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnMinimizar);
            this.guna2Panel1.Controls.Add(this.btnCerrar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(980, 24);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.Location = new System.Drawing.Point(909, -2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 26);
            this.btnMinimizar.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(947, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 26);
            this.btnCerrar.TabIndex = 2;
            // 
            // btnNombreMedico
            // 
            this.btnNombreMedico.Animated = true;
            this.btnNombreMedico.AutoRoundedCorners = true;
            this.btnNombreMedico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnNombreMedico.BorderRadius = 19;
            this.btnNombreMedico.BorderThickness = 2;
            this.btnNombreMedico.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnNombreMedico.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnNombreMedico.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnNombreMedico.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnNombreMedico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnNombreMedico.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnNombreMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNombreMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNombreMedico.FillColor = System.Drawing.Color.Transparent;
            this.btnNombreMedico.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnNombreMedico.ForeColor = System.Drawing.Color.DimGray;
            this.btnNombreMedico.Location = new System.Drawing.Point(37, 95);
            this.btnNombreMedico.Name = "btnNombreMedico";
            this.btnNombreMedico.Size = new System.Drawing.Size(145, 40);
            this.btnNombreMedico.TabIndex = 6;
            this.btnNombreMedico.Text = "Filtrado por nombre";
            // 
            // btnEspecialidadMedico
            // 
            this.btnEspecialidadMedico.Animated = true;
            this.btnEspecialidadMedico.AutoRoundedCorners = true;
            this.btnEspecialidadMedico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnEspecialidadMedico.BorderRadius = 19;
            this.btnEspecialidadMedico.BorderThickness = 2;
            this.btnEspecialidadMedico.Checked = true;
            this.btnEspecialidadMedico.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnEspecialidadMedico.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnEspecialidadMedico.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnEspecialidadMedico.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEspecialidadMedico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnEspecialidadMedico.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnEspecialidadMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEspecialidadMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEspecialidadMedico.FillColor = System.Drawing.Color.Transparent;
            this.btnEspecialidadMedico.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEspecialidadMedico.ForeColor = System.Drawing.Color.DimGray;
            this.btnEspecialidadMedico.Location = new System.Drawing.Point(192, 95);
            this.btnEspecialidadMedico.Name = "btnEspecialidadMedico";
            this.btnEspecialidadMedico.Size = new System.Drawing.Size(145, 40);
            this.btnEspecialidadMedico.TabIndex = 7;
            this.btnEspecialidadMedico.Text = "Filtrado por especialidad";
            // 
            // btnRelLabMedico
            // 
            this.btnRelLabMedico.Animated = true;
            this.btnRelLabMedico.AutoRoundedCorners = true;
            this.btnRelLabMedico.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnRelLabMedico.BorderRadius = 19;
            this.btnRelLabMedico.BorderThickness = 2;
            this.btnRelLabMedico.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnRelLabMedico.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnRelLabMedico.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnRelLabMedico.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnRelLabMedico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnRelLabMedico.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnRelLabMedico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRelLabMedico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRelLabMedico.FillColor = System.Drawing.Color.Transparent;
            this.btnRelLabMedico.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRelLabMedico.ForeColor = System.Drawing.Color.DimGray;
            this.btnRelLabMedico.Location = new System.Drawing.Point(343, 95);
            this.btnRelLabMedico.Name = "btnRelLabMedico";
            this.btnRelLabMedico.Size = new System.Drawing.Size(145, 40);
            this.btnRelLabMedico.TabIndex = 8;
            this.btnRelLabMedico.Text = "Filtrado por relación laboral";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reportes de médicos";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.AutoRoundedCorners = true;
            this.cmbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltro.BorderRadius = 17;
            this.cmbFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cmbFiltro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFiltro.ItemHeight = 30;
            this.cmbFiltro.Location = new System.Drawing.Point(49, 181);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(229, 36);
            this.cmbFiltro.TabIndex = 12;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(46, 161);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(74, 17);
            this.lblFiltro.TabIndex = 55;
            this.lblFiltro.Text = "Título filtro";
            // 
            // btnFiltrarEspecialidad
            // 
            this.btnFiltrarEspecialidad.Animated = true;
            this.btnFiltrarEspecialidad.AutoRoundedCorners = true;
            this.btnFiltrarEspecialidad.BorderRadius = 17;
            this.btnFiltrarEspecialidad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrarEspecialidad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFiltrarEspecialidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltrarEspecialidad.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFiltrarEspecialidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFiltrarEspecialidad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnFiltrarEspecialidad.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(178)))), ((int)(((byte)(210)))));
            this.btnFiltrarEspecialidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFiltrarEspecialidad.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarEspecialidad.Location = new System.Drawing.Point(283, 181);
            this.btnFiltrarEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrarEspecialidad.Name = "btnFiltrarEspecialidad";
            this.btnFiltrarEspecialidad.Size = new System.Drawing.Size(119, 36);
            this.btnFiltrarEspecialidad.TabIndex = 56;
            this.btnFiltrarEspecialidad.Text = "Buscar";
            // 
            // mEDICOSTableAdapter
            // 
            // 
            // bD3K3G052022DataSetBindingSource
            // 
            this.bD3K3G052022DataSetBindingSource.Position = 0;
            // 
            // reportViewerMedico
            // 
            reportDataSource1.Name = "DatosMedicos";
            reportDataSource1.Value = this.mEDICOSBindingSource;
            this.reportViewerMedico.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerMedico.LocalReport.ReportEmbeddedResource = "SIMED_V1.Forms Para Reportes.ReporteMedico.rdlc";
            this.reportViewerMedico.Location = new System.Drawing.Point(31, 234);
            this.reportViewerMedico.Name = "reportViewerMedico";
            this.reportViewerMedico.ServerReport.BearerToken = null;
            this.reportViewerMedico.Size = new System.Drawing.Size(937, 246);
            this.reportViewerMedico.TabIndex = 57;
            this.reportViewerMedico.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 617);
            this.Controls.Add(this.reportViewerMedico);
            this.Controls.Add(this.btnFiltrarEspecialidad);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNombreMedico);
            this.Controls.Add(this.btnEspecialidadMedico);
            this.Controls.Add(this.btnRelLabMedico);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteMedico";
            this.Load += new System.EventHandler(this.ReporteMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICOSBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bD3K3G052022DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2ControlBox btnCerrar;
        private Guna.UI2.WinForms.Guna2Button btnNombreMedico;
        private Guna.UI2.WinForms.Guna2Button btnEspecialidadMedico;
        private Guna.UI2.WinForms.Guna2Button btnRelLabMedico;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private Guna.UI2.WinForms.Guna2GradientButton btnFiltrarEspecialidad;
        private System.Windows.Forms.BindingSource mEDICOSBindingSource;
        private System.Windows.Forms.BindingSource bD3K3G052022DataSetBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMedico;
    }
}