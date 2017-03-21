using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarbershopTech.Consultas
{
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
            LLenarCombo();
        }

        public void LLenarCombo()
        {
            comboBox1.Items.Insert(0, "Todos");
            comboBox1.Items.Insert(1, "ClienteId");
            comboBox1.Items.Insert(2, "Nombre");
            comboBox1.Items.Insert(3, "Apellidos");
            comboBox1.Items.Insert(4, "Direccion");
            comboBox1.Items.Insert(5, "Cedula");
            comboBox1.Items.Insert(6, "Fecha");
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Todos";

            if (comboBox1.Items.Count >= 1)
            {
                comboBox1.SelectedIndex = -1;
            }


        }

        public bool ValidarTextBox()
        {
            if (string.IsNullOrEmpty(BuscartextBox.Text))
            {
                errorProvider1.SetError(BuscartextBox, "Favor llenar");
                return false;
            }
            return true;
        }

        public void SeleccionarCombo()
        {

            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = BLL.ClienteBLL.GetListTodo();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.ClienteBLL.GetList(p => p.ClienteId == Utilidades.TOINT(BuscartextBox.Text));
                }

            }

            if (comboBox1.SelectedIndex == 2)
            {
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.ClienteBLL.GetList(p => p.Nombres == BuscartextBox.Text);
                }

            }

            if (comboBox1.SelectedIndex == 3)
            {
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.ClienteBLL.GetList(p => p.Apellidos == BuscartextBox.Text);
                }

            }

            if (comboBox1.SelectedIndex == 4)
            {
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.ClienteBLL.GetList(p => p.Direccion == BuscartextBox.Text);
                }

            }

            if (comboBox1.SelectedIndex == 5)
            {
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.ClienteBLL.GetList(p => p.Cedula == (BuscartextBox.Text));
                }

            }

            if (comboBox1.SelectedIndex == 6)
            {
                desdedateTimePicker.Enabled = true;
                hastadateTimePicker.Enabled = true;
                if (desdedateTimePicker.Value.Date > hastadateTimePicker.Value.Date)
                {
                    dataGridView1.DataSource = BLL.ClienteBLL.GetList(p => p.Fecha >= desdedateTimePicker.Value.Date && p.Fecha < hastadateTimePicker.Value.Date);
                }
            }

        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            SeleccionarCombo();
        }
    }
}
