using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Factura
    {
        public int IDFactura { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public string Total { get; set; }
    }
}
