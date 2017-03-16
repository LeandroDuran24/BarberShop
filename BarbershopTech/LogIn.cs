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

        public void Limpiar()
        {
            NombretextBox.Clear();
            ContraseñamaskedTextBox.Clear();
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

            if (!Validar())
            {
                MessageBox.Show("Favor Llenar");
            }
            else
            {
                string username = NombretextBox.Text;
                string clave = ContraseñamaskedTextBox.Text;

                using (BarberShopDb db = new BarberShopDb())
                {
                    var user = (from u in db.usuario where u.Nombres == username select u.Nombres).FirstOrDefault();
                    var passw = (from u in db.usuario where u.Contrasena == clave select u.Contrasena).FirstOrDefault();

                    if (user == username || passw == clave)
                    {
                        MenuPrincipal mp = new MenuPrincipal();
                        mp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Los datos estan incompletos");
                        
                    }
                    Limpiar();
                }
            }
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
