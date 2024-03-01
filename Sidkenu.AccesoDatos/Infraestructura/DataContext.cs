using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Sidkenu.AccesoDatos.CadenaConexion;
using Sidkenu.AccesoDatos.CadenaConexion.Constantes;
using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Core;
using Sidkenu.AccesoDatos.Entidades.Seguridad;
using Sidkenu.AccesoDatos.Entidades.Setting.Core;
using Sidkenu.AccesoDatos.Entidades.Setting.Seguridad;
using Sidkenu.Infraestructura;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace Sidkenu.AccesoDatos.Infraestructura
{
    public class DataContext : DbContext
    {
        private readonly IConexionServicio _conexionServicio;

        public DataContext()
        {
            _conexionServicio = new ConexionServicio();
        }

        public void RemoveLogic<T>(T entity, string user) where T : EntidadBase
        {
            entity.EstaEliminado = !entity.EstaEliminado;

            Entry(entity).State = EntityState.Modified;

            SaveChanges();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Add(_ => new BlankTriggerAddingConvention());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var cadenaConexion = _conexionServicio.ObtenerCadenaConexion(MotoBaseDatos.Obtener);

            // Conexion con el Motor de Base de Datos
            if (MotoBaseDatos.Obtener == TipoMotorBaseDatos.SqlServer)
            {
                optionsBuilder.UseSqlServer(cadenaConexion, op =>
                    {
                        op.CommandTimeout(60);
                        op.EnableRetryOnFailure();
                    });

                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            }
            else if (MotoBaseDatos.Obtener == TipoMotorBaseDatos.MySql)
            {
                optionsBuilder.UseMySql(cadenaConexion,
                    new MySqlServerVersion(new Version(8, 0, 30)), op =>
                    {
                        op.CommandTimeout(60);
                        op.EnableRetryOnFailure(
                            maxRetryCount: 5,
                            maxRetryDelay: TimeSpan.FromSeconds(30),
                            errorNumbersToAdd: null);
                    });
                optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Setting de Seguridad

            modelBuilder.ApplyConfiguration(new EmpresaSetting());
            modelBuilder.ApplyConfiguration(new ProvinciaSetting());
            modelBuilder.ApplyConfiguration(new LocalidadSetting());
            modelBuilder.ApplyConfiguration(new TipoResponsabilidadSetting());
            modelBuilder.ApplyConfiguration(new IngresoBrutoSetting());
            modelBuilder.ApplyConfiguration(new PersonaSetting());
            modelBuilder.ApplyConfiguration(new UsuarioSetting());
            modelBuilder.ApplyConfiguration(new EmpresaPersonaSetting());
            modelBuilder.ApplyConfiguration(new ConfiguracionSeguridadSetting());
            modelBuilder.ApplyConfiguration(new GrupoSetting());
            modelBuilder.ApplyConfiguration(new GrupoFormularioSetting());
            modelBuilder.ApplyConfiguration(new GrupoPersonaSetting());
            modelBuilder.ApplyConfiguration(new FormularioSetting());
            modelBuilder.ApplyConfiguration(new ModuloSetting());

            #endregion

            #region Setting de Core

            modelBuilder.ApplyConfiguration(new ArticuloSetting());
            modelBuilder.ApplyConfiguration(new ArticuloBajaSetting());
            modelBuilder.ApplyConfiguration(new ArticuloDepositoSetting());
            modelBuilder.ApplyConfiguration(new ArticuloFormulaSetting());
            modelBuilder.ApplyConfiguration(new ArticuloOpcionalSetting());
            modelBuilder.ApplyConfiguration(new ArticulokitSetting());
            modelBuilder.ApplyConfiguration(new ArticuloProveedorSetting());
            modelBuilder.ApplyConfiguration(new ArticuloHistorialCostoSetting());
            modelBuilder.ApplyConfiguration(new ArticuloPrecioSetting());
            modelBuilder.ApplyConfiguration(new CajaSetting());
            modelBuilder.ApplyConfiguration(new CajaDetalleSetting());
            modelBuilder.ApplyConfiguration(new ClienteSetting());
            modelBuilder.ApplyConfiguration(new CondicionIvaSetting());
            modelBuilder.ApplyConfiguration(new ContadorSetting());
            modelBuilder.ApplyConfiguration(new CuentaCorrienteClienteSetting());
            modelBuilder.ApplyConfiguration(new CuentaCorrienteProveedorSetting());
            modelBuilder.ApplyConfiguration(new DepositoSetting());
            modelBuilder.ApplyConfiguration(new FamiliaSetting());
            modelBuilder.ApplyConfiguration(new FamiliaCajaSetting());
            modelBuilder.ApplyConfiguration(new TipoGastoSetting());
            modelBuilder.ApplyConfiguration(new GastoSetting());
            modelBuilder.ApplyConfiguration(new ListaPrecioSetting());
            modelBuilder.ApplyConfiguration(new MarcaSetting());
            modelBuilder.ApplyConfiguration(new MesaSetting());
            modelBuilder.ApplyConfiguration(new MotivoBajaSetting());
            modelBuilder.ApplyConfiguration(new MovimientoCajaSetting());
            modelBuilder.ApplyConfiguration(new PlanTarjetaSetting());
            modelBuilder.ApplyConfiguration(new ProveedorSetting());
            modelBuilder.ApplyConfiguration(new SalonSetting());
            modelBuilder.ApplyConfiguration(new TarjetaSetting());
            modelBuilder.ApplyConfiguration(new TipoDocumentoSetting());
            modelBuilder.ApplyConfiguration(new UnidadMedidaSetting());
            modelBuilder.ApplyConfiguration(new ConfiguracionCoreSetting());
            modelBuilder.ApplyConfiguration(new FamiliaListaPrecioSetting());
            modelBuilder.ApplyConfiguration(new MarcaListaPrecioSetting());
            modelBuilder.ApplyConfiguration(new OrdenFabricacionSetting());
            modelBuilder.ApplyConfiguration(new OrdenFabricacionDetalleSetting());
            modelBuilder.ApplyConfiguration(new CostoFabricacionSetting());
            modelBuilder.ApplyConfiguration(new ConfiguracionBalanzaSetting());
            modelBuilder.ApplyConfiguration(new BancoSetting());

            modelBuilder.ApplyConfiguration(new ComprobanteDetalleFabricacionSetting());
            modelBuilder.ApplyConfiguration(new ComprobanteDetalleSetting());

            modelBuilder.ApplyConfiguration(new ComprobanteSetting());
            modelBuilder.ApplyConfiguration(new ComprobanteVentaSetting());
            modelBuilder.ApplyConfiguration(new ComprobanteGastoSetting());
            modelBuilder.ApplyConfiguration(new ComprobanteTransferenciaSetting());
            modelBuilder.ApplyConfiguration(new ComprobanteTotalesSetting());

            modelBuilder.ApplyConfiguration(new MedioPagoSetting());
            modelBuilder.ApplyConfiguration(new MedioPagoChequeSetting());
            modelBuilder.ApplyConfiguration(new MedioPagoCtaCteSetting());
            modelBuilder.ApplyConfiguration(new MedioPagoEfectivoSetting());
            modelBuilder.ApplyConfiguration(new MedioPagoTarjetaSetting());
            modelBuilder.ApplyConfiguration(new MedioPagoTransferenciaSetting());

            modelBuilder.ApplyConfiguration(new PuestoTrabajoSetting());
            modelBuilder.ApplyConfiguration(new CajaPuestoTrabajoSetting());

            modelBuilder.ApplyConfiguration(new PedidoSetting());
            modelBuilder.ApplyConfiguration(new PedidoDetalleSetting());

            #endregion

            if (MotoBaseDatos.Obtener == TipoMotorBaseDatos.SqlServer)
            {
                if (Auditoria.Obtener == TipoAccionAuditoria.ConAuditoria)
                {
                    #region Seguridad Con Auditoria

                    modelBuilder.Entity<Empresa>()
                    .ToTable("Empresas", op =>
                    {
                        op.IsTemporal();
                    }).HasIndex(x => x.Codigo)
                    .IsUnique();

                    modelBuilder.Entity<Localidad>()
                    .ToTable("Localidades", op =>
                    {
                        op.IsTemporal();
                    }).HasIndex(x => new { x.ProvinciaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Provincia>()
                    .ToTable("Provincias", op =>
                    {
                        op.IsTemporal();
                    }).HasIndex(x => x.Descripcion)
                    .IsUnique();

                    modelBuilder.Entity<TipoResponsabilidad>()
                    .ToTable("TiposResponsabilidades", op =>
                    {
                        op.IsTemporal();
                    }).HasIndex(x => x.Descripcion)
                    .IsUnique();

                    modelBuilder.Entity<IngresoBruto>()
                    .ToTable("IngresosBrutos", op =>
                    {
                        op.IsTemporal();
                    }).HasIndex(x => x.Descripcion)
                    .IsUnique();

                    modelBuilder.Entity<Persona>()
                    .ToTable("Personas", op =>
                    {
                        op.IsTemporal();
                    }).HasIndex(x => x.Cuil)
                    .IsUnique();

                    modelBuilder.Entity<Usuario>()
                    .ToTable("Usuarios", op =>
                    {
                        op.IsTemporal();
                    }).HasIndex(x => x.Nombre)
                    .IsUnique();

                    modelBuilder.Entity<EmpresaPersona>()
                    .ToTable("EmpresasPersonas", op =>
                    {
                        op.IsTemporal();
                    }).HasIndex(x => new { x.PersonaId, x.EmpresaId })
                    .IsUnique();

                    modelBuilder.Entity<ConfiguracionSeguridad>()
                    .ToTable("ConfiguracionesSeguridad", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                    modelBuilder.Entity<Grupo>()
                    .ToTable("Grupos", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<GrupoFormulario>()
                    .ToTable("GrupoFormularios", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.GrupoId, x.FormularioId })
                    .IsUnique();

                    modelBuilder.Entity<GrupoPersona>()
                    .ToTable("GrupoPersonas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.GrupoId, x.PersonaId })
                    .IsUnique();

                    modelBuilder.Entity<Formulario>()
                    .ToTable("Formularios", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.Codigo })
                    .IsUnique();

                    modelBuilder.Entity<Modulo>()
                    .ToTable("Modulos", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                    modelBuilder.Entity<ConfiguracionBalanza>()
                    .ToTable("ConfiguracionBalanzas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                    #endregion

                    #region Core con Auditoria

                    modelBuilder.Entity<CajaPuestoTrabajo>()
                    .ToTable("CajasPuestosTrabajos", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.CajaId, x.PuestoTrabajoId })
                    .IsUnique();

                    modelBuilder.Entity<PuestoTrabajo>()
                   .ToTable("PuestosTrabajos", op =>
                   {
                       op.IsTemporal();
                   })
                   .HasIndex(x => new { x.EmpresaId, x.SerialNumber })
                   .IsUnique();

                    modelBuilder.Entity<ArticuloBase>()
                    .ToTable("Articulos", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<ArticuloProveedor>()
                   .ToTable("ArticuloProveedores", op =>
                   {
                       op.IsTemporal();
                   })
                   .HasIndex(x => new { x.ArticuloId, x.ProveedorId })
                   .IsUnique();

                    modelBuilder.Entity<ArticuloBaja>()
                    .ToTable("ArticuloBajas", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<ArticuloOpcional>()
                   .ToTable("ArticuloOpcionales", op =>
                   {
                       op.IsTemporal();
                   });

                    modelBuilder.Entity<ArticuloKit>()
                   .ToTable("ArticuloKits", op =>
                   {
                       op.IsTemporal();
                   });

                    modelBuilder.Entity<ArticuloPrecio>()
                    .ToTable("ArticuloPrecios", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<ArticuloDeposito>()
                   .ToTable("ArticuloDepositos", op =>
                   {
                       op.IsTemporal();
                   }).HasIndex(x => new { x.ArticuloId, x.DepositoId })
                   .IsUnique();

                    modelBuilder.Entity<ArticuloFormula>()
                    .ToTable("ArticuloFormulas", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<ArticuloHistorialCosto>()
                    .ToTable("ArticuloHistorialCostos", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<Banco>()
                    .ToTable("Bancos", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Variante>()
                   .ToTable("Variantes", op =>
                   {
                       op.IsTemporal();
                   }).HasIndex(x => new { x.EmpresaId, x.Descripcion })
                   .IsUnique();

                    modelBuilder.Entity<VarianteValor>()
                   .ToTable("VarianteValores", op =>
                   {
                       op.IsTemporal();
                   }).HasIndex(x => new { x.VarianteId, x.Descripcion })
                   .IsUnique();



                    modelBuilder.Entity<Caja>()
                    .ToTable("Cajas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<CajaDetalle>()
                    .ToTable("CajaDetalles", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<Cliente>()
                    .ToTable("Clientes", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Documento })
                    .IsUnique();

                    modelBuilder.Entity<Comprobante>()
                    .ToTable("Comprobantes", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<ComprobanteSalon>()
                    .ToTable("Comprobantes", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<ComprobanteVenta>()
                    .ToTable("Comprobantes", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<ComprobanteGasto>()
                   .ToTable("Comprobantes", op =>
                   {
                       op.IsTemporal();
                   });

                    modelBuilder.Entity<ComprobanteTransferencia>()
                   .ToTable("Comprobantes", op =>
                   {
                       op.IsTemporal();
                   });

                    modelBuilder.Entity<ComprobanteDetalle>()
                    .ToTable("ComprobanteDetalles", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<ComprobanteDetalleFabricacion>()
                    .ToTable("ComprobanteDetalleFabricaciones", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<ComprobanteTotales>()
                    .ToTable("ComprobanteTotales", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<CondicionIva>()
                    .ToTable("CondicionIvas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Contador>()
                    .ToTable("Contadores", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.TipoContador })
                    .IsUnique();

                    modelBuilder.Entity<CuentaCorrienteCliente>()
                    .ToTable("CuentaCorrienteClientes", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<CuentaCorrienteProveedor>()
                    .ToTable("CuentaCorrienteProveedores", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<Deposito>()
                    .ToTable("Depositos", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<ArticuloDeposito>()
                    .ToTable("DepositoArticulos", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<Familia>()
                    .ToTable("Familias", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<FamiliaCaja>()
                    .ToTable("FamiliaCajas", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<TipoGasto>()
                    .ToTable("TipoGastos", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Gasto>()
                    .ToTable("Gastos", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<ListaPrecio>()
                    .ToTable("ListaPrecios", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Marca>()
                    .ToTable("Marcas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Mesa>()
                    .ToTable("Mesas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.SalonId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<MotivoBaja>()
                    .ToTable("MotivoBajas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<MovimientoCaja>()
                    .ToTable("MovimientoCajas", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<PlanTarjeta>()
                    .ToTable("PlanTarjetas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.TarjetaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Proveedor>()
                    .ToTable("Proveedores", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.CUIT })
                    .IsUnique();

                    modelBuilder.Entity<Salon>()
                    .ToTable("Salones", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Tarjeta>()
                    .ToTable("Tarjetas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<TipoDocumento>()
                    .ToTable("TipoDocumentos", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => x.Descripcion)
                    .IsUnique();

                    modelBuilder.Entity<UnidadMedida>()
                    .ToTable("UnidadMedidas", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<FamiliaListaPrecio>()
                    .ToTable("FamiliaListaPrecios", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.FamiliaId, x.ListaPrecioId })
                    .IsUnique();

                    modelBuilder.Entity<MarcaListaPrecio>()
                    .ToTable("MarcaListaPrecios", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId, x.MarcaId, x.ListaPrecioId })
                    .IsUnique();

                    modelBuilder.Entity<ConfiguracionCore>()
                    .ToTable("ConfiguracionCores", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                    modelBuilder.Entity<OrdenFabricacion>()
                    .ToTable("OrdenFabricaciones", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.Numero })
                    .IsUnique();

                    modelBuilder.Entity<OrdenFabricacionDetalle>()
                    .ToTable("OrdenFabricacionDetalles", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<CostoFabricacion>()
                    .ToTable("CostoFabricaciones", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<MedioPago>()
                    .ToTable("MedioPagos", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<MedioPagoCheque>()
                    .ToTable("MedioPagos", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<MedioPagoCtaCte>()
                    .ToTable("MedioPagos", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<MedioPagoEfectivo>()
                    .ToTable("MedioPagos", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<MedioPagoTarjeta>()
                    .ToTable("MedioPagos", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<MedioPagoTransferencia>()
                    .ToTable("MedioPagos", op =>
                    {
                        op.IsTemporal();
                    });

                    modelBuilder.Entity<Pedido>()
                    .ToTable("Pedidos", op =>
                    {
                        op.IsTemporal();
                    })
                    .HasIndex(x => new { x.Numero })
                    .IsUnique();

                    modelBuilder.Entity<PedidoDetalle>()
                    .ToTable("PedidoDetalles", op =>
                    {
                        op.IsTemporal();
                    });

                    #endregion
                }
                else
                {
                    #region Seguridad sin Auditoria

                    modelBuilder.Entity<Empresa>()
                    .ToTable("Empresas")
                    .HasIndex(x => x.Codigo)
                    .IsUnique();

                    modelBuilder.Entity<Localidad>()
                    .ToTable("Localidades")
                    .HasIndex(x => new { x.ProvinciaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Provincia>()
                    .ToTable("Provincias")
                    .HasIndex(x => x.Descripcion)
                    .IsUnique();

                    modelBuilder.Entity<TipoResponsabilidad>()
                    .ToTable("TiposResponsabilidades")
                    .HasIndex(x => x.Descripcion)
                    .IsUnique();

                    modelBuilder.Entity<IngresoBruto>()
                    .ToTable("IngresosBrutos")
                    .HasIndex(x => x.Descripcion)
                    .IsUnique();

                    modelBuilder.Entity<Persona>()
                    .ToTable("Personas")
                    .HasIndex(x => x.Cuil)
                    .IsUnique();

                    modelBuilder.Entity<Usuario>()
                    .ToTable("Usuarios")
                    .HasIndex(x => x.Nombre)
                    .IsUnique();

                    modelBuilder.Entity<EmpresaPersona>()
                    .ToTable("EmpresasPersonas")
                    .HasIndex(x => new { x.PersonaId, x.EmpresaId })
                    .IsUnique();

                    modelBuilder.Entity<ConfiguracionSeguridad>()
                    .ToTable("ConfiguracionesSeguridad")
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                    modelBuilder.Entity<Grupo>()
                    .ToTable("Grupos")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<GrupoFormulario>()
                    .ToTable("GrupoFormularios")
                    .HasIndex(x => new { x.GrupoId, x.FormularioId })
                    .IsUnique();

                    modelBuilder.Entity<GrupoPersona>()
                    .ToTable("GrupoPersonas")
                    .HasIndex(x => new { x.GrupoId, x.PersonaId })
                    .IsUnique();

                    modelBuilder.Entity<Formulario>()
                    .ToTable("Formularios")
                    .HasIndex(x => new { x.Codigo })
                    .IsUnique();

                    modelBuilder.Entity<Modulo>()
                    .ToTable("Modulos")
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                    #endregion

                    #region Core sin Auditoria

                    modelBuilder.Entity<CajaPuestoTrabajo>()
                  .ToTable("CajasPuestosTrabajos")
                  .HasIndex(x => new { x.CajaId, x.PuestoTrabajoId })
                  .IsUnique();

                    modelBuilder.Entity<PuestoTrabajo>()
                   .ToTable("PuestosTrabajos")
                   .HasIndex(x => new { x.EmpresaId, x.SerialNumber })
                   .IsUnique();

                    modelBuilder.Entity<ArticuloBase>()
                    .ToTable("Articulos")
                    .HasIndex(x => new { x.EmpresaId, x.Codigo })
                    .IsUnique();

                    modelBuilder.Entity<ArticuloProveedor>()
                   .ToTable("ArticuloProveedores")
                   .HasIndex(x => new { x.ArticuloId, x.ProveedorId })
                   .IsUnique();

                    modelBuilder.Entity<ArticuloBaja>()
                    .ToTable("ArticuloBajas");

                    modelBuilder.Entity<ArticuloOpcional>()
                   .ToTable("ArticuloOpcionales");

                    modelBuilder.Entity<ArticuloFormula>()
                  .ToTable("ArticuloFormulas");

                    modelBuilder.Entity<ArticuloDeposito>()
                   .ToTable("ArticuloDepositos")
                   .HasIndex(x => new { x.ArticuloId, x.DepositoId })
                   .IsUnique();

                    modelBuilder.Entity<ArticuloHistorialCosto>()
                    .ToTable("ArticuloHistorialCostos");

                    modelBuilder.Entity<ArticuloKit>()
                   .ToTable("ArticuloKits");

                    modelBuilder.Entity<ArticuloPrecio>()
                    .ToTable("ArticuloPrecios");

                    modelBuilder.Entity<Banco>()
                    .ToTable("Bancos")
                    .HasIndex(x => new { x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Variante>()
                  .ToTable("Variantes")
                  .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                  .IsUnique();

                    modelBuilder.Entity<VarianteValor>()
                   .ToTable("VarianteValores")
                   .HasIndex(x => new { x.VarianteId, x.Descripcion })
                   .IsUnique();

                    modelBuilder.Entity<Caja>()
                    .ToTable("Cajas")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<CajaDetalle>()
                    .ToTable("CajaDetalles");

                    modelBuilder.Entity<Cliente>()
                    .ToTable("Clientes")
                    .HasIndex(x => new { x.EmpresaId, x.Documento })
                    .IsUnique();

                    modelBuilder.Entity<Comprobante>()
                    .ToTable("Comprobantes");

                    modelBuilder.Entity<ComprobanteSalon>()
                    .ToTable("Comprobantes");

                    modelBuilder.Entity<ComprobanteVenta>()
                    .ToTable("Comprobantes");

                    modelBuilder.Entity<ComprobanteGasto>()
                   .ToTable("Comprobantes");

                    modelBuilder.Entity<ComprobanteTransferencia>()
                   .ToTable("Comprobantes");

                    modelBuilder.Entity<ComprobanteDetalle>()
                    .ToTable("ComprobanteDetalles");

                    modelBuilder.Entity<ComprobanteDetalleFabricacion>()
                    .ToTable("ComprobanteDetalleFabricaciones");

                    modelBuilder.Entity<ComprobanteTotales>()
                    .ToTable("ComprobanteTotales");

                    modelBuilder.Entity<CondicionIva>()
                    .ToTable("CondicionIvas")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Contador>()
                    .ToTable("Contadores")
                    .HasIndex(x => new { x.EmpresaId, x.TipoContador })
                    .IsUnique();

                    modelBuilder.Entity<CuentaCorrienteCliente>()
                    .ToTable("CuentaCorrienteClientes");

                    modelBuilder.Entity<CuentaCorrienteProveedor>()
                    .ToTable("CuentaCorrienteProveedores");

                    modelBuilder.Entity<Deposito>()
                    .ToTable("Depositos")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Familia>()
                    .ToTable("Familias")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<FamiliaCaja>()
                    .ToTable("FamiliaCajas");

                    modelBuilder.Entity<TipoGasto>()
                    .ToTable("TipoGastos")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Gasto>()
                    .ToTable("Gastos");

                    modelBuilder.Entity<ListaPrecio>()
                    .ToTable("ListaPrecios")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Marca>()
                    .ToTable("Marcas")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Mesa>()
                    .ToTable("Mesas")
                    .HasIndex(x => new { x.SalonId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<MotivoBaja>()
                    .ToTable("MotivoBajas")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<MovimientoCaja>()
                    .ToTable("MovimientoCajas");

                    modelBuilder.Entity<PlanTarjeta>()
                    .ToTable("PlanTarjetas")
                    .HasIndex(x => new { x.TarjetaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Proveedor>()
                    .ToTable("Proveedores")
                    .HasIndex(x => new { x.EmpresaId, x.CUIT })
                    .IsUnique();

                    modelBuilder.Entity<Salon>()
                    .ToTable("Salones")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<Tarjeta>()
                    .ToTable("Tarjetas")
                    .HasIndex(x => new { x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<TipoDocumento>()
                    .ToTable("TipoDocumentos")
                    .HasIndex(x => x.Descripcion)
                    .IsUnique();

                    modelBuilder.Entity<UnidadMedida>()
                    .ToTable("UnidadMedidas")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                    modelBuilder.Entity<FamiliaListaPrecio>()
                    .ToTable("FamiliaListaPrecios")
                    .HasIndex(x => new { x.EmpresaId, x.FamiliaId, x.ListaPrecioId })
                    .IsUnique();

                    modelBuilder.Entity<MarcaListaPrecio>()
                    .ToTable("MarcaListaPrecios")
                    .HasIndex(x => new { x.EmpresaId, x.MarcaId, x.ListaPrecioId })
                    .IsUnique();

                    modelBuilder.Entity<ConfiguracionCore>()
                    .ToTable("ConfiguracionCores")
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                    modelBuilder.Entity<OrdenFabricacion>()
                    .ToTable("OrdenFabricaciones")
                    .HasIndex(x => new { x.Numero })
                    .IsUnique();

                    modelBuilder.Entity<OrdenFabricacionDetalle>()
                    .ToTable("OrdenFabricacionDetalles");

                    modelBuilder.Entity<CostoFabricacion>()
                    .ToTable("CostoFabricaciones");

                    modelBuilder.Entity<ConfiguracionBalanza>()
                    .ToTable("ConfiguracionBalanzas")
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                    modelBuilder.Entity<MedioPago>()
                    .ToTable("MedioPagos");

                    modelBuilder.Entity<MedioPagoCheque>()
                    .ToTable("MedioPagos");

                    modelBuilder.Entity<MedioPagoCtaCte>()
                    .ToTable("MedioPagos");

                    modelBuilder.Entity<MedioPagoEfectivo>()
                    .ToTable("MedioPagos");

                    modelBuilder.Entity<MedioPagoTarjeta>()
                    .ToTable("MedioPagos");

                    modelBuilder.Entity<MedioPagoTransferencia>()
                    .ToTable("MedioPagos");

                    modelBuilder.Entity<Pedido>()
                    .ToTable("Pedidos")
                    .HasIndex(x => new { x.Numero })
                    .IsUnique();

                    modelBuilder.Entity<PedidoDetalle>()
                    .ToTable("PedidoDetalles");
                    #endregion
                }
            }
            else if (MotoBaseDatos.Obtener == TipoMotorBaseDatos.MySql)
            {
                #region Seguridad MySql

                modelBuilder.Entity<Empresa>()
                    .ToTable("Empresas")
                    .HasIndex(x => x.Codigo)
                    .IsUnique();

                modelBuilder.Entity<Localidad>()
                    .ToTable("Localidades")
                    .HasIndex(x => new { x.ProvinciaId, x.Descripcion })
                    .IsUnique();

                modelBuilder.Entity<Provincia>()
                    .ToTable("Provincias")
                    .HasIndex(x => x.Descripcion)
                    .IsUnique();

                modelBuilder.Entity<TipoResponsabilidad>()
                    .ToTable("TiposResponsabilidades")
                    .HasIndex(x => x.Descripcion)
                    .IsUnique();

                modelBuilder.Entity<IngresoBruto>()
                    .ToTable("IngresosBrutos")
                    .HasIndex(x => x.Descripcion)
                    .IsUnique();

                modelBuilder.Entity<Persona>()
                    .ToTable("Personas")
                    .HasIndex(x => x.Cuil)
                    .IsUnique();

                modelBuilder.Entity<Usuario>()
                    .ToTable("Usuarios")
                    .HasIndex(x => x.Nombre)
                    .IsUnique();

                modelBuilder.Entity<EmpresaPersona>()
                    .ToTable("EmpresasPersonas")
                    .HasIndex(x => new { x.PersonaId, x.EmpresaId })
                    .IsUnique();

                modelBuilder.Entity<ConfiguracionSeguridad>()
                    .ToTable("ConfiguracionesSeguridad")
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                modelBuilder.Entity<Grupo>()
                    .ToTable("Grupos")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                modelBuilder.Entity<GrupoFormulario>()
                    .ToTable("GruposFormularios")
                    .HasIndex(x => new { x.GrupoId, x.FormularioId })
                    .IsUnique();

                modelBuilder.Entity<GrupoPersona>()
                   .ToTable("GrupoPersonas")
                   .HasIndex(x => new { x.GrupoId, x.PersonaId })
                   .IsUnique();

                modelBuilder.Entity<Formulario>()
                    .ToTable("Formularios")
                    .HasIndex(x => new { x.Codigo })
                    .IsUnique();

                modelBuilder.Entity<Modulo>()
                    .ToTable("Modulos")
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                #endregion

                #region Core MySql

                modelBuilder.Entity<CajaPuestoTrabajo>()
                  .ToTable("CajasPuestosTrabajos")
                  .HasIndex(x => new { x.CajaId, x.PuestoTrabajoId })
                  .IsUnique();

                modelBuilder.Entity<PuestoTrabajo>()
                   .ToTable("PuestosTrabajos")
                   .HasIndex(x => new { x.EmpresaId, x.SerialNumber })
                   .IsUnique();

                modelBuilder.Entity<ArticuloBase>()
                   .ToTable("Articulos")
                   .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                   .IsUnique();

                modelBuilder.Entity<ArticuloProveedor>()
               .ToTable("ArticuloProveedores")
               .HasIndex(x => new { x.ArticuloId, x.ProveedorId })
               .IsUnique();

                modelBuilder.Entity<ArticuloBaja>()
                .ToTable("ArticuloBajas");

                modelBuilder.Entity<ArticuloOpcional>()
               .ToTable("ArticuloOpcionales");

                modelBuilder.Entity<ArticuloFormula>()
              .ToTable("ArticuloFormulas");

                modelBuilder.Entity<ArticuloDeposito>()
               .ToTable("ArticuloDepositos")
               .HasIndex(x => new { x.ArticuloId, x.DepositoId })
               .IsUnique();

                modelBuilder.Entity<ArticuloHistorialCosto>()
                    .ToTable("ArticuloHistorialCostos");

                modelBuilder.Entity<ArticuloKit>()
                   .ToTable("ArticuloKits");

                modelBuilder.Entity<ArticuloPrecio>()
                .ToTable("ArticuloPrecios");

                modelBuilder.Entity<Banco>()
                    .ToTable("Bancos")
                    .HasIndex(x => new { x.Descripcion })
                    .IsUnique();

                modelBuilder.Entity<Variante>()
              .ToTable("Variantes")
              .HasIndex(x => new { x.EmpresaId, x.Descripcion })
              .IsUnique();

                modelBuilder.Entity<VarianteValor>()
               .ToTable("VarianteValores")
               .HasIndex(x => new { x.VarianteId, x.Descripcion })
               .IsUnique();

                modelBuilder.Entity<Caja>()
                .ToTable("Cajas")
                .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<CajaDetalle>()
                .ToTable("CajaDetalles");

                modelBuilder.Entity<Cliente>()
                .ToTable("Clientes")
                .HasIndex(x => new { x.EmpresaId, x.Documento })
                .IsUnique();

                modelBuilder.Entity<Comprobante>()
                    .ToTable("Comprobantes");

                modelBuilder.Entity<ComprobanteSalon>()
                .ToTable("Comprobantes");

                modelBuilder.Entity<ComprobanteVenta>()
                .ToTable("Comprobantes");

                modelBuilder.Entity<ComprobanteGasto>()
                  .ToTable("Comprobantes");

                modelBuilder.Entity<ComprobanteTransferencia>()
                   .ToTable("Comprobantes");

                modelBuilder.Entity<ComprobanteDetalle>()
                .ToTable("ComprobanteDetalles");

                modelBuilder.Entity<ComprobanteDetalleFabricacion>()
                .ToTable("ComprobanteDetalleFabricaciones");

                modelBuilder.Entity<ComprobanteTotales>()
                .ToTable("ComprobanteTotales");

                modelBuilder.Entity<CondicionIva>()
                .ToTable("CondicionIvas")
                .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<Contador>()
                    .ToTable("Contadores")
                    .HasIndex(x => new { x.EmpresaId, x.TipoContador })
                    .IsUnique();

                modelBuilder.Entity<CuentaCorrienteCliente>()
                .ToTable("CuentaCorrienteClientes");

                modelBuilder.Entity<CuentaCorrienteProveedor>()
                .ToTable("CuentaCorrienteProveedores");

                modelBuilder.Entity<Deposito>()
                .ToTable("Depositos")
                .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<ArticuloDeposito>()
                .ToTable("DepositoArticulos");

                modelBuilder.Entity<Familia>()
                .ToTable("Familias")
                .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<FamiliaCaja>()
                .ToTable("FamiliaCajas");

                modelBuilder.Entity<TipoGasto>()
                    .ToTable("TipoGastos")
                    .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                    .IsUnique();

                modelBuilder.Entity<Gasto>()
                .ToTable("Gastos");

                modelBuilder.Entity<ListaPrecio>()
                .ToTable("ListaPrecios")
                .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<Marca>()
                .ToTable("Marcas")
                .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<Mesa>()
                    .ToTable("Mesas")
                    .HasIndex(x => new { x.SalonId, x.Descripcion })
                    .IsUnique();

                modelBuilder.Entity<MotivoBaja>()
                .ToTable("MotivoBajas")
                .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<MovimientoCaja>()
                    .ToTable("MovimientoCajas");

                modelBuilder.Entity<PlanTarjeta>()
                .ToTable("PlanTarjetas")
                .HasIndex(x => new { x.TarjetaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<Proveedor>()
                .ToTable("Proveedores")
                .HasIndex(x => new { x.EmpresaId, x.CUIT })
                .IsUnique();

                modelBuilder.Entity<Salon>()
                .ToTable("Salones")
                .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<Tarjeta>()
                .ToTable("Tarjetas")
                .HasIndex(x => new { x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<TipoDocumento>()
                .ToTable("TipoDocumentos")
                .HasIndex(x => x.Descripcion)
                .IsUnique();

                modelBuilder.Entity<UnidadMedida>()
                .ToTable("UnidadMedidas")
                .HasIndex(x => new { x.EmpresaId, x.Descripcion })
                .IsUnique();

                modelBuilder.Entity<FamiliaListaPrecio>()
                    .ToTable("FamiliaListaPrecios")
                    .HasIndex(x => new { x.EmpresaId, x.FamiliaId, x.ListaPrecioId })
                    .IsUnique();

                modelBuilder.Entity<MarcaListaPrecio>()
                .ToTable("MarcaListaPrecios")
                .HasIndex(x => new { x.EmpresaId, x.MarcaId, x.ListaPrecioId })
                .IsUnique();

                modelBuilder.Entity<ConfiguracionCore>()
                .ToTable("ConfiguracionCores")
                .HasIndex(x => new { x.EmpresaId })
                .IsUnique();

                modelBuilder.Entity<OrdenFabricacion>()
                    .ToTable("OrdenFabricaciones")
                    .HasIndex(x => new { x.Numero })
                    .IsUnique();

                modelBuilder.Entity<OrdenFabricacionDetalle>()
                .ToTable("OrdenFabricacionDetalles");

                modelBuilder.Entity<CostoFabricacion>()
                    .ToTable("CostoFabricaciones");

                modelBuilder.Entity<ConfiguracionBalanza>()
                    .ToTable("ConfiguracionBalanzas")
                    .HasIndex(x => new { x.EmpresaId })
                    .IsUnique();

                modelBuilder.Entity<MedioPago>()
                    .ToTable("MedioPagos");

                modelBuilder.Entity<MedioPagoCheque>()
                .ToTable("MedioPagos");

                modelBuilder.Entity<MedioPagoCtaCte>()
                .ToTable("MedioPagos");

                modelBuilder.Entity<MedioPagoEfectivo>()
                .ToTable("MedioPagos");

                modelBuilder.Entity<MedioPagoTarjeta>()
                .ToTable("MedioPagos");

                modelBuilder.Entity<MedioPagoTransferencia>()
                .ToTable("MedioPagos");

                modelBuilder.Entity<Pedido>()
                    .ToTable("Pedidos")
                    .HasIndex(x => new { x.Numero })
                    .IsUnique();

                modelBuilder.Entity<PedidoDetalle>()
                .ToTable("PedidoDetalles");

                #endregion
            }

            modelBuilder.Crear();
        }

        // Mapeo de las Entidades

        // =============================================================== //
        // ==========                 Seguridad                =========== //
        // =============================================================== //

        #region Mapeo Seguridad

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<TipoResponsabilidad> TipoResponsabilidades { get; set; }
        public DbSet<IngresoBruto> IngresosBrutos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EmpresaPersona> EmpresasPersonas { get; set; }
        public DbSet<ConfiguracionSeguridad> ConfiguracionesSeguridad { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<GrupoFormulario> GruposFormularios { get; set; }
        public DbSet<GrupoPersona> GruposPersonas { get; set; }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<PuestoTrabajo> PuestosTrabajos { get; set; }

        #endregion

        // =============================================================== //
        // ==========                   Core                   =========== //
        // =============================================================== //

        #region Mapeo Core

        public DbSet<ArticuloBase> ArticulosBases { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<ArticuloBaja> ArticuloBajas { get; set; }
        public DbSet<ArticuloOpcional> ArticuloOpcionales { get; set; }
        public DbSet<ArticuloProveedor> ArticuloProveedores { get; set; }
        public DbSet<ArticuloDeposito> ArticuloDepositos { get; set; }
        public DbSet<ArticuloFormula> ArticuloFormulas { get; set; }
        public DbSet<ArticuloTemporal> ArticuloTemporales { get; set; }
        public DbSet<ArticuloKit> ArticuloKits { get; set; }
        public DbSet<ArticuloHistorialCosto> ArticuloHistorialCostos { get; set; }
        public DbSet<ArticuloPrecio> Precios { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Caja> Cajas { get; set; }
        public DbSet<CajaDetalle> CajaDetalles { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<ComprobanteDetalle> ComprobanteDetalles { get; set; }
        public DbSet<ComprobanteDetalleFabricacion> ComprobanteDetalleFabricaciones { get; set; }
        public DbSet<ComprobanteTotales> ComprobanteTotales { get; set; }
        public DbSet<CondicionIva> CondicionIvas { get; set; }
        public DbSet<Contador> Contadores { get; set; }
        public DbSet<CuentaCorrienteCliente> CuentaCorrienteClientes { get; set; }
        public DbSet<CuentaCorrienteProveedor> CuentaCorrienteProveedores { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Variante> Variantes { get; set; }
        public DbSet<VarianteValor> VarianteValores { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<FamiliaCaja> FamiliaCajas { get; set; }
        public DbSet<TipoGasto> TipoGastos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<ListaPrecio> ListaPrecios { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<MotivoBaja> MotivoBajas { get; set; }
        public DbSet<MovimientoCaja> MovimientoCajas { get; set; }
        public DbSet<PlanTarjeta> PlanTarjetas { get; set; }
        public DbSet<Salon> Salones { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<UnidadMedida> UnidadMedidas { get; set; }
        public DbSet<ConfiguracionCore> ConfiguracionCores { get; set; }
        public DbSet<FamiliaListaPrecio> FamiliaListaPrecios { get; set; }
        public DbSet<MarcaListaPrecio> MarcaListaPrecios { get; set; }
        public DbSet<OrdenFabricacion> OrdenFabricaciones { get; set; }
        public DbSet<OrdenFabricacionDetalle> OrdenFabricacionDetalles { get; set; }
        public DbSet<CostoFabricacion> CostoFabricaciones { get; set; }
        public DbSet<ConfiguracionBalanza> ConfiguracionBalanzas { get; set; }
        public DbSet<MedioPago> MedioPagos { get; set; }
        public DbSet<CajaPuestoTrabajo> CajasPuestoTrabajos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalles { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        #endregion
    }
}
