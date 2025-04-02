using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTeoriaSistemas.CodigoFuente;

namespace ProyectoTeoriaSistemas
{
    public class Venta
    {
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public double TotalVenta { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
        //public Venta(string cliente, double totalVenta, List<DetalleFactura> detalles)
        public Venta(string cliente, double totalVenta, List<DetalleFactura> detalles)
        {
            Fecha = DateTime.Now;
            Cliente = cliente;
            TotalVenta = totalVenta;
           // Detalles = detalles;
        }
    }

}
