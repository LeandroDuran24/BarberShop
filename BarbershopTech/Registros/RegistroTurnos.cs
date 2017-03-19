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
            Limpiar();
        }

        public void Limpiar()
        {
            NombrecomboBox.Text = null;
            PeluquerocomboBox.Text = null;
            dateTimePickerDesde.Value = DateTime.Today;
            dateTimePickerHasta.Value = DateTime.Today;
            IdtextBox.Clear();


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

        public bool Validar()
        {
            if(string.IsNullOrEmpty(NombrecomboBox.Text))
            {
                errorProvider1.SetError(NombrecomboBox, "Favor Llenar");
                return false;
            }


            if (string.IsNullOrEmpty(PeluquerocomboBox.Text))
            {
                errorProvider1.SetError(PeluquerocomboBox, "Favor Llenar");
                return false;
            }

            if (string.IsNullOrEmpty(dateTimePickerHasta.Text))
            {
                errorProvider1.SetError(dateTimePickerHasta, "Favor Llenar");
                return false;
            }
            return true;
        }

        public Turnos LlenarCampos()
        {
            Turnos turno = new Turnos();
            turno.ClienteId = Utilidades.TOINT(NombrecomboBox.SelectedValue.ToString());
            turno.PeluqueroId = Utilidades.TOINT(PeluquerocomboBox.SelectedValue.ToString());
            turno.NombreCliente = NombrecomboBox.Text;
            turno.NombrePeluquero = PeluquerocomboBox.Text;
            turno.FechaDesde = dateTimePickerDesde.Value;
            turno.FechaHasta = dateTimePickerHasta.Value;
            turno.PeluqueroId = Utilidades.TOINT(PeluquerocomboBox.SelectedValue.ToString());
            return turno;
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

            if(!Validar())
            {
                MessageBox.Show("Favor Llenar");

            }
            else
            {
                Turnos turno = new Turnos();
                turno = LlenarCampos();
                BLL.TurnoBLL.Guardar(turno);
                    MessageBox.Show("Se guardo");
            }
            Limpiar();

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdtextBox.Text);
            Turnos conn = BLL.TurnoBLL.Buscar((p => p.TurnosId == id));

            if (conn != null)
            {
                BLL.TurnoBLL.Eliminar(conn);
                MessageBox.Show("Se ha eliminado Correctamente");
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IdtextBox.Text);
            Turnos conn = BLL.TurnoBLL.Buscar((p => p.TurnosId == id));

            if (conn != null)
            {
                NombrecomboBox.Text = conn.NombreCliente;
                PeluquerocomboBox.Text = conn.NombrePeluquero;
                MessageBox.Show("Se ha encontrado Correctamente");
            }
            else
            {
                MessageBox.Show("No se ha Eliminado");

            }
            Limpiar();
        }

        private void NombrecomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PeluquerocomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        
    }
}
