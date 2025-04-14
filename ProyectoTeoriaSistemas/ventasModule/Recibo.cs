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
        string Comprobante { get; set; } //Factura/Ticket
        int NumComprobante { get; set; } //numero del documento
        
        public List<Producto> ProductosRecibo { get; set; } = new List<Producto>(); //lista de productos
        double TotalVenta { get; set; } //





    }
}
