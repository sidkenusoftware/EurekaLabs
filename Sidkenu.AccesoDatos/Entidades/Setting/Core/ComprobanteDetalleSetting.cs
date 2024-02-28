using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ComprobanteDetalleSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ComprobanteDetalle>
    {
        public void Configure(EntityTypeBuilder<ComprobanteDetalle> builder)
        {
            // Propiedades
            builder.Property(x => x.ComprobanteId)
                .IsRequired();

            builder.Property(x => x.ArticuloId)
                .IsRequired(false);

            builder.Property(x => x.Codigo)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .IsRequired();

            builder.Property(x => x.Neto)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.Alicuota)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.Iva)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.Cantidad)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.SubTotal)
                .HasPrecision(18, 6)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Comprobante)
                .WithMany(x => x.Detalles)
                .HasForeignKey(x => x.ComprobanteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Articulo)
                .WithMany(x => x.Detalles)
                .HasForeignKey(x => x.ArticuloId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Fabricaciones)
                .WithOne(x => x.ComprobanteDetalle)
                .HasForeignKey(x => x.ComprobanteDetalleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
