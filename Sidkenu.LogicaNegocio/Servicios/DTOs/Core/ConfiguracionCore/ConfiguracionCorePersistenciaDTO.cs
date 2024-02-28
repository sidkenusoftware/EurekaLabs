﻿using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;

namespace Sidkenu.LogicaNegocio.Servicios.DTOs.Core.ConfiguracionCore
{
    public class ConfiguracionCorePersistenciaDTO 
    {
        public Guid Id { get; set; }
        public Guid EmpresaId { get; set; }
        public bool ActivarAumentoPrecioPorMarca { get; set; }
        public bool ActivarAumentoPrecioPorFamilia { get; set; }
        public bool ActivarAumentoPrecioPorMarcaListaPrecio { get; set; }
        public bool ActivarAumentoPrecioPorFamiliaListaPrecio { get; set; }

        public Guid ListaPrecioPorDefectoParaVentaId { get; set; }

        public Guid DepositoPorDefectoParaVentaId { get; set; }
        public Guid DepositoPorDefectoParaCompraId { get; set; }

        public bool ActivarStockPorVencimientoLote { get; set; }
        public bool ActualizarPrecioFinalizarLaFabricacion { get; set; }
        public bool IncorporarCostoFabricacion { get; set; }
        public decimal? CantidadAproximadaFabricacionArticulos { get; set; }

        public bool PedirAutorizacionParaArticulos { get; set; }
        public Guid? PersonaQueAutorizaId  { get; set; }
        public bool PedirAutorizacionParaDescuentos { get; set; }
        public decimal DescuentoMaximo { get; set; }

        public bool UnificarRenglonesIngresarMismoArticulo { get; set; }

        public bool SepararPuntoVentaCaja { get; set; }
        public bool ActivarCobroConTicketCaja { get; set; }
        // -------------------------------------------------------- //

        public bool ActivarInteresPorTransferencia { get; set; }
        public decimal? InteresPorTransferencia { get; set; }

        // -------------------------------------------------------- //

        public bool ActivarInteresPorCheque { get; set; }
        public decimal? InteresPorCheque { get; set; }
    }
}
