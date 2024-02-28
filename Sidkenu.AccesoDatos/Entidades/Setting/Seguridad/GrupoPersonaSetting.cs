using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Seguridad
{
    public class GrupoPersonaSetting : EntidadBaseSetting, 
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<GrupoPersona>
    {
        public void Configure(EntityTypeBuilder<GrupoPersona> builder)
        {
            // Propiedades
            builder.Property(x => x.GrupoId)
                .IsRequired();

            builder.Property(x => x.PersonaId)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.Grupo)
                .WithMany(x => x.GrupoPersonas)
                .HasForeignKey(x => x.GrupoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Persona)
                .WithMany(x => x.GrupoPersonas)
                .HasForeignKey(x => x.PersonaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
