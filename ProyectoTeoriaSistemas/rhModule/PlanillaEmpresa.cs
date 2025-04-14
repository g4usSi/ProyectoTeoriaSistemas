using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoTeoriaSistemas
{
    public class PlanillaEmpresa
    {
        // Lista que almacena todas las planillas
        public List<ProyectoTeoriaSistemas.CodigoFuente.Planilla> PlanillasEmpleados = new List<ProyectoTeoriaSistemas.CodigoFuente.Planilla>();

        // Agregar planilla a la lista
        public void AgregarTrabajador(ProyectoTeoriaSistemas.CodigoFuente.Planilla trabajador)
        {
            PlanillasEmpleados.Add(trabajador);
        }

        // Totales generales
        public decimal TotalDevengado => PlanillasEmpleados.Sum(emp => emp.TotalDevengado);
        public decimal TotalDescuentos => PlanillasEmpleados.Sum(emp => emp.TotalDescuentos);
        public decimal TotalSueldoNeto => PlanillasEmpleados.Sum(emp => emp.SueldoNeto);

        // Método para obtener el total de la planilla (por ejemplo, del sueldo neto) para un año y mes específicos.
        public decimal ObtenerTotalPlanillaMes(int año, int mes)
        {
            return PlanillasEmpleados
                        .Where(p => p.Fecha.Year == año && p.Fecha.Month == mes)
                        .Sum(p => p.SueldoNeto);
        }
    }
}
