﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoDeVenta.Principal.Catalogos.Productos;

namespace PuntoDeVenta.Principal.Catalogos
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Producto objProductos = new Producto();
            objProductos.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
