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
        Confirmacion confirmacion;
        [Inject] IJSRuntime js { get; set; }
        [Parameter] public List<Pelicula> Peliculas { get; set; }

        protected override void OnInitialized()
        {
            Console.WriteLine("OnInitialized");
        }

        protected override void OnParametersSet()
        {
            Console.WriteLine("OnParametersSet");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine($"OnAfterRender: {firstRender}");
        }

        protected override bool ShouldRender()
        {
            Console.WriteLine("ShouldRender");
            return true;
        }

        bool MostrarBotones = true;
        Pelicula peliculaABorrar;

        void /*async Task*/ EliminarPelicula(Pelicula pelicula)
        {
            peliculaABorrar = pelicula;
            confirmacion.Mostrar();
            /*var confirmado =
                await js.Confirm( $"Desea borrar la pelicula {pelicula.Titulo}?");
            if (confirmado)
            {
                Peliculas.Remove(pelicula);
                await js.ExitoEliminado();
            }*/
        }

        async Task EliminarPeliculaConfirmacion()
        {
            Peliculas.Remove(peliculaABorrar);
            confirmacion.Ocultar();
            peliculaABorrar = null;
            await js.ExitoEliminado();
        }

        void onCancelConfirmacion()
        {
            confirmacion.Ocultar();
            peliculaABorrar = null;
        }
    }
}
