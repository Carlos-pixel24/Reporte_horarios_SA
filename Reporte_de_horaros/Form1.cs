namespace Reporte_de_horaros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
    }
}