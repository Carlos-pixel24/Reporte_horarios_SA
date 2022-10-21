namespace Horario_reporte
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pVerde = new System.Windows.Forms.Panel();
            this.pBlanco = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pbLineuser = new System.Windows.Forms.PictureBox();
            this.pbLinepass = new System.Windows.Forms.PictureBox();
            this.pcUser = new System.Windows.Forms.PictureBox();
            this.pcPass = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbFocus = new System.Windows.Forms.Label();
            this.pVerde.SuspendLayout();
            this.pBlanco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinepass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPass)).BeginInit();
            this.SuspendLayout();
            // 
            // pVerde
            // 
            this.pVerde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pVerde.BackgroundImage")));
            this.pVerde.Controls.Add(this.pbLogo);
            this.pVerde.Dock = System.Windows.Forms.DockStyle.Left;
            this.pVerde.Location = new System.Drawing.Point(0, 0);
            this.pVerde.Name = "pVerde";
            this.pVerde.Size = new System.Drawing.Size(183, 316);
            this.pVerde.TabIndex = 0;
            // 
            // pBlanco
            // 
            this.pBlanco.Controls.Add(this.button1);
            this.pBlanco.Controls.Add(this.pcPass);
            this.pBlanco.Controls.Add(this.pcUser);
            this.pBlanco.Controls.Add(this.pbLinepass);
            this.pBlanco.Controls.Add(this.pbLineuser);
            this.pBlanco.Controls.Add(this.txtPass);
            this.pBlanco.Controls.Add(this.txtUser);
            this.pBlanco.Controls.Add(this.lbBienvenido);
            this.pBlanco.Controls.Add(this.pbMinimizar);
            this.pBlanco.Controls.Add(this.pbCerrar);
            this.pBlanco.Controls.Add(this.lbFocus);
            this.pBlanco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBlanco.Location = new System.Drawing.Point(183, 0);
            this.pBlanco.Name = "pBlanco";
            this.pBlanco.Size = new System.Drawing.Size(530, 316);
            this.pBlanco.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 98);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(149, 116);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(505, 3);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(22, 22);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 0;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(473, 3);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(22, 22);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 1;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbBienvenido.Location = new System.Drawing.Point(193, 21);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(161, 32);
            this.lbBienvenido.TabIndex = 2;
            this.lbBienvenido.Text = "Bienvenid@";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtUser.ForeColor = System.Drawing.Color.OliveDrab;
            this.txtUser.Location = new System.Drawing.Point(113, 94);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(311, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtPass.ForeColor = System.Drawing.Color.OliveDrab;
            this.txtPass.Location = new System.Drawing.Point(113, 147);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(311, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // pbLineuser
            // 
            this.pbLineuser.Image = ((System.Drawing.Image)(resources.GetObject("pbLineuser.Image")));
            this.pbLineuser.Location = new System.Drawing.Point(113, 120);
            this.pbLineuser.Name = "pbLineuser";
            this.pbLineuser.Size = new System.Drawing.Size(308, 2);
            this.pbLineuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLineuser.TabIndex = 5;
            this.pbLineuser.TabStop = false;
            // 
            // pbLinepass
            // 
            this.pbLinepass.Image = ((System.Drawing.Image)(resources.GetObject("pbLinepass.Image")));
            this.pbLinepass.Location = new System.Drawing.Point(113, 173);
            this.pbLinepass.Name = "pbLinepass";
            this.pbLinepass.Size = new System.Drawing.Size(308, 2);
            this.pbLinepass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLinepass.TabIndex = 6;
            this.pbLinepass.TabStop = false;
            // 
            // pcUser
            // 
            this.pcUser.Image = ((System.Drawing.Image)(resources.GetObject("pcUser.Image")));
            this.pcUser.Location = new System.Drawing.Point(77, 92);
            this.pcUser.Name = "pcUser";
            this.pcUser.Size = new System.Drawing.Size(30, 30);
            this.pcUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcUser.TabIndex = 7;
            this.pcUser.TabStop = false;
            // 
            // pcPass
            // 
            this.pcPass.Image = ((System.Drawing.Image)(resources.GetObject("pcPass.Image")));
            this.pcPass.Location = new System.Drawing.Point(77, 145);
            this.pcPass.Name = "pcPass";
            this.pcPass.Size = new System.Drawing.Size(30, 30);
            this.pcPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcPass.TabIndex = 8;
            this.pcPass.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(78)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(165)))), ((int)(((byte)(133)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(221, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "ACCEDER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbFocus
            // 
            this.lbFocus.AutoSize = true;
            this.lbFocus.Location = new System.Drawing.Point(7, 4);
            this.lbFocus.Name = "lbFocus";
            this.lbFocus.Size = new System.Drawing.Size(0, 13);
            this.lbFocus.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 316);
            this.Controls.Add(this.pBlanco);
            this.Controls.Add(this.pVerde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.pVerde.ResumeLayout(false);
            this.pBlanco.ResumeLayout(false);
            this.pBlanco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinepass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pVerde;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pBlanco;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcPass;
        private System.Windows.Forms.PictureBox pcUser;
        private System.Windows.Forms.PictureBox pbLinepass;
        private System.Windows.Forms.PictureBox pbLineuser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.Label lbFocus;
    }
}

