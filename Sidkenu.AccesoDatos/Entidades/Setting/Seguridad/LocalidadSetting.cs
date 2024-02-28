using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Seguridad
{
    public class LocalidadSetting : EntidadBaseSetting, 
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Localidad>
    {
        public void Configure(EntityTypeBuilder<Localidad> builder)
        {
            // Propiedades
            builder.Property(x => x.ProvinciaId)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            // Propiedades de Navegacion
            builder.HasMany(x => x.Empresas)
                .WithOne(x => x.Localidad)
                .HasForeignKey(x => x.LocalidadId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Provincia)
                .WithMany(x => x.Localidades)
                .HasForeignKey(x => x.ProvinciaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
