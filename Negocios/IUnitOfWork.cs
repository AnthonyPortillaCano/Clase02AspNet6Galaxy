using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public interface IUnitOfWork
    {
         IProductoNegocio productoNegocio { get;  }
         IPersonaNegocio personaNegocio { get;  }

        Task<int> CommitAsync();
    }
}
