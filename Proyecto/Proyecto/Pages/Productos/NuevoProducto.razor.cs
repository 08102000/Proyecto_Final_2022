using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;
using Proyecto.Interfaces;

namespace Proyecto.Pages.Productos
{
    partial class NuevoProducto
    {
        [Inject] private IProductoServicio usuarioServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        [Inject] SweetAlertService Swal { get; set; }

        private Productos1 user = new Productos1();

        protected async Task Guardar()
        {
           

            bool inserto = await usuarioServicio.Nuevo(user);
            if (inserto)
            {
                await Swal.FireAsync("Felicidades", "Usuario creado con exito", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "Usuario no se pudo crear", SweetAlertIcon.Error);
            }
            navigationManager.NavigateTo("/Usuarios");

        }

        protected async Task Cancelar()
        {
            navigationManager.NavigateTo("/Usuarios");
        }


    }
}
