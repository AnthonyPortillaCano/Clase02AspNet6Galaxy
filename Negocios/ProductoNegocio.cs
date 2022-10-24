using AccesoDatos;
using AccesoDatos.EFCore.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Negocios
{
    public class ProductoNegocio: IProductoNegocio
    {
        protected IProductoRepository _productoRepository;
        public ProductoNegocio(DbContext dbContext)
        {
            _productoRepository = new ProductoRepository(dbContext);
        }
         public async Task<List<Producto>> GetProductos()
        {
            return await _productoRepository.GetAll();
        }
        public async Task<Producto> GetProductoPorId(int id)
        {
            return await _productoRepository.GetById(id);
        }
        public  void InsertProducto(Producto producto)
        {
              _productoRepository.Insert(producto);
        }
        public void UpdateProducto(Producto producto)
        {
            _productoRepository.Update(producto);
        }
        public async Task DeleteProducto(int id)
        {
            await _productoRepository.Delete(id);
        }
    }
}