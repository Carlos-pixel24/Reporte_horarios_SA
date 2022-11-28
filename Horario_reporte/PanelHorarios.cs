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
    public partial class PanelHorarios : Form
    {
        public PanelHorarios()
        {
            InitializeComponent();
        }

        private void lbBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void uI_TextBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void uI_TextBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            Ventana_Horario horario = new Ventana_Horario();
            horario.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {

        }

        private void uI_TextBox1_Enter_1(object sender, EventArgs e)
        {
            if (txtBuscador.Text == "Buscador...")
            {
                txtBuscador.Text = "";
                //txtBuscador.UseSystemPasswordChar = true;
            }
        }

        private void uI_TextBox1_Leave_1(object sender, EventArgs e)
        {
            if (txtBuscador.Text == "")
            {
                txtBuscador.Text = "Buscador...";
                //txtBuscador.UseSystemPasswordChar = false;
            }
        }
    }
}