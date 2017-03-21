using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Entidades;

namespace BarbershopTech.Registros
{
    public partial class RegistroFactura : Form
    {
        Facturas factura;
        public RegistroFactura()
        {
            InitializeComponent();
            Limpiar();
            LlenarComboNombre();
            LlenarComboServicio();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroFactura_Load(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(comboBoxNombre.Text))
            {
                errorProvider1.SetError(comboBoxNombre, "Favor Llenar");
                return false;
            }

            if (string.IsNullOrEmpty(comboBoxServicios.Text))
            {
                errorProvider1.SetError(comboBoxServicios, "Favor Llenar");
                return false;
            }

            return true;
        }

        public void Limpiar()
        {
            comboBoxServicios.Text = null;
            comboBoxNombre.Text = null;
            textBoxComentario.Clear();
            textBoxPorcientoDescuento.Clear();
            textBoxImpuesto.Clear();
            textBoxTotal.Clear();
            textBoxSub.Clear();
            textBoxfacturaId.Clear();
            textBoxForma.Clear();
            dateTimePickerDesde.Value = DateTime.Now;
            dataGridView1.DataSource = null;
            errorProvider1.Clear();

            factura = new Facturas();
        }

        public void LlenarComboNombre()
        {
            List<Clientes> lista = BLL.ClienteBLL.GetListTodo();
            comboBoxNombre.DataSource = lista;
            comboBoxNombre.DisplayMember = "Nombres";
            comboBoxNombre.ValueMember = "ClienteId";

            if (comboBoxNombre.Items.Count > 0)
                comboBoxNombre.SelectedIndex = -1;
        }

        public void LlenarComboServicio()
        {
            List<TipoServicios> lista = BLL.TipoServicioBLL.GetListTodo();
            comboBoxServicios.DataSource = lista;
            comboBoxServicios.DisplayMember = "Nombre";
            comboBoxServicios.ValueMember = "ServicioId";
            if (comboBoxServicios.Items.Count > 0)
                comboBoxServicios.SelectedIndex = -1;

        }

        public Facturas LlenarCampos()
        {
            
            factura.NombreCliente = comboBoxNombre.Text;
            factura.FacturaId = Utilidades.TOINT(textBoxfacturaId.Text);
            factura.Comentario = textBoxComentario.Text;
            factura.ServicioId = Utilidades.TOINT(comboBoxServicios.SelectedValue.ToString());
            factura.Fecha = dateTimePickerDesde.Value;
            factura.DescuentoPorciento = Utilidades.TOINT(textBoxPorcientoDescuento.Text);
            factura.Impuesto = Utilidades.TOINT(textBoxImpuesto.Text);
            factura.SubTotal = Utilidades.TOINT(textBoxSub.Text);
            factura.Total = Utilidades.TOINT(textBoxTotal.Text);
            factura.TipoPago = textBoxForma.Text;

            return factura;
        }

        public void LlenarDataGrid(Facturas nueva)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nueva.ServicioList.ToList();
        }

        public void SacarCuenta()
        {
            decimal Subtotal = 0;
            decimal Total = 0;
            const int COLUMNAPRECIO = 2;


            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow precio in dataGridView1.Rows)
                {

                    Subtotal += (int)precio.Cells[COLUMNAPRECIO].Value;
                    textBoxSub.Text = Subtotal.ToString();

                }

                if (textBoxPorcientoDescuento.Text != null)
                {
                    decimal TotalDesc = Convert.ToDecimal((Utilidades.TOINT(textBoxPorcientoDescuento.Text) * Convert.ToDecimal(Subtotal) / 100));
                    Total = Subtotal - TotalDesc;
                    Subtotal = Subtotal - TotalDesc;
                    textBoxSub.Text = Subtotal.ToString();
                    textBoxTotal.Text = Total.ToString();

                }

                if (textBoxImpuesto.Text != null)
                {
                    decimal TotalImp = Convert.ToDecimal((Utilidades.TOINT(textBoxImpuesto.Text) * Convert.ToDecimal(Subtotal) / 100));
                    Total = Subtotal + TotalImp;
                    textBoxSub.Text = Subtotal.ToString();
                    textBoxTotal.Text = Total.ToString();

                }
               
            }
            else
            {
                MessageBox.Show("Error");
                Limpiar();
            }


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int id = 0;
           
            if (!Validar())
            {
                MessageBox.Show("Favor Llenar");
            }
            else
            {
                factura = LlenarCampos();

                if (id != factura.FacturaId)
                {
                    BLL.FacturaBLL.Mofidicar(factura);
                    MessageBox.Show("Se ha Modificado");
                }
                else
                {
                    BLL.FacturaBLL.Guardar(factura);
                    MessageBox.Show("Se ha Guardado Correctamente");
                }

            }
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxfacturaId.Text);
            factura = BLL.FacturaBLL.Buscar(p => p.FacturaId == id);
            if (factura != null)
            {
                comboBoxNombre.Text = factura.NombreCliente;
                textBoxComentario.Text = factura.Comentario;
                textBoxPorcientoDescuento.Text = Convert.ToString(factura.DescuentoPorciento.ToString());
                textBoxImpuesto.Text = Convert.ToString(factura.Impuesto.ToString());
                textBoxForma.Text = factura.TipoPago;
                textBoxSub.Text = Convert.ToString(factura.SubTotal.ToString());
                textBoxTotal.Text = Convert.ToString(factura.Total.ToString());
                LlenarDataGrid(factura);
                MessageBox.Show(" se ha encontrado Correctamente");
            }
            else
            {
                MessageBox.Show("No existe");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            TipoServicios servicio = new TipoServicios();
            servicio = (TipoServicios)comboBoxServicios.SelectedItem;
            factura.ServicioList.Add(servicio);

            LlenarDataGrid(factura);
            SacarCuenta();
        }

        private void comboBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
