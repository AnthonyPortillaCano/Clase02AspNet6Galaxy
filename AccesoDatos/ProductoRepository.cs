using AccesoDatos.EFCore;
using AccesoDatos.EFCore.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProductoRepository : RepositoryEF<Producto>, IProductoRepository
    {
        public ProductoRepository(DbContext context) : base(context)
        {
            repositoryEF = new RepositoryEF<Producto>(context);
        }
        public IRepositoryEF<Producto> repositoryEF { get; set; }

        public async Task<List<Producto>> GetAll()
        {
            return await repositoryEF.GetAll();
        }
        public async Task<Producto> GetById(int id)
        {
            return await repositoryEF.GetEntityByIdAsync(id);
        }
        public void Insert(Producto producto)
        {
            repositoryEF.Insert(producto);
        }
        public void Update(Producto producto)
        {
            repositoryEF.Update(producto);
        }
        public async Task Delete(int id)
        {
            Producto producto = await repositoryEF.GetEntityByIdAsync(id);  
            repositoryEF.Delete(producto);
        }

    }
}
