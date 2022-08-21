using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistros : Form
    {
        CD_Registrar objRegis = new CD_Registrar();
        E_Registrar objEntidad = new E_Registrar();
        N_Registrar objNRegistros = new N_Registrar();
        

        public FrmRegistros()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrosRegresar_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void FrmRegistros_Load(object sender, EventArgs e)
        {
            ListarEdificios();
            ListarAulas();
            ListarRegistros();
            
        }

        private void ListarEdificios()
        {
            CD_Registrar objRegis = new CD_Registrar();
            cbbEdificio.DataSource = objRegis.ListarEdificios();
            cbbEdificio.DisplayMember = "EDIFI";
            cbbEdificio.ValueMember = "IDEDIFI";
        }
        public void ListarRegistros()
        {
            dataGridView1.DataSource = objRegis.ListarRegistros();
        }
        private void ListarAulas()
        {
            CD_Registrar objRegis = new CD_Registrar();
            cbbAula.DataSource = objRegis.ListarAulas();
            cbbAula.DisplayMember = "AULA";
            cbbAula.ValueMember = "IDAULA";
        }

        private void btnRegistrosGuardar_Click(object sender, EventArgs e)
        {

            Guardar();

        }

        

        public void Guardar()
        {

            try
            {

                objEntidad.Nombre = txtNombre.Text.ToUpper();
                objEntidad.Apellido = txtApellido.Text.ToUpper();
                objEntidad.HoraEntrada = txtEntrada.Text.ToUpper();
                objEntidad.HoraSalida = txtSalida.Text.ToUpper();
                objEntidad.Motivo = txtMotivo.Text.ToUpper();
                objEntidad.IdAu = Convert.ToInt32(cbbAula.SelectedValue);
                objEntidad.IdEd = Convert.ToInt32(cbbEdificio.SelectedValue);
                objEntidad.Carrera = txtCorreo.Text.ToUpper();


                objNRegistros.InsertandoRegistros(objEntidad);

                MessageBox.Show("Se  guardo el registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el registro" + ex);
            }
            ListarRegistros();



        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
