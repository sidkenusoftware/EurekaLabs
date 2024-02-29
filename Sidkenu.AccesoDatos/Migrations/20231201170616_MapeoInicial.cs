using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class MapeoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfiguracionesSeguridad",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginNormal = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioCredencial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordCredencial = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Puerto = table.Column<int>(type: "int", nullable: false),
                    Host = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LogInformacion = table.Column<bool>(type: "bit", nullable: false),
                    LogWarning = table.Column<bool>(type: "bit", nullable: false),
                    LogError = table.Column<bool>(type: "bit", nullable: false),
                    EnviarMailCreateUsuario = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionesSeguridad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formularios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DescripcionCompleta = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EstaVigente = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formularios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngresosBrutos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresosBrutos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Cuil = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tarjetas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposResponsabilidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposResponsabilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    InicioPorPrimeraVez = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvinciaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localidades_Provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlanTarjetas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TarjetaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Alicuota = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanTarjetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanTarjetas_Tarjetas_TarjetaId",
                        column: x => x.TarjetaId,
                        principalTable: "Tarjetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocalidadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoResponsabilidadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngresoBrutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Referente = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Cuit = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    FechaInicioActividad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NroIngresoBruto = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_IngresosBrutos_IngresoBrutoId",
                        column: x => x.IngresoBrutoId,
                        principalTable: "IngresosBrutos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresas_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Empresas_TiposResponsabilidades_TipoResponsabilidadId",
                        column: x => x.TipoResponsabilidadId,
                        principalTable: "TiposResponsabilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cajas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PermiteGastos = table.Column<bool>(type: "bit", nullable: false),
                    PermitePagosProveedor = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cajas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cajas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CondicionIvas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    AplicaParaFacturaElectronica = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicionIvas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CondicionIvas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracionBalanzas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfiguracionPorPeso = table.Column<bool>(type: "bit", nullable: false),
                    CodigoIdentificarImporte = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    DecimalesImporte = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    CodigoIdentificarPeso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DecimalPeso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConvierteUnidadPeso = table.Column<bool>(type: "bit", nullable: false),
                    Equivalencia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LongitudTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InicioIdentificarTipo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinIdentificarTipo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InicioIdentificarCodigoArcitulo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinIdentificarCodigoArcitulo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InicioIdentificarImportePrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinIdentificarImportePrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionBalanzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfiguracionBalanzas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoContador = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<long>(type: "bigint", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contadores_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CostoFabricaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostoFabricaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostoFabricaciones_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Depositos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Abreviatura = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TipoDeposito = table.Column<int>(type: "int", nullable: false),
                    Predeterminado = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depositos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Depositos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Depositos_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresasPersonas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresasPersonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresasPersonas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpresasPersonas_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Familias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ActivarRestriccionHoraVenta = table.Column<bool>(type: "bit", nullable: false),
                    RestriccionHoraVentaDesde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestriccionHoraVentaHasta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivarAumentoPrecioHoraVenta = table.Column<bool>(type: "bit", nullable: false),
                    AumentoPrecioHoraVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AumentoPrecioHoraVentaDesde = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AumentoPrecioHoraVentaHasta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoValor = table.Column<int>(type: "int", nullable: true),
                    ActivarAumentoPrecioPublico = table.Column<bool>(type: "bit", nullable: false),
                    AumentoPrecioPublico = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TipoValorPublico = table.Column<int>(type: "int", nullable: true),
                    ActivarAumentoPrecioPublicoImpuesto = table.Column<bool>(type: "bit", nullable: false),
                    AumentoPrecioPublicoImpuesto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TipoValorPublicoImpuesto = table.Column<int>(type: "int", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Familias_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PorDefecto = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListaPrecios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Rentabilidad = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaPrecios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaPrecios_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ActivarAumentoPrecioPublico = table.Column<bool>(type: "bit", nullable: false),
                    AumentoPrecioPublico = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TipoValorPublico = table.Column<int>(type: "int", nullable: true),
                    ActivarAumentoPrecioPublicoImpuesto = table.Column<bool>(type: "bit", nullable: false),
                    AumentoPrecioPublicoImpuesto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TipoValorPublicoImpuesto = table.Column<int>(type: "int", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marcas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Seguridad = table.Column<bool>(type: "bit", nullable: false),
                    Venta = table.Column<bool>(type: "bit", nullable: false),
                    Compra = table.Column<bool>(type: "bit", nullable: false),
                    Inventario = table.Column<bool>(type: "bit", nullable: false),
                    Fabricacion = table.Column<bool>(type: "bit", nullable: false),
                    PuntoVenta = table.Column<bool>(type: "bit", nullable: false),
                    Caja = table.Column<bool>(type: "bit", nullable: false),
                    Dashboard = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modulos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MotivoBajas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoBajas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotivoBajas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipoResponsabilidadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CUIT = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivarCuentaCorriente = table.Column<bool>(type: "bit", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedores_TiposResponsabilidades_TipoResponsabilidadId",
                        column: x => x.TipoResponsabilidadId,
                        principalTable: "TiposResponsabilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoGastos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoGastos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoGastos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnidadMedidas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Equivalencia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadMedidas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnidadMedidas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Variantes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variantes_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CajaDetalles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MontoApertura = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    FechaApertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonaAperturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MontoCierre = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    FechaCierre = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonaCierreId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MontoSistema = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    Diferencia = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    EstadoCaja = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CajaDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CajaDetalles_Cajas_CajaId",
                        column: x => x.CajaId,
                        principalTable: "Cajas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CajaDetalles_Personas_PersonaAperturaId",
                        column: x => x.PersonaAperturaId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CajaDetalles_Personas_PersonaCierreId",
                        column: x => x.PersonaCierreId,
                        principalTable: "Personas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FamiliaCajas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FamiliaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamiliaCajas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamiliaCajas_Cajas_CajaId",
                        column: x => x.CajaId,
                        principalTable: "Cajas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FamiliaCajas_Familias_FamiliaId",
                        column: x => x.FamiliaId,
                        principalTable: "Familias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GrupoFormularios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrupoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormularioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoFormularios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrupoFormularios_Formularios_FormularioId",
                        column: x => x.FormularioId,
                        principalTable: "Formularios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GrupoFormularios_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GrupoPersonas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrupoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoPersonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrupoPersonas_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GrupoPersonas_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ListaPrecioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TipoResponsabilidadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoDocumentoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivarCuentaCorriente = table.Column<bool>(type: "bit", nullable: false),
                    MontoMaximoCompra = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    ActivarBonificacion = table.Column<bool>(type: "bit", nullable: false),
                    Bonificacion = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_ListaPrecios_ListaPrecioId",
                        column: x => x.ListaPrecioId,
                        principalTable: "ListaPrecios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_TipoDocumentos_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_TiposResponsabilidades_TipoResponsabilidadId",
                        column: x => x.TipoResponsabilidadId,
                        principalTable: "TiposResponsabilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracionCores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivarAumentoPrecioPorMarca = table.Column<bool>(type: "bit", nullable: false),
                    ActivarAumentoPrecioPorFamilia = table.Column<bool>(type: "bit", nullable: false),
                    ActivarAumentoPrecioPorMarcaListaPrecio = table.Column<bool>(type: "bit", nullable: false),
                    ActivarAumentoPrecioPorFamiliaListaPrecio = table.Column<bool>(type: "bit", nullable: false),
                    ListaPrecioPorDefectoParaVentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositoPorDefectoParaVentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositoPorDefectoParaCompraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivarStockPorVencimientoLote = table.Column<bool>(type: "bit", nullable: false),
                    ActualizarPrecioFinalizarLaFabricacion = table.Column<bool>(type: "bit", nullable: false),
                    IncorporarCostoFabricacion = table.Column<bool>(type: "bit", nullable: false),
                    CantidadAproximadaFabricacionArticulos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionCores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfiguracionCores_Depositos_DepositoPorDefectoParaCompraId",
                        column: x => x.DepositoPorDefectoParaCompraId,
                        principalTable: "Depositos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConfiguracionCores_Depositos_DepositoPorDefectoParaVentaId",
                        column: x => x.DepositoPorDefectoParaVentaId,
                        principalTable: "Depositos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConfiguracionCores_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConfiguracionCores_ListaPrecios_ListaPrecioPorDefectoParaVentaId",
                        column: x => x.ListaPrecioPorDefectoParaVentaId,
                        principalTable: "ListaPrecios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FamiliaListaPrecios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FamiliaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ListaPrecioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoValor = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamiliaListaPrecios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamiliaListaPrecios_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FamiliaListaPrecios_Familias_FamiliaId",
                        column: x => x.FamiliaId,
                        principalTable: "Familias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FamiliaListaPrecios_ListaPrecios_ListaPrecioId",
                        column: x => x.ListaPrecioId,
                        principalTable: "ListaPrecios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ListaPrecioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salones_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Salones_ListaPrecios_ListaPrecioId",
                        column: x => x.ListaPrecioId,
                        principalTable: "ListaPrecios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MarcaListaPrecios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarcaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ListaPrecioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoValor = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaListaPrecios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarcaListaPrecios_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarcaListaPrecios_ListaPrecios_ListaPrecioId",
                        column: x => x.ListaPrecioId,
                        principalTable: "ListaPrecios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarcaListaPrecios_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComprobanteCompra",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProveedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroCompra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iva27 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iva21 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iva105 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercepcionTemp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercepcionPyP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercepcionIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercepcionIB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false),
                    TipoComprobante = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprobanteCompra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprobanteCompra_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoGastoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gastos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Gastos_TipoGastos_TipoGastoId",
                        column: x => x.TipoGastoId,
                        principalTable: "TipoGastos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VarianteValores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VarianteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarianteValores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VarianteValores_Variantes_VarianteId",
                        column: x => x.VarianteId,
                        principalTable: "Variantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovimientoCajas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaDetalleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoMovimiento = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientoCajas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimientoCajas_CajaDetalles_CajaDetalleId",
                        column: x => x.CajaDetalleId,
                        principalTable: "CajaDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CuentaCorrienteClientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NroComprobanteFactura = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoMovimiento = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaCorrienteClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuentaCorrienteClientes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EstadoMesa = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mesas_Salones_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CuentaCorrienteProveedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComprobanteCompraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoMovimiento = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuentaCorrienteProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuentaCorrienteProveedores_ComprobanteCompra_ComprobanteCompraId",
                        column: x => x.ComprobanteCompraId,
                        principalTable: "ComprobanteCompra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovimientoGasto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaDetalleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GastoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientoGasto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimientoGasto_CajaDetalles_CajaDetalleId",
                        column: x => x.CajaDetalleId,
                        principalTable: "CajaDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovimientoGasto_Gastos_GastoId",
                        column: x => x.GastoId,
                        principalTable: "Gastos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DescripcionAdicional = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CodigoBarra = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Detalle = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PerfilArticulo = table.Column<int>(type: "int", nullable: false),
                    TipoArticulo = table.Column<int>(type: "int", nullable: false),
                    PrecioCosto = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticuloPadreId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FamiliaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnidadMedidaVentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UnidadMedidaCompraId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CondicionIvaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MarcaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VarianteValorUnoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VarianteValorDosId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PermiteStockNegativo = table.Column<bool>(type: "bit", nullable: true),
                    TienePerdida = table.Column<bool>(type: "bit", nullable: true),
                    PorcentajePerdida = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    ActivarLimiteVenta = table.Column<bool>(type: "bit", nullable: true),
                    LimiteVenta = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    EstaBloqueado = table.Column<bool>(type: "bit", nullable: true),
                    Comision = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    ActivarBonificacion = table.Column<bool>(type: "bit", nullable: true),
                    Bonificacion = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    TipoBonificacion = table.Column<int>(type: "int", nullable: true),
                    BonificacionFechaDesde = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BonificacionFechaHasta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TieneGarantia = table.Column<bool>(type: "bit", nullable: true),
                    Garantia = table.Column<int>(type: "int", nullable: true),
                    StockMaximo = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    StockMinimo = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    PuntoPedido = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    TieneRentabilidad = table.Column<bool>(type: "bit", nullable: true),
                    Rentabilidad = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    FechaVigenciaKit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FacturacionPorImporte = table.Column<bool>(type: "bit", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articulos_Articulos_ArticuloPadreId",
                        column: x => x.ArticuloPadreId,
                        principalTable: "Articulos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Articulos_CondicionIvas_CondicionIvaId",
                        column: x => x.CondicionIvaId,
                        principalTable: "CondicionIvas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulos_Familias_FamiliaId",
                        column: x => x.FamiliaId,
                        principalTable: "Familias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articulos_UnidadMedidas_UnidadMedidaCompraId",
                        column: x => x.UnidadMedidaCompraId,
                        principalTable: "UnidadMedidas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Articulos_UnidadMedidas_UnidadMedidaVentaId",
                        column: x => x.UnidadMedidaVentaId,
                        principalTable: "UnidadMedidas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Articulos_VarianteValores_VarianteValorDosId",
                        column: x => x.VarianteValorDosId,
                        principalTable: "VarianteValores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Articulos_VarianteValores_VarianteValorUnoId",
                        column: x => x.VarianteValorUnoId,
                        principalTable: "VarianteValores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovimientoCtaCteClientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaDetalleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CuentaCorrienteClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientoCtaCteClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimientoCtaCteClientes_CajaDetalles_CajaDetalleId",
                        column: x => x.CajaDetalleId,
                        principalTable: "CajaDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovimientoCtaCteClientes_CuentaCorrienteClientes_CuentaCorrienteClienteId",
                        column: x => x.CuentaCorrienteClienteId,
                        principalTable: "CuentaCorrienteClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComprobanteSalon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MesaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstadoComprobanteSalon = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false),
                    TipoComprobante = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprobanteSalon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprobanteSalon_Mesas_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComprobanteSalon_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovimientoCtaCteProveedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaDetalleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CuentaCorrienteProveedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientoCtaCteProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovimientoCtaCteProveedores_CajaDetalles_CajaDetalleId",
                        column: x => x.CajaDetalleId,
                        principalTable: "CajaDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovimientoCtaCteProveedores_CuentaCorrienteProveedores_CuentaCorrienteProveedorId",
                        column: x => x.CuentaCorrienteProveedorId,
                        principalTable: "CuentaCorrienteProveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloBajas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotivoBajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloBajas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticuloBajas_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticuloBajas_MotivoBajas_MotivoBajaId",
                        column: x => x.MotivoBajaId,
                        principalTable: "MotivoBajas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloDepositos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloDepositos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticuloDepositos_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticuloDepositos_Depositos_DepositoId",
                        column: x => x.DepositoId,
                        principalTable: "Depositos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloFormulas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloSecundarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloFormulas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticuloFormulas_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArticuloFormulas_Articulos_ArticuloSecundarioId",
                        column: x => x.ArticuloSecundarioId,
                        principalTable: "Articulos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArticuloHistorialCostos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrecioCostoAnterior = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioCostoNuevo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloHistorialCostos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticuloHistorialCostos_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloKits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloPadreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloHijoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloKits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticuloKits_Articulos_ArticuloHijoId",
                        column: x => x.ArticuloHijoId,
                        principalTable: "Articulos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArticuloKits_Articulos_ArticuloPadreId",
                        column: x => x.ArticuloPadreId,
                        principalTable: "Articulos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArticuloOpcionales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloPadreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloHijoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloOpcionales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticuloOpcionales_Articulos_ArticuloHijoId",
                        column: x => x.ArticuloHijoId,
                        principalTable: "Articulos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArticuloOpcionales_Articulos_ArticuloPadreId",
                        column: x => x.ArticuloPadreId,
                        principalTable: "Articulos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArticuloPrecios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ListaPrecioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloPrecios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticuloPrecios_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticuloPrecios_ListaPrecios_ListaPrecioId",
                        column: x => x.ListaPrecioId,
                        principalTable: "ListaPrecios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticuloProveedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProveedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodigoProveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticuloProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticuloProveedores_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticuloProveedores_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenFabricaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    DepositoOrigenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepositoDestinoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloBaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstadoOrdenFabricacion = table.Column<int>(type: "int", nullable: false),
                    ActulizarPrecioPublico = table.Column<bool>(type: "bit", nullable: false),
                    CantidadFabricar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrigenFabricacion = table.Column<int>(type: "int", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenFabricaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenFabricaciones_Articulos_ArticuloBaseId",
                        column: x => x.ArticuloBaseId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenFabricaciones_Depositos_DepositoDestinoId",
                        column: x => x.DepositoDestinoId,
                        principalTable: "Depositos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdenFabricaciones_Depositos_DepositoOrigenId",
                        column: x => x.DepositoOrigenId,
                        principalTable: "Depositos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdenFabricaciones_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenFabricacionDetalles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrdenFabricacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenFabricacionDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenFabricacionDetalles_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenFabricacionDetalles_OrdenFabricaciones_OrdenFabricacionId",
                        column: x => x.OrdenFabricacionId,
                        principalTable: "OrdenFabricaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CondicionIvas",
                columns: new[] { "Id", "AplicaParaFacturaElectronica", "Codigo", "Descripcion", "EmpresaId", "EstaEliminado", "User", "Valor" },
                values: new object[,]
                {
                    { new Guid("2d2eda21-bcdf-4e65-8f84-7fab3213a597"), true, "8", "5 %", null, false, "semilla@tsidkenu.com", 5m },
                    { new Guid("47f1dac2-18e7-4532-8431-0179b4364342"), true, "4", "10,50 %", null, false, "semilla@tsidkenu.com", 10.5m },
                    { new Guid("4ba66fdb-c260-43e1-b41a-5675c6294939"), true, "9", "2,50 %", null, false, "semilla@tsidkenu.com", 2.5m },
                    { new Guid("678fa3c8-d91f-4732-a334-669e87c7adff"), true, "6", "27 %", null, false, "semilla@tsidkenu.com", 27m },
                    { new Guid("93f786b6-a7b5-4071-9cc3-f60b9210777c"), true, "2", "Exento", null, false, "semilla@tsidkenu.com", 0m },
                    { new Guid("9817f462-8fdc-4ec2-8898-817df3b6d383"), true, "7", "Gravado", null, false, "semilla@tsidkenu.com", 0m },
                    { new Guid("a7849c2b-c85a-45f7-b41b-37fd7c2a3391"), true, "1", "No Gravado", null, false, "semilla@tsidkenu.com", 0m },
                    { new Guid("bdde7e70-9ac9-4c83-8f2a-f987e1f89689"), true, "3", "0 %", null, false, "semilla@tsidkenu.com", 0m },
                    { new Guid("d7e228c4-1337-4f37-9a52-7fafdce8789c"), false, "0", "No Corresponde", null, false, "semilla@tsidkenu.com", 0m },
                    { new Guid("ddc29430-8ba3-4b7f-9409-f3ba0192c7b5"), true, "5", "21 %", null, false, "semilla@tsidkenu.com", 21m }
                });

            migrationBuilder.InsertData(
                table: "ConfiguracionesSeguridad",
                columns: new[] { "Id", "EmpresaId", "EnviarMailCreateUsuario", "EstaEliminado", "Host", "LogError", "LogInformacion", "LogWarning", "LoginNormal", "PasswordCredencial", "Puerto", "User", "UsuarioCredencial" },
                values: new object[] { new Guid("aae4b7c7-fc44-4045-82d5-8f82259fe7e1"), new Guid("00000000-0000-0000-0000-000000000000"), true, false, "smtp.gmail.com", true, true, true, false, "yoggzvkvkqhsjsuz", 587, "semilla@tsidkenu.com", "sidkenusoftware@gmail.com" });

            migrationBuilder.InsertData(
                table: "IngresosBrutos",
                columns: new[] { "Id", "Descripcion", "EstaEliminado", "User" },
                values: new object[,]
                {
                    { new Guid("1f240866-5440-4f66-a4b8-2cd1f5d4cf4b"), "Convenio Multilateral", false, "semilla@tsidkenu.com" },
                    { new Guid("e9e8dc8d-78b4-4488-afc0-dee5efc0a44b"), "Simplificado", false, "semilla@tsidkenu.com" },
                    { new Guid("fae8f0d0-a5a2-4e15-b4c3-cfa12f9e1d5f"), "Local ", false, "semilla@tsidkenu.com" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "Descripcion", "EstaEliminado", "User" },
                values: new object[] { new Guid("8deca615-b519-4f3f-9dd8-b2ee38a1b43e"), "Tucuman", false, "semilla@tsidkenu.com" });

            migrationBuilder.InsertData(
                table: "TipoDocumentos",
                columns: new[] { "Id", "Descripcion", "EstaEliminado", "User" },
                values: new object[,]
                {
                    { new Guid("3fa0b564-f847-48e7-87e2-471b56cae5de"), "DNI", false, "semilla@tsidkenu.com" },
                    { new Guid("6aac87dc-0bd0-4b5b-8fa6-7f04f8fcd1e1"), "Sin Identificación", false, "semilla@tsidkenu.com" },
                    { new Guid("7b68bb85-5e28-4af1-b25e-31a6c009206d"), "Libreta Enrole", false, "semilla@tsidkenu.com" },
                    { new Guid("8e355ff5-7ec5-4c3c-97b0-19d52032d70a"), "Libreta Civica", false, "semilla@tsidkenu.com" },
                    { new Guid("a60cb8fa-b79d-432c-9586-6b3d991891c0"), "Pasaporte", false, "semilla@tsidkenu.com" },
                    { new Guid("e518fffd-fd48-4b69-8284-72b28c4945f0"), "CUIL", false, "semilla@tsidkenu.com" },
                    { new Guid("fc9d61cb-485a-4746-a847-8aa7efd793ed"), "CUIT", false, "semilla@tsidkenu.com" }
                });

            migrationBuilder.InsertData(
                table: "TiposResponsabilidades",
                columns: new[] { "Id", "Codigo", "Descripcion", "EstaEliminado", "User" },
                values: new object[,]
                {
                    { new Guid("06ade40a-3b27-47ac-bb1c-acf4f2280845"), 4, "IVA Sujeto Exento", false, "semilla@tsidkenu.com" },
                    { new Guid("8e510066-1784-4612-9594-74da81b032e1"), 9, "Cliente del Exterior", false, "semilla@tsidkenu.com" },
                    { new Guid("9ba3ded3-95db-40a4-8b43-d61217085c43"), 5, "Consumidor Final", false, "semilla@tsidkenu.com" },
                    { new Guid("9f4649d4-6f18-4c6b-b225-d05de6cc8264"), 6, "Responsable Monotributo", false, "semilla@tsidkenu.com" },
                    { new Guid("a10b3dba-f114-45fc-910d-9e7c12cc39c8"), 13, "Monotributista Social", false, "semilla@tsidkenu.com" },
                    { new Guid("a3855865-8614-4887-8d2b-d164c52d58d1"), 10, "IVA Liberado - Ley 19.640", false, "semilla@tsidkenu.com" },
                    { new Guid("add6b889-3f56-431f-9478-fbf3dbf211e2"), 15, "IVA No Alcanzado", false, "semilla@tsidkenu.com" },
                    { new Guid("afc61b18-4dad-41fb-851d-bcec19ba8cdf"), 1, "IVA Responsable No Inscripto", false, "semilla@tsidkenu.com" },
                    { new Guid("cc62a30e-0c04-43b0-97da-9f32f349f9f8"), 8, "Proveedor del Exterior", false, "semilla@tsidkenu.com" }
                });

            migrationBuilder.InsertData(
                table: "Variantes",
                columns: new[] { "Id", "Codigo", "Descripcion", "EmpresaId", "EstaEliminado", "User" },
                values: new object[] { new Guid("e473f5aa-523d-4a67-a670-5996ed58555c"), "VAR9999", "Variante Defecto", null, false, "semilla@tsidkenu.com" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "ActivarBonificacion", "ActivarCuentaCorriente", "Bonificacion", "Direccion", "Documento", "EmpresaId", "EstaEliminado", "FechaNacimiento", "ListaPrecioId", "Mail", "MontoMaximoCompra", "RazonSocial", "Telefono", "TipoDocumentoId", "TipoResponsabilidadId", "User" },
                values: new object[] { new Guid("dce6f3c7-3a5e-413c-abfb-41c2e3f70fce"), false, false, 0m, "Libertad", "99999999", null, false, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "consumidorfinal@gmail.com", 0m, "Consumidor Final", "9999999", new Guid("3fa0b564-f847-48e7-87e2-471b56cae5de"), new Guid("9ba3ded3-95db-40a4-8b43-d61217085c43"), "semilla@tsidkenu.com" });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "Descripcion", "EstaEliminado", "ProvinciaId", "User" },
                values: new object[] { new Guid("2e40bccd-58fd-490d-8f77-4509c14a3517"), "San Miguel de Tucuman", false, new Guid("8deca615-b519-4f3f-9dd8-b2ee38a1b43e"), "semilla@tsidkenu.com" });

            migrationBuilder.InsertData(
                table: "VarianteValores",
                columns: new[] { "Id", "Codigo", "Descripcion", "EstaEliminado", "User", "VarianteId" },
                values: new object[] { new Guid("fb70e9a4-d2a8-444f-8f73-da10d9320430"), "VAR9999", "Variante Valor Defecto", false, "semilla@tsidkenu.com", new Guid("e473f5aa-523d-4a67-a670-5996ed58555c") });

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloBajas_ArticuloId",
                table: "ArticuloBajas",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloBajas_MotivoBajaId",
                table: "ArticuloBajas",
                column: "MotivoBajaId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloDepositos_ArticuloId_DepositoId",
                table: "ArticuloDepositos",
                columns: new[] { "ArticuloId", "DepositoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloDepositos_DepositoId",
                table: "ArticuloDepositos",
                column: "DepositoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloFormulas_ArticuloId",
                table: "ArticuloFormulas",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloFormulas_ArticuloSecundarioId",
                table: "ArticuloFormulas",
                column: "ArticuloSecundarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloHistorialCostos_ArticuloId",
                table: "ArticuloHistorialCostos",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloKits_ArticuloHijoId",
                table: "ArticuloKits",
                column: "ArticuloHijoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloKits_ArticuloPadreId",
                table: "ArticuloKits",
                column: "ArticuloPadreId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloOpcionales_ArticuloHijoId",
                table: "ArticuloOpcionales",
                column: "ArticuloHijoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloOpcionales_ArticuloPadreId",
                table: "ArticuloOpcionales",
                column: "ArticuloPadreId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloPrecios_ArticuloId",
                table: "ArticuloPrecios",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloPrecios_ListaPrecioId",
                table: "ArticuloPrecios",
                column: "ListaPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloProveedores_ArticuloId_ProveedorId",
                table: "ArticuloProveedores",
                columns: new[] { "ArticuloId", "ProveedorId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArticuloProveedores_ProveedorId",
                table: "ArticuloProveedores",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_ArticuloPadreId",
                table: "Articulos",
                column: "ArticuloPadreId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_CondicionIvaId",
                table: "Articulos",
                column: "CondicionIvaId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_EmpresaId_Descripcion",
                table: "Articulos",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_FamiliaId",
                table: "Articulos",
                column: "FamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_MarcaId",
                table: "Articulos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_UnidadMedidaCompraId",
                table: "Articulos",
                column: "UnidadMedidaCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_UnidadMedidaVentaId",
                table: "Articulos",
                column: "UnidadMedidaVentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_VarianteValorDosId",
                table: "Articulos",
                column: "VarianteValorDosId");

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_VarianteValorUnoId",
                table: "Articulos",
                column: "VarianteValorUnoId");

            migrationBuilder.CreateIndex(
                name: "IX_CajaDetalles_CajaId",
                table: "CajaDetalles",
                column: "CajaId");

            migrationBuilder.CreateIndex(
                name: "IX_CajaDetalles_PersonaAperturaId",
                table: "CajaDetalles",
                column: "PersonaAperturaId");

            migrationBuilder.CreateIndex(
                name: "IX_CajaDetalles_PersonaCierreId",
                table: "CajaDetalles",
                column: "PersonaCierreId");

            migrationBuilder.CreateIndex(
                name: "IX_Cajas_EmpresaId_Descripcion",
                table: "Cajas",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EmpresaId_Documento",
                table: "Clientes",
                columns: new[] { "EmpresaId", "Documento" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ListaPrecioId",
                table: "Clientes",
                column: "ListaPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoDocumentoId",
                table: "Clientes",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoResponsabilidadId",
                table: "Clientes",
                column: "TipoResponsabilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprobanteCompra_ProveedorId",
                table: "ComprobanteCompra",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprobanteSalon_MesaId",
                table: "ComprobanteSalon",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprobanteSalon_PersonaId",
                table: "ComprobanteSalon",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicionIvas_EmpresaId_Descripcion",
                table: "CondicionIvas",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionBalanzas_EmpresaId",
                table: "ConfiguracionBalanzas",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionCores_DepositoPorDefectoParaCompraId",
                table: "ConfiguracionCores",
                column: "DepositoPorDefectoParaCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionCores_DepositoPorDefectoParaVentaId",
                table: "ConfiguracionCores",
                column: "DepositoPorDefectoParaVentaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionCores_EmpresaId",
                table: "ConfiguracionCores",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionCores_ListaPrecioPorDefectoParaVentaId",
                table: "ConfiguracionCores",
                column: "ListaPrecioPorDefectoParaVentaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionesSeguridad_EmpresaId",
                table: "ConfiguracionesSeguridad",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contadores_EmpresaId_TipoContador",
                table: "Contadores",
                columns: new[] { "EmpresaId", "TipoContador" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CostoFabricaciones_EmpresaId",
                table: "CostoFabricaciones",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaCorrienteClientes_ClienteId",
                table: "CuentaCorrienteClientes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CuentaCorrienteProveedores_ComprobanteCompraId",
                table: "CuentaCorrienteProveedores",
                column: "ComprobanteCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Depositos_EmpresaId_Descripcion",
                table: "Depositos",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Depositos_PersonaId",
                table: "Depositos",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_Codigo",
                table: "Empresas",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_IngresoBrutoId",
                table: "Empresas",
                column: "IngresoBrutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_LocalidadId",
                table: "Empresas",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_TipoResponsabilidadId",
                table: "Empresas",
                column: "TipoResponsabilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresasPersonas_EmpresaId",
                table: "EmpresasPersonas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresasPersonas_PersonaId_EmpresaId",
                table: "EmpresasPersonas",
                columns: new[] { "PersonaId", "EmpresaId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FamiliaCajas_CajaId",
                table: "FamiliaCajas",
                column: "CajaId");

            migrationBuilder.CreateIndex(
                name: "IX_FamiliaCajas_FamiliaId",
                table: "FamiliaCajas",
                column: "FamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_FamiliaListaPrecios_EmpresaId_FamiliaId_ListaPrecioId",
                table: "FamiliaListaPrecios",
                columns: new[] { "EmpresaId", "FamiliaId", "ListaPrecioId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FamiliaListaPrecios_FamiliaId",
                table: "FamiliaListaPrecios",
                column: "FamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_FamiliaListaPrecios_ListaPrecioId",
                table: "FamiliaListaPrecios",
                column: "ListaPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_Familias_EmpresaId_Descripcion",
                table: "Familias",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Formularios_Codigo",
                table: "Formularios",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_EmpresaId",
                table: "Gastos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_TipoGastoId",
                table: "Gastos",
                column: "TipoGastoId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupoFormularios_FormularioId",
                table: "GrupoFormularios",
                column: "FormularioId");

            migrationBuilder.CreateIndex(
                name: "IX_GrupoFormularios_GrupoId_FormularioId",
                table: "GrupoFormularios",
                columns: new[] { "GrupoId", "FormularioId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GrupoPersonas_GrupoId_PersonaId",
                table: "GrupoPersonas",
                columns: new[] { "GrupoId", "PersonaId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GrupoPersonas_PersonaId",
                table: "GrupoPersonas",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_EmpresaId_Descripcion",
                table: "Grupos",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngresosBrutos_Descripcion",
                table: "IngresosBrutos",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaPrecios_EmpresaId_Descripcion",
                table: "ListaPrecios",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_ProvinciaId_Descripcion",
                table: "Localidades",
                columns: new[] { "ProvinciaId", "Descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarcaListaPrecios_EmpresaId_MarcaId_ListaPrecioId",
                table: "MarcaListaPrecios",
                columns: new[] { "EmpresaId", "MarcaId", "ListaPrecioId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarcaListaPrecios_ListaPrecioId",
                table: "MarcaListaPrecios",
                column: "ListaPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcaListaPrecios_MarcaId",
                table: "MarcaListaPrecios",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_EmpresaId_Descripcion",
                table: "Marcas",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_SalonId_Descripcion",
                table: "Mesas",
                columns: new[] { "SalonId", "Descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modulos_EmpresaId",
                table: "Modulos",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MotivoBajas_EmpresaId_Descripcion",
                table: "MotivoBajas",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCajas_CajaDetalleId",
                table: "MovimientoCajas",
                column: "CajaDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCtaCteClientes_CajaDetalleId",
                table: "MovimientoCtaCteClientes",
                column: "CajaDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCtaCteClientes_CuentaCorrienteClienteId",
                table: "MovimientoCtaCteClientes",
                column: "CuentaCorrienteClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCtaCteProveedores_CajaDetalleId",
                table: "MovimientoCtaCteProveedores",
                column: "CajaDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCtaCteProveedores_CuentaCorrienteProveedorId",
                table: "MovimientoCtaCteProveedores",
                column: "CuentaCorrienteProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoGasto_CajaDetalleId",
                table: "MovimientoGasto",
                column: "CajaDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoGasto_GastoId",
                table: "MovimientoGasto",
                column: "GastoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenFabricacionDetalles_ArticuloId",
                table: "OrdenFabricacionDetalles",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenFabricacionDetalles_OrdenFabricacionId",
                table: "OrdenFabricacionDetalles",
                column: "OrdenFabricacionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenFabricaciones_ArticuloBaseId",
                table: "OrdenFabricaciones",
                column: "ArticuloBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenFabricaciones_DepositoDestinoId",
                table: "OrdenFabricaciones",
                column: "DepositoDestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenFabricaciones_DepositoOrigenId",
                table: "OrdenFabricaciones",
                column: "DepositoOrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenFabricaciones_EmpresaId",
                table: "OrdenFabricaciones",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenFabricaciones_Numero",
                table: "OrdenFabricaciones",
                column: "Numero",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Cuil",
                table: "Personas",
                column: "Cuil",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanTarjetas_TarjetaId_Descripcion",
                table: "PlanTarjetas",
                columns: new[] { "TarjetaId", "Descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_EmpresaId_CUIT",
                table: "Proveedores",
                columns: new[] { "EmpresaId", "CUIT" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_TipoResponsabilidadId",
                table: "Proveedores",
                column: "TipoResponsabilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_Descripcion",
                table: "Provincias",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salones_EmpresaId_Descripcion",
                table: "Salones",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salones_ListaPrecioId",
                table: "Salones",
                column: "ListaPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_Descripcion",
                table: "Tarjetas",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoDocumentos_Descripcion",
                table: "TipoDocumentos",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoGastos_EmpresaId_Descripcion",
                table: "TipoGastos",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TiposResponsabilidades_Descripcion",
                table: "TiposResponsabilidades",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnidadMedidas_EmpresaId_Descripcion",
                table: "UnidadMedidas",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Nombre",
                table: "Usuarios",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PersonaId",
                table: "Usuarios",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Variantes_EmpresaId_Descripcion",
                table: "Variantes",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_VarianteValores_VarianteId_Descripcion",
                table: "VarianteValores",
                columns: new[] { "VarianteId", "Descripcion" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticuloBajas");

            migrationBuilder.DropTable(
                name: "ArticuloDepositos");

            migrationBuilder.DropTable(
                name: "ArticuloFormulas");

            migrationBuilder.DropTable(
                name: "ArticuloHistorialCostos");

            migrationBuilder.DropTable(
                name: "ArticuloKits");

            migrationBuilder.DropTable(
                name: "ArticuloOpcionales");

            migrationBuilder.DropTable(
                name: "ArticuloPrecios");

            migrationBuilder.DropTable(
                name: "ArticuloProveedores");

            migrationBuilder.DropTable(
                name: "ComprobanteSalon");

            migrationBuilder.DropTable(
                name: "ConfiguracionBalanzas");

            migrationBuilder.DropTable(
                name: "ConfiguracionCores");

            migrationBuilder.DropTable(
                name: "ConfiguracionesSeguridad");

            migrationBuilder.DropTable(
                name: "Contadores");

            migrationBuilder.DropTable(
                name: "CostoFabricaciones");

            migrationBuilder.DropTable(
                name: "EmpresasPersonas");

            migrationBuilder.DropTable(
                name: "FamiliaCajas");

            migrationBuilder.DropTable(
                name: "FamiliaListaPrecios");

            migrationBuilder.DropTable(
                name: "GrupoFormularios");

            migrationBuilder.DropTable(
                name: "GrupoPersonas");

            migrationBuilder.DropTable(
                name: "MarcaListaPrecios");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "MovimientoCajas");

            migrationBuilder.DropTable(
                name: "MovimientoCtaCteClientes");

            migrationBuilder.DropTable(
                name: "MovimientoCtaCteProveedores");

            migrationBuilder.DropTable(
                name: "MovimientoGasto");

            migrationBuilder.DropTable(
                name: "OrdenFabricacionDetalles");

            migrationBuilder.DropTable(
                name: "PlanTarjetas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "MotivoBajas");

            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "Formularios");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "CuentaCorrienteClientes");

            migrationBuilder.DropTable(
                name: "CuentaCorrienteProveedores");

            migrationBuilder.DropTable(
                name: "CajaDetalles");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "OrdenFabricaciones");

            migrationBuilder.DropTable(
                name: "Tarjetas");

            migrationBuilder.DropTable(
                name: "Salones");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "ComprobanteCompra");

            migrationBuilder.DropTable(
                name: "Cajas");

            migrationBuilder.DropTable(
                name: "TipoGastos");

            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "Depositos");

            migrationBuilder.DropTable(
                name: "ListaPrecios");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "CondicionIvas");

            migrationBuilder.DropTable(
                name: "Familias");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "UnidadMedidas");

            migrationBuilder.DropTable(
                name: "VarianteValores");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Variantes");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "IngresosBrutos");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "TiposResponsabilidades");

            migrationBuilder.DropTable(
                name: "Provincias");
        }
    }
}
