using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Reglas
{
    public class PeliculaMapper : BaseMapper<Pelicula>
    {

        public override void Grabar(List<Pelicula> entidades)
        {
            foreach (var pelicula in entidades)
            {
                pelicula.IdGenero = pelicula.Genero.Id;

                pelicula.IdActores = new List<Guid>();
                foreach (var actor in pelicula.Actores)
                {
                    pelicula.IdActores.Add(actor.Id);
                }

                pelicula.IdDirectores = new List<Guid>();
                foreach (var director in pelicula.Directores)
                {
                    pelicula.IdDirectores.Add(director.Id);
                }
            }

            base.Grabar(entidades);
        }

        
        }
    }

