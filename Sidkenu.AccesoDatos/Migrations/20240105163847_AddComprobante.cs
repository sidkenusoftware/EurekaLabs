using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddComprobante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComprobanteSalon_Mesas_MesaId",
                table: "ComprobanteSalon");

            migrationBuilder.DropForeignKey(
                name: "FK_ComprobanteSalon_Personas_PersonaId",
                table: "ComprobanteSalon");

            migrationBuilder.DropForeignKey(
                name: "FK_CuentaCorrienteProveedores_ComprobanteCompra_ComprobanteCompraId",
                table: "CuentaCorrienteProveedores");

            migrationBuilder.DropTable(
                name: "ComprobanteCompra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComprobanteSalon",
                table: "ComprobanteSalon");
            
            migrationBuilder.RenameTable(
                name: "ComprobanteSalon",
                newName: "Comprobantes");

            migrationBuilder.RenameColumn(
                name: "EstadoComprobanteSalon",
                table: "Comprobantes",
                newName: "EstadoComprobante");

            migrationBuilder.RenameIndex(
                name: "IX_ComprobanteSalon_PersonaId",
                table: "Comprobantes",
                newName: "IX_Comprobantes_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_ComprobanteSalon_MesaId",
                table: "Comprobantes",
                newName: "IX_Comprobantes_MesaId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Comprobantes",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "Comprobantes",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Comprobantes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "MesaId",
                table: "Comprobantes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Comprobantes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Descuento",
                table: "Comprobantes",
                type: "decimal(4,2)",
                precision: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Comprobantes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "EmpresaId",
                table: "Comprobantes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Iva105",
                table: "Comprobantes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Iva21",
                table: "Comprobantes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Iva27",
                table: "Comprobantes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroCompra",
                table: "Comprobantes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PercepcionIB",
                table: "Comprobantes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PercepcionIva",
                table: "Comprobantes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PercepcionPyP",
                table: "Comprobantes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PercepcionTemp",
                table: "Comprobantes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProveedorId",
                table: "Comprobantes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comprobantes",
                table: "Comprobantes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ComprobanteDetalles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComprobanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Neto = table.Column<decimal>(type: "decimal(4,2)", precision: 4, nullable: false),
                    Alicuota = table.Column<decimal>(type: "decimal(4,2)", precision: 4, nullable: false),
                    Iva = table.Column<decimal>(type: "decimal(4,2)", precision: 4, nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(4,2)", precision: 4, nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(4,2)", precision: 4, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprobanteDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprobanteDetalles_Articulos_ArticuloId",
                        column: x => x.ArticuloId,
                        principalTable: "Articulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComprobanteDetalles_Comprobantes_ComprobanteId",
                        column: x => x.ComprobanteId,
                        principalTable: "Comprobantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComprobanteTotales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComprobanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Neto = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Alicuota = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    Iva = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprobanteTotales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprobanteTotales_Comprobantes_ComprobanteId",
                        column: x => x.ComprobanteId,
                        principalTable: "Comprobantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComprobanteDetalleFabricaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComprobanteDetalleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticuloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(4,2)", precision: 4, nullable: false),
                    PrecioPublico = table.Column<decimal>(type: "decimal(4,2)", precision: 4, nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(4,2)", precision: 4, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprobanteDetalleFabricaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprobanteDetalleFabricaciones_ComprobanteDetalles_ComprobanteDetalleId",
                        column: x => x.ComprobanteDetalleId,
                        principalTable: "ComprobanteDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
                        
            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_ClienteId",
                table: "Comprobantes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_EmpresaId",
                table: "Comprobantes",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_ProveedorId",
                table: "Comprobantes",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprobanteDetalleFabricaciones_ComprobanteDetalleId",
                table: "ComprobanteDetalleFabricaciones",
                column: "ComprobanteDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprobanteDetalles_ArticuloId",
                table: "ComprobanteDetalles",
                column: "ArticuloId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprobanteDetalles_ComprobanteId",
                table: "ComprobanteDetalles",
                column: "ComprobanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprobanteTotales_ComprobanteId",
                table: "ComprobanteTotales",
                column: "ComprobanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comprobantes_Clientes_ClienteId",
                table: "Comprobantes",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comprobantes_Empresas_EmpresaId",
                table: "Comprobantes",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comprobantes_Mesas_MesaId",
                table: "Comprobantes",
                column: "MesaId",
                principalTable: "Mesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comprobantes_Personas_PersonaId",
                table: "Comprobantes",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comprobantes_Proveedores_ProveedorId",
                table: "Comprobantes",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CuentaCorrienteProveedores_Comprobantes_ComprobanteCompraId",
                table: "CuentaCorrienteProveedores",
                column: "ComprobanteCompraId",
                principalTable: "Comprobantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comprobantes_Clientes_ClienteId",
                table: "Comprobantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Comprobantes_Empresas_EmpresaId",
                table: "Comprobantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Comprobantes_Mesas_MesaId",
                table: "Comprobantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Comprobantes_Personas_PersonaId",
                table: "Comprobantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Comprobantes_Proveedores_ProveedorId",
                table: "Comprobantes");

            migrationBuilder.DropForeignKey(
                name: "FK_CuentaCorrienteProveedores_Comprobantes_ComprobanteCompraId",
                table: "CuentaCorrienteProveedores");

            migrationBuilder.DropTable(
                name: "ComprobanteDetalleFabricaciones");

            migrationBuilder.DropTable(
                name: "ComprobanteTotales");

            migrationBuilder.DropTable(
                name: "ComprobanteDetalles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comprobantes",
                table: "Comprobantes");

            migrationBuilder.DropIndex(
                name: "IX_Comprobantes_ClienteId",
                table: "Comprobantes");

            migrationBuilder.DropIndex(
                name: "IX_Comprobantes_EmpresaId",
                table: "Comprobantes");

            migrationBuilder.DropIndex(
                name: "IX_Comprobantes_ProveedorId",
                table: "Comprobantes");
            
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "Descuento",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "Iva105",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "Iva21",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "Iva27",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "NumeroCompra",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "PercepcionIB",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "PercepcionIva",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "PercepcionPyP",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "PercepcionTemp",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                table: "Comprobantes");

            migrationBuilder.RenameTable(
                name: "Comprobantes",
                newName: "ComprobanteSalon");

            migrationBuilder.RenameColumn(
                name: "EstadoComprobante",
                table: "ComprobanteSalon",
                newName: "EstadoComprobanteSalon");

            migrationBuilder.RenameIndex(
                name: "IX_Comprobantes_PersonaId",
                table: "ComprobanteSalon",
                newName: "IX_ComprobanteSalon_PersonaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comprobantes_MesaId",
                table: "ComprobanteSalon",
                newName: "IX_ComprobanteSalon_MesaId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "ComprobanteSalon",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "SubTotal",
                table: "ComprobanteSalon",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4);

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "ComprobanteSalon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MesaId",
                table: "ComprobanteSalon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComprobanteSalon",
                table: "ComprobanteSalon",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ComprobanteCompra",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProveedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Iva105 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iva21 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iva27 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    NumeroCompra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PercepcionIB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercepcionIva = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercepcionPyP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercepcionTemp = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoComprobante = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
            
            migrationBuilder.CreateIndex(
                name: "IX_ComprobanteCompra_ProveedorId",
                table: "ComprobanteCompra",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComprobanteSalon_Mesas_MesaId",
                table: "ComprobanteSalon",
                column: "MesaId",
                principalTable: "Mesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComprobanteSalon_Personas_PersonaId",
                table: "ComprobanteSalon",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CuentaCorrienteProveedores_ComprobanteCompra_ComprobanteCompraId",
                table: "CuentaCorrienteProveedores",
                column: "ComprobanteCompraId",
                principalTable: "ComprobanteCompra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
