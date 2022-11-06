﻿using SIMED_V1.Entidades;
using SIMED_V1.Bases_de_datos;
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
    public partial class ProgressBar : Form
    {
        new Usuarios usu = new Usuarios();
        public ProgressBar(Usuarios user)
        {
            InitializeComponent();

            usu.NombreDeUsuario = user.NombreDeUsuario;

            usu = EmpleadosBD.obtenerUsuarioconusername(user.NombreDeUsuario);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbrInicioSistema_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbrInicioSistema.Value+=5;
            if (pbrInicioSistema.Value == 100)
            {
                PrincipalForm ventana = new PrincipalForm(usu);
                ventana.Show();
                this.Close();
                
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
