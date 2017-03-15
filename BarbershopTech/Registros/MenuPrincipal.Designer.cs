namespace BarbershopTech.Registros
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTurnos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePeluquerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Turnos";
            // 
            // buttonTurnos
            // 
            this.buttonTurnos.BackColor = System.Drawing.Color.Silver;
            this.buttonTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTurnos.ForeColor = System.Drawing.Color.DimGray;
            this.buttonTurnos.Image = ((System.Drawing.Image)(resources.GetObject("buttonTurnos.Image")));
            this.buttonTurnos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTurnos.Location = new System.Drawing.Point(0, 171);
            this.buttonTurnos.Name = "buttonTurnos";
            this.buttonTurnos.Size = new System.Drawing.Size(139, 156);
            this.buttonTurnos.TabIndex = 2;
            this.buttonTurnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTurnos.UseVisualStyleBackColor = false;
            this.buttonTurnos.Click += new System.EventHandler(this.buttonTurnos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuariosToolStripMenuItem,
            this.registroClientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.serviciosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registrarUsuariosToolStripMenuItem
            // 
            this.registrarUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarUsuariosToolStripMenuItem.Image")));
            this.registrarUsuariosToolStripMenuItem.Name = "registrarUsuariosToolStripMenuItem";
            this.registrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.registrarUsuariosToolStripMenuItem.Text = "Usuarios";
            this.registrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuariosToolStripMenuItem_Click);
            // 
            // registroClientesToolStripMenuItem
            // 
            this.registroClientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroClientesToolStripMenuItem.Image")));
            this.registroClientesToolStripMenuItem.Name = "registroClientesToolStripMenuItem";
            this.registroClientesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.registroClientesToolStripMenuItem.Text = "Clientes";
            this.registroClientesToolStripMenuItem.Click += new System.EventHandler(this.registroClientesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.empleadosToolStripMenuItem.Text = "Peluqueros";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUsuariosToolStripMenuItem,
            this.consultaEmpleadosToolStripMenuItem,
            this.consultaDeTurnosToolStripMenuItem,
            this.consultaDePeluquerosToolStripMenuItem,
            this.serviciosToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeUsuariosToolStripMenuItem
            // 
            this.consultaDeUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaDeUsuariosToolStripMenuItem.Image")));
            this.consultaDeUsuariosToolStripMenuItem.Name = "consultaDeUsuariosToolStripMenuItem";
            this.consultaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultaDeUsuariosToolStripMenuItem.Text = "Usuarios";
            this.consultaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUsuariosToolStripMenuItem_Click);
            // 
            // consultaEmpleadosToolStripMenuItem
            // 
            this.consultaEmpleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaEmpleadosToolStripMenuItem.Image")));
            this.consultaEmpleadosToolStripMenuItem.Name = "consultaEmpleadosToolStripMenuItem";
            this.consultaEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultaEmpleadosToolStripMenuItem.Text = "Clientes";
            this.consultaEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.consultaEmpleadosToolStripMenuItem_Click);
            // 
            // consultaDeTurnosToolStripMenuItem
            // 
            this.consultaDeTurnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaDeTurnosToolStripMenuItem.Image")));
            this.consultaDeTurnosToolStripMenuItem.Name = "consultaDeTurnosToolStripMenuItem";
            this.consultaDeTurnosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultaDeTurnosToolStripMenuItem.Text = "Turnos";
            this.consultaDeTurnosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeTurnosToolStripMenuItem_Click);
            // 
            // consultaDePeluquerosToolStripMenuItem
            // 
            this.consultaDePeluquerosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaDePeluquerosToolStripMenuItem.Image")));
            this.consultaDePeluquerosToolStripMenuItem.Name = "consultaDePeluquerosToolStripMenuItem";
            this.consultaDePeluquerosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultaDePeluquerosToolStripMenuItem.Text = "Peluqueros";
            this.consultaDePeluquerosToolStripMenuItem.Click += new System.EventHandler(this.consultaDePeluquerosToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem1
            // 
            this.serviciosToolStripMenuItem1.Name = "serviciosToolStripMenuItem1";
            this.serviciosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.serviciosToolStripMenuItem1.Text = "Servicios";
            this.serviciosToolStripMenuItem1.Click += new System.EventHandler(this.serviciosToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTurnos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTurnos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDePeluquerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}