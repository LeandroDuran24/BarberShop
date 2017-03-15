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
    public partial class RegistroTurnos : Form
    {
        public RegistroTurnos()
        {
            InitializeComponent();
            LlenarComboNombre();
            LlenarComboPeluquero();
            LlenarComboServicio();
            Limpiar();
        }

        public void Limpiar()
        {
            NombrecomboBox.Text = "";
            PeluquerocomboBox.Text = "";


        }

        public void LlenarComboNombre()
        {
            List<Entidades.Clientes> lista = BLL.ClienteBLL.GetListTodo();
            NombrecomboBox.DataSource = lista;
            NombrecomboBox.DisplayMember = "Nombres";
            NombrecomboBox.ValueMember = "ClienteId";

            if (NombrecomboBox.Items.Count >= 1)
            {
                NombrecomboBox.SelectedIndex = -1;
            }


        }

        public void LlenarComboPeluquero()
        {
            List<Entidades.Peluqueros> lista = BLL.PeluqueroBLL.GetListTodo();
            PeluquerocomboBox.DataSource = lista;
            PeluquerocomboBox.DisplayMember = "Nombre";
            PeluquerocomboBox.ValueMember = "PeluqueroId";

            if (PeluquerocomboBox.Items.Count >= 1)
            {
                PeluquerocomboBox.SelectedIndex = -1;
            }
        }

        public void LlenarComboServicio()
        {
            List<TipoServicios> lista = BLL.TipoServicioBLL.GetListTodo();
            PeluquerocomboBox.DataSource = lista;
            PeluquerocomboBox.DisplayMember = "Nombre";
            PeluquerocomboBox.ValueMember = "ServicioId";

            if (comboBoxServicio.Items.Count >= 1)
            {
                comboBoxServicio.SelectedIndex = -1;
            }
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

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Turnos turno = new Turnos();
            turno.NombreCliente = NombrecomboBox.Text;
            turno.ClienteId = Utilidades.TOINT(NombrecomboBox.SelectedValue.ToString());
            turno.NombrePeluquero = PeluquerocomboBox.Text;
            turno.PeluqueroId = Utilidades.TOINT(PeluquerocomboBox.SelectedValue.ToString());

            if (BLL.TurnoBLL.Guardar(turno))
                MessageBox.Show("Se guardo");
            else
                MessageBox.Show("No se guardo");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
