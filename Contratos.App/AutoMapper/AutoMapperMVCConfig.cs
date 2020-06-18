

using AutoMapper;

namespace Contratos.App.AutoMapper
{
    public class AutoMapperMVCConfig
    {
        public static void RegisterMappings()
        {
            var _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DataTransferObjectToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToDataTransferObjectMappingProfile());
            });
        }
    }
}