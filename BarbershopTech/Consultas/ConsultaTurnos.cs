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
    public partial class ConsultaTurnos : Form
    {
        public ConsultaTurnos()
        {
            InitializeComponent();
            LLenarCombo();
        }

        public void LLenarCombo()
        {
            comboBox1.Items.Insert(0, "Todos");
            comboBox1.Items.Insert(1, "Cliente");
            comboBox1.Items.Insert(2, "Peluquero");
            comboBox1.Items.Insert(3, "Servicio");
            comboBox1.Items.Insert(4, "Id");
            comboBox1.Items.Insert(5, "Fecha");
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
                dataGridView1.DataSource = BLL.TurnoBLL.GetListTodo();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.TurnoBLL.GetList(p => p.NombreCliente == BuscartextBox.Text);
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
                    dataGridView1.DataSource = BLL.TurnoBLL.GetList(p => p.NombrePeluquero == BuscartextBox.Text);
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
                    dataGridView1.DataSource = BLL.TurnoBLL.GetList(p => p.NombreServicio == BuscartextBox.Text);
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
                    dataGridView1.DataSource = BLL.TurnoBLL.GetList(p => p.TurnosId == Utilidades.TOINT(BuscartextBox.Text));
                }

            }

           
            

           /* if (comboBox1.SelectedIndex == 5)
            {
               
                if (desdedateTimePicker.Value.Date > hastadateTimePicker.Value.Date)
                {
                    dataGridView1.DataSource = BLL.TurnoBLL.GetList(p => p.Fecha >= desdedateTimePicker.Value.Date && p.Fecha < hastadateTimePicker.Value.Date);
                }
            }*/

        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            SeleccionarCombo();
        }
    }
}
