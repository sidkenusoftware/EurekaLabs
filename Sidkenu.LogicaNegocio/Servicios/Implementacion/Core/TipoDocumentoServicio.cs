using AutoMapper;
using Sidkenu.Infraestructura;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.TipoDocumento;
using Sidkenu.LogicaNegocio.Servicios.Implementacion.Base;
using Sidkenu.LogicaNegocio.Servicios.Interface.Core;
using Sidkenu.LogicaNegocio.Servicios.Interface.Seguridad;
using System.Data.Entity;

namespace Sidkenu.LogicaNegocio.Servicios.Implementacion.Core
{
    public class TipoDocumentoServicio : ServicioBase, ITipoDocumentoServicio
    {
        public TipoDocumentoServicio(IMapper mapper,                                 
                                     IConfiguracionServicio configuracionServicio)
                                     : base(mapper, configuracionServicio)
        {
        }

        public ResultDTO GetAll()
        {
            using var _context = new DataContext();

            // using var transaction = _context.Database.BeginTransaction();

            try
            {
                var entities = _context.TipoDocumentos
                    .AsNoTracking()
                    .ToList();
                
                return new ResultDTO
                {
                    State = true,
                    Data = _mapper.Map<IEnumerable<TipoDocumentoDTO>>(entities)
                };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Message = ex.Message,
                    State = false
                };
            }
        }
    }
}
