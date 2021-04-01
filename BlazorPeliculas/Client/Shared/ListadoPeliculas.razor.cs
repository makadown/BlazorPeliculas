using BlazorPeliculas.Client.Helpers;
using BlazorPeliculas.Shared.Entidades;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Shared
{
    public partial class ListadoPeliculas
    {
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public List<Pelicula> Peliculas { get; set; }
    
        Pelicula peliculaABorrar;
        async Task  EliminarPelicula(Pelicula pelicula)
        {
           var confirmado =
                await js.Confirm( $"Desea borrar la pelicula {pelicula.Titulo}?");
            if (confirmado)
            {
                Peliculas.Remove(pelicula);
                await js.ExitoEliminado();
            }
        }
    }
}
