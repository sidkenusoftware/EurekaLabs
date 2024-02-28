using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ConfiguracionCoreSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ConfiguracionCore>
    {
        public void Configure(EntityTypeBuilder<ConfiguracionCore> builder)
        {
            // Propiedades

            builder.Property(x => x.EmpresaId)
                .IsRequired();

            builder.Property(x => x.DepositoPorDefectoParaVentaId)
                .IsRequired();

            builder.Property(x => x.DepositoPorDefectoParaCompraId)
                .IsRequired();

            builder.Property(x => x.ListaPrecioPorDefectoParaVentaId)
                .IsRequired();

            builder.Property(x => x.ActivarAumentoPrecioPorFamilia)
                .IsRequired();

            builder.Property(x => x.ActivarAumentoPrecioPorFamiliaListaPrecio)
                .IsRequired();

            builder.Property(x => x.ActivarAumentoPrecioPorMarca)
                .IsRequired();

            builder.Property(x => x.ActivarAumentoPrecioPorMarcaListaPrecio)
                .IsRequired();

            builder.Property(x => x.ActivarStockPorVencimientoLote)
                .IsRequired();

            builder.Property(x => x.ActualizarPrecioFinalizarLaFabricacion)
               .IsRequired();

            builder.Property(x => x.IncorporarCostoFabricacion)
               .IsRequired();

            builder.Property(x => x.CantidadAproximadaFabricacionArticulos)
               .IsRequired(false);

            builder.Property(x => x.UnificarRenglonesIngresarMismoArticulo)
               .IsRequired();

            builder.Property(x => x.SepararPuntoVentaCaja)
               .IsRequired();

            builder.Property(x => x.ActivarCobroConTicketCaja)
               .IsRequired();

            builder.Property(x => x.ActivarInteresPorTransferencia)
               .IsRequired();

            builder.Property(x => x.InteresPorTransferencia)
               .IsRequired();

            builder.Property(x => x.ActivarInteresPorCheque)
               .IsRequired();

            builder.Property(x => x.InteresPorCheque)
               .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.ConfiguracionCores)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.DepositoPorDefectoParaCompra)
                .WithMany(x => x.ConfiguracionCoreDepositoPorDefectoParaCompras)
                .HasForeignKey(x => x.DepositoPorDefectoParaCompraId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.DepositoPorDefectoParaVenta)
                .WithMany(x => x.ConfiguracionCoreDepositoPorDefectoParaVentas)
                .HasForeignKey(x => x.DepositoPorDefectoParaVentaId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.ListaPrecioPorDefectoParaVenta)
                .WithMany(x => x.ConfiguracionCoreListaPrecios)
                .HasForeignKey(x => x.ListaPrecioPorDefectoParaVentaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}