using Guna.UI2.WinForms;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace SIMED_V1.Forms_Para_Reportes
{
    public partial class UGeneral : UserControl

    {
        Guna2Button actual;
      
        public UGeneral()
        {
            InitializeComponent();
          

        }
        int imageNumber = 1;
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

            actual = btnSieteDias;

            DataTable t = AfiliadosBD.ObtenerAfiliadosNuevos(dtFechaFin.Value, dtFechaInicio.Value);
            lblAfiliadosNuevos.Text = t.Rows.Count.ToString();
            lblIngNuevos.Text = "$" + PlanesBD.ObtenerIngresosNuevos(dtFechaFin.Value, dtFechaInicio.Value).ToString();

            ViajesGrafico(dtFechaInicio.Value, dtFechaFin.Value);

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

          

            actual = btnPersonalizado;

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


            actual = btnCatorceDias;

            DataTable t = AfiliadosBD.ObtenerAfiliadosNuevos(dtFechaFin.Value, dtFechaInicio.Value);
            lblAfiliadosNuevos.Text = t.Rows.Count.ToString();
            lblIngNuevos.Text = "$" + PlanesBD.ObtenerIngresosNuevos(dtFechaFin.Value, dtFechaInicio.Value).ToString();

            ViajesGrafico(dtFechaInicio.Value, dtFechaFin.Value);
            PlanesGrafico(dtFechaInicio.Value, dtFechaFin.Value);


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


            DataTable t = AfiliadosBD.ObtenerAfiliadosNuevos(dtFechaFin.Value, dtFechaInicio.Value);
            lblAfiliadosNuevos.Text = t.Rows.Count.ToString();
            lblIngNuevos.Text = "$" + PlanesBD.ObtenerIngresosNuevos(dtFechaFin.Value, dtFechaInicio.Value).ToString();

            actual = btnEsteMes;
            ViajesGrafico(dtFechaInicio.Value, dtFechaFin.Value);
            PlanesGrafico(dtFechaInicio.Value, dtFechaFin.Value);



        }

        private void ViajesGrafico(DateTime fechaInicio, DateTime fechaFin) {

            var fechas = new List<DateTime>();
            var cant = new List<int>();



            for (var dt = dtFechaInicio.Value; dt <= dtFechaFin.Value; dt = dt.AddDays(1))
            {
                fechas.Add(dt);
            }



            foreach (var fecha in fechas)
            {

                int viajes = ViajesBD.obtenerViajesEntreFechas(fecha);
                cant.Add(viajes);


            }



            chartViajes.Series["Viajes"].Points.Clear();

           

            for (int i = 0; i < fechas.Count; i++)
            {
                
                chartViajes.Series["Viajes"].Points.AddXY(fechas[i].ToShortDateString(), cant[i]);

            }


        }

        private void PlanesGrafico(DateTime fechaInicio, DateTime fechaFin) {

            List<int> ventas = PlanesBD.ObtenerIngresosPorPlan(dtFechaFin.Value, dtFechaInicio.Value);


            List<String> planes = PlanesBD.ObtenerPlanes(ventas);

            

            chartPlanes.Series["Planes"].Points.Clear();

            for (int i = 0; i < planes.Count; i++)
            {

                chartPlanes.Series["Planes"].Points.AddXY(planes[i].ToString() + " (" + ventas[i].ToString() + ")", ventas[i].ToString());
                
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if ((dtFechaFin.Value - dtFechaInicio.Value).TotalDays > 366)
            {
                ErroresForm ventana = new ErroresForm();
                ventana.show("Periodo demasiado extenso, pruebe uno más reducido");
                ventana.Show();
            }
            else {

                DataTable t = AfiliadosBD.ObtenerAfiliadosNuevos(dtFechaFin.Value, dtFechaInicio.Value);
                lblAfiliadosNuevos.Text = t.Rows.Count.ToString();
                lblIngNuevos.Text = "$" + PlanesBD.ObtenerIngresosNuevos(dtFechaFin.Value, dtFechaInicio.Value).ToString();

                ViajesGrafico(dtFechaInicio.Value, dtFechaFin.Value);
                PlanesGrafico(dtFechaInicio.Value, dtFechaFin.Value);

                btnOk.Visible = false;


            }



        }

        private void UGeneral_Load(object sender, EventArgs e)
        {
            DataTable t = AfiliadosBD.ObtenerAfiliadosNuevos(dtFechaFin.Value, dtFechaInicio.Value);
            lblAfiliadosNuevos.Text = t.Rows.Count.ToString();
            lblIngNuevos.Text = "$" + PlanesBD.ObtenerIngresosNuevos(dtFechaFin.Value, dtFechaInicio.Value).ToString();


           
            lblAmbTotales.Text = AmbulanciasBD.ObtenerAmbulanciasTotales().ToString();
            lblMedTotales.Text = MedicoBD.ObtenerMedicosTotales().ToString();
            lblEnfTotales.Text = EnfermeroBD.ObtenerEnfermerosTotales().ToString();
            lblUsuTotales.Text = UsuarioBD.ObtenerUsuariosTotales().ToString();

            
                picSlider.ImageLocation = string.Format(@"C:\Users\Nicolas\Desktop\SIMED\Resources\" + 1 + ".jpg");
                
            
            
        }

        private void lblFechaInicio_Click(object sender, EventArgs e)
        {
            if (actual == btnPersonalizado)
            {
                dtFechaInicio.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblFechaFin_Click(object sender, EventArgs e)
        {
            if (actual == btnPersonalizado)
            {
                dtFechaFin.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblFechaIncio_Click(object sender, EventArgs e)
        {
            if (actual == btnPersonalizado)
            {
                dtFechaInicio.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblFechaFin_Click_1(object sender, EventArgs e)
        {
            if (actual == btnPersonalizado)
            {
                dtFechaFin.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtFechaFin_ValueChanged(object sender, EventArgs e)
        {
            lblFechaFin.Text = EmpleadosBD.UpperCaseFirstChar(dtFechaFin.Text);

          
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {

            lblFechaIncio.Text = EmpleadosBD.UpperCaseFirstChar(dtFechaInicio.Text);

        }
        private void CargarSiguienteImagen()
        {
            
            imageNumber++;
            if (imageNumber >4)
            {
                imageNumber = 1;
            }
            picSlider.ImageLocation = string.Format(@"C:\Users\Nicolas\Desktop\SIMED\Resources\" + imageNumber + ".jpg");
        }

        private void CargarImagenPrevia()
        {
            
            imageNumber--;
            if (imageNumber < 1)
            {
                imageNumber = 4;
            }
            picSlider.ImageLocation = string.Format(@"C:\Users\Nicolas\Desktop\SIMED\Resources\"+ imageNumber +".jpg");
        }

        private void btnPrevio_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            CargarImagenPrevia();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            CargarSiguienteImagen();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarSiguienteImagen();
            timer1.Interval = 3000;
        }

        private void picSlider_Click(object sender, EventArgs e)
        {
            if (picSlider.ImageLocation == string.Format(@"C:\Users\Nicolas\Desktop\SIMED\Resources\" + 1 + ".jpg"))
            {
                System.Diagnostics.Process.Start("https://simedsrl.com/articulaciones/reumatismo-consecuencias/");
            }

            if (picSlider.ImageLocation == string.Format(@"C:\Users\Nicolas\Desktop\SIMED\Resources\" + 2 + ".jpg"))
            {
                System.Diagnostics.Process.Start("https://simedsrl.com/calidad-de-vida/dermatitis-atopica-que-es/");
            }

            if (picSlider.ImageLocation == string.Format(@"C:\Users\Nicolas\Desktop\SIMED\Resources\" + 3 + ".jpg"))
            {
                System.Diagnostics.Process.Start("https://simedsrl.com/actividad-fisica/omega-3-y-vitamina-d/");
            }

            if (picSlider.ImageLocation == string.Format(@"C:\Users\Nicolas\Desktop\SIMED\Resources\" + 4 + ".jpg"))
            {
                System.Diagnostics.Process.Start("https://simedsrl.com/enfermedades-contagiosas/hepatitis-tipos/");
            }


        }
    }
}
