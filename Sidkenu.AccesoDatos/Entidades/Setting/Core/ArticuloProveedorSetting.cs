using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Core
{
    public class ArticuloProveedorSetting : EntidadBaseSetting,
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<ArticuloProveedor>
    {
        public void Configure(EntityTypeBuilder<ArticuloProveedor> builder)
        {
            // Propiedades

            builder.Property(x => x.ArticuloId)
                .IsRequired();

            builder.Property(x => x.ProveedorId)
                .IsRequired();

            builder.Property(x => x.CodigoProveedor)
                .IsRequired(false);

            // Propiedades de Navegacion

            builder.HasOne(x => x.Articulo)
                .WithMany(x => x.ArticuloProveedores)
                .HasForeignKey(x => x.ArticuloId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Proveedor)
                .WithMany(x => x.ArticuloProveedores)
                .HasForeignKey(x => x.ProveedorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}