using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private string CadenaConexion;

        public ProductoRepositorio(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }
        public async Task<bool> Actualizar(Productos1 producto)
        {
            int resultado;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "UPDATE producto SET Codigo = @Codigo, Descripcion = @Descripcion, Precio = @Precio, Existencia = @Existencia WHERE Codigo = @Codigo ;";
                resultado = await conexion.ExecuteAsync(sql, new
                {
                    producto.Codigo,
                    producto.Descripcion,
                    producto.Precio,
                    producto.Existencia
                    
                });
                return resultado > 0;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public async Task<bool> Eliminar(Productos1 producto)
        {
            int resultado;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "DELETE FROM producto WHERE Codigo = @Codigo;";
                resultado = await conexion.ExecuteAsync(sql, new { producto.Codigo });
                return resultado > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<IEnumerable<Productos1>> GetLista()
        {
            IEnumerable<Productos1> lista = new List<Productos1>();

            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT * FROM producto;";
                lista = await conexion.QueryAsync<Productos1>(sql);
            }
            catch (Exception ex)
            {
            }
            return lista;
        }
        public async Task<Productos1> GetPorCodigo(string codigo)
        {
            Productos1 user = new Productos1();
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT * FROM producto WHERE Codigo = @Codigo;";
                user = await conexion.QueryFirstAsync<Productos1>(sql, new { codigo });
            }
            catch (Exception ex)
            {

            }
            return user;
        }
        public async Task<bool> Nuevo(Productos1 producto)
        {
            int resultado;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "INSERT INTO producto (Codigo, Descripcion, Precio, Existencia) VALUES (@Codigo, @Descripcion, @Precio, @Existencia)";
                resultado = await conexion.ExecuteAsync(sql, producto);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

       
    }
}
