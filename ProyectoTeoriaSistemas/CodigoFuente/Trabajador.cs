using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoTeoriaSistemas.CodigoFuente
{
    public class Trabajador
    {
        public string DPI { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public decimal SueldoOrdinario { get; set; }
        public int HorasExtras { get; set; }
        public decimal ValorHorasExtras { get; set; }
        public decimal Comisiones { get; set; }
        public decimal Bonificaciones { get; set; }
        public decimal IGSS { get; set; }
        public decimal Prestamos { get; set; }

        public decimal TotalDevengado => SueldoOrdinario + ValorHorasExtras + Comisiones + Bonificaciones;
        public decimal TotalDescuentos => IGSS + Prestamos;
        public decimal SueldoNeto => TotalDevengado - TotalDescuentos;
    }
}
