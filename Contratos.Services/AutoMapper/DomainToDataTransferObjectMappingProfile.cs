using AutoMapper;
using Contratos.Domain.Entities;
using Contratos.Services.Dtos;

namespace Contratos.Services.AutoMapper
{
    public class DomainToDataTransferObjectMappingProfile : Profile
    {
        public DomainToDataTransferObjectMappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<Contrato, ContratoDTO>();
        }
    }
}
