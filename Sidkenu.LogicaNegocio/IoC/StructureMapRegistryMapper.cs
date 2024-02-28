using AutoMapper;
using Sidkenu.Servicio.Mapper;
using StructureMap;

namespace Sidkenu.LogicaNegocio.IoC
{
    public class StructureMapRegistryMapper : Registry
    {
        public StructureMapRegistryMapper()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<SeguridadAutoMapperProfile>();
                cfg.AddProfile<CoreAutoMapperProfile>();
            });

            For<IMapper>().Use(mapperConfiguration.CreateMapper());
        }
    }
}
