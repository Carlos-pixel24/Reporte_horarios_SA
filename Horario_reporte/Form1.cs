using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horario_reporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.OliveDrab;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.OliveDrab;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.OliveDrab;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.OliveDrab;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ESTE ES EL CODIGO PARA PASAR DE UN FORM A OTRO
            //Y CERRAR EL ANTERIOR FORM

            Index index = new Index();
            index.Show();

            this.Hide();

            //  NOTA
            //  ESTA TRANSICION DE LOGIN A INDEX SE DEBE DE ACITVAR
            //  SOLAMENTE CUANDO YA SE VERIFICAN LAS CREDENCIALES
            //  DEL USUARIO
            //  (VALIDAR SESION)
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lbFocus.Focus();
        }
    }
}
