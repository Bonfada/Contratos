using Contratos.Services.Dtos;
using System.Collections.Generic;

namespace Contratos.Services.Interfaces
{
    public interface IClienteService
    {
        void Add(ClienteDTO cliente);
        IEnumerable<ClienteDTO> List();
    }
}
