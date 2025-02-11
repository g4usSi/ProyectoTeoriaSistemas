using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeoriaSistemas
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public double PrecioVenta { get; set; }
      


        public Producto(int iD, string nombre, string marca, int stock, double precio)
        {
            ID = iD;
            Nombre = nombre;
            Marca = marca;
            Stock = stock;
            Precio = precio;
            PrecioVenta = 0;
            
        }

        public bool DescontarStock(int cantidad)
        {
            if (Stock >= cantidad)
            {
                Stock -= cantidad;
                return true; // Compra válida
            }
            return false; // Stock insuficiente
        }

    }
}
