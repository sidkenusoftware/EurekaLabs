using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class CajaDetalleSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<CajaDetalle>
    {
        public void Configure(EntityTypeBuilder<CajaDetalle> builder)
        {
            // Propiedades

            builder.Property(x => x.CajaId)
                .IsRequired();

            builder.Property(x => x.MontoApertura).HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.FechaApertura)
                .IsRequired();

            builder.Property(x => x.PersonaAperturaId)
                .IsRequired();


            builder.Property(x => x.MontoCierre).HasPrecision(18, 6)
                .IsRequired(false);

            builder.Property(x => x.FechaCierre)
                .IsRequired(false);

            builder.Property(x => x.PersonaCierreId)
                .IsRequired(false);


            builder.Property(x => x.MontoSistema).HasPrecision(18, 6)
                .IsRequired(false);

            builder.Property(x => x.Diferencia).HasPrecision(18, 6)
                .IsRequired(false);

            builder.Property(x => x.EstadoCaja)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Caja)
                .WithMany(x => x.CajaDetalles)
                .HasForeignKey(x => x.CajaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.PersonaApertura)
                .WithMany(x => x.CajaDetalleAperturas)
                .HasForeignKey(x => x.PersonaAperturaId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.PersonaCierre)
                .WithMany(x => x.CajaDetalleCierres)
                .HasForeignKey(x => x.PersonaCierreId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.Movimientos)
                .WithOne(x => x.CajaDetalle)
                .HasForeignKey(x => x.CajaDetalleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}