using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CProducto
    {
        public int idproducto { get; set; }
        public String descripcion { get; set; }
        public decimal precio_lista { get; set; }
        public decimal precio_mayoreo { get; set; }
        public double valor_medida { get; set; }
        public int idunidadmedida { get; set; }
        //public String sku;
        public DateTime updated_at { get; set; }
        public DateTime created_at { get; set; }
    }
}
