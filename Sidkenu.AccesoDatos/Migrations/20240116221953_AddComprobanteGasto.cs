using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddComprobanteGasto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TipoGastoId",
                table: "Comprobantes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ArticuloId",
                table: "ComprobanteDetalles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_TipoGastoId",
                table: "Comprobantes",
                column: "TipoGastoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comprobantes_TipoGastos_TipoGastoId",
                table: "Comprobantes",
                column: "TipoGastoId",
                principalTable: "TipoGastos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comprobantes_TipoGastos_TipoGastoId",
                table: "Comprobantes");

            migrationBuilder.DropIndex(
                name: "IX_Comprobantes_TipoGastoId",
                table: "Comprobantes");

            migrationBuilder.DropColumn(
                name: "TipoGastoId",
                table: "Comprobantes");

            migrationBuilder.AlterColumn<Guid>(
                name: "ArticuloId",
                table: "ComprobanteDetalles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);
        }
    }
}
