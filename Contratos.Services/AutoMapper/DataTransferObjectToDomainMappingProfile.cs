using AutoMapper;
using Contratos.Domain.Entities;
using Contratos.Services.Dtos;

namespace Contratos.Services.AutoMapper
{
    public class DataTransferObjectToDomainMappingProfile :Profile
    {
        public DataTransferObjectToDomainMappingProfile()
        {
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<ClienteDTO, Cliente>();

            CreateMap<ContratoDTO, Contrato>();
                
        }
    }
}
