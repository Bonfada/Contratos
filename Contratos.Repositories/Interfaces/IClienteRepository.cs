using Contratos.Domain.Entities;
using Contratos.Repositories.Base;
using System.Collections.Generic;

namespace Contratos.Repositories.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        IEnumerable<Cliente> Buscar();
        
    }
}
