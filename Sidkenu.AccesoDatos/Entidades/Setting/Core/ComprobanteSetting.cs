using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ComprobanteSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Comprobante>
    {
        public void Configure(EntityTypeBuilder<Comprobante> builder)
        {
            // Propiedades
            builder.Property(x => x.EmpresaId)
                .IsRequired();

            builder.Property(x => x.PersonaId)
                .IsRequired();

            builder.Property(x => x.ClienteId)
                .IsRequired();

            builder.Property(x => x.Fecha)
                .IsRequired();

            builder.Property(x => x.Numero)
                .IsRequired(false);

            builder.Property(x => x.SubTotal)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.Descuento)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.Total)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(x => x.TipoComprobante)
                .IsRequired();

            builder.Property(x => x.EstadoComprobante)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Comprobantes)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Persona)
                .WithMany(x => x.Comprobantes)
                .HasForeignKey(x => x.PersonaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Comprobantes)
                .HasForeignKey(x => x.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Totales)
                .WithOne(x => x.Comprobante)
                .HasForeignKey(x => x.ComprobanteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.MedioPagos)
               .WithOne(x => x.Comprobante)
               .HasForeignKey(x => x.ComprobanteId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
