using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ClienteSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Propiedades
            builder.Property(x => x.EmpresaId)
                .IsRequired(false);

            builder.Property(x => x.ListaPrecioId)
                .IsRequired(false);

            builder.Property(x => x.TipoDocumentoId)
                .IsRequired();

            builder.Property(x => x.TipoResponsabilidadId)
                .IsRequired();

            builder.Property(x => x.RazonSocial)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(x => x.Telefono)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Direccion)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(x => x.Mail)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.FechaNacimiento)
                .IsRequired();

            builder.Property(x => x.Documento)
                .HasMaxLength(13)
                .IsRequired();

            builder.Property(x => x.ActivarCuentaCorriente)
                .IsRequired();

            builder.Property(x => x.MontoMaximoCompra).HasPrecision(18, 6)
                .IsRequired(false);


            builder.Property(x => x.ActivarBonificacion)
                .IsRequired();

            builder.Property(x => x.Bonificacion).HasPrecision(18, 6)
                .IsRequired(false);

            // Propiedades de Navegacion
            builder.HasMany(x => x.CuentaCorrienteClientes)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Clientes)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TipoDocumento)
                .WithMany(x => x.Clientes)
                .HasForeignKey(x => x.TipoDocumentoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TipoResponsabilidad)
                .WithMany(x => x.Clientes)
                .HasForeignKey(x => x.TipoResponsabilidadId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ListaPrecio)
                .WithMany(x => x.Clientes)
                .HasForeignKey(x => x.ListaPrecioId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Comprobantes)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
