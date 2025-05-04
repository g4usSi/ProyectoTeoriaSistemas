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

        public double Subtotal => (Producto.PrecioVenta * Cantidad);
        //Agregue otro atributo....
        public int IDArticulo => Producto.ID;
        public double PrecioUnitario => Producto.PrecioVenta;
        public DetalleFactura(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
        public DetalleFactura()
        {
            Producto = new Producto();
            Cantidad = 0;
        }
    }

}
