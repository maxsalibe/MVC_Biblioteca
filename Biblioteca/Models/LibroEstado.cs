using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Modelo
{
    public class LibroEstado
    {
        public int libroId { get; set; }
        public string titulo { get; set; }
        public string rutaimagen { get; set; }
        public bool prestado { get; set; }

    }
}
