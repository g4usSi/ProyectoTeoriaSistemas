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
        public void AgregarProductos()
        {
            listaProductos.AddLast(new Producto(1, "Base Líquida Mate", "Maybelline", 50, 120.00));
            listaProductos.AddLast(new Producto(2, "Rubor en Polvo", "NARS", 30, 150.00));
            listaProductos.AddLast(new Producto(3, "Máscara de Pestañas Voluminizadora", "L'Oréal", 40, 90.00));
            listaProductos.AddLast(new Producto(4, "Sombra de Ojos Nude", "Urban Decay", 20, 220.00));
            listaProductos.AddLast(new Producto(5, "Delineador Líquido Negro", "Kat Von D", 60, 110.00));
            listaProductos.AddLast(new Producto(6, "Labial Líquido Mate", "NYX", 35, 85.00));
            listaProductos.AddLast(new Producto(7, "Corrector Líquido", "Tarte", 25, 130.00));
            listaProductos.AddLast(new Producto(8, "Iluminador en Polvo", "Becca", 15, 180.00));
            listaProductos.AddLast(new Producto(9, "Polvo Compacto Translúcido", "Laura Mercier", 18, 200.00));
            listaProductos.AddLast(new Producto(10, "Bálsamo Labial Hidratante", "EOS", 70, 60.00));
        }
        public Producto ObtenerProducto(int id)
        {
            return listaProductos.FirstOrDefault(p => p.ID == id);
        }
    }
}
