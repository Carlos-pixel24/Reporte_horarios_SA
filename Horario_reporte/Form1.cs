using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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


            String usuario = txtUser.Text;
            String contraseña = txtPass.Text;
            MySqlDataReader reader = null;

            String query_busqueda = "Select IDusuario from Usuarios where " +
                "usuario='"+usuario+"' and contraseña='"+contraseña+"' LIMIT 1";

            MySqlConnection conexion_DB = Clases.CN.conexion();
            conexion_DB.Open();


            try
            {

                MySqlCommand com = new MySqlCommand(query_busqueda, conexion_DB);
                reader = com.ExecuteReader();

                if (reader.HasRows)
                {

                    Index index = new Index();
                    index.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRO NINGUN USUARIO CON ESTE NOMBRE");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: " + ex);
            }

           

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
