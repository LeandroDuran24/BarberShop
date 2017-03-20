using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarbershopTech.Consultas;
using BarbershopTech.Reportes;
using Entidades;

namespace BarbershopTech.Registros
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private RegistroClientes cliente = null;
        private RegistroPeluqueros peluquero = null;
        private RegistroServicios servicio = null;
        private RegistroUsuarios usuario = null;
        private RegistroTurnos turno = null;

        private RegistroClientes FormInstanceCliente
        {
            get
            {
                if (cliente == null)
                {
                    cliente = new RegistroClientes();
                    cliente.Disposed += new EventHandler(form_Disposed);
                }

                return cliente;
            }
        }

        private RegistroTurnos FormInstanceTurnos
        {
            get
            {
                if (turno == null)
                {
                    turno = new RegistroTurnos();
                    turno.Disposed += new EventHandler(form_Disposed);
                }

                return turno;
            }
        }

        private RegistroUsuarios FormInstanceUsuarios
        {
            get
            {
                if (usuario == null)
                {
                    usuario = new RegistroUsuarios();
                    usuario.Disposed += new EventHandler(form_Disposed);
                }

                return usuario;
            }
        }

        private RegistroServicios FormInstanceServicio
        {
            get
            {
                if (servicio == null)
                {
                    servicio = new RegistroServicios();
                    servicio.Disposed += new EventHandler(form_Disposed);
                }

                return servicio;
            }
        }

        private RegistroPeluqueros FormInstancePeluquero
        {
            get
            {
                if (peluquero == null)
                {
                    peluquero = new RegistroPeluqueros();
                    peluquero.Disposed += new EventHandler(form_Disposed);
                }

                return peluquero;
            }
        }

        void form_Disposed(object sender, EventArgs e)
        {
            cliente = null;
            peluquero = null;
            servicio = null;
            usuario = null;
            turno = null;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuarios r = this.FormInstanceUsuarios;
            r.Show();
            r.BringToFront();

        }

        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes r = this.FormInstanceCliente;
            r.Show();
            r.BringToFront();

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPeluqueros r = this.FormInstancePeluquero;
            r.Show();
            r.BringToFront();

        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroServicios r = this.FormInstanceServicio;
            r.Show();
            r.BringToFront();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroTurnos r = this.FormInstanceTurnos;
            r.Show();
            r.BringToFront();
        }

        //falta esta parte por la instancia de la ventana
        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios c = new ConsultaUsuarios();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroFactura r = new RegistroFactura();
            r.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFactura cf = new ConsultaFactura();
            cf.Show();
        }

        private void cambiarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log l = new Log();
            l.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteFactura rf = new ReporteFactura();
            rf.Show();
        }
    }
}
