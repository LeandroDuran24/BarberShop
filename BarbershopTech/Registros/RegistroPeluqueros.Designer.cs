﻿namespace BarbershopTech.Registros
{
    partial class RegistroPeluqueros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPeluqueros));
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.PeluqueroidtextBox = new System.Windows.Forms.TextBox();
            this.nombretextBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(235, 115);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(112, 41);
            this.Eliminarbutton.TabIndex = 54;
            this.Eliminarbutton.Text = "ELiminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(105, 115);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(109, 41);
            this.Guardarbutton.TabIndex = 53;
            this.Guardarbutton.Text = "Registrar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // PeluqueroidtextBox
            // 
            this.PeluqueroidtextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PeluqueroidtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeluqueroidtextBox.Location = new System.Drawing.Point(116, 32);
            this.PeluqueroidtextBox.Name = "PeluqueroidtextBox";
            this.PeluqueroidtextBox.Size = new System.Drawing.Size(90, 20);
            this.PeluqueroidtextBox.TabIndex = 52;
            // 
            // nombretextBox3
            // 
            this.nombretextBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nombretextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretextBox3.Location = new System.Drawing.Point(116, 65);
            this.nombretextBox3.Name = "nombretextBox3";
            this.nombretextBox3.Size = new System.Drawing.Size(231, 20);
            this.nombretextBox3.TabIndex = 51;
            this.nombretextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombretextBox3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Peluquero Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroPeluqueros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 224);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.PeluqueroidtextBox);
            this.Controls.Add(this.nombretextBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "RegistroPeluqueros";
            this.Text = "RegistroPeluqueros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.TextBox PeluqueroidtextBox;
        private System.Windows.Forms.TextBox nombretextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}