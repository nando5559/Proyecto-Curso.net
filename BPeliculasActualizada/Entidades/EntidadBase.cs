using System;

namespace Entidades
{

    public abstract class EntidadBase : IEntidad
    {
        public Guid Id { get; set; }

        protected EntidadBase()
        {
            Id = Guid.NewGuid();
        }

    }
}

