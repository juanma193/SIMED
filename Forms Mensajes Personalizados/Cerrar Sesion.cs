using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Mensajes_Personalizados
{
    public partial class Cerrar_Sesion : Form
    {
        Form inicioprincipal;
        public Cerrar_Sesion(Form inicio)
        {
            InitializeComponent();
            inicioprincipal = inicio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Menu")
                    Application.OpenForms[i].Close();
            }
        }
    }
}
