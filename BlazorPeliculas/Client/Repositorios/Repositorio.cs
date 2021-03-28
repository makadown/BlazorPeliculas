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
                                Lanzamiento = new DateTime(2019,7,01)
                        },
                        new Pelicula() {
                                Titulo ="Moana",
                                Lanzamiento = new DateTime(2016,11,23)
                        },
                        new Pelicula() {
                                Titulo ="Inception",
                                Lanzamiento = new DateTime(2010,7,16)
                        }
                    };
        }
    }
}
