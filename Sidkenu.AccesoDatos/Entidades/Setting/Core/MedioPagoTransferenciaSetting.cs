using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class MedioPagoTransferenciaSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<MedioPagoTransferencia>
    {
        public void Configure(EntityTypeBuilder<MedioPagoTransferencia> builder)
        {
            // Propiedades

            builder.Property(x => x.BancoId)
                .IsRequired();

            builder.Property(x => x.NombreTitular)
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(x => x.NumeroTransferencia)
                .HasMaxLength(50)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Banco)
                .WithMany(x => x.Transferencias)
                .HasForeignKey(x => x.BancoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}