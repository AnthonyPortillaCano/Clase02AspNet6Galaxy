using AccesoDatos.EFCore.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly BDEmpresaContext _context;
        protected readonly string _connectionString;
        public UnitOfWork(BDEmpresaContext context, string connectionString)
        {
            _context = context;
            productoNegocio = new ProductoNegocio(_context);
            _connectionString = connectionString;
            personaNegocio = new PersonaNegocio(_connectionString);
        }

        public IProductoNegocio productoNegocio { get; private set; }
        public IPersonaNegocio personaNegocio { get; private set; }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
