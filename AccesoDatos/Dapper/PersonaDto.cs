using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Dapper
{
    public class PersonaDto
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; }

        public int Edad { get; set; }
    }
}
