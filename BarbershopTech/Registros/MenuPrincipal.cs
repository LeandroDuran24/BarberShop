using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarbershopTech.Consultas;

namespace BarbershopTech.Registros
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           /* Bitmap img = new Bitmap(System.Windows.Forms.Application.StartupPath + @"\Img\menu.jpg");
            this.BackgroundImage = img;
            BackgroundImageLayout = ImageLayout.Stretch;*/
        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuarios r = new RegistroUsuarios();
            r.Show();
        }

        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes r = new RegistroClientes();
            r.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPeluqueros r = new RegistroPeluqueros();
            r.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroServicios r = new RegistroServicios();
            r.Show();
        }

        private void buttonTurnos_Click(object sender, EventArgs e)
        {
            RegistroTurnos r = new RegistroTurnos();
            r.Show();
        }

        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes c = new ConsultaClientes();
            c.Show();
        }

        private void consultaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes c = new ConsultaClientes();
            c.Show();
        }

        private void consultaDeTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTurnos c = new ConsultaTurnos();
            c.Show();
        }

        private void consultaDePeluquerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPeluqueros c = new ConsultaPeluqueros();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaServicios c = new ConsultaServicios();
            c.Show();
        }
    }
}
