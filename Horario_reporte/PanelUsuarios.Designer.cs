namespace Horario_reporte
{
    partial class PanelUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelUsuarios));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.txtNombre = new UIDC.UI_TextBox();
            this.txtApellido = new UIDC.UI_TextBox();
            this.txtCargo = new UIDC.UI_TextBox();
            this.txtUsuario = new UIDC.UI_TextBox();
            this.txtContra = new UIDC.UI_TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.BTNeliminar = new System.Windows.Forms.Button();
            this.BTNeditar = new System.Windows.Forms.Button();
            this.BTNregistrar = new System.Windows.Forms.Button();
            this.BTNbuscar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BarraTitulo.Controls.Add(this.lbBienvenido);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(800, 45);
            this.BarraTitulo.TabIndex = 33;
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbBienvenido.Location = new System.Drawing.Point(260, 5);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(267, 32);
            this.lbBienvenido.TabIndex = 3;
            this.lbBienvenido.Text = "Control de Usuarios";
            this.lbBienvenido.Click += new System.EventHandler(this.lbBienvenido_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BackgroundColour = System.Drawing.Color.White;
            this.txtNombre.BorderColour = System.Drawing.Color.DarkGreen;
            this.txtNombre.BorderSize = 3;
            this.txtNombre.Location = new System.Drawing.Point(143, 83);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(229, 29);
            this.txtNombre.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded;
            this.txtNombre.TabIndex = 34;
            this.txtNombre.Text = "Nombre...";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TextColour = System.Drawing.Color.DarkGreen;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.BackgroundColour = System.Drawing.Color.White;
            this.txtApellido.BorderColour = System.Drawing.Color.DarkGreen;
            this.txtApellido.BorderSize = 3;
            this.txtApellido.Location = new System.Drawing.Point(144, 118);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = false;
            this.txtApellido.Size = new System.Drawing.Size(229, 29);
            this.txtApellido.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded;
            this.txtApellido.TabIndex = 35;
            this.txtApellido.Text = "Apellido...";
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido.TextColour = System.Drawing.Color.DarkGreen;
            this.txtApellido.UseSystemPasswordChar = false;
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.Transparent;
            this.txtCargo.BackgroundColour = System.Drawing.Color.White;
            this.txtCargo.BorderColour = System.Drawing.Color.DarkGreen;
            this.txtCargo.BorderSize = 3;
            this.txtCargo.Location = new System.Drawing.Point(143, 153);
            this.txtCargo.MaxLength = 32767;
            this.txtCargo.Multiline = false;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = false;
            this.txtCargo.Size = new System.Drawing.Size(229, 29);
            this.txtCargo.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded;
            this.txtCargo.TabIndex = 36;
            this.txtCargo.Text = "Cargo...";
            this.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCargo.TextColour = System.Drawing.Color.DarkGreen;
            this.txtCargo.UseSystemPasswordChar = false;
            this.txtCargo.Enter += new System.EventHandler(this.txtCargo_Enter);
            this.txtCargo.Leave += new System.EventHandler(this.txtCargo_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BackgroundColour = System.Drawing.Color.White;
            this.txtUsuario.BorderColour = System.Drawing.Color.DarkGreen;
            this.txtUsuario.BorderSize = 3;
            this.txtUsuario.Location = new System.Drawing.Point(143, 188);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.Size = new System.Drawing.Size(229, 29);
            this.txtUsuario.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded;
            this.txtUsuario.TabIndex = 37;
            this.txtUsuario.Text = "Usuario...";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TextColour = System.Drawing.Color.DarkGreen;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.Transparent;
            this.txtContra.BackgroundColour = System.Drawing.Color.White;
            this.txtContra.BorderColour = System.Drawing.Color.DarkGreen;
            this.txtContra.BorderSize = 3;
            this.txtContra.Location = new System.Drawing.Point(143, 223);
            this.txtContra.MaxLength = 32767;
            this.txtContra.Multiline = false;
            this.txtContra.Name = "txtContra";
            this.txtContra.ReadOnly = false;
            this.txtContra.Size = new System.Drawing.Size(229, 29);
            this.txtContra.StyleBorder = UIDC.UI_TextBox.Styles.NotBorderRounded;
            this.txtContra.TabIndex = 38;
            this.txtContra.Text = "Contraseña Asignada...";
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContra.TextColour = System.Drawing.Color.DarkGreen;
            this.txtContra.UseSystemPasswordChar = false;
            this.txtContra.Enter += new System.EventHandler(this.txtContra_Enter);
            this.txtContra.Leave += new System.EventHandler(this.txtContra_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(397, 267);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(397, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(397, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(397, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(397, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 40);
            this.button4.TabIndex = 46;
            this.button4.Text = "Exportar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // BTNeliminar
            // 
            this.BTNeliminar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTNeliminar.FlatAppearance.BorderSize = 0;
            this.BTNeliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNeliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNeliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNeliminar.ForeColor = System.Drawing.Color.White;
            this.BTNeliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNeliminar.Location = new System.Drawing.Point(397, 175);
            this.BTNeliminar.Name = "BTNeliminar";
            this.BTNeliminar.Size = new System.Drawing.Size(211, 40);
            this.BTNeliminar.TabIndex = 45;
            this.BTNeliminar.Text = "Eliminar";
            this.BTNeliminar.UseVisualStyleBackColor = false;
            this.BTNeliminar.Click += new System.EventHandler(this.BTNeliminar_Click);
            // 
            // BTNeditar
            // 
            this.BTNeditar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTNeditar.FlatAppearance.BorderSize = 0;
            this.BTNeditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNeditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNeditar.ForeColor = System.Drawing.Color.White;
            this.BTNeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNeditar.Location = new System.Drawing.Point(397, 129);
            this.BTNeditar.Name = "BTNeditar";
            this.BTNeditar.Size = new System.Drawing.Size(211, 40);
            this.BTNeditar.TabIndex = 44;
            this.BTNeditar.Text = "Editar";
            this.BTNeditar.UseVisualStyleBackColor = false;
            this.BTNeditar.Click += new System.EventHandler(this.BTNeditar_Click);
            // 
            // BTNregistrar
            // 
            this.BTNregistrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTNregistrar.FlatAppearance.BorderSize = 0;
            this.BTNregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNregistrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNregistrar.ForeColor = System.Drawing.Color.White;
            this.BTNregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNregistrar.Location = new System.Drawing.Point(397, 83);
            this.BTNregistrar.Name = "BTNregistrar";
            this.BTNregistrar.Size = new System.Drawing.Size(211, 40);
            this.BTNregistrar.TabIndex = 43;
            this.BTNregistrar.Text = "Registrar";
            this.BTNregistrar.UseVisualStyleBackColor = false;
            this.BTNregistrar.Click += new System.EventHandler(this.BTNregistrar_Click);
            // 
            // BTNbuscar
            // 
            this.BTNbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNbuscar.FlatAppearance.BorderSize = 0;
            this.BTNbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BTNbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNbuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNbuscar.ForeColor = System.Drawing.Color.White;
            this.BTNbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNbuscar.Location = new System.Drawing.Point(397, 221);
            this.BTNbuscar.Name = "BTNbuscar";
            this.BTNbuscar.Size = new System.Drawing.Size(211, 40);
            this.BTNbuscar.TabIndex = 51;
            this.BTNbuscar.Text = "Buscar";
            this.BTNbuscar.UseVisualStyleBackColor = false;
            this.BTNbuscar.Click += new System.EventHandler(this.BTNbuscar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(397, 221);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 52;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(143, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 29);
            this.button1.TabIndex = 53;
            this.button1.Text = "Vaciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.BTNbuscar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTNeliminar);
            this.Controls.Add(this.BTNeditar);
            this.Controls.Add(this.BTNregistrar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelUsuarios";
            this.Text = "PanelUsuarios";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lbBienvenido;
        private UIDC.UI_TextBox txtNombre;
        private UIDC.UI_TextBox txtApellido;
        private UIDC.UI_TextBox txtCargo;
        private UIDC.UI_TextBox txtUsuario;
        private UIDC.UI_TextBox txtContra;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTNeliminar;
        private System.Windows.Forms.Button BTNeditar;
        private System.Windows.Forms.Button BTNregistrar;
        private System.Windows.Forms.Button BTNbuscar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
    }
}