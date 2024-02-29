using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIndexEmpresaIdDeComprobante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MedioPagos_EmpresaId",
                table: "MedioPagos");

            migrationBuilder.DropIndex(
                name: "IX_Comprobantes_EmpresaId",
                table: "Comprobantes");

            migrationBuilder.CreateIndex(
                name: "IX_MedioPagos_EmpresaId",
                table: "MedioPagos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_EmpresaId",
                table: "Comprobantes",
                column: "EmpresaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MedioPagos_EmpresaId",
                table: "MedioPagos");

            migrationBuilder.DropIndex(
                name: "IX_Comprobantes_EmpresaId",
                table: "Comprobantes");

            migrationBuilder.CreateIndex(
                name: "IX_MedioPagos_EmpresaId",
                table: "MedioPagos",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comprobantes_EmpresaId",
                table: "Comprobantes",
                column: "EmpresaId",
                unique: true);
        }
    }
}
