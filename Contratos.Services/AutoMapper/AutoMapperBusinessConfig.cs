using AutoMapper;

namespace Contratos.Services.AutoMapper
{
    public class AutoMapperBusinessConfig
    {
        public static IMapper MapperService { get; private set; }

        public static void RegisterMappings()
        {
            var _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToDataTransferObjectMappingProfile());
                cfg.AddProfile(new DataTransferObjectToDomainMappingProfile());
            });
            MapperService = _mapper.CreateMapper();
        }
    }
}
