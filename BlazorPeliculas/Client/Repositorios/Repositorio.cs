using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
                    {
                        new Pelicula() {
                                Titulo ="Spiderman: Far from home",
                                Lanzamiento = new DateTime(2019,7,01),
                                Poster = "https://rock101online.mx/wp-content/uploads/2019/07/large_far-home-poster.jpg"
                        },
                        new Pelicula() {
                                Titulo ="Moana",
                                Lanzamiento = new DateTime(2016,11,23),
                                Poster = "https://i.pinimg.com/474x/e3/59/cc/e359cc5e5302e610f0134ec93b62a730.jpg"
                        },
                        new Pelicula() {
                                Titulo ="Inception",
                                Lanzamiento = new DateTime(2010,7,16),
                                Poster = "https://flxt.tmsimg.com/assets/p7825626_p_v10_af.jpg"
                        }
                    };
        }
    }
}
