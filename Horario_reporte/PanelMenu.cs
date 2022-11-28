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
    public partial class PanelMenu : Form
    {
        public PanelMenu()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.pnlMenu.Controls.Count > 0)
                this.pnlMenu.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlMenu.Controls.Add(fh);
            this.pnlMenu.Tag = fh;
            fh.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PanelHorarios());
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();
            panel7.Hide();
            panel10.Hide();
            panel11.Hide();
            panel13.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PanelAsistencias());
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();
            panel7.Hide();
            panel10.Hide();
            panel11.Hide();
            panel13.Hide();
        }
    }
}