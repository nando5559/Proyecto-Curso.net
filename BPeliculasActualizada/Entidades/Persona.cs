using System;

namespace Entidades
{
    public class Persona : EntidadBase
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimento { get; set; }

    }
}
