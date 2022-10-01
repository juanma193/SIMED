using SIMED_V1.Forms_Para_El_Menu;
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
    public partial class PrincipalForm : Form
    {
        UserControl ContActivo;
        private const int cGrip = 16;
        private const int cCaption = 32;

        public PrincipalForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            
            //uUsuarios1.Hide();
            //uMedicos1.Hide();
            //uAmbulancias1.Hide();
            //uEnfermeros1.Hide();
        }

        private void uUsuarios1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //uMedicos1.Show();
            //uMedicos1.BringToFront();
            this.pnContenido.Controls.Remove(ContActivo);
            ContActivo = new UMedicos();
            ContActivo.Dock = DockStyle.Fill;
            this.pnContenido.Controls.Add(ContActivo);
            
        }

        private void txtAmbulancias_Click(object sender, EventArgs e)
        {
            //uAmbulancias1.Show();
            //uAmbulancias1.BringToFront();
            this.pnContenido.Controls.Remove(ContActivo);
            ContActivo = new UAmbulancias();
            ContActivo.Dock = DockStyle.Fill;
            this.pnContenido.Controls.Add(ContActivo);
        }

        private void btnEnfermeros_Click(object sender, EventArgs e)
        {
            //uEnfermeros1.Show();
            //uEnfermeros1.BringToFront();
            PrincipalForm menu = this;

            this.pnContenido.Controls.Remove(ContActivo);
            ContActivo = new UEnfermeros(menu);
            ContActivo.Dock = DockStyle.Fill;
            this.pnContenido.Controls.Add(ContActivo);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //uUsuarios1.Show();
            //uUsuarios1.BringToFront();
            this.pnContenido.Controls.Remove(ContActivo);
            ContActivo = new UUsuarios();
            ContActivo.Dock = DockStyle.Fill;
            this.pnContenido.Controls.Add(ContActivo);

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAfiliados_Click(object sender, EventArgs e)
        {
            this.pnContenido.Controls.Remove(ContActivo);
            //
            ContActivo = new UAfiliados();
            ContActivo.Dock = DockStyle.Fill;
            this.pnContenido.Controls.Add(ContActivo);
        }

        private void pnContenido_Paint(object sender, PaintEventArgs e)
        {

        }
       
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

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            this.pnContenido.Controls.Remove(ContActivo);
            ContActivo = new UPlanes();
            ContActivo.Dock = DockStyle.Fill;
            this.pnContenido.Controls.Add(ContActivo);
        }

        private void txtMedicos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            LoginUsuarios ventana = new LoginUsuarios();
            //Programar ventana desea salir??
            ventana.Show();
            this.Dispose();
            
          

            
        }
    }
}
