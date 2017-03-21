using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace BarbershopTech.UI.Registros
{
    public partial class RegistroProductos : Form
    {
        public RegistroProductos()
        {
            InitializeComponent();
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

        public void Limpiar()
        {
            textBoxNombre.Clear();
            textBoxId.Clear();
            textBoxCompra.Clear();
            textBoxVenta.Clear();
            textBoxDesc.Clear();
            textBoxCant.Clear();
            errorProvider1.Clear();
        }

        public bool Validar()
        {
            if(string.IsNullOrEmpty(textBoxNombre.Text))
            {
                errorProvider1.SetError(textBoxNombre, "Favor Llenar");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxDesc.Text))
            {
                errorProvider1.SetError(textBoxDesc, "Favor Llenar");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxCompra.Text))
            {
                errorProvider1.SetError(textBoxCompra, "Favor Llenar");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxVenta.Text))
            {
                errorProvider1.SetError(textBoxVenta, "Favor Llenar");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxCant.Text))
            {
                errorProvider1.SetError(textBoxCant, "Favor Llenar");
                return false;
            }

            return true;
        }

        public Productos LlenarCampos()
        {
            Productos producto = new Productos();
            producto.ProductoId=Utilidades.TOINT(textBoxId.Text);
            producto.Nombre = textBoxNombre.Text;
            producto.Descripcion = textBoxDesc.Text;
            producto.PrecioCompra = Utilidades.TOINT(textBoxCompra.Text);
            producto.PrecioVenta = Utilidades.TOINT(textBoxVenta.Text);
            producto.Cantidad = Utilidades.TOINT(textBoxCant.Text);
            return producto;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            int id = 0;
            if(!Validar())
            {
                MessageBox.Show("Favor Llenar");
            }
            else
            {
                productos = LlenarCampos();
                if (id != productos.ProductoId)
                {
                    BLL.ProductoBLL.Mofidicar(productos);
                    MessageBox.Show("Se ha modificado");
                }
                else
                {
                    BLL.ProductoBLL.Guardar(productos);
                    MessageBox.Show("Se ha Guardado Correctamente...");
                }

                
            }
            Limpiar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            Productos producto = BLL.ProductoBLL.Buscar((p => p.ProductoId == id));

            if (producto != null)
            {
                textBoxNombre.Text = producto.Nombre;
                textBoxDesc.Text = producto.Descripcion;
                textBoxCompra.Text = Convert.ToString(producto.PrecioCompra);
                textBoxVenta.Text = Convert.ToString(producto.PrecioVenta);
                textBoxCant.Text = Convert.ToString(producto.Cantidad);
              
                MessageBox.Show("Se ha encontrado Correctamente");
            }
            else
            {
                MessageBox.Show("No existe");

            }
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            Productos producto = BLL.ProductoBLL.Buscar((p => p.ProductoId == id));

            if (producto != null)
            {
                BLL.ProductoBLL.Eliminar(producto);
                MessageBox.Show("Se ha encontrado Correctamente");
            }
            else
            {
                MessageBox.Show("No existe");

            }
            Limpiar();
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void textBoxDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);

        }

        private void textBoxCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void textBoxVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void textBoxCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }
    }
}
