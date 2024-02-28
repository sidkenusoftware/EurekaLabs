using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ProveedorSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            // Propiedades

            builder.Property(x => x.EmpresaId)
                .IsRequired(false);

            builder.Property(x => x.Codigo)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.RazonSocial)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.CUIT)
                .HasMaxLength(13)
                .IsRequired();

            builder.Property(x => x.Direccion)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Telefono)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(x => x.Contacto)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.ActivarCuentaCorriente)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Empresa)
                .WithMany(x => x.Proveedores)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.TipoResponsabilidad)
                .WithMany(x => x.Proveedores)
                .HasForeignKey(x => x.TipoResponsabilidadId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ComprobantesCompras)
                .WithOne(x => x.Proveedor)
                .HasForeignKey(x => x.ProveedorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ArticuloProveedores)
                .WithOne(x => x.Proveedor)
                .HasForeignKey(x => x.ProveedorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}