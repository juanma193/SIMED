using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class AltaMedico : Form
    {
        public AltaMedico()
        {
            InitializeComponent();
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultCmbItem = "Tipo de documento";
            cmbTipoDocumento.Items.Add(defaultCmbItem);
            cmbTipoDocumento.SelectedItem = defaultCmbItem;
        }

        private void cmbBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultCmbItem = "Barrio";
            cmbBarrios.Items.Add(defaultCmbItem);
            cmbBarrios.SelectedItem = defaultCmbItem;
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultCmbItem = "Especialidad";
            cmbEspecialidad.Items.Add(defaultCmbItem);
            cmbEspecialidad.SelectedItem = defaultCmbItem;
        }
    }
}
