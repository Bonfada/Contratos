using Contratos.Services.Dtos;
using System.Collections.Generic;

namespace Contratos.Services.Interfaces
{
    public interface IContratoService
    {
        void Add(ContratoDTO contrato);
        void Edit(ContratoDTO cliente);
        void Delete(ContratoDTO cliente);
        ContratoDTO GetById(int id);
        IEnumerable<ContratoDTO> Buscar();
    }
}
