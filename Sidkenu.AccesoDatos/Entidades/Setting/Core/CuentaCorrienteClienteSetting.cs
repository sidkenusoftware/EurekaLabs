using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class CuentaCorrienteClienteSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<CuentaCorrienteCliente>
    {
        public void Configure(EntityTypeBuilder<CuentaCorrienteCliente> builder)
        {
            // Propiedades

            builder.Property(x => x.ClienteId)
                .IsRequired();

            builder.Property(x => x.Fecha)
                .IsRequired();

            builder.Property(x => x.FechaVencimiento)
                .IsRequired(false);

            builder.Property(x => x.NroComprobanteFactura)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.TipoMovimiento)
                .IsRequired();

            builder.Property(x => x.Monto).HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.Observacion)
                .IsRequired(false);

            // Propiedades de Navegacion

            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.CuentaCorrienteClientes)
                .HasForeignKey(x => x.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}