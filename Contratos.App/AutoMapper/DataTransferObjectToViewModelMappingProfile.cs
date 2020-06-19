using AutoMapper;
using Contratos.App.ViewModels;
using Contratos.Services.Dtos;
using Contratos.Services.Util;


namespace Contratos.App.AutoMapper
{
    public class DataTransferObjectToViewModelMappingProfile : Profile
    {
        public DataTransferObjectToViewModelMappingProfile()
        {
            CreateMap<UsuarioViewModel, UsuarioDTO>()
                .ForMember(dest => dest.Senha, opt => opt.MapFrom(src => Hash.GerarHash(src.Senha)));

            CreateMap<ClienteViewModel, ClienteDTO>();
            CreateMap<ContratoViewModel, ContratoDTO>();
        }
    }
}