namespace BarbershopTech
{
    partial class Log
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.ContraseñamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.entrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ContraseñamaskedTextBox
            // 
            this.ContraseñamaskedTextBox.BackColor = System.Drawing.Color.DimGray;
            this.ContraseñamaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContraseñamaskedTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContraseñamaskedTextBox.ForeColor = System.Drawing.Color.White;
            this.ContraseñamaskedTextBox.Location = new System.Drawing.Point(108, 171);
            this.ContraseñamaskedTextBox.Name = "ContraseñamaskedTextBox";
            this.ContraseñamaskedTextBox.PasswordChar = '☯';
            this.ContraseñamaskedTextBox.Size = new System.Drawing.Size(272, 20);
            this.ContraseñamaskedTextBox.TabIndex = 1426;
            this.ContraseñamaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseñamaskedTextBox_KeyPress);
            // 
            // NombretextBox
            // 
            this.NombretextBox.BackColor = System.Drawing.Color.DimGray;
            this.NombretextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombretextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NombretextBox.ForeColor = System.Drawing.Color.White;
            this.NombretextBox.Location = new System.Drawing.Point(108, 90);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(272, 20);
            this.NombretextBox.TabIndex = 1425;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.BackColor = System.Drawing.Color.Transparent;
            this.contrasena.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena.Location = new System.Drawing.Point(216, 150);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(79, 18);
            this.contrasena.TabIndex = 1431;
            this.contrasena.Text = "Contraseña";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(216, 69);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(48, 18);
            this.nombre.TabIndex = 1430;
            this.nombre.Text = "Email";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salir.Location = new System.Drawing.Point(262, 233);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 29);
            this.salir.TabIndex = 1428;
            this.salir.Text = "Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click_1);
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.Transparent;
            this.entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Image = ((System.Drawing.Image)(resources.GetObject("entrar.Image")));
            this.entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entrar.Location = new System.Drawing.Point(142, 233);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(87, 29);
            this.entrar.TabIndex = 1427;
            this.entrar.Text = "Entrar";
            this.entrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 69);
            this.pictureBox1.TabIndex = 1429;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 57);
            this.pictureBox2.TabIndex = 1433;
            this.pictureBox2.TabStop = false;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BarbershopTech.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 352);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ContraseñamaskedTextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ContraseñamaskedTextBox;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox NombretextBox;
      //  private UI.Reportes.DataSetBarberShopTableAdapters.ClientesTableAdapter clientesTableAdapter1;
    }
}