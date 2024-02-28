﻿using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.MotivoBaja
{
    public class MotivoBajaPersistenciaDTO : EntidadBaseDTO
    {
        public Guid? EmpresaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
