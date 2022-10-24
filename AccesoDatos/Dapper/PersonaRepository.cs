using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Dapper
{
    public class PersonaRepository: IPersonaRepository
    {
        protected readonly string _connectionString;
        public PersonaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<List<PersonaDto>> ListarPersona()
        {
            try
            {
                List<PersonaDto> listPersona = new();
                using var connection = new SqlConnection(_connectionString);
                await connection.OpenAsync();
                var resultado = await connection.QueryAsync<PersonaDto>("sp_ListaPersona", CommandType.StoredProcedure);
                listPersona = resultado.Cast<PersonaDto>().ToList();
                await connection.CloseAsync();
                return listPersona;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
