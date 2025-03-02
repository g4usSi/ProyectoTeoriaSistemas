using ProyectoTeoriaSistemas.CodigoFuente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTeoriaSistemas.CodigoFuente;

//Estas son las planillas, que se mostraran en el DataGrid, supongo que realmente deberian guardarse en el SQL...
namespace ProyectoTeoriaSistemas
{
    class PlanillaEmpresa
    {
        //public List<Trabajador> Empleados = new List<Trabajador>();
        List<Planilla> PlanillasEmpresariales = new List<Planilla>();

        // Agregar empleado a la planilla
        public void AgregarTrabajador(Planilla trabajador)
        {
            PlanillasEmpresariales.Add(trabajador);
        }

        // Totales generales de la planilla
        public decimal TotalDevengado => PlanillasEmpresariales.Sum(emp => emp.TotalDevengado);
        public decimal TotalDescuentos => PlanillasEmpresariales.Sum(emp => emp.TotalDescuentos);
        public decimal TotalSueldoNeto => PlanillasEmpresariales.Sum(emp => emp.SueldoNeto);
    }
}

