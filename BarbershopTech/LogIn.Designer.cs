namespace BarbershopTech
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.ContraseñamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.Button();
            this.entrar = new System.Windows.Forms.Button();
            this.contrasena = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContraseñamaskedTextBox
            // 
            this.ContraseñamaskedTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContraseñamaskedTextBox.Location = new System.Drawing.Point(237, 168);
            this.ContraseñamaskedTextBox.Name = "ContraseñamaskedTextBox";
            this.ContraseñamaskedTextBox.PasswordChar = '*';
            this.ContraseñamaskedTextBox.Size = new System.Drawing.Size(272, 20);
            this.ContraseñamaskedTextBox.TabIndex = 1418;
            this.ContraseñamaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseñamaskedTextBox_KeyPress);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NombretextBox.Location = new System.Drawing.Point(237, 87);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(272, 20);
            this.NombretextBox.TabIndex = 1417;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salir.Location = new System.Drawing.Point(403, 236);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 29);
            this.salir.TabIndex = 1420;
            this.salir.Text = "Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.Transparent;
            this.entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Image = ((System.Drawing.Image)(resources.GetObject("entrar.Image")));
            this.entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entrar.Location = new System.Drawing.Point(273, 236);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(80, 29);
            this.entrar.TabIndex = 1419;
            this.entrar.Text = "Entrar";
            this.entrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.BackColor = System.Drawing.Color.Transparent;
            this.contrasena.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena.Location = new System.Drawing.Point(345, 147);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(79, 18);
            this.contrasena.TabIndex = 1423;
            this.contrasena.Text = "Contraseña";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(345, 66);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(58, 18);
            this.nombre.TabIndex = 1422;
            this.nombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 211);
            this.pictureBox1.TabIndex = 1421;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 21);
            this.label1.TabIndex = 1424;
            this.label1.Text = "Inicio de Sesion";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 345);
            this.Controls.Add(this.ContraseñamaskedTextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "LogIn";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ContraseñamaskedTextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

