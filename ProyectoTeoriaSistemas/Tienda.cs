using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeoriaSistemas
{
    public  class Tienda
    {
        public LinkedList<Producto> listaProductos = new LinkedList<Producto>();


        public Producto ObtenerProducto(int id)
        {
            return listaProductos.FirstOrDefault(p => p.ID == id);
        }
    }
}
