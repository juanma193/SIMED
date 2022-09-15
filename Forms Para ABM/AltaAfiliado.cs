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
    public partial class AltaAfiliado : Form
    {
        public AltaAfiliado()
        {
            InitializeComponent();
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultCmbItem = "Tipo de documento";
            cmbTipoDocumento.Items.Add(defaultCmbItem);
            cmbTipoDocumento.SelectedItem = defaultCmbItem;

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultCmbItem = "Barrio";
            cmbBarrios.Items.Add(defaultCmbItem);
            cmbBarrios.SelectedItem = defaultCmbItem;
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultCmbItem = "Plan";
            cmbPlanes.Items.Add(defaultCmbItem);
            cmbPlanes.SelectedItem = defaultCmbItem;
        }
    }
}
