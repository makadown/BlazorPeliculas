using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {

        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {
            SweetAlertService Swal = new(js);

            SweetAlertResult result = await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "Confirmar",
                Text = mensaje,
                Icon = SweetAlertIcon.Warning,
                ShowCancelButton = true,
                ConfirmButtonText = "Aceptar",
                CancelButtonText = "Cancelar"
            });
            return result.IsConfirmed;
            //   return await js.InvokeAsync<bool>("confirm", mensaje);
        }

        public static async Task ExitoEliminado(this IJSRuntime js)
        {
            SweetAlertService Swal = new(js);

            await Swal.FireAsync(
                  "Eliminado",
                  "Información eliminada exitosamente",
                  SweetAlertIcon.Success
                  );
            //   return await js.InvokeAsync<bool>("confirm", mensaje);
        }


    }
}
