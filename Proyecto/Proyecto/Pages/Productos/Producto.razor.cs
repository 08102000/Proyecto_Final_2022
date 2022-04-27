using Microsoft.AspNetCore.Components;
using Modelos;
using Proyecto.Interfaces;

namespace Proyecto.Pages.Productos
{
    partial class Producto
    {
        [Inject] private IProductoServicio _productoServicio { get; set; }

        private IEnumerable<Productos1> productoLista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            productoLista = (IEnumerable<Productos1>)(IEnumerable<Producto>)await _productoServicio.GetLista();
        }

    }
}
