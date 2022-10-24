using AccesoDatos.EFCore.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public interface IProductoRepository
    {
        Task<List<Producto>> GetAll();

        Task<Producto> GetById(int id);

        void Insert(Producto producto);

        void Update(Producto producto);

        Task Delete(int id);
    }
}
