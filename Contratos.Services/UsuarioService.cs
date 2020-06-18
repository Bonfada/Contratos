using AutoMapper;
using Contratos.Domain.Entities;
using Contratos.Repositories.Interfaces;
using Contratos.Services.Dtos;
using Contratos.Services.Interfaces;
using System.Collections.Generic;

namespace Contratos.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(
            IMapper mapper,
            IUsuarioRepository usuarioRepository)
        {
            _mapper = mapper;
            _usuarioRepository = usuarioRepository;
        }

        public void Add(UsuarioDTO usuario)
        {
            _usuarioRepository.Add(_mapper.Map<Usuario>(usuario));
        }

        public IEnumerable<UsuarioDTO> Buscar()
        {
            return _mapper.Map<IEnumerable<UsuarioDTO>>(_usuarioRepository.Buscar());
        }
    }
}
