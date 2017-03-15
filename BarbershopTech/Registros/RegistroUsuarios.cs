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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(EmailtextBox.Text))
            {
                errorProvider1.SetError(EmailtextBox, "Favor de LLenar");
                return false;
            }
            if (string.IsNullOrEmpty(ContraseñamaskedTextBox.Text))
            {
                errorProvider1.SetError(ContraseñamaskedTextBox, "Favor de LLenar");
                return false;
            }

            if (string.IsNullOrEmpty(ConfirmarmaskedTextBox.Text))
            {
                errorProvider1.SetError(ConfirmarmaskedTextBox, "Favor Llenar");
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            NombretextBox.Clear();
            EmailtextBox.Clear();
            ContraseñamaskedTextBox.Clear();
            ConfirmarmaskedTextBox.Clear();
            textBoxId.Clear();

        }

        public Usuarios LlenarCampos()
        {
            Usuarios guardar = new Usuarios();
            guardar.UsuarioId = Utilidades.TOINT(textBoxId.Text);
            guardar.Nombres = NombretextBox.Text;
            guardar.Email = EmailtextBox.Text;
            guardar.Contrasena = Convert.ToString(ContraseñamaskedTextBox.Text);
            guardar.Confirmar = Convert.ToString(ConfirmarmaskedTextBox.Text);
            return guardar;

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

        private void Eliminarbutton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);

            Usuarios eliminar = BLL.UsuarioBLL.Buscar(p => p.UsuarioId == id);

            if (eliminar != null)
            {
                BLL.UsuarioBLL.Eliminar(eliminar);
                MessageBox.Show("Correcto");

            }
            else

                MessageBox.Show("Error");
            Limpiar();
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            Usuarios guardar = new Usuarios();
            int id = 0;

            if (!Validar())
            {

                MessageBox.Show("Ha Ocurrido Error...");
            }
            else
            {

                guardar = LlenarCampos();
                if (id != guardar.UsuarioId)
                {
                    BLL.UsuarioBLL.Mofidicar(guardar);
                    MessageBox.Show("Se ha Modificado");
                }
                else
                {
                    if (ContraseñamaskedTextBox.Text != ConfirmarmaskedTextBox.Text)
                    {
                        ConfirmarmaskedTextBox.Clear();
                        MessageBox.Show("No coinciden las Clave");

                    }
                    else
                    {
                        BLL.UsuarioBLL.Guardar(guardar);
                        MessageBox.Show("Se ha Guardado Correctamente..."); ;
                    }
                }
                Limpiar();

            }
        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {

            int id = int.Parse(textBoxId.Text);
            Usuarios usuario = BLL.UsuarioBLL.Buscar(p => p.UsuarioId == id);

            if (usuario != null)
            {
                EmailtextBox.Text = usuario.Email;
                NombretextBox.Text = usuario.Nombres;
                ContraseñamaskedTextBox.Text = Convert.ToString(usuario.Contrasena);
                ConfirmarmaskedTextBox.Text = Convert.ToString(usuario.Confirmar);
                MessageBox.Show("Se ha encontrado correctamente");
            }
            else
            {
                MessageBox.Show("No existe ese usuario");
            }
            Limpiar();
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void EmailtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void ContraseñamaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void ConfirmarmaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }
    }
}
