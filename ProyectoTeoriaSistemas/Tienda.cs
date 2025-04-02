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
        public PlanillaEmpresa PlanillaEmpresa { get; set; }
        public LinkedList<Producto> listaProductos = new LinkedList<Producto>();
        public List<Compra> historialCompras = new List<Compra>();

        public Tienda()
        {
            historialVentas = new List<Venta>();
            
            PlanillaEmpresa = new PlanillaEmpresa();
            AgregarProductos();
            AgregarPlanillasSimuladas();
            
            AgregarComprasSimuladas();
            AgregarVentasSimuladas();
        }

        private void AgregarVentasSimuladas()
        {      // Simular ventas en enero 2025
            historialVentas.Add(new Venta("Cliente A", 100, new List<DetalleFactura> { new DetalleFactura(new Producto(1, "Base Líquida Mate", "Maybelline", 50, 120.00), 2) }) { Fecha = new DateTime(2025, 1, 5) });
            historialVentas.Add(new Venta("Cliente B", 150, new List<DetalleFactura> { new DetalleFactura(new Producto(3, "Máscara de Pestañas", "L'Oréal", 40, 90.00), 3) }) { Fecha = new DateTime(2025, 1, 5) });
            historialVentas.Add(new Venta("Cliente C", 180, new List<DetalleFactura> { new DetalleFactura(new Producto(6, "Labial Mate", "NYX", 35, 85.00), 2) }) { Fecha = new DateTime(2025, 1, 6) });
            historialVentas.Add(new Venta("Cliente D", 220, new List<DetalleFactura> { new DetalleFactura(new Producto(4, "Sombra de Ojos", "Urban Decay", 20, 220.00), 1) }) { Fecha = new DateTime(2025, 1, 7) });
            historialVentas.Add(new Venta("Cliente E", 250, new List<DetalleFactura> { new DetalleFactura(new Producto(8, "Iluminador", "Becca", 15, 180.00), 5) }) { Fecha = new DateTime(2025, 1, 8) });
            historialVentas.Add(new Venta("Cliente F", 400, new List<DetalleFactura> { new DetalleFactura(new Producto(9, "Polvo Translúcido", "Laura Mercier", 18, 200.00), 2) }) { Fecha = new DateTime(2025, 1, 15) });
            historialVentas.Add(new Venta("Cliente G", 120, new List<DetalleFactura> { new DetalleFactura(new Producto(1, "Base Líquida Mate", "Maybelline", 50, 120.00), 3) }) { Fecha = new DateTime(2025, 1, 10) });
            historialVentas.Add(new Venta("Cliente H", 180, new List<DetalleFactura> { new DetalleFactura(new Producto(3, "Máscara de Pestañas", "L'Oréal", 40, 90.00), 2) }) { Fecha = new DateTime(2025, 1, 12) });
            historialVentas.Add(new Venta("Cliente I", 300, new List<DetalleFactura> { new DetalleFactura(new Producto(6, "Labial Mate", "NYX", 35, 85.00), 4) }) { Fecha = new DateTime(2025, 1, 18) });
            historialVentas.Add(new Venta("Cliente J", 220, new List<DetalleFactura> { new DetalleFactura(new Producto(4, "Sombra de Ojos", "Urban Decay", 20, 220.00), 1) }) { Fecha = new DateTime(2025, 1, 20) });
            historialVentas.Add(new Venta("Cliente K", 500, new List<DetalleFactura> { new DetalleFactura(new Producto(8, "Iluminador", "Becca", 15, 180.00), 5) }) { Fecha = new DateTime(2025, 1, 22) });
            historialVentas.Add(new Venta("Cliente L", 600, new List<DetalleFactura> { new DetalleFactura(new Producto(9, "Polvo Translúcido", "Laura Mercier", 18, 200.00), 3) }) { Fecha = new DateTime(2025, 1, 25) });
            
        }
        private void AgregarComprasSimuladas()
        {
            historialCompras.Add(new Compra("Proveedor X", new Producto(1, "Base Líquida Mate", "Maybelline", 20, 84.00), 16, 84.00) { Fecha = new DateTime(2025, 1, 1) });
            historialCompras.Add(new Compra("Proveedor Y", new Producto(3, "Máscara de Pestañas", "L'Oréal", 30, 63.00), 19, 63.00) { Fecha = new DateTime(2025, 1, 1) });
            historialCompras.Add(new Compra("Proveedor Z", new Producto(6, "Labial Mate", "NYX", 30, 59.50), 16, 59.50) { Fecha = new DateTime(2025, 1, 1) });
            historialCompras.Add(new Compra("Proveedor X", new Producto(4, "Sombra de Ojos", "Urban Decay", 20, 154.00), 14, 154.00) { Fecha = new DateTime(2025, 1, 1) });
            historialCompras.Add(new Compra("Proveedor Y", new Producto(8, "Iluminador", "Becca", 20, 126.00), 25, 126.00) { Fecha = new DateTime(2025, 1, 8) });
            historialCompras.Add(new Compra("Proveedor Z", new Producto(9, "Polvo Translúcido", "Laura Mercier", 50, 140.00), 16, 140.00) { Fecha = new DateTime(2025, 1, 1) });

        }


       


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
        public double CalcularCostoVentas()
        {
            // Paso 1: Inventario Inicial
            double inventarioInicial = listaProductos.Sum(p => p.Stock * p.PrecioCompra);

            // Paso 2: Compras realizadas
            double comprasTotales = historialCompras.Sum(c => c.Cantidad * c.PrecioCompra);

            // Paso 3: Restamos las ventas del inventario
            foreach (var venta in historialVentas)
            {
                if (venta?.Detalles == null)
                {
                    continue; // Si no hay detalles de la venta, saltamos
                }

                foreach (var detalle in venta.Detalles)
                {
                    if (detalle?.Producto == null)
                    {
                        continue; // Si no hay producto, saltamos
                    }

                    var producto = listaProductos.FirstOrDefault(p => p.ID == detalle.Producto.ID);
                    if (producto != null)
                    {
                        producto.Stock -= detalle.Cantidad; // Actualizamos el stock restando la cantidad vendida
                    }
                    else
                    {
                        Console.WriteLine($"Producto con ID {detalle.Producto.ID} no encontrado en el inventario.");
                    }
                }
            }

            // Paso 4: Inventario Final
            double inventarioFinal = listaProductos.Sum(p => p.Stock * p.PrecioCompra);

            // Paso 5: Calcular Costo de Ventas
            double costoVentas = inventarioInicial + comprasTotales - inventarioFinal;

            return costoVentas;
        }




        /// <summary>
        /// Agrega planillas predeterminadas (simuladas) para poder usarlas cuando se muestre el resumen.
        /// </summary>
        private void AgregarPlanillasSimuladas()
        {
            // Simular planilla para Enero de 2025
            var planilla1 = new Planilla
            {
                IDPlanilla = 1,
                Empleado = new EmpleadoDatos { Nombre = "Resumen de Empleados" },
                SueldoOrdinario = 5000m,
                HorasExtras = 10,
                Comisiones = 300m,
                Bonificaciones = 200m,
                IGSS = 300m,
                Prestamos = 100m,
                Nombre = "Planilla Enero 2025",
                Cargo = "N/A",
                Fecha = new DateTime(2025, 1, 1)
            };

            // Simular planilla para Marzo de 2024
            var planilla2 = new Planilla
            {
                IDPlanilla = 2,
                Empleado = new EmpleadoDatos { Nombre = "Resumen de Empleados" },
                SueldoOrdinario = 6000m,
                HorasExtras = 8,
                Comisiones = 250m,
                Bonificaciones = 180m,
                IGSS = 350m,
                Prestamos = 150m,
                Nombre = "Planilla Marzo 2024",
                Cargo = "N/A",
                Fecha = new DateTime(2024, 3, 1)
            };

            // Agregar las planillas predeterminadas al objeto PlanillaEmpresa
            PlanillaEmpresa.AgregarTrabajador(planilla1);
            PlanillaEmpresa.AgregarTrabajador(planilla2);
        }

        // Métodos para obtener ventas (para ingresos)
        public Producto ObtenerProducto(int id)
        {
            return listaProductos.FirstOrDefault(p => p.ID == id);
        }

        public void AgregarVenta(Venta venta)
        {
            historialVentas.Add(venta);
        }

        public List<Venta> ObtenerVentas() => historialVentas;

        public List<Venta> ObtenerIngresosPorFecha(int ano, int mes)
        {
            return historialVentas
                .Where(v => v.Fecha.Year == ano && v.Fecha.Month == mes)
                .ToList();
        }

        public double ObtenerTotalIngresosPorFecha(int ano, int mes)
        {
            return historialVentas
                .Where(v => v.Fecha.Year == ano && v.Fecha.Month == mes)
                .Sum(v => v.TotalVenta);
        }

    }

    /// <summary>
    /// Esta clase es una representación simplificada para mostrar en el DataGrid de egresos.
    /// Solo incluye la fecha, el total (suma de sueldo neto u otro campo que determines) y una descripción.
    /// </summary>
    public class ResumenPlanilla
    {
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Descripcion { get; set; }

        public static decimal CalcularTotalPlanillasPorFecha(List<ProyectoTeoriaSistemas.CodigoFuente.Planilla> planillas, int año, int mes)
        {
            return planillas
                .Where(p => p.Fecha.Year == año && p.Fecha.Month == mes)
                .Sum(p => p.SueldoNeto);
        }

    }
}
