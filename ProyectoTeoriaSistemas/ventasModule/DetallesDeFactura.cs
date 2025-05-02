using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeoriaSistemas.ventasModule
{
    public class DetallesDeFactura
    {
        public int IDDetalle { get; set; }
        public int IDFactura { get; set; }
        public int IDArticulo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public DetallesDeFactura()
        {
        }
        //public decimal Total { get; set; } // Puedes calcularlo manualmente si tu DB no lo genera
        //public decimal Descuento { get; set; } // Opcional, si manejas promociones o rebajas



    }
}
