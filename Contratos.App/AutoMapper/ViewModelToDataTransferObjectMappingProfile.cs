using AutoMapper;
using Contratos.Domain.Entities;
using Contratos.Services.Dtos;

namespace Contratos.App.AutoMapper
{
    public class ViewModelToDataTransferObjectMappingProfile :Profile
    {
        public ViewModelToDataTransferObjectMappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
        }
    }
}