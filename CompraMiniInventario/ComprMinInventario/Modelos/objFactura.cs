using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class objFactura:objBase
    {
        public List<objFacturadetalle> Detalle { get; set; } =new List<objFacturadetalle>();
        public objProveedores proveedor { get; set; }
        public string Numero { get; set; }
    }
}
