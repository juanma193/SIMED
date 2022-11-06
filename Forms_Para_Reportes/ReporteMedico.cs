using Microsoft.Reporting.WinForms;
using SIMED.Models;
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
    public partial class ReporteMedico : Form
    {
        public ReporteMedico()
        {
            InitializeComponent();
        }

        private void ReporteMedico_Load(object sender, EventArgs e)
        {
           


            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2022DataSet.MEDICOS' Puede moverla o quitarla según sea necesario.
            //this.mEDICOSTableAdapter.Fill(this.bD3K3G05_2022DataSet.MEDICOS);


            this.reportViewerMedico.RefreshReport();
           
        }


        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnFiltrarEspecialidad_Click(object sender, EventArgs e)
        {
            var db = new BD3K3G05_2022Context();
            List<Medicos> medico = (from doc in db.Medicos select doc).ToList();

            mEDICOSBindingSource.DataSource = medico;



            reportViewerMedico.LocalReport.ReportEmbeddedResource = "ReporteMedico.rdlc";

            reportViewerMedico.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            reportViewerMedico.RefreshReport();
        

            /*
        DataTable tabla = new DataTable();
            tabla = MedicoBD.ObtenerMedicoCompletoReporte();


            ReportDataSource rpd = new ReportDataSource("DataSetMedico", tabla);
           // reportViewerMedico.LocalReport.ReportEmbeddedResource = "SIMED_V1.Forms_Para_Reportes.ReporteMedico.rdlc";
            reportViewerMedico.LocalReport.DataSources.Clear();
            reportViewerMedico.LocalReport.DataSources.Add(rpd);
            reportViewerMedico.RefreshReport();
            */
        }
    }
}
