using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Seguridad
{
    public class PersonaSetting : EntidadBaseSetting, 
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            // Propiedades
            builder.Property(x => x.Apellido)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Nombre)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Telefono)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.Direccion)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(x => x.Foto)
                .IsRequired();

            builder.Property(x => x.Mail)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.FechaNacimiento)
                .IsRequired();

            builder.Property(x => x.Cuil)
                .HasMaxLength(13)
                .IsRequired();

            // Propiedades de Navegacion
            builder.HasMany(x => x.Usuarios)
                .WithOne(x => x.Persona)
                .HasForeignKey(x => x.PersonaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.EmpresaPersonas)
                .WithOne(x => x.Persona)
                .HasForeignKey(x => x.PersonaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.CajaDetalleAperturas)
                .WithOne(x => x.PersonaApertura)
                .HasForeignKey(x => x.PersonaAperturaId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.CajaDetalleCierres)
                .WithOne(x => x.PersonaCierre)
                .HasForeignKey(x => x.PersonaCierreId)
                .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasMany(x => x.Comprobantes)
                .WithOne(x => x.Persona)
                .HasForeignKey(x => x.PersonaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
