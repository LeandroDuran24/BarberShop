﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BarbershopTech.Consultas
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
            LLenarCombo();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
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
                dataGridView1.DataSource = BLL.UsuarioBLL.GetListTodo();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor Llenar");
                }
                else
                {
                    dataGridView1.DataSource = BLL.UsuarioBLL.GetList(p => p.Nombres == BuscartextBox.Text);
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
                    int id = Utilidades.TOINT(BuscartextBox.Text);
                    dataGridView1.DataSource = BLL.UsuarioBLL.GetList(p => p.UsuarioId == id);
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
                dataGridView1.DataSource = BLL.UsuarioBLL.GetListTodo();
                BuscartextBox.Enabled = false;
            }

            else if (comboBox1.SelectedIndex == 1)
            {

                dataGridView1.DataSource = BLL.UsuarioBLL.GetList(p => p.Nombres == BuscartextBox.Text);
                BuscartextBox.Enabled = true;
            }

            else if (comboBox1.SelectedIndex == 2)
            {

                dataGridView1.DataSource = BLL.UsuarioBLL.GetList(p => p.UsuarioId == Utilidades.TOINT(BuscartextBox.Text));
                BuscartextBox.Enabled = true;
            }
        }
    }
}
