using Contratos.Services.Dtos;
using System.Collections.Generic;

namespace Contratos.Services.Interfaces
{
    public interface IClienteService
    {
        void Add(ClienteDTO cliente);
        void Edit(ClienteDTO cliente);
        void Delete(ClienteDTO cliente);
        ClienteDTO GetById(int id);
        IEnumerable<ClienteDTO> List();
    }
}


