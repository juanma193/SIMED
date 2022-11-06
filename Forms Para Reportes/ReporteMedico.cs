using Microsoft.Reporting.WinForms;
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
            this.mEDICOSTableAdapter.Fill(this.bD3K3G05_2022DataSet.MEDICOS);
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2022DataSet.MEDICOS' Puede moverla o quitarla según sea necesario.
            //this.mEDICOSTableAdapter.Fill(this.bD3K3G05_2022DataSet.MEDICOS);


            //this.reportViewerMedico.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            

            DataTable tabla = new DataTable();
            tabla = MedicoBD.ObtenerMedicoCompletoReporte();

            ReportDataSource ds = new ReportDataSource("DatosMedicos", tabla);

            //reportViewerMedico.ProcessingMode = ProcessingMode.Remote;


            reportViewerMedico.LocalReport.DataSources.Add(ds);
            reportViewerMedico.LocalReport.Refresh();
            
            reportViewerMedico.RefreshReport();
        }
    }
}
