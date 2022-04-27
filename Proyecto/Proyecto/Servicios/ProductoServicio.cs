using Datos.Interfaces;
using Datos.Repositorios;
using Modelos;
using Proyecto.Data;
using Proyecto.Interfaces;
using Proyecto.Pages.Productos;

namespace Proyecto.Servicios
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly MySQLConfiguration _configuration;
        private IProductoRepositorio usuarioRepositorio;

        public ProductoServicio(MySQLConfiguration configuration)
        {
            _configuration = configuration;
            usuarioRepositorio = new ProductoRepositorio(configuration.CadenaConexion);
        }

        public async Task<bool> Actualizar(Productos1 producto)
        {
            return await usuarioRepositorio.Actualizar(producto);
        }

        public async Task<bool> Eliminar(Productos1 producto)
        {
            return await usuarioRepositorio.Eliminar(producto);
        }

        public async Task<IEnumerable<Productos1>> GetLista()
        {
            return await usuarioRepositorio.GetLista();
        }

        public async Task<Productos1> GetPorCodigo(string codigo)
        {
            return await usuarioRepositorio.GetPorCodigo(codigo);
        }

        public async Task<bool> Nuevo(Productos1 producto)
        {
            return await usuarioRepositorio.Nuevo(producto);
        }

        public Task<bool> Nuevo(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
