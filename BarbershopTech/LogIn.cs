using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarbershopTech.Registros;

namespace BarbershopTech
{
    public partial class LogIn : Form
    {
        public LogIn()
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
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Hide();
        }

        private void NombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void ContraseñamaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }
    }
}
