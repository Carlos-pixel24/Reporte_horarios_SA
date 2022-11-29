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
    public partial class PanelUsuarios : Form
    {
        String idusuario;
        public PanelUsuarios()
        {
            InitializeComponent();
        }

        private void lbBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre...")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre...";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido...")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido...";
            }
        }

        private void txtCargo_Enter(object sender, EventArgs e)
        {
            if (txtCargo.Text == "Cargo...")
            {
                txtCargo.Text = "";
            }
        }

        private void txtCargo_Leave(object sender, EventArgs e)
        {
            if (txtCargo.Text == "")
            {
                txtCargo.Text = "Cargo...";
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario...")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario...";
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña Asignada...")
            {
                txtContra.Text = "";
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña Asignada...";
            }
        }

        private void BTNregistrar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Cargo = txtCargo.Text;
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContra.Text;

            String Query = "INSERT INTO Usuarios (Nombre,Apellido,Cargo,usuario,contraseña) Values" +
                "('"+Nombre+"','"+Apellido+"','"+Cargo+"','"+Usuario+"','"+Contraseña+"')";

            MySqlConnection conexion_DB = Clases.CN.conexion();
            conexion_DB.Open();

            try
            {

                MySqlCommand com = new MySqlCommand(Query, conexion_DB);
                com.ExecuteNonQuery();

                MessageBox.Show("USUARIO REGISTRADO CON EXITO");
                txtContra.Text = "Contraseña Asignada...";
                txtNombre.Text = "Nombre...";
                txtApellido.Text = "Apellido...";
                txtUsuario.Text = "Usuario...";
                txtCargo.Text = "Cargo...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);

            }

            finally {
                conexion_DB.Close();
            }
        }

        private void BTNbuscar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            MySqlDataReader reader = null;

            String query_busqueda = "Select IDusuario,Nombre,Apellido,Cargo,contraseña from Usuarios where " +
                "usuario LIKE '"+usuario+"'LIMIT 1";

            MySqlConnection conexion_DB = Clases.CN.conexion();
            conexion_DB.Open();


            try
            {

                MySqlCommand com = new MySqlCommand(query_busqueda, conexion_DB);
                reader = com.ExecuteReader();

                if (reader.HasRows) { 

                while (reader.Read())
                {
                        idusuario = reader.GetString(0);
                        txtNombre.Text = reader.GetString(1);
                        txtApellido.Text = reader.GetString(2);
                        txtCargo.Text = reader.GetString(3);
                        txtContra.Text = reader.GetString(4);
                       
                    }

                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRO NINGUN USUARIO CON ESTE NOMBRE");
                }
            } catch (Exception ex) {

                MessageBox.Show("ERROR: "+ex);
            }
        }

        private void BTNeditar_Click(object sender, EventArgs e)
        {

            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Cargo = txtCargo.Text;
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContra.Text;

            String Query_actualizar = "UPDATE Usuarios set Nombre='" + Nombre + "',Apellido='" + Apellido + "',Cargo='"
                + Cargo + "',usuario='" + Usuario + "',contraseña='" + Contraseña + "'where IDusuario='"
                +idusuario+"'";

            MySqlConnection conexion_DB = Clases.CN.conexion();
            conexion_DB.Open();

            try
            {

                MySqlCommand com = new MySqlCommand(Query_actualizar, conexion_DB);
                com.ExecuteNonQuery();

                MessageBox.Show("SE HA ACTUALIZADO LA INFORMACION CON EXITO");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);

            }

            finally
            {
                conexion_DB.Close();
            }

        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            String Query_Borrar = "DELETE FROM Usuarios WHERE IDusuario='"+idusuario+"'";

            MySqlConnection conexion_DB = Clases.CN.conexion();
            conexion_DB.Open();

            try
            {

                MySqlCommand com = new MySqlCommand(Query_Borrar, conexion_DB);
                com.ExecuteNonQuery();

                MessageBox.Show("SE HA ELIMINADO EL USUARIO CORRECTAMENTE");
                txtContra.Text = "Contraseña Asignada...";
                txtNombre.Text = "Nombre...";
                txtApellido.Text = "Apellido...";
                txtUsuario.Text = "Usuario...";
                txtCargo.Text = "Cargo...";

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);

            }

            finally
            {
                conexion_DB.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtContra.Text = "Contraseña Asignada...";
            txtNombre.Text = "Nombre...";
            txtApellido.Text = "Apellido...";
            txtUsuario.Text = "Usuario...";
            txtCargo.Text = "Cargo...";
        }
    }
}