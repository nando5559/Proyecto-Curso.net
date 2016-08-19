using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pelicula
    {
         public string  Nombre { get; set; }
         public string Estudio { get; set; }
        public DateTime FechaEstreno { get; set; }
        public List<Persona> Actores { get; set; }
        public List<Persona>Director{ get; set; }

    }
}
