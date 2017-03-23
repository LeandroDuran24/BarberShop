using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarbershopTech.Registros;
using DAL;
using Entidades;

namespace BarbershopTech
{
    public partial class Log : Form
    {
        private static Usuarios usuarioLabel = null;

        public Log()
        {
            InitializeComponent();

        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Favor llenar");
                return false;
            }

            if (string.IsNullOrEmpty(ContraseñamaskedTextBox.Text))
            {
                errorProvider1.SetError(ContraseñamaskedTextBox, "Favor llenar");
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            NombretextBox.Clear();
            ContraseñamaskedTextBox.Clear();
            errorProvider1.Clear();

        }

        public static Usuarios Label()
        {
            return usuarioLabel;
        }

        private void Log_Load(object sender, EventArgs e)
        {

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

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrar_Click(object sender, EventArgs e)
        {

            Usuarios usuario = null;
            usuario = BLL.UsuarioBLL.Buscar(p => p.Email == NombretextBox.Text);
            usuarioLabel = usuario;

            if (!Validar())
            {
                MessageBox.Show("Favor Llenar");
            }
            else
            {
                if (usuario != null)
                {
                    if (usuario.Contrasena == ContraseñamaskedTextBox.Text)
                    {
                        MenuPrincipal menu = new MenuPrincipal();

                        menu.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("La Clave no Coincide con el Email");
                        Limpiar();
                        NombretextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("No existe ese Usuario");
                    Limpiar();
                    NombretextBox.Focus();
                }
            }
        }

        private void salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void ContraseñamaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);

           
            if (e.KeyChar == (char)Keys.Enter)
            {
                Usuarios usuario = null;
                usuario = BLL.UsuarioBLL.Buscar(p => p.Email == NombretextBox.Text);
                usuarioLabel = usuario;

                if (!Validar())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    if (usuario != null)
                    {
                        if (usuario.Contrasena == ContraseñamaskedTextBox.Text)
                        {
                            MenuPrincipal menu = new MenuPrincipal();

                            menu.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("La Clave no Coincide con el Email");
                            Limpiar();
                            NombretextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe ese Usuario");
                        Limpiar();
                        NombretextBox.Focus();
                    }
                }
            }
        }


    }
}
