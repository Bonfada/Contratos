using Contratos.Domain.Entities;
using Contratos.Repositories.Base;
using System.Collections.Generic;

namespace Contratos.Repositories.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        IEnumerable<Usuario> Buscar();
    }
}
