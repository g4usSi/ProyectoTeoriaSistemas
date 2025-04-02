using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public class Compra
    {
        public string Proveedor { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioCompra { get; set; }
        public DateTime Fecha { get; set; }

        public Compra(string proveedor, Producto producto, int cantidad, double precioCompra)
        {
            Proveedor = proveedor;
            Producto = producto;
            Cantidad = cantidad;
            PrecioCompra = precioCompra;
            Fecha = DateTime.Now; // Se puede asignar una fecha específica al instanciar
        }

        public double gasto()
        {
            return Cantidad*PrecioCompra;
        }
    }

}


