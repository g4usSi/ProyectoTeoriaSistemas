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

        public Tienda()
        {
            historialVentas = new List<Venta>();
            AgregarVentasSimuladas();
            PlanillaEmpresa = new PlanillaEmpresa();
            AgregarPlanillasSimuladas();
            AgregarProductos();
        }

        private void AgregarVentasSimuladas()
        {
            // Aquí va el código que ya tienes para cargar ventas simuladas.
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
