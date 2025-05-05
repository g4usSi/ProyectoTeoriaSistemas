using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTeoriaSistemas.finanzasModule
{
    public class Egreso
    {
        public int IDEgreso { get; set; } //

        public int IDFactura { get; set; }//ver si esto funciona de algo 
        public DateTime DateTime { get; set; }//
        public string Descripcion { get; set; }//
        public string Total { get; set; }//
    }
}
