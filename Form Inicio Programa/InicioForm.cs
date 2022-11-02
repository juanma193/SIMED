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
    public partial class InicioForm : Form
    {
        MusicPlayer player = MusicPlayer.Instance;
        public InicioForm()
        {
            
            InitializeComponent();
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = "C:\\Facultad\\Tercer Año\\PAV 1\\practicas\\archivos para proyecto\\ps3Sonido.wav";
            //player.Play();
            //player.Play("C:\\Program Files (x86)\\SIMED\\archivos\\musica simed.wav");

        }

        private void InicioForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIniciarPrograma_Click(object sender, EventArgs e)
        {

            LoginUsuarios ventana = new LoginUsuarios();
            ventana.Show();
            this.Hide();
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = "C:\\Facultad\\Tercer Año\\PAV 1\\practicas\\archivos para proyecto\\sonidoPS2.wav";
            //player.Play();
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
