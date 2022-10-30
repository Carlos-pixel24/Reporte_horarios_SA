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
    public partial class Ventana_Horario : Form
    {
        public Ventana_Horario()
        {
            InitializeComponent();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true) 
            {
                this.Width =378;
            }
            else
                this.Width = 204;
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.Width = 550;
            }
            else
                this.Width = 378;
        }
    }
}
