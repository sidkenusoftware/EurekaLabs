using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddCajaEnPuestoTrabajo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CajaId",
                table: "PuestosTrabajos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PuestosTrabajos_CajaId",
                table: "PuestosTrabajos",
                column: "CajaId");

            migrationBuilder.AddForeignKey(
                name: "FK_PuestosTrabajos_Cajas_CajaId",
                table: "PuestosTrabajos",
                column: "CajaId",
                principalTable: "Cajas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PuestosTrabajos_Cajas_CajaId",
                table: "PuestosTrabajos");

            migrationBuilder.DropIndex(
                name: "IX_PuestosTrabajos_CajaId",
                table: "PuestosTrabajos");

            migrationBuilder.DropColumn(
                name: "CajaId",
                table: "PuestosTrabajos");

        }
    }
}
