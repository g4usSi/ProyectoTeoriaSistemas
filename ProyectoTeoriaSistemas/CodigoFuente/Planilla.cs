using System;

namespace ProyectoTeoriaSistemas.CodigoFuente
{    // Esta es la clase que tienes que usar 
    public class Planilla
    {
        //Este objeto solo almacena los datos de los empleados, para acceder a el,
        //tienes que llamar sus atributos, no se si esta bien en la clase estatica
        public EmpleadoDatos Empleado { get; set; }//no la jalo
        public int IDPlanilla { get; set; } //esta es la llave primaria de esta cosa
        public decimal SueldoOrdinario { get; set; }
        public int HorasExtras { get; set; }
        public decimal Comisiones { get; set; }
        public decimal Bonificaciones { get; set; }
        public decimal IGSS { get; set; }
        public decimal Prestamos { get; set; }
        public string Nombre { get; set; }  // ver si jala asi recordar que este nombre, se lo mando cuando envie los datos en el query 
        public string Cargo { get; set; } // ver si jala asi



        public decimal SueldoNetoCalculado { get; set; }





        public decimal PagoHorasExtras => (SueldoOrdinario / 160) * 1.5m * HorasExtras;
        public decimal TotalDevengado => SueldoOrdinario + PagoHorasExtras + Comisiones + Bonificaciones;
        public decimal TotalDescuentos => IGSS + Prestamos;
        public decimal SueldoNeto => TotalDevengado - TotalDescuentos;

        public decimal GetSueldoNeto()
        {
            return TotalDevengado - TotalDescuentos;
        }

        

        public string retornarNombre(EmpleadoDatos empleadoConvertir)
        {
            return empleadoConvertir.Nombre;
        }





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
