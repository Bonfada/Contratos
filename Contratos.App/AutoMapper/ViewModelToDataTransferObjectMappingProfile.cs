using AutoMapper;
using Contratos.App.ViewModels;
using Contratos.Domain.Entities;
using Contratos.Services.Dtos;

namespace Contratos.App.AutoMapper
{
    public class ViewModelToDataTransferObjectMappingProfile :Profile
    {
        public ViewModelToDataTransferObjectMappingProfile()
        {
            CreateMap<UsuarioDTO, UsuarioViewModel >();
            CreateMap< ClienteDTO, ClienteViewModel >();
            CreateMap< ContratoDTO, ContratoViewModel >();
        }
    }
}