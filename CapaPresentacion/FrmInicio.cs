using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            FrmRegistros frmRegistros = new FrmRegistros();
            frmRegistros.Show();
            this.Hide();
        }

        private void btnVistas_Click(object sender, EventArgs e)
        {
            FrmRegistros frmVistas = new FrmRegistros();
            frmVistas.Show();
            this.Hide();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsers frmRegistrarUsers = new FrmRegistrarUsers();
            frmRegistrarUsers.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            if(FrmLogin.area == "A0001")
            {
                btnRegistrarUsuario.Enabled = true;
                btnRegistros.Enabled = true;
                btnVistas.Enabled = true;

                lblArea.Text = "Administrador";
            }
            else if(FrmLogin.area == "A0002")
            {
                btnRegistrarUsuario.Enabled=false;
                btnRegistros.Enabled=true;
                btnVistas.Enabled=true;

                lblArea.Text = "General";
            }

            lblUsuario.Text = FrmLogin.usuario_nombre;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblHora.Text = DateTime.Now.ToString("hh: mm: ss tt");
        }
    }
}
