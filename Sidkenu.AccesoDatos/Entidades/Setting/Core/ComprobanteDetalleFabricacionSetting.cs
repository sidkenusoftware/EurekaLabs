using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ComprobanteDetalleFabricacionSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ComprobanteDetalleFabricacion>
    {
        public void Configure(EntityTypeBuilder<ComprobanteDetalleFabricacion> builder)
        {
            // Propiedades
            builder.Property(x => x.ComprobanteDetalleId)
                .IsRequired();

            builder.Property(x => x.ArticuloId)
                .IsRequired();

            builder.Property(x => x.Codigo)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .IsRequired();

            builder.Property(x => x.PrecioPublico)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.Cantidad)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.SubTotal)
                .HasPrecision(18, 6)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.ComprobanteDetalle)
                .WithMany(x => x.Fabricaciones)
                .HasForeignKey(x => x.ComprobanteDetalleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
