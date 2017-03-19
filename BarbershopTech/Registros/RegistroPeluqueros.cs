using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace BarbershopTech.Registros
{
    public partial class RegistroPeluqueros : Form
    {
        public RegistroPeluqueros()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(nombretextBox3.Text))
            {
                errorProvider1.SetError(nombretextBox3, "Favor de LLenar");
                return false;
            }

            return true;
        }

        public void Limpiar()
        {
            nombretextBox3.Clear();

        }

        public static void ValidarNumero(KeyPressEventArgs pE)

        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
                if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;

            }
            else
            {
                pE.Handled = true;
            }
        }

        public static void ValidarLetras(KeyPressEventArgs pE)
        {
            if (char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
               if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;

            }
            else
                if (char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(PeluqueroidtextBox.Text);
            Peluqueros conn = BLL.PeluqueroBLL.Buscar((p => p.PeluqueroId == id));

            if (conn != null)
            {
                BLL.PeluqueroBLL.Eliminar(conn);
                MessageBox.Show("Se ha eliminado Correctamente");
            }
            else
            {
                MessageBox.Show("No se ha Eliminado");

            }
            Limpiar();

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Peluqueros guardar = new Peluqueros();
            int id = 0;

            if (!Validar())
            {

                MessageBox.Show("Ha Ocurrido Error...");
            }
            else
            {

                guardar.PeluqueroId = Utilidades.TOINT(PeluqueroidtextBox.Text);
                guardar.Nombre = nombretextBox3.Text;

                if (id != guardar.PeluqueroId)
                {
                    BLL.PeluqueroBLL.Mofidicar(guardar);
                    MessageBox.Show("Se ha modificado");
                }
                else
                {
                    BLL.PeluqueroBLL.Guardar(guardar);
                    MessageBox.Show("Se ha Guardado Correctamente...");
                }

                Limpiar();
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(PeluqueroidtextBox.Text);
            Peluqueros conn = BLL.PeluqueroBLL.Buscar((p => p.PeluqueroId == id));

            if (conn != null)
            {
                nombretextBox3.Text = conn.Nombre;
                MessageBox.Show("Se ha encontrado Correctamente");
            }
            else
            {
                MessageBox.Show("No se ha Eliminado");

            }
            Limpiar();

        }

        private void nombretextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void RegistroPeluqueros_Load(object sender, EventArgs e)
        {

        }
    }
}
