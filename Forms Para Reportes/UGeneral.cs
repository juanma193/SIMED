using SIMED_V1.Bases_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_Reportes
{
    public partial class UGeneral : UserControl
    {
        public UGeneral()
        {
            InitializeComponent();

        }

        private void btnSieteDias_Click(object sender, EventArgs e)
        {
            btnSieteDias.Checked = true;
            btnCatorceDias.Checked = false;
            btnEsteMes.Checked = false;
            btnPersonalizado.Checked = false;
            dtFechaFin.Value = DateTime.Now;
            dtFechaInicio.Value = DateTime.Now.AddDays(-7);
            dtFechaFin.Enabled = false;
            dtFechaInicio.Enabled = false;
            btnOk.Visible = false;

            DataTable t = AfiliadosBD.ObtenerAfiliadosNuevos(dtFechaFin.Value, dtFechaInicio.Value);
            lblAfiliadosNuevos.Text = t.Rows.Count.ToString();
            lblIngNuevos.Text = PlanesBD.ObtenerIngresosNuevos(dtFechaFin.Value, dtFechaInicio.Value).ToString();
        }

        private void btnPersonalizado_Click(object sender, EventArgs e)
        {
            btnPersonalizado.Checked = true;
            btnSieteDias.Checked = false;
            btnEsteMes.Checked = false;
            btnCatorceDias.Checked = false;
            dtFechaFin.Enabled = true;
            dtFechaInicio.Enabled = true;
            btnOk.Visible = true;

        }

        private void btnCatorceDias_Click(object sender, EventArgs e)
        {
            btnSieteDias.Checked = false;
            btnPersonalizado.Checked = false;
            btnEsteMes.Checked = false;
            btnCatorceDias.Checked = true;
            dtFechaFin.Value = DateTime.Now;
            dtFechaInicio.Value = DateTime.Now.AddDays(-14);
            dtFechaFin.Enabled = false;
            dtFechaInicio.Enabled = false;
            btnOk.Visible = false;

        }

        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            btnSieteDias.Checked = false;
            btnPersonalizado.Checked = false;
            btnCatorceDias.Checked = false;
            btnEsteMes.Checked = true;
            dtFechaFin.Value = DateTime.Now;
            dtFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtFechaFin.Enabled = false;
            dtFechaInicio.Enabled = false;
            btnOk.Visible = false;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void UGeneral_Load(object sender, EventArgs e)
        {
            lblAfiliadosNuevos.Text = AfiliadosBD.ObtenerAfiliadosNuevos(dtFechaFin.Value, dtFechaInicio.Value).ToString();
        }
    }
}
