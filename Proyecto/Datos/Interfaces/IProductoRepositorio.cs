using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IProductoRepositorio
    {
        Task<bool> Nuevo(Productos1 producto);
        Task<bool> Actualizar(Productos1 producto);
        Task<bool> Eliminar(Productos1 producto);
        Task<IEnumerable<Productos1>> GetLista();
        Task<Productos1> GetPorCodigo(string codigo);
    }
}
