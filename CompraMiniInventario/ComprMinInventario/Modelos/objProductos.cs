using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ObjProductos : objBase
    {
        public string Codigo { get; set; }
        public int Costo { get; set; }
        public string Garantia { get; set; }
        public string Cantidad { get; set; }
        public objIva Iva { get; set; }

    }
}
