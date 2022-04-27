using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ProductoServices
    {
        ClientService clientService;
        public ProductoServices()
        {
            clientService = ClientService.Instance;
        }
        public async Task<CResponseData<List<CUnidadMedida>>> obtenerUnidadesMedida()
        {
            var response = await clientService.client.GetStringAsync("unidades/medida");
            var data = JsonConvert.DeserializeObject<CResponseData<List<CUnidadMedida>>>(response);

           return data;
        }

        public async Task<HttpResponseMessage> altaProducto(CProducto producto)
        {
            var objProduct = new Dictionary<string, string>
                {
                    { "idproducto", producto.idproducto.ToString() },
                    { "descripcion", producto.descripcion},
                    { "precio_lista",producto.precio_lista.ToString()},
                    { "valor_medida", producto.valor_medida.ToString()},
                    {"idunidadmedida", producto.idunidadmedida.ToString()},
                    {"precio_mayoreo", producto.precio_mayoreo.ToString() }
                };

            var content = new FormUrlEncodedContent(objProduct);
            var response = await clientService.client.PostAsync("producto", content);

            return response;
        }

        public async Task<CResponseData<CProducto>> productoById(Int32 productoId)
        {            
            var response = await clientService.client.GetStringAsync("producto/id/"+ productoId);
            var data = JsonConvert.DeserializeObject<CResponseData<CProducto>>(response);

            return data;
        }

        public async Task<CResponseData<List<CProducto>>> productoByDescripcion(String sDescripcion)
        {
            var response = await clientService.client.GetStringAsync("producto/nombre/desc-" + sDescripcion);
            var data = JsonConvert.DeserializeObject<CResponseData<List<CProducto>>>(response);

            return data;
        }
    }
}
