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
    public partial class AltaProducto : Form
    {
        ProductoServices objProductosServices;
        public AltaProducto()
        {
            InitializeComponent();
            obtenerUnidadesMedidaAsync();
        }

        private void AltaProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public async void obtenerUnidadesMedidaAsync()
        {
            objProductosServices = new ProductoServices();
            CResponseData<List<CUnidadMedida>> data = await objProductosServices.obtenerUnidadesMedida();

            cbxUnidadesMedida.DataSource = data.data;

            cbxUnidadesMedida.DisplayMember = "nombre";
            cbxUnidadesMedida.ValueMember = "idunidadmedida";
         
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            objProductosServices = new ProductoServices();
            CProducto producto = new CProducto();
            producto.idproducto = Convert.ToInt32(tbxProductoId.Text);
            producto.descripcion = tbxDescripcion.Text;
            producto.valor_medida = Convert.ToDouble(tbxValorMedida.Text);
            producto.idunidadmedida = Convert.ToInt32(cbxUnidadesMedida.SelectedValue);
            producto.precio_lista = Convert.ToDecimal(tbxPrecioLista.Text);
            producto.precio_mayoreo = Convert.ToDecimal(tbxPrecioMayoreo.Text);
            HttpResponseMessage data = await objProductosServices.altaProducto(producto);
        }

        private async void tbxProductoId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CResponseData<CProducto> response = await objProductosServices.productoById(Convert.ToInt32(tbxProductoId.Text));
                if(response.data != null)
                {
                    CProducto producto = new CProducto();
                    producto = response.data;
                    tbxDescripcion.Text = producto.descripcion;
                    tbxValorMedida.Text = producto.valor_medida.ToString();
                    cbxUnidadesMedida.SelectedValue = Convert.ToInt32(producto.idunidadmedida);
                    tbxPrecioLista.Text = producto.precio_lista.ToString();
                    tbxPrecioMayoreo.Text = producto.precio_mayoreo.ToString();

                }
                else{
                    clearFields();
                }
            }
        }

        public void clearFields()
        {
            tbxDescripcion.Clear();
            tbxValorMedida.Clear();
            cbxUnidadesMedida.SelectedIndex = 0;
            tbxPrecioLista.Clear();
            tbxPrecioMayoreo.Clear();
        }

        private void tbxPrecioLista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbxProductoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
