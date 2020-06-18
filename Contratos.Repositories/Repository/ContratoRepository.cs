using Contratos.Data.Contexto;
using Contratos.Domain.Entities;
using Contratos.Repositories.Base;
using Contratos.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Contratos.Repositories.Repository
{
    public class ContratoRepository : BaseRepository<Contrato>, IContratoRepository
    {
        public ContratoRepository(ContratosContexto context) : base(context) { }

        public IEnumerable<Contrato> Buscar()
        {
            return entidade.AsNoTracking().ToList();
        }
    }
}
