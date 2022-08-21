using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmRegistrarUsers : Form
    {
        N_RegisterUser objN = new N_RegisterUser();
        E_RegisterUser objE = new E_RegisterUser();
        public FrmRegistrarUsers()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmRegistrarUsers_Load(object sender, EventArgs e)
        {
            //cbbTipoUsuario.DataSource = objCD.CargarCombo();
            //cbbTipoUsuario.DisplayMember = "id_empleado";
            //cbbTipoUsuario.ValueMember = "id_empleado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            /*try
            {
                ///objE.Id_area = cbbTipoUsuario.ValueMember = "id_empleado";
                objE.Nombre = txtNombre.Text.ToUpper();
                objE.Apellido = txtApellido.Text.ToUpper();
                objE.Nacimiento = txtFechaNacimiento.Text.ToUpper();
                objE.Usuario = txtUsuario.Text.ToUpper();
                objE.Contraseña = txtPass.Text.ToUpper();
                objE.Id_empleado = txtTipo.Text.ToUpper();


                objN.InsertandoUsuarios(objE);

                MessageBox.Show("Se  guardo el registro");
                
                limpiarCaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el registro" + ex);
            }

            
        }*/

            /*private void limpiarCaja()
            {

                //cbbTipoUsuario.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtFechaNacimiento.Text = "";
                txtUsuario.Text = "";
                txtPass.Text = "";
                txtTipo.Text = "";

            }*/


        }

        public void Guardar()
        {

            try
            {

                objE.Nombre = txtNombre.Text.ToUpper();
                objE.Apellido = txtApellido.Text.ToUpper();
                objE.Id_area = txtTipo.Text.ToUpper();
                objE.Id_empleado = txtTipo.Text.ToUpper();
                objE.Nacimiento = txtFechaNacimiento.Text.ToUpper();
                objE.Usuario = txtUsuario.Text.ToUpper();
                objE.Contraseña = txtPass.Text.ToUpper();



                objN.InsertandoUser(objE);

                MessageBox.Show("Se  guardo el registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el registro" + ex);
            }
            



        }
    }
}
