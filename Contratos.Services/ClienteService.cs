using AutoMapper;
using Contratos.Repositories.Interfaces;
using Contratos.Services.Dtos;
using Contratos.Services.Interfaces;
using System.Collections.Generic;

namespace Contratos.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(
            IMapper mapper, 
            IClienteRepository usuarioRepository)
        {
            _mapper = mapper;
            _clienteRepository = usuarioRepository;
        }

        public void Add(ClienteDTO contrato)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClienteDTO> List()
        {
            throw new System.NotImplementedException();
        }
    }
}
