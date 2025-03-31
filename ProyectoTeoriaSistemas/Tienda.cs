using ProyectoTeoriaSistemas.CodigoFuente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeoriaSistemas
{
    public class Tienda
    {
        private List<Venta> historialVentas;
        public Tienda()
        {
            historialVentas = new List<Venta>();  
            AgregarVentasSimuladas();
        }
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
        public void AgregarVenta(Venta venta)
        {
            historialVentas.Add(venta);
        }
        public List<Venta> ObtenerVentas()
        {
            return historialVentas;
        }

        // VENTAS DE PRUEBA TAMBIEN JALA LAS VENTAS DIRECTAMETE DE FVENTAS
        private void AgregarVentasSimuladas()
        {
            // Simular ventas en enero de 2025
            historialVentas.Add(new Venta("Cliente A", 300, new List<DetalleFactura> { new DetalleFactura(new Producto(1, "Base Líquida Mate", "Maybelline", 50, 120.00), 2) }) { Fecha = new DateTime(2025, 1, 5) });
            historialVentas.Add(new Venta("Cliente B", 450, new List<DetalleFactura> { new DetalleFactura(new Producto(3, "Máscara de Pestañas", "L'Oréal", 40, 90.00), 3) }) { Fecha = new DateTime(2025, 1, 10) });
            historialVentas.Add(new Venta("Cliente C", 250, new List<DetalleFactura> { new DetalleFactura(new Producto(6, "Labial Mate", "NYX", 35, 85.00), 2) }) { Fecha = new DateTime(2025, 1, 15) });
            historialVentas.Add(new Venta("Cliente D", 600, new List<DetalleFactura> { new DetalleFactura(new Producto(4, "Sombra de Ojos", "Urban Decay", 20, 220.00), 1) }) { Fecha = new DateTime(2025, 1, 20) });
            historialVentas.Add(new Venta("Cliente E", 1000, new List<DetalleFactura> { new DetalleFactura(new Producto(8, "Iluminador", "Becca", 15, 180.00), 5) }) { Fecha = new DateTime(2025, 1, 25) });
            historialVentas.Add(new Venta("Cliente F", 720, new List<DetalleFactura> { new DetalleFactura(new Producto(9, "Polvo Translúcido", "Laura Mercier", 18, 200.00), 2) }) { Fecha = new DateTime(2025, 1, 30) });

            // Simular ventas en marzo de 2024
            historialVentas.Add(new Venta("Cliente G", 400, new List<DetalleFactura> { new DetalleFactura(new Producto(2, "Rubor", "NARS", 30, 150.00), 1) }) { Fecha = new DateTime(2024, 3, 2) });
            historialVentas.Add(new Venta("Cliente H", 600, new List<DetalleFactura> { new DetalleFactura(new Producto(5, "Delineador", "Kat Von D", 60, 110.00), 3) }) { Fecha = new DateTime(2024, 3, 6) });
            historialVentas.Add(new Venta("Cliente I", 800, new List<DetalleFactura> { new DetalleFactura(new Producto(7, "Corrector", "Tarte", 25, 130.00), 4) }) { Fecha = new DateTime(2024, 3, 10) });
            historialVentas.Add(new Venta("Cliente J", 200, new List<DetalleFactura> { new DetalleFactura(new Producto(10, "Bálsamo Labial", "EOS", 70, 60.00), 2) }) { Fecha = new DateTime(2024, 3, 15) });
            historialVentas.Add(new Venta("Cliente K", 900, new List<DetalleFactura> { new DetalleFactura(new Producto(1, "Base Líquida", "Maybelline", 50, 120.00), 3) }) { Fecha = new DateTime(2024, 3, 20) });
            historialVentas.Add(new Venta("Cliente L", 500, new List<DetalleFactura> { new DetalleFactura(new Producto(6, "Labial Mate", "NYX", 35, 85.00), 3) }) { Fecha = new DateTime(2024, 3, 25) });
            historialVentas.Add(new Venta("Cliente M", 700, new List<DetalleFactura> { new DetalleFactura(new Producto(4, "Sombra de Ojos", "Urban Decay", 20, 220.00), 2) }) { Fecha = new DateTime(2024, 3, 28) });
        }
    }
}
