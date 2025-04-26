using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public class Factura
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string NIT { get; set; }
        public string NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();

        public double Total => Detalles.Sum(d => d.Subtotal);
        //Metodo para sobreescribir el constructor... es provisional para no romper el forms
        public Factura(int id)
        {
            ID = id;
            Cliente = "";
            NIT = "C/F";
            NumeroFactura = id.ToString();
            Fecha = DateTime.Now;
        }
        public Factura(int id, string cliente, string nit, string numeroFactura)
        {
            ID = id;
            Cliente = cliente;
            NIT = nit;
            NumeroFactura = numeroFactura;
            Fecha = DateTime.Now;
        }

        // Agrega un producto a la factura (sin lógica de stock, delega a quien use esta clase)
        public void AgregarDetalle(Producto producto, int cantidad)
        {
            if (producto == null)
                //Aqui hay que agregar logica SQL si no hay suficiente del producto seleccionado
                throw new ArgumentNullException(nameof(producto));

            Detalles.Add(new DetalleFactura(producto, cantidad));
        }
    }
}
