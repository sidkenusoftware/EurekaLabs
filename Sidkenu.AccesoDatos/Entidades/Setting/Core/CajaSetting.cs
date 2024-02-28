using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class CajaSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Caja>
    {
        public void Configure(EntityTypeBuilder<Caja> builder)
        {
            // Propiedades

            builder.Property(x => x.EmpresaId)
                .IsRequired();

            builder.Property(x => x.Abreviatura)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.PermiteGastos)
                .IsRequired();

            builder.Property(x => x.PermitePagosProveedor)
                .IsRequired();

            builder.Property(x => x.AceptaMedioPagoEfectivo)
                .IsRequired();

            builder.Property(x => x.AceptaMedioPagoCheque)
                .IsRequired();

            builder.Property(x => x.AceptaMedioPagoTarjeta)
                .IsRequired();

            builder.Property(x => x.AceptaMedioPagoTransferencia)
                .IsRequired();

            builder.Property(x => x.AceptaMedioPagoCtaCte)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Cajas)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.CajaDetalles)
                .WithOne(x => x.Caja)
                .HasForeignKey(x => x.CajaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.FamiliaCajas)
                .WithOne(x => x.Caja)
                .HasForeignKey(x => x.CajaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Puestos)
                .WithOne(x => x.Caja)
                .HasForeignKey(x => x.CajaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}