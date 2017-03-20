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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(nombretextBox.Text))
            {
                errorProvider1.SetError(nombretextBox, "Favor de LLenar");
                return false;
            }
            if (string.IsNullOrEmpty(apellidotextBox.Text))
            {
                errorProvider1.SetError(apellidotextBox, "Favor de LLenar");
                return false;
            }


            return true;
        }

        public void Limpiar()
        {
            nombretextBox.Clear();
            direcciontextBox1.Clear();
            apellidotextBox.Clear();
            IdtextBox.Clear();
            cedmaskedTextBox.Clear();
            FechadateTimePicker1.Value = DateTime.Today;
            emailextBox.Clear();

        }

        public Clientes LlenarCampos()
        {
            Clientes guardado = new Clientes();
            guardado.ClienteId = Utilidades.TOINT(IdtextBox.Text);
            guardado.Nombres = nombretextBox.Text;
            guardado.Apellidos = apellidotextBox.Text;
            guardado.Direccion = direcciontextBox1.Text;
            guardado.Email = emailextBox.Text;
            guardado.Cedula = cedmaskedTextBox.Text;
            guardado.Fecha = FechadateTimePicker1.Value;
            return guardado;
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
            int id = int.Parse(IdtextBox.Text);
            Clientes conn = BLL.ClienteBLL.Buscar((p => p.ClienteId == id));

            if (conn != null)
            {
                BLL.ClienteBLL.Eliminar(conn);
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
            var guardado = new Clientes();
            int id = 0;

            if (!Validar())
            {

                MessageBox.Show("Ha Ocurrido Error...");
            }
            else
            {
            
                guardado = LlenarCampos();
                if (id != guardado.ClienteId)
                {
                    BLL.ClienteBLL.Mofidicar(guardado);
                    MessageBox.Show("Se ha modificado");
                }
                else
                {
                    BLL.ClienteBLL.Guardar(guardado);
                    MessageBox.Show("Se ha Guardado Correctamente...");
                }

                Limpiar();
            }
        }   
        
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdtextBox.Text);
            Clientes conn = BLL.ClienteBLL.Buscar((p => p.ClienteId == id));

            if (conn != null)
            {
                nombretextBox.Text = conn.Nombres;
                direcciontextBox1.Text = conn.Direccion;
                apellidotextBox.Text = conn.Apellidos;
                emailextBox.Text = conn.Email;
                cedmaskedTextBox.Text = conn.Cedula;
                FechadateTimePicker1.Value = conn.Fecha;

                MessageBox.Show("Se ha encontrado Correctamente");
            }
            else
            {
                MessageBox.Show("No se ha Eliminado");

            }
            Limpiar();
        }
        
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void nombretextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void apellidotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void direcciontextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

       
    }
}
