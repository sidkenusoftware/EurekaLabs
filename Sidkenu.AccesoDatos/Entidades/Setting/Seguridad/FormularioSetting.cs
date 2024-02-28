using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Seguridad
{
    public class FormularioSetting : EntidadBaseSetting, 
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Formulario>
    {
        public void Configure(EntityTypeBuilder<Formulario> builder)
        {
            // Propiedades
            builder.Property(x => x.Codigo)
                .IsRequired();

            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.DescripcionCompleta)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.EstaVigente)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasMany(x => x.GruposFormularios)
                .WithOne(x => x.Formulario)
                .HasForeignKey(x => x.FormularioId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
