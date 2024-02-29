using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddEntidadCajaPuestoTrabajo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CajasPuestosTrabajos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PuestoTrabajoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CajasPuestosTrabajos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CajasPuestosTrabajos_Cajas_CajaId",
                        column: x => x.CajaId,
                        principalTable: "Cajas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CajasPuestosTrabajos_PuestosTrabajos_PuestoTrabajoId",
                        column: x => x.PuestoTrabajoId,
                        principalTable: "PuestosTrabajos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CajasPuestosTrabajos_PuestoTrabajoId",
                table: "CajasPuestosTrabajos",
                column: "PuestoTrabajoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CajasPuestosTrabajos");
        }
    }
}
