using Microsoft.EntityFrameworkCore;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Constantes;

namespace Sidkenu.Infraestructura
{
    public static class SemillaCargaInicial
    {
        public static void Crear(this ModelBuilder modelBuilder)
        {
            // ===================================================================================== //
            // =====================             Tipos de Documentos              ================== //
            // ===================================================================================== //

            var tipoDocumentoSinIdentificacion = new TipoDocumento
            {
                Id = Guid.NewGuid(),
                Descripcion = "Sin Identificación",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoDocumento>().HasData(tipoDocumentoSinIdentificacion);

            var tipoDocumentoCuit = new TipoDocumento
            {
                Id = Guid.NewGuid(),
                Descripcion = "CUIT",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoDocumento>().HasData(tipoDocumentoCuit);

            var tipoDocumentoCuil = new TipoDocumento
            {
                Id = Guid.NewGuid(),
                Descripcion = "CUIL",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoDocumento>().HasData(tipoDocumentoCuil);

            var tipoDocumentoDni = new TipoDocumento
            {
                Id = Guid.NewGuid(),
                Descripcion = "DNI",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoDocumento>().HasData(tipoDocumentoDni);

            var tipoDocumentoPasaporte = new TipoDocumento
            {
                Id = Guid.NewGuid(),
                Descripcion = "Pasaporte",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoDocumento>().HasData(tipoDocumentoPasaporte);

            var tipoDocumentoLibretaCivica = new TipoDocumento
            {
                Id = Guid.NewGuid(),
                Descripcion = "Libreta Civica",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoDocumento>().HasData(tipoDocumentoLibretaCivica);

            var tipoDocumentoLibretaEnrole = new TipoDocumento
            {
                Id = Guid.NewGuid(),
                Descripcion = "Libreta Enrole",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoDocumento>().HasData(tipoDocumentoLibretaEnrole);

            // ===================================================================================== //
            // =====================                   Provincia                  ================== //
            // ===================================================================================== //

            var provinciaTucuman = new Provincia
            {
                Id = Guid.NewGuid(),
                Descripcion = "Tucuman",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<Provincia>().HasData(provinciaTucuman);

            // ===================================================================================== //
            // =====================                   Localidad                  ================== //
            // ===================================================================================== //

            var localidadSanTucuman = new Localidad
            {
                Id = Guid.NewGuid(),
                ProvinciaId = provinciaTucuman.Id,
                Descripcion = "San Miguel de Tucuman",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<Localidad>().HasData(localidadSanTucuman);

            // ===================================================================================== //
            // =====================                  Condicion de Iva            ================== //
            // ===================================================================================== //

            var tipoResponsabilidadIvaRespNoInscrip = new TipoResponsabilidad
            {
                Id = Guid.NewGuid(),
                Codigo = 1,
                Descripcion = "IVA Responsable No Inscripto",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoResponsabilidad>().HasData(tipoResponsabilidadIvaRespNoInscrip);

            var tipoResponsabilidadIvaSujetoExento = new TipoResponsabilidad
            {
                Id = Guid.NewGuid(),
                Codigo = 4,
                Descripcion = "IVA Sujeto Exento",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoResponsabilidad>().HasData(tipoResponsabilidadIvaSujetoExento);

            var tipoResponsabilidadConsumidorFinal = new TipoResponsabilidad
            {
                Id = Guid.NewGuid(),
                Codigo = 5,
                Descripcion = "Consumidor Final",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoResponsabilidad>().HasData(tipoResponsabilidadConsumidorFinal);

            var tipoResponsabilidadResponsableMonotributo = new TipoResponsabilidad
            {
                Id = Guid.NewGuid(),
                Codigo = 6,
                Descripcion = "Responsable Monotributo",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoResponsabilidad>().HasData(tipoResponsabilidadResponsableMonotributo);

            var tipoResponsabilidadProveedorDelExterior = new TipoResponsabilidad
            {
                Id = Guid.NewGuid(),
                Codigo = 8,
                Descripcion = "Proveedor del Exterior",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoResponsabilidad>().HasData(tipoResponsabilidadProveedorDelExterior);

            var tipoResponsabilidadClienteDelExterior = new TipoResponsabilidad
            {
                Id = Guid.NewGuid(),
                Codigo = 9,
                Descripcion = "Cliente del Exterior",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoResponsabilidad>().HasData(tipoResponsabilidadClienteDelExterior);

            var tipoResponsabilidadIvaLiberado = new TipoResponsabilidad
            {
                Id = Guid.NewGuid(),
                Codigo = 10,
                Descripcion = "IVA Liberado - Ley 19.640",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoResponsabilidad>().HasData(tipoResponsabilidadIvaLiberado);

            var tipoResponsabilidadMonotributistaSocial = new TipoResponsabilidad
            {
                Id = Guid.NewGuid(),
                Codigo = 13,
                Descripcion = "Monotributista Social",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoResponsabilidad>().HasData(tipoResponsabilidadMonotributistaSocial);

            var tipoResponsabilidadIvaNoAlcanzado = new TipoResponsabilidad
            {
                Id = Guid.NewGuid(),
                Codigo = 15,
                Descripcion = "IVA No Alcanzado",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<TipoResponsabilidad>().HasData(tipoResponsabilidadIvaNoAlcanzado);

            // ===================================================================================== //
            // =====================                   Cliente                    ================== //
            // ===================================================================================== //

            var clienteConsumidorFinal = new Cliente
            {
                Id = Guid.NewGuid(),
                RazonSocial = "Consumidor Final",
                ActivarBonificacion = false,
                ActivarCuentaCorriente = false,
                Bonificacion = 0,
                Direccion = "Libertad",
                Documento = ClientePorDefecto.NumeroDocumentoConsumidorFinal,
                FechaNacimiento = new DateTime(1900, 1, 1,0,0,0),
                Mail = "consumidorfinal@gmail.com",
                MontoMaximoCompra = 0,
                TipoDocumentoId = tipoDocumentoDni.Id,
                TipoResponsabilidadId = tipoResponsabilidadConsumidorFinal.Id,
                Telefono = "9999999",                
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<Cliente>().HasData(clienteConsumidorFinal);

            // ===================================================================================== //
            // =====================                 Ingreso Bruto                ================== //
            // ===================================================================================== //

            var ingresoBrutoSimplificado = new IngresoBruto
            {
                Id = Guid.NewGuid(),
                Descripcion = "Simplificado",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<IngresoBruto>().HasData(ingresoBrutoSimplificado);

            var ingresoBrutoLocal = new IngresoBruto
            {
                Id = Guid.NewGuid(),
                Descripcion = "Local ",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<IngresoBruto>().HasData(ingresoBrutoLocal);

            var ingresoBrutoConvenioMultilateral = new IngresoBruto
            {
                Id = Guid.NewGuid(),
                Descripcion = "Convenio Multilateral",
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<IngresoBruto>().HasData(ingresoBrutoConvenioMultilateral);

            // ===================================================================================== //
            // =====================                 Alicuota Iva                 ================== //
            // ===================================================================================== //

            var alicuotaIva0 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "0",
                Descripcion = "No Corresponde",
                Valor = 0,
                AplicaParaFacturaElectronica = false,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva0);

            var alicuotaIva1 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "1",
                Descripcion = "No Gravado",
                Valor = 0,
                AplicaParaFacturaElectronica = true,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva1);

            var alicuotaIva2 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "2",
                Descripcion = "Exento",
                Valor = 0,
                AplicaParaFacturaElectronica = true,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva2);

            var alicuotaIva3 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "3",
                Descripcion = "0 %",
                Valor = 0,
                AplicaParaFacturaElectronica = true,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva3);

            var alicuotaIva4 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "4",
                Descripcion = "10,50 %",
                Valor = 10.5m,
                AplicaParaFacturaElectronica = true,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva4);

            var alicuotaIva5 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "5",
                Descripcion = "21 %",
                Valor = 21m,
                AplicaParaFacturaElectronica = true,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva5);

            var alicuotaIva6 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "6",
                Descripcion = "27 %",
                Valor = 27m,
                AplicaParaFacturaElectronica = true,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva6);

            var alicuotaIva7 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "7",
                Descripcion = "Gravado",
                Valor = 0,
                AplicaParaFacturaElectronica = true,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva7);

            var alicuotaIva8 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "8",
                Descripcion = "5 %",
                Valor = 5,
                AplicaParaFacturaElectronica = true,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva8);

            var alicuotaIva9 = new CondicionIva
            {
                Id = Guid.NewGuid(),
                Codigo = "9",
                Descripcion = "2,50 %",
                Valor = 2.5m,
                AplicaParaFacturaElectronica = true,
                User = "semilla@tsidkenu.com",
                EstaEliminado = false,
            };

            modelBuilder.Entity<CondicionIva>().HasData(alicuotaIva9);

            // ===================================================================================== //
            // =====================                Configuración                 ================== //
            // ===================================================================================== //

            var configuracionGeneral = new ConfiguracionSeguridad
            {
                Id = Guid.NewGuid(),

                LogInformacion = true,
                LogError = true,
                LogWarning = true,

                LoginNormal = false,

                Host = MailOptions.Host,
                Puerto = MailOptions.Puerto,
                PasswordCredencial = MailOptions.PasswordCredencialMail,
                UsuarioCredencial = MailOptions.UsuarioCredencialMail,

                EnviarMailCreateUsuario = true,

                EstaEliminado = false,
                User = "semilla@tsidkenu.com",
            };

            modelBuilder.Entity<ConfiguracionSeguridad>().HasData(configuracionGeneral);

            // ===================================================================================== //
            // =====================           Variante Por Defecto               ================== //
            // ===================================================================================== //

            var varianteDefault = new Variante
            {
                Id = Guid.NewGuid(),
                Codigo = VarianteDefecto.VarianteCodigo,
                Descripcion = "Variante Defecto",
                EstaEliminado = false,
                User = "semilla@tsidkenu.com",                
            };

            modelBuilder.Entity<Variante>().HasData(varianteDefault);

            var varianteValorDefault = new VarianteValor
            {
                Id = Guid.NewGuid(),
                Codigo = VarianteDefecto.VarianteValorCodigo,
                Descripcion = "Variante Valor Defecto",
                EstaEliminado = false,
                User = "semilla@tsidkenu.com",
                VarianteId = varianteDefault.Id,
            };

            modelBuilder.Entity<VarianteValor>().HasData(varianteValorDefault);
        }
    }
}
