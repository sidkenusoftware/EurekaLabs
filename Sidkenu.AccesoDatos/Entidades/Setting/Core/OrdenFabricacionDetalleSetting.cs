using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class OrdenFabricacionDetalleSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<OrdenFabricacionDetalle>
    {
        public void Configure(EntityTypeBuilder<OrdenFabricacionDetalle> builder)
        {
            // Propiedades
            builder.Property(x => x.OrdenFabricacionId)
                .IsRequired();

            builder.Property(x => x.ArticuloId)
                .IsRequired();

            builder.Property(x => x.Codigo)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .IsRequired();

            builder.Property(x => x.Cantidad).HasPrecision(18, 6)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.OrdenFabricacion)
                .WithMany(x => x.OrdenFabricacionDetalles)
                .HasForeignKey(x => x.OrdenFabricacionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Articulo)
                .WithMany(x => x.OrdenFabricacionDetalles)
                .HasForeignKey(x => x.ArticuloId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}