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
    public partial class ConsultarViaje : Form
    {
        public ConsultarViaje()
        {
            InitializeComponent();
        }

        private void cmbMoviles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultCmbItem = "Móvil";
            cmbMoviles.Items.Add(defaultCmbItem);
            cmbMoviles.SelectedItem = defaultCmbItem;
        }
    }
}
