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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            AbrirFormEnPanel(new PanelMenu());
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.pnlVentana.Controls.Count > 0)
                this.pnlVentana.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlVentana.Controls.Add(fh);
            this.pnlVentana.Tag = fh;
            fh.Show();
        }

        private void tmrHyF_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 220)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 220;

            if (pbLogo.Width == 110)
            {
                pbLogo.Width = 70;
                pbLogo.Height = 70;
            }
            else
                pbLogo.Width = 110;
                pbLogo.Height = 90;
        }



        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PanelMenu());
        }
    }
}