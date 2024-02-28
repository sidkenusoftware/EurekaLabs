using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Base;

namespace Sidkenu.AccesoDatos.Entidades.Setting.Seguridad
{
    public class EmpresaSetting : EntidadBaseSetting, 
        Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            // Propiedades
            builder.Property(x => x.IngresoBrutoId)
                .IsRequired();

            builder.Property(x => x.TipoResponsabilidadId)
                .IsRequired();

            builder.Property(x => x.LocalidadId)
                .IsRequired();

            builder.Property(x => x.Codigo)
                .IsRequired();

            builder.Property(x => x.Abreviatura)
                .HasMaxLength(10)
                .IsRequired(false);

            builder.Property(x => x.Descripcion)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Telefono)
                .HasMaxLength(150)
                .IsRequired(false);

            builder.Property(x => x.Direccion)
                .HasMaxLength(300)
                .IsRequired(false);

            builder.Property(x => x.Referente)
                .HasMaxLength(150)
                .IsRequired(false);

            builder.Property(x => x.Logo)
                .IsRequired();

            builder.Property(x => x.Mail)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.FechaInicioActividad)
                .IsRequired();

            builder.Property(x => x.NroIngresoBruto)
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(x => x.Cuit)
                .HasMaxLength(13)
                .IsRequired();

            // Propiedades de Navegacion

            builder.HasOne(x => x.TipoResponsabilidad)
                .WithMany(x => x.Empresas)
                .HasForeignKey(x => x.TipoResponsabilidadId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Localidad)
                .WithMany(x => x.Empresas)
                .HasForeignKey(x => x.LocalidadId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.IngresoBruto)
                .WithMany(x => x.Empresas)
                .HasForeignKey(x => x.IngresoBrutoId)
                .OnDelete(DeleteBehavior.Restrict);



            builder.HasMany(x => x.EmpresasPersonas)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Grupos)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Modulos)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Depositos)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Cajas)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.TipoGastos)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Gastos)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Articulos)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Articulos)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Familias)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Marcas)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.UnidadMedidas)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Clientes)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.CondicionIvas)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.ListaPrecios)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Proveedores)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.MotivoBajas)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Salones)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.FamiliaListaPrecios)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.MarcaListaPrecios)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.OrdenFabricaciones)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Comprobantes)
                .WithOne(x => x.Empresa)
                .HasForeignKey(x => x.EmpresaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
