using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class OrdenFabricacionSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<OrdenFabricacion>
    {
        public void Configure(EntityTypeBuilder<OrdenFabricacion> builder)
        {
            // Propiedades

            builder.Property(x => x.Fecha)
                .IsRequired();

            builder.Property(x => x.Numero)
                .IsRequired();

            builder.Property(x => x.DepositoDestinoId)
                .IsRequired();

            builder.Property(x => x.DepositoOrigenId)
                .IsRequired();

            builder.Property(x => x.EmpresaId)
                .IsRequired();

            builder.Property(x => x.ArticuloBaseId)
                .IsRequired();

            builder.Property(x => x.EstadoOrdenFabricacion)
                .IsRequired();

            builder.Property(x => x.ActulizarPrecioPublico)
                .IsRequired();

            builder.Property(x => x.FechaFinalizacion)
                .IsRequired(false);

            // Propiedades de Navegacion

            builder.HasOne(x => x.DepositoDestino)
                .WithMany(x => x.OrdenFabricacionDestinos)
                .HasForeignKey(x => x.DepositoDestinoId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.DepositoOrigen)
                .WithMany(x => x.OrdenFabricacionOrigenes)
                .HasForeignKey(x => x.DepositoOrigenId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.OrdenFabricaciones)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.OrdenFabricacionDetalles)
                .WithOne(x => x.OrdenFabricacion)
                .HasForeignKey(x => x.OrdenFabricacionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ArticuloBase)
                .WithMany(x => x.OrdenFabricaciones)
                .HasForeignKey(x => x.ArticuloBaseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}