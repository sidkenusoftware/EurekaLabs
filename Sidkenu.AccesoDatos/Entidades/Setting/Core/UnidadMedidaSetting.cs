using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class UnidadMedidaSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<UnidadMedida>
    {
        public void Configure(EntityTypeBuilder<UnidadMedida> builder)
        {
            // Propiedades
            builder.Property(x => x.EmpresaId)
                .IsRequired(false);

            builder.Property(x => x.Codigo)
            .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Equivalencia)
            .IsRequired();

            // Propiedades de Navegacion

            builder.HasMany(x => x.ArticulosVentas)
            .WithOne(x => x.UnidadMedidaVenta)
            .HasForeignKey(x => x.UnidadMedidaVentaId)
            .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.ArticulosCompras)
            .WithOne(x => x.UnidadMedidaCompra)
            .HasForeignKey(x => x.UnidadMedidaCompraId)
            .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.UnidadMedidas)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}