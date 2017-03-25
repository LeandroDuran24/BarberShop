﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Microsoft.Reporting.WinForms;

namespace BarbershopTech.UI.Reportes
{
    public partial class RClientes : Form
    {
        public List<Clientes> cliente = new List<Clientes>();

        public RClientes()
        {
            InitializeComponent();
          

        }

        private void RClientes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            reportViewer1.Reset();
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = @"C:\Users\Leandro\Desktop\BarberShop - copia\BarbershopTech\UI\Reportes\Clientes.rdlc";

            ReportDataSource source = new ReportDataSource("DataSetCliente",cliente);

            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}