using Entidades;
using Newtonsoft.Json;
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
        public Producto()
        {
            InitializeComponent();
        }

       
        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnAltas_Click(object sender, EventArgs e)
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
