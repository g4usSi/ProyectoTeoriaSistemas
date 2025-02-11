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

        // Ahora el Subtotal incluye el cálculo del 70% adicional directamente
        public double Subtotal => (Producto.Precio * Cantidad) + CalcularSubtotalConMargen();

        public DetalleFactura(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        // Método que calcula el 70% adicional sobre el precio original
        private double CalcularSubtotalConMargen()
        {
            return (Producto.Precio * 0.70) * Cantidad; // Calcula solo el 70% adicional
        }
    }

}
