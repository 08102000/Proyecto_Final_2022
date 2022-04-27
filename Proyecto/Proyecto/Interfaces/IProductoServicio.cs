using Modelos;

namespace Proyecto.Interfaces
{
    public interface IProductoServicio
    {
        Task<bool> Nuevo(Productos1 producto);
        Task<bool> Actualizar(Productos1 producto);
        Task<bool> Eliminar(Productos1 producto);
        Task<IEnumerable<Productos1>> GetLista();
        Task<Productos1> GetPorCodigo(string codigo);
        Task<bool> Nuevo(Pages.Productos.Producto producto);
    }
}
