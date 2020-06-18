using Contratos.Services.Dtos;
using System.Collections.Generic;

namespace Contratos.Services.Interfaces
{
    public interface IUsuarioService
    {
        void Add(UsuarioDTO contrato);
        IEnumerable<UsuarioDTO> List();
    }
}
