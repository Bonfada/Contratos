using Contratos.Data.Contexto;
using Contratos.Domain.Entities;
using Contratos.Repositories.Base;
using Contratos.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Contratos.Repositories.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ContratosContexto context) : base(context) { }

        public IEnumerable<Cliente> Buscar()
        {
            return entidade.AsNoTracking().ToList();
        }
    }
}
