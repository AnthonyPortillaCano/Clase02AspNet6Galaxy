using AccesoDatos.EFCore.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public interface IProductoNegocio
    {
        Task<List<Producto>> GetProductos();
        Task<Producto> GetProductoPorId(int id);

        void InsertProducto(Producto producto);

        void UpdateProducto(Producto producto);

         Task DeleteProducto(int id);
    }
}
