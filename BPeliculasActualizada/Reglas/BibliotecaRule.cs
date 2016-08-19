using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reglas
{
    public class BibliotecaRule
    {
         public void AlmacenarPelicula(Pelicula pelicula)
            {
            //obtengo la lista de peliculas
            var peliculas = ObtenerPeliculas();
            peliculas.Add(pelicula);

            }

        public  DevolverPeliculaPorNombre()
        {

        }
        public void EditarPelicula(Pelicula pelicula)
           {
           }
        public List<Pelicula> ObtenerPeliculas()
             {
            //obtiene la ruta que inicia el programa y la guarda en path
             var path = System.Windows.Forms.Application.StartupPath;
            path += "\\Clientes.Json";
            //pregunta si existe,el archivo   
            if (!System.IO.File.Exists(path))
            {
                return new List<Pelicula>();
            }
            //abre el archivo 
            var contenido = System.IO.File.ReadAllText(path);

            var lista = JsonConvert.DeserializeObject<List<Pelicula>>(contenido);

            return lista;
             }
    }
}
