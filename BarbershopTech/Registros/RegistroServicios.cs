﻿using System;
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
    public partial class RegistroServicios : Form
    {
        public RegistroServicios()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(nombretextBox3.Text))
            {
                errorProvider1.SetError(nombretextBox3, "Favor de LLenar");
                return false;
            }

            if (string.IsNullOrEmpty(CostoTexBox.Text))
            {
                errorProvider1.SetError(CostoTexBox, "Favor de LLenar");
                return false;
            }

            return true;
        }

        public void Limpiar()
        {
            nombretextBox3.Clear();
            idSeriviciotextBox.Clear();
            CostoTexBox.Clear();

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
            var guardar = new TipoServicios();
            int id = 0;

            if (!Validar())
            {

                MessageBox.Show("Ha Ocurrido Error...");
            }
            else
            {

                guardar.ServicioId = Utilidades.TOINT(idSeriviciotextBox.Text);
                guardar.Nombre = nombretextBox3.Text;
                guardar.Costo = Convert.ToInt32(CostoTexBox.Text);
                if (id != guardar.ServicioId)
                {
                    BLL.TipoServicioBLL.Mofidicar(guardar);
                }
                else
                {
                    BLL.TipoServicioBLL.Guardar(guardar);
                    MessageBox.Show("Se ha Guardado Correctamente...");
                }

                Limpiar();
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idSeriviciotextBox.Text);
            TipoServicios conn = BLL.TipoServicioBLL.Buscar((p => p.ServicioId == id));

            if (conn != null)
            {
                BLL.TipoServicioBLL.Eliminar(conn);
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
            int id = int.Parse(idSeriviciotextBox.Text);
            TipoServicios conn = BLL.TipoServicioBLL.Buscar((p => p.ServicioId == id));

            if (conn != null)
            {
                nombretextBox3.Text = conn.Nombre;
                CostoTexBox.Text = Convert.ToString(conn.Costo);

                MessageBox.Show("Se ha encontrado Correctamente");
            }
            else
            {
                MessageBox.Show("No se ha Eliminado");

            }
            Limpiar();
        }

        private void idSeriviciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void nombretextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarLetras(e);
        }

        private void nombretextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostoButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(e);
        }

        private void RegistroServicios_Load(object sender, EventArgs e)
        {

        }
    }
}
