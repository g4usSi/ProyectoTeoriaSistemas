using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Esta es la planilla de empleado, falta la planilla general

namespace ProyectoTeoriaSistemas.CodigoFuente
{
    //Esta es la que realmente tenes que usar OwO
    public class Planilla
    {
        //Este objeto solo almacena los datos de los empleados, para acceder a el, tienes que llamar sus atributos, no se si esta bien en la clase estatica
        public EmpleadoDatos Empleado { get; set; }  // Datos del empleado
        public decimal SueldoOrdinario { get; set; } // Sueldo base sin extras
        public int HorasExtras { get; set; }        // Cantidad de horas extra trabajadas
        public decimal Comisiones { get; set; }     // Comisiones ganadas
        public decimal Bonificaciones { get; set; } // Bonos adicionales
        public decimal IGSS { get; set; }           // Descuento del IGSS
        public decimal Prestamos { get; set; }      // Descuento por préstamos

        // Cálculo del pago por horas extras (asumiendo que se paga 1.5x el sueldo normal por hora extra)
        public decimal PagoHorasExtras => (SueldoOrdinario / 160) * 1.5m * HorasExtras;

        // Total Devengado = Sueldo Ordinario + Horas Extras + Comisiones + Bonificaciones
        public decimal TotalDevengado => SueldoOrdinario + PagoHorasExtras + Comisiones + Bonificaciones;

        // Total de Descuentos = IGSS + Préstamos
        public decimal TotalDescuentos => IGSS + Prestamos;

        // Sueldo Neto = Total Devengado - Total de Descuentos
        public decimal SueldoNeto => TotalDevengado - TotalDescuentos;
    }

    //Omite la Existencia de este, es adorno
    public class EmpleadoDatos
    {
        public string DPI { get; set; }         // Identificación única del empleado
        public string Nombre { get; set; }      // Nombre completo
        public string Cargo { get; set; }       // Puesto de trabajo
        public decimal Sueldo { get; set; }     // Sueldo base
        public DateTime FechaNacimiento { get; set; } // Fecha de nacimiento del empleado
    }
}
