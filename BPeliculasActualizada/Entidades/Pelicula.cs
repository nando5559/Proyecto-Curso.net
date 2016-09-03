using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Entidades
{
    public class Pelicula
{
       public Pelicula()
        {
            Actores = new List<Persona>();
            Directores = new List<Persona>();
            IdActores = new List<Guid>();
        }

        public string Nombre { get; set; }

        public int AnioEstreno { get; set; }

        [JsonIgnore]
        public List<Persona> Actores { get; private set; }

        [JsonIgnore]
        public List<Persona> Directores { get; private set; }

        public List<Guid> IdActores { get; set; }
}
}