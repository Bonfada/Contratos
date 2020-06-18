using Contratos.Services.Dtos;
using System.Collections.Generic;

namespace Contratos.Services.Interfaces
{
    public interface IContratoService
    {
        void Add(ContratoDTO contrato);
        IEnumerable<ContratoDTO> Buscar();
    }
}
