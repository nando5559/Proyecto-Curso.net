using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Entidades
{
    public class Pelicula: EntidadBase
    {
        public Pelicula()
        {
            Actores = new List<Persona>();
            Directores = new List<Persona>();
            IdActores = new List<Guid>();
        }

        [JsonIgnore]
        public Genero Genero { get; set; }

        public Guid IdGenero { get; set; }

        public string Nombre { get; set; }

        public int AnioEstreno { get; set; }

        public List<Guid> IdActores { get; set; }

        [JsonIgnore]
        public List<Persona> Actores { get; private set; }


        public List<Guid> IdDirectores { get; set; }

        [JsonIgnore]
        public List<Persona> Directores { get; private set; }

    }
}
