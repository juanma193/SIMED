using SIMED.Models;
using SIMED_V1.Forms_Para_ABM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1
{
    public partial class UMedicos : UserControl
    {
        int idPerfil;

        public UMedicos(Usuarios usuario)
        {
            InitializeComponent();
            idPerfil = usuario.IdUsuario;


        }

        private void btnDarAltaMedico_Click(object sender, EventArgs e)
        {
            AltaMedico ventana = new AltaMedico(idPerfil);
            ventana.Show();

        }

        private void btnConsultarDatosMedico_Click(object sender, EventArgs e)
        {
            ConsultaMedico ventana = new ConsultaMedico(idPerfil);
            ventana.Show();

        }

    }
}
