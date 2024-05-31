using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class objProveedores:objBase
    {
        public int Nit { get; set; }
        public string Ciudad { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }

    }

    //int id, string Nombre, int Nit, int Ciudad, string Telefono, string Correo
}
