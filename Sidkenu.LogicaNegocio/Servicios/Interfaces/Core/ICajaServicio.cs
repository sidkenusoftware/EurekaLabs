using Sidkenu.LogicaNegocio.Servicios.DTOs.Base;
using Sidkenu.LogicaNegocio.Servicios.DTOs.Core.Caja;

namespace Sidkenu.LogicaNegocio.Servicios.Interface.Core
{
    public interface ICajaServicio
    {
        ResultDTO Add(CajaPersistenciaDTO entidad, string user);
        ResultDTO Update(CajaPersistenciaDTO entidad, string user);
        ResultDTO Delete(CajaDeleteDTO deleteDTO, string user);

        ResultDTO Transferir(CajaTransferenciaDTO cajaTransferencia, string user);

        // ================================================================= //

        ResultDTO GetById(Guid id);
        ResultDTO GetByFilter(CajaFilterDTO filter);
        ResultDTO GetAll(Guid empresaId);

        // ================================================================= //

        ResultDTO AbrirCaja(CajaAperturaDTO cajaAperturaDTO, string user);
        ResultDTO GetDetalle(Guid cajaId, DateTime fechaDesde, DateTime fechaHasta);
        ResultDTO GetDetalle(Guid cajaDetalleId);
        ResultDTO GetUltimaCajaAbierta(Guid empresaId);
        ResultDTO GetUltimaCajaAbierta(Guid empresaId, Guid cajaId);

        // ================================================================= //

        ResultDTO GetCajasParaHacerTransferencia(Guid empresaId);

        // ================================================================= //

        ResultDTO CerrarCaja(CajaCerrarDTO cajaCerrarDTO, string user);

        // ================================================================= //

        bool VerificarSiEstaAbiertaCaja(Guid empresaId);
        bool VerificarSiEstaAbiertaCaja(Guid empresaId, Guid cajaId);
        int ObtenerCantidadCajasAbiertas(Guid empresaId);
    }
}