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
    public partial class ConsultaPeluqueros : Form
    {
        public ConsultaPeluqueros()
        {
            InitializeComponent();
            LLenarCombo();
        }

        public void LLenarCombo()
        {
            comboBox1.Items.Insert(0, "Todos");
            comboBox1.Items.Insert(1, "Nombres");
            comboBox1.Items.Insert(2, "Id");
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
                dataGridView1.DataSource = BLL.PeluqueroBLL.GetListTodo();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.PeluqueroBLL.GetList(p => p.Nombre == BuscartextBox.Text);
                }

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.PeluqueroBLL.GetList(p => p.PeluqueroId == Utilidades.TOINT(BuscartextBox.Text));
                }
            }

        }


        private void Filtrar_Click(object sender, EventArgs e)
        {
            SeleccionarCombo();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.DataSource = BLL.PeluqueroBLL.GetListTodo();
                BuscartextBox.Enabled = false;
            }

            else if (comboBox1.SelectedIndex == 1)
            {

                dataGridView1.DataSource = BLL.PeluqueroBLL.GetList(p => p.Nombre == BuscartextBox.Text);
                BuscartextBox.Enabled = true;

            }

            else if (comboBox1.SelectedIndex == 2)
            {

                dataGridView1.DataSource = BLL.PeluqueroBLL.GetList(p => p.PeluqueroId == Utilidades.TOINT(BuscartextBox.Text));
                BuscartextBox.Enabled = true;
            }
        }
    }
}

