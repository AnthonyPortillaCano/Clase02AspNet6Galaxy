using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Dapper
{
    public interface IPersonaRepository
    {
        Task<List<PersonaDto>> ListarPersona();
    }
}
