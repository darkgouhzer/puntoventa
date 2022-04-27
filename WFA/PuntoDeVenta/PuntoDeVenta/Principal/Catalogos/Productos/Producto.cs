using Entidades;
using Newtonsoft.Json;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Principal.Catalogos.Productos
{
    public partial class Producto : Form
    {
        ProductoServices objProductosServices;
        public Producto()
        {
            InitializeComponent();
            objProductosServices = new ProductoServices();
            filtrarProductos();
        }

       
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            filtrarProductos();
        }

        private async void filtrarProductos()
        {
            var response = await objProductosServices.productoByDescripcion(tbxDescripcion.Text);
            dtgProductos.Rows.Clear();
            foreach (CProducto producto in response.data)
            {
                dtgProductos.Rows.Add(producto.idproducto, producto.descripcion, 0, producto.precio_lista, producto.precio_mayoreo, producto.precio_lista, producto.precio_mayoreo);
            }
        }
        private void BtnAltas_Click(object sender, EventArgs e)
        {
            AltaProducto altaProducto = new AltaProducto();            
            altaProducto.ShowDialog();
        }

        private void Producto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
