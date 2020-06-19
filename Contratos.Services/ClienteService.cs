using AutoMapper;
using Contratos.Domain.Entities;
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

        public void Add(ClienteDTO cliente)
        {
            _clienteRepository.Add(_mapper.Map<Cliente>(cliente));
            _clienteRepository.Save();
        }

        public void Delete(ClienteDTO cliente)
        {
            var obj = _clienteRepository.GetById(cliente.Id);
            _clienteRepository.Delete(obj);
            _clienteRepository.Save();
        }

        public void Edit(ClienteDTO cliente)
        {
            _clienteRepository.Update(_mapper.Map<Cliente>(cliente));
            _clienteRepository.Save();
        }

        public ClienteDTO GetById(int id)
        {
            return _mapper.Map<ClienteDTO>(_clienteRepository.GetById(id));
        }

        public IEnumerable<ClienteDTO> List()
        {
            return _mapper.Map<IEnumerable<ClienteDTO>>(_clienteRepository.Buscar());
        }
    }
}
