using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMovimientoCtaGastProvee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovimientoCtaCteClientes");

            migrationBuilder.DropTable(
                name: "MovimientoCtaCteProveedores");

            migrationBuilder.DropTable(
                name: "MovimientoGasto");

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "MovimientoCajas");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "MovimientoCajas",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<decimal>(
                name: "Capital",
                table: "MovimientoCajas",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<Guid>(
                name: "ComprobanteId",
                table: "MovimientoCajas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Interes",
                table: "MovimientoCajas",
                type: "decimal(18,6)",
                precision: 18,
                scale: 6,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TipoOperacion",
                table: "MovimientoCajas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MovimientoCajas_ComprobanteId",
                table: "MovimientoCajas",
                column: "ComprobanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovimientoCajas_Comprobantes_ComprobanteId",
                table: "MovimientoCajas",
                column: "ComprobanteId",
                principalTable: "Comprobantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovimientoCajas_Comprobantes_ComprobanteId",
                table: "MovimientoCajas");

            migrationBuilder.DropIndex(
                name: "IX_MovimientoCajas_ComprobanteId",
                table: "MovimientoCajas");

            migrationBuilder.DropColumn(
                name: "Capital",
                table: "MovimientoCajas");

            migrationBuilder.DropColumn(
                name: "ComprobanteId",
                table: "MovimientoCajas");

            migrationBuilder.DropColumn(
                name: "Interes",
                table: "MovimientoCajas");

            migrationBuilder.DropColumn(
                name: "TipoOperacion",
                table: "MovimientoCajas");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "MovimientoCajas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<decimal>(
                name: "Monto",
                table: "MovimientoCajas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "MovimientoCtaCteClientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaDetalleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CuentaCorrienteClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "MovimientoCtaCteProveedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaDetalleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CuentaCorrienteProveedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "MovimientoGasto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaDetalleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GastoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
        }
    }
}
