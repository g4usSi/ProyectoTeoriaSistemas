using System;

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public class Planilla
    {
        public EmpleadoDatos Empleado { get; set; }
        public int IDPlanilla { get; set; }
        public decimal SueldoOrdinario { get; set; }
        public int HorasExtras { get; set; }
        public decimal Comisiones { get; set; }
        public decimal Bonificaciones { get; set; }
        public decimal IGSS { get; set; }
        public decimal Prestamos { get; set; }
        public string Nombre { get; set; }  // Por ejemplo: "Planilla Enero 2025"
        public string Cargo { get; set; }   // Puede quedar en "N/A" para el resumen

        public decimal SueldoNetoCalculado { get; set; }

        // Agregamos la propiedad Fecha para saber a qué mes pertenece la planilla.
        public DateTime Fecha { get; set; }

        public decimal PagoHorasExtras => (SueldoOrdinario / 160) * 1.5m * HorasExtras;
        public decimal TotalDevengado => SueldoOrdinario + PagoHorasExtras + Comisiones + Bonificaciones;
        public decimal TotalDescuentos => IGSS + Prestamos;
        public decimal SueldoNeto => TotalDevengado - TotalDescuentos;

        public decimal GetSueldoNeto() => SueldoNeto;

        public string retornarNombre(EmpleadoDatos empleadoConvertir) => empleadoConvertir.Nombre;
    }

    public class EmpleadoDatos
    {
        public string DPI { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public decimal Sueldo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
