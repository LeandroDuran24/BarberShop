﻿namespace BarbershopTech.Registros
{
    partial class RegistroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarios));
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Eliminarbutton1 = new System.Windows.Forms.Button();
            this.ConfirmarmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ContraseñamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Registrarbutton = new System.Windows.Forms.Button();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscarbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton1.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton1.Image")));
            this.Buscarbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton1.Location = new System.Drawing.Point(308, 17);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(102, 35);
            this.Buscarbutton1.TabIndex = 33;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            this.Buscarbutton1.Click += new System.EventHandler(this.Buscarbutton1_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(179, 23);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(119, 20);
            this.textBoxId.TabIndex = 32;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "UsuarioId";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombretextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NombretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombretextBox.Location = new System.Drawing.Point(179, 62);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(231, 20);
            this.NombretextBox.TabIndex = 26;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nombre";
            // 
            // Eliminarbutton1
            // 
            this.Eliminarbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Eliminarbutton1.BackColor = System.Drawing.Color.Transparent;
            this.Eliminarbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eliminarbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton1.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton1.Image")));
            this.Eliminarbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton1.Location = new System.Drawing.Point(308, 271);
            this.Eliminarbutton1.Name = "Eliminarbutton1";
            this.Eliminarbutton1.Size = new System.Drawing.Size(102, 35);
            this.Eliminarbutton1.TabIndex = 31;
            this.Eliminarbutton1.Text = "Eliminar";
            this.Eliminarbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton1.UseVisualStyleBackColor = false;
            this.Eliminarbutton1.Click += new System.EventHandler(this.Eliminarbutton1_Click);
            // 
            // ConfirmarmaskedTextBox
            // 
            this.ConfirmarmaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmarmaskedTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmarmaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarmaskedTextBox.Location = new System.Drawing.Point(179, 197);
            this.ConfirmarmaskedTextBox.Name = "ConfirmarmaskedTextBox";
            this.ConfirmarmaskedTextBox.PasswordChar = '*';
            this.ConfirmarmaskedTextBox.Size = new System.Drawing.Size(231, 20);
            this.ConfirmarmaskedTextBox.TabIndex = 29;
            this.ConfirmarmaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmarmaskedTextBox_KeyPress);
            // 
            // ContraseñamaskedTextBox
            // 
            this.ContraseñamaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContraseñamaskedTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContraseñamaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñamaskedTextBox.Location = new System.Drawing.Point(179, 153);
            this.ContraseñamaskedTextBox.Name = "ContraseñamaskedTextBox";
            this.ContraseñamaskedTextBox.PasswordChar = '*';
            this.ContraseñamaskedTextBox.Size = new System.Drawing.Size(231, 20);
            this.ContraseñamaskedTextBox.TabIndex = 28;
            this.ContraseñamaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseñamaskedTextBox_KeyPress);
            // 
            // Registrarbutton
            // 
            this.Registrarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Registrarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Registrarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrarbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Registrarbutton.Image")));
            this.Registrarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registrarbutton.Location = new System.Drawing.Point(179, 271);
            this.Registrarbutton.Name = "Registrarbutton";
            this.Registrarbutton.Size = new System.Drawing.Size(102, 35);
            this.Registrarbutton.TabIndex = 30;
            this.Registrarbutton.Text = "Registrar";
            this.Registrarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Registrarbutton.UseVisualStyleBackColor = false;
            this.Registrarbutton.Click += new System.EventHandler(this.Registrarbutton_Click);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailtextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailtextBox.Location = new System.Drawing.Point(179, 104);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(231, 20);
            this.EmailtextBox.TabIndex = 27;
            this.EmailtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailtextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Confirmar contraseña";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 378);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Eliminarbutton1);
            this.Controls.Add(this.ConfirmarmaskedTextBox);
            this.Controls.Add(this.ContraseñamaskedTextBox);
            this.Controls.Add(this.Registrarbutton);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RegistroUsuarios";
            this.Text = "RegistroUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Eliminarbutton1;
        private System.Windows.Forms.MaskedTextBox ConfirmarmaskedTextBox;
        private System.Windows.Forms.MaskedTextBox ContraseñamaskedTextBox;
        private System.Windows.Forms.Button Registrarbutton;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}