using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    internal class Recibo
    {
        string Cliente { get; set; }
        DateTime Fecha { get; set; }
        string Comprobante { get; set; }
        int NumComprobante { get; set; }
        public List<Producto> ProductosRecibo { get; set; } = new List<Producto>();



    }
}
