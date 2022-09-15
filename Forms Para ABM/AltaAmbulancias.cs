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
    public partial class AltaAmbulancias : Form
    {
        public AltaAmbulancias()
        {
            InitializeComponent();
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultCmbItem = "Modelo";
            cmbModelo.Items.Add(defaultCmbItem);
            cmbModelo.SelectedItem = defaultCmbItem;


        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
