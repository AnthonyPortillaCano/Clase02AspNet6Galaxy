using AccesoDatos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public interface IPersonaNegocio
    {
        Task<List<PersonaDto>> ListarPersona();
    }
}
