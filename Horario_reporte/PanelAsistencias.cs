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
    public partial class PanelAsistencias : Form
    {
        public PanelAsistencias()
        {
            InitializeComponent();
        }

        private void txtBuscador_Enter(object sender, EventArgs e)
        {
            if (txtBuscador.Text == "Buscador...")
            {
                txtBuscador.Text = "";
                //txtBuscador.UseSystemPasswordChar = true;
                
            }
        }

        private void txtBuscador_Leave(object sender, EventArgs e)
        {
            if (txtBuscador.Text == "")
            {
                txtBuscador.Text = "Buscador...";
                //txtBuscador.UseSystemPasswordChar = false;
            }
        }
    }
}
