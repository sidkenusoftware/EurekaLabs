using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class MedioPagoTarjetaSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<MedioPagoTarjeta>
    {
        public void Configure(EntityTypeBuilder<MedioPagoTarjeta> builder)
        {
            // Propiedades

            builder.Property(x => x.PlanTarjetaId)
                .IsRequired();

            builder.Property(x => x.NumeroCupon)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.PlanTarjeta)
                .WithMany(x => x.MedioPagos)
                .HasForeignKey(x => x.PlanTarjetaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
