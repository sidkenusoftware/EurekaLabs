using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddCampoFotoDetalleComprobante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Articulos_EmpresaId_Descripcion",
                table: "Articulos");
                        
            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "OrdenFabricaciones",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Foto",
                table: "ComprobanteDetalles",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AddColumn<int>(
                name: "TipoItem",
                table: "ComprobanteDetalles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_EmpresaId_Codigo",
                table: "Articulos",
                columns: new[] { "EmpresaId", "Codigo" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Articulos_EmpresaId_Codigo",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "Foto",
                table: "OrdenFabricaciones");

            migrationBuilder.DropColumn(
                name: "TipoItem",
                table: "ComprobanteDetalles");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Foto",
                table: "ComprobanteDetalles",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_EmpresaId_Descripcion",
                table: "Articulos",
                columns: new[] { "EmpresaId", "Descripcion" },
                unique: true,
                filter: "[EmpresaId] IS NOT NULL");
        }
    }
}
