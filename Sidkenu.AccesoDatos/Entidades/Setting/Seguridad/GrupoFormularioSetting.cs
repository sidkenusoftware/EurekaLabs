using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Seguridad
{
    public class GrupoFormularioSetting : EntidadBaseSetting, 
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<GrupoFormulario>
    {
        public void Configure(EntityTypeBuilder<GrupoFormulario> builder)
        {
            // Propiedades
            builder.Property(x => x.GrupoId)
                .IsRequired();

            builder.Property(x => x.FormularioId)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Grupo)
                .WithMany(x => x.GrupoFormularios)
                .HasForeignKey(x => x.GrupoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Formulario)
                .WithMany(x => x.GruposFormularios)
                .HasForeignKey(x => x.FormularioId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
