using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace SIMED_V1
{
    public partial class ErroresForm : Form

    {

        public ErroresForm()
        {
            InitializeComponent();
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = "C:\\Facultad\\Tercer Año\\PAV 1\\practicas\\archivos para proyecto\\sonidoPayaso.wav";
            //player.Play();
            this.Show();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            


        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public void show(string msg)
        {
            lblMensaje.Text = msg;
        
        }
        

        private void ErroresForm_Load(object sender, EventArgs e)
        {
            
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = "C:\\Facultad\\Tercer Año\\PAV 1\\practicas\\archivos para proyecto\\sonidoPS2.wav";
            //player.Play();
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void picWarning_Click(object sender, EventArgs e)
        {

        }
    }
}
