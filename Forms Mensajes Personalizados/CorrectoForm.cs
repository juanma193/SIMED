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
    public partial class CorrectoForm : Form
    {
        public CorrectoForm()
        {
            InitializeComponent();
            this.Show();
        }

        public void show(string msg)
        {
            lblMensaje.Text = msg;

        }
        private void CorrectoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
