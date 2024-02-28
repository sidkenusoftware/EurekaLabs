﻿using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Banco;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface IBancoServicio
    {
        ResultDTO Add(BancoPersistenciaDTO entidad, string user);
        ResultDTO Update(BancoPersistenciaDTO entidad, string user);
        ResultDTO Delete(BancoDeleteDTO deleteDTO, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(BancoFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);
        ResultDTO GetAll();
    }
}
