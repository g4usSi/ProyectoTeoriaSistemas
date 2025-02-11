using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public class DetalleFactura
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double Subtotal => Producto.Precio * Cantidad;  // Calcula el total del producto

        public DetalleFactura(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
    }

}
