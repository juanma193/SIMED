using SIMED.Models;
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

namespace SIMED_V1.Forms_Para_ABM
{
    public partial class ConsultaMedico : Form
    {
        int idPerfil;
        public ConsultaMedico(int idPerf)
        {
            InitializeComponent();
            idPerfil = idPerf;
        }

        private void btnVolverConsulta_Click(object sender, EventArgs e)
        {

            Usuarios usu = new Usuarios();
            PrincipalForm ventana = new PrincipalForm(usu);
            ventana.Show();
            this.Dispose();
        }


        private void txtConsultaMatriculaMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConsultaNombreMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConsultaApellidoMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            if(txtConsultaMatriculaMedico.Text == "" && txtConsultaNombreMedico.Text == "" && txtConsultaApellidoMedico.Text == "")
            {
                grdConsultaMedico.DataSource = MedicoBD.ObtenerMedicos();
                chkMedicos.Visible = false;
            }
            else
            {
                if(txtConsultaMatriculaMedico.Text == "")
                {
                    txtConsultaMatriculaMedico.Text = "-1";
                    grdConsultaMedico.DataSource = MedicoBD.ObtenerMedicos(int.Parse(txtConsultaMatriculaMedico.Text), txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);
                }
                else
                {
                    grdConsultaMedico.DataSource = MedicoBD.ObtenerMedicos(int.Parse(txtConsultaMatriculaMedico.Text), txtConsultaNombreMedico.Text, txtConsultaApellidoMedico.Text);
                }

                chkMedicos.Visible = true;
                chkMedicos.Checked = false;
            }

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtConsultaMatriculaMedico.Text = "";
            txtConsultaNombreMedico.Text = "";
            txtConsultaApellidoMedico.Text = "";
        }

        public void CargarGrillaConsultaMedico()
        {
            grdConsultaMedico.DataSource = MedicoBD.ObtenerMedicos();
        }

        private void ConsultaMedico_Load(object sender, EventArgs e)
        {
            CargarGrillaConsultaMedico();
        }


        private void chkMedicos_CheckedChanged(Object sender, EventArgs e)
        {
            if (chkMedicos.Checked)
            {
                grdConsultaMedico.DataSource = MedicoBD.ObtenerMedicos();
                chkMedicos.Visible = false;
            }
        }


        private void grdConsultaMedico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ConsultaMedico cons = this;
            DatosMedico ventana = new DatosMedico(cons, idPerfil);

            //Es necesario poner la prop. Modifiers de los txt del form en Public!
            ventana.txtMatriculaMedicoDato.PlaceholderText = grdConsultaMedico.Rows[e.RowIndex].Cells[0].Value.ToString();
            ventana.txtNombreMedicoDato.PlaceholderText = grdConsultaMedico.Rows[e.RowIndex].Cells[1].Value.ToString();
            ventana.txtApellidoMedicoDato.PlaceholderText = grdConsultaMedico.Rows[e.RowIndex].Cells[2].Value.ToString();

            // Para los datos que no están en la gdr
            DataTable tabla = MedicoBD.ObtenerMedicoCompleto(int.Parse(grdConsultaMedico.Rows[e.RowIndex].Cells[0].Value.ToString()));

            ventana.txtCalleMedicoDato.PlaceholderText = tabla.Rows[0]["calle"].ToString();
            ventana.txtNumeroCalleMedicoDato.PlaceholderText = tabla.Rows[0]["nroCalle"].ToString();

            int sexo = int.Parse(tabla.Rows[0]["id_sexo"].ToString());
            if (sexo == 1) { ventana.rdFemeninoMedicoDato.Checked = true; }
            if (sexo == 2) { ventana.rdMasculinoMedicoDato.Checked = true; }
            if (sexo == 3) { ventana.rdOtroMedicoDato.Checked = true; }

            int rel_Lab = int.Parse(tabla.Rows[0]["id_relacionLaboral"].ToString());
            if (rel_Lab == 1) { ventana.rdPlantaPermanenteMedicoDato.Checked = true; }
            if (rel_Lab == 2) { ventana.rdContratoCircunsMedicoDato.Checked = true; }
            if (rel_Lab == 3) { ventana.rdContratoRenovMedicoDato.Checked = true; }

            int filas = tabla.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                int dias_lab = int.Parse(tabla.Rows[i]["id_diaLaboral"].ToString());
                if (dias_lab == 1) { ventana.chkLunesMedicoDato.Checked = true; }
                if (dias_lab == 2) { ventana.chkMartesMedicoDato.Checked = true; }
                if (dias_lab == 3) { ventana.chkMiercolesMedicoDato.Checked = true; }
                if (dias_lab == 4) { ventana.chkJuevesMedicoDato.Checked = true; }
                if (dias_lab == 5) { ventana.chkViernesMedicoDato.Checked = true; }
                if (dias_lab == 6) { ventana.chkSabadoMedicoDato.Checked = true; }
                if (dias_lab == 7) { ventana.chkDomingoMedicoDato.Checked = true; }
            }


            ventana.txtTipoDocMedicoDato.PlaceholderText = tabla.Rows[0]["descripcionTipoDocumento"].ToString();
            ventana.txtNumeroDocMedicoDato.PlaceholderText = tabla.Rows[0]["numDocumento"].ToString();
            ventana.txtCiudadMedicoDato.PlaceholderText = tabla.Rows[0]["descripcionCiudad"].ToString();
            ventana.txtEspecialidadMedicoDato.PlaceholderText = tabla.Rows[0]["descripcionEspecialidad"].ToString();
            ventana.txtBarrioMedicoDato.PlaceholderText = tabla.Rows[0]["nombre_barrio"].ToString();
            ventana.dtFechaNacMedicoDato.Value = DateTime.Parse(tabla.Rows[0]["fechaNacimiento"].ToString());
            ventana.dtHoraIngresoMedicoDato.Value = DateTime.Parse(tabla.Rows[0]["horarioIngreso"].ToString());
            ventana.dtHoraEgresoMedicoDato.Value = DateTime.Parse(tabla.Rows[0]["horarioEgreso"].ToString());

            ventana.Show();
        }



        private void btnConsultaEliminarMedico_Click(object sender, EventArgs e)
        {
            ConsultaMedico cons = this;
            DatosMedico ventana = new DatosMedico(cons, idPerfil);
            ventana.lblDatosMedico.Text = "Eliminar enfermero";
            ventana.btnEliminarMedicoDato.Visible = true;
            ventana.btnEliminarMedicoDato.Enabled = true;

            //Es necesario poner la prop. Modifiers de los txt del form en Public!
            DataGridViewRow fila = grdConsultaMedico.CurrentRow;
            ventana.txtMatriculaMedicoDato.PlaceholderText = fila.Cells[0].Value.ToString();
            ventana.txtNombreMedicoDato.PlaceholderText = fila.Cells[1].Value.ToString();
            ventana.txtApellidoMedicoDato.PlaceholderText = fila.Cells[2].Value.ToString();

            // Para los datos que no están en la gdr
            DataTable tabla = MedicoBD.ObtenerMedicoCompleto(int.Parse(fila.Cells[0].Value.ToString()));
            ventana.txtCalleMedicoDato.PlaceholderText = tabla.Rows[0]["calle"].ToString();
            ventana.txtNumeroCalleMedicoDato.PlaceholderText = tabla.Rows[0]["nroCalle"].ToString();

            int sexo = int.Parse(tabla.Rows[0]["id_sexo"].ToString());
            if (sexo == 1) { ventana.rdFemeninoMedicoDato.Checked = true; }
            if (sexo == 2) { ventana.rdMasculinoMedicoDato.Checked = true; }
            if (sexo == 3) { ventana.rdOtroMedicoDato.Checked = true; }

            int rel_Lab = int.Parse(tabla.Rows[0]["id_relacionLaboral"].ToString());
            if (rel_Lab == 1) { ventana.rdPlantaPermanenteMedicoDato.Checked = true; }
            if (rel_Lab == 2) { ventana.rdContratoCircunsMedicoDato.Checked = true; }
            if (rel_Lab == 3) { ventana.rdContratoRenovMedicoDato.Checked = true; }

            int filas = tabla.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                int dias_lab = int.Parse(tabla.Rows[i]["id_diaLaboral"].ToString());
                if (dias_lab == 1) { ventana.chkLunesMedicoDato.Checked = true; }
                if (dias_lab == 2) { ventana.chkMartesMedicoDato.Checked = true; }
                if (dias_lab == 3) { ventana.chkMiercolesMedicoDato.Checked = true; }
                if (dias_lab == 4) { ventana.chkJuevesMedicoDato.Checked = true; }
                if (dias_lab == 5) { ventana.chkViernesMedicoDato.Checked = true; }
                if (dias_lab == 6) { ventana.chkSabadoMedicoDato.Checked = true; }
                if (dias_lab == 7) { ventana.chkDomingoMedicoDato.Checked = true; }
            }


            ventana.txtTipoDocMedicoDato.PlaceholderText = tabla.Rows[0]["descripcionTipoDocumento"].ToString();
            ventana.txtNumeroDocMedicoDato.PlaceholderText = tabla.Rows[0]["numDocumento"].ToString();
            ventana.txtCiudadMedicoDato.PlaceholderText = tabla.Rows[0]["descripcionCiudad"].ToString();
            ventana.txtEspecialidadMedicoDato.PlaceholderText = tabla.Rows[0]["descripcionEspecialidad"].ToString();
            ventana.txtBarrioMedicoDato.PlaceholderText = tabla.Rows[0]["nombre_barrio"].ToString();
            ventana.dtFechaNacMedicoDato.Value = DateTime.Parse(tabla.Rows[0]["fechaNacimiento"].ToString());
            ventana.dtHoraIngresoMedicoDato.Value = DateTime.Parse(tabla.Rows[0]["horarioIngreso"].ToString());
            ventana.dtHoraEgresoMedicoDato.Value = DateTime.Parse(tabla.Rows[0]["horarioEgreso"].ToString());


            ventana.Show();

        }

        private void grdConsultaMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConsultaEliminarMedico.Enabled = true;
            btnConsultaModificarMedico.Enabled = true;
        }

        private void btnConsultaModificarMedico_Click(object sender, EventArgs e)
        {
            ConsultaMedico cons = this;
            ModificarMedico ventana = new ModificarMedico(cons, idPerfil);

            //Es necesario poner la prop. Modifiers de los txt del form en Public!
            DataGridViewRow fila = grdConsultaMedico.CurrentRow;
            ventana.txtModificarMatriculaMedico.Text = fila.Cells[0].Value.ToString();
            ventana.txtModificarNombreMedico.Text = fila.Cells[1].Value.ToString();
            ventana.txtModificarApellidoMedico.Text = fila.Cells[2].Value.ToString();

            // Para los datos que no están en la gdr
            DataTable tabla = MedicoBD.ObtenerMedicoCompleto(int.Parse(fila.Cells[0].Value.ToString()));
            ventana.txtModificarCalleMedico.Text = tabla.Rows[0]["calle"].ToString();
            ventana.txtModificarNroCalleMedico.Text = tabla.Rows[0]["nroCalle"].ToString();

            int sexo = int.Parse(tabla.Rows[0]["id_sexo"].ToString());
            if (sexo == 1) { ventana.rdModificarFemeninoMedico.Checked = true; }
            if (sexo == 2) { ventana.rdModificarMasculinoMedico.Checked = true; }
            if (sexo == 3) { ventana.rdModificarOtroMedico.Checked = true; }

            int rel_Lab = int.Parse(tabla.Rows[0]["id_relacionLaboral"].ToString());
            if (rel_Lab == 1) { ventana.rdModificarPlantaPermanente.Checked = true; }
            if (rel_Lab == 2) { ventana.rdModificarContratoCircuns.Checked = true; }
            if (rel_Lab == 3) { ventana.rdModificarContratoRenov.Checked = true; }

            int filas = tabla.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                int dias_lab = int.Parse(tabla.Rows[i]["id_diaLaboral"].ToString());
                if (dias_lab == 1) { ventana.chkModificarLunesMedico.Checked = true; }
                if (dias_lab == 2) { ventana.chkModificarMartesMedico.Checked = true; }
                if (dias_lab == 3) { ventana.chkModificarMiercolesMedico.Checked = true; }
                if (dias_lab == 4) { ventana.chkModificarJuevesMedico.Checked = true; }
                if (dias_lab == 5) { ventana.chkModificarViernesMedico.Checked = true; }
                if (dias_lab == 6) { ventana.chkModificarSabadoMedico.Checked = true; }
                if (dias_lab == 7) { ventana.chkModificarDomingoMedico.Checked = true; }
            }


            ventana.cmbModificarTipoDocumentoMedico.Text = tabla.Rows[0]["descripcionTipoDocumento"].ToString();
            ventana.txtModificarNroDocMedico.Text = tabla.Rows[0]["numDocumento"].ToString();
            ventana.cmbModificarCiudadMedico.Text = tabla.Rows[0]["descripcionCiudad"].ToString();
            ventana.cmbModificarEspecialidadMedico.Text = tabla.Rows[0]["descripcionEspecialidad"].ToString();
            ventana.cmbModificarBarriosMedico.Text = tabla.Rows[0]["nombre_barrio"].ToString();
            ventana.dtModificarFechaNacMedico.Value = DateTime.Parse(tabla.Rows[0]["fechaNacimiento"].ToString());
            ventana.dtModificarHoraIngresoMedico.Value = DateTime.Parse(tabla.Rows[0]["horarioIngreso"].ToString());
            ventana.dtModificarHoraEgresoMedico.Value = DateTime.Parse(tabla.Rows[0]["horarioEgreso"].ToString());


            ventana.Show();
        }
    }
}
