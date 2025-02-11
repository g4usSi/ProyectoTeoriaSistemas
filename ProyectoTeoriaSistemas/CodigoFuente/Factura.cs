using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public class Factura
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();

        public double Total => Detalles.Sum(d => d.Subtotal);  // Calcula el total de la factura

        public Factura(int id)
        {
            ID = id;
            Fecha = DateTime.Now;
        }

        // Agregar productos a la factura y descontar stock
        public void AgregarProducto(Tienda tienda, int idProducto, int cantidad)
        {
            Producto producto = tienda.ObtenerProducto(idProducto);

            if (producto != null && producto.DescontarStock(cantidad))
            {
                Detalles.Add(new DetalleFactura(producto, cantidad));
            }
            else
            {
                throw new Exception($"❌ No hay suficiente stock para {producto.Nombre}.");
            }
        }
    }

}
