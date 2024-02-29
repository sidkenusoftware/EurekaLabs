using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sidkenu.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddMediosDePagos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "MedioPagos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComprobanteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Capital = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    Interes = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BancoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NumeroCheque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlanTarjetaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NumeroCupon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedioPagoTransferencia_BancoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NumeroTransferencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NombreTitular = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstaEliminado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedioPagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedioPagos_Bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "Bancos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedioPagos_Bancos_MedioPagoTransferencia_BancoId",
                        column: x => x.MedioPagoTransferencia_BancoId,
                        principalTable: "Bancos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedioPagos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedioPagos_Comprobantes_ComprobanteId",
                        column: x => x.ComprobanteId,
                        principalTable: "Comprobantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedioPagos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedioPagos_PlanTarjetas_PlanTarjetaId",
                        column: x => x.PlanTarjetaId,
                        principalTable: "PlanTarjetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_EmpresaId",
                table: "Tarjetas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Bancos_EmpresaId",
                table: "Bancos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_MedioPagos_BancoId",
                table: "MedioPagos",
                column: "BancoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedioPagos_ClienteId",
                table: "MedioPagos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_MedioPagos_ComprobanteId",
                table: "MedioPagos",
                column: "ComprobanteId");

            migrationBuilder.CreateIndex(
                name: "IX_MedioPagos_EmpresaId",
                table: "MedioPagos",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedioPagos_MedioPagoTransferencia_BancoId",
                table: "MedioPagos",
                column: "MedioPagoTransferencia_BancoId");

            migrationBuilder.CreateIndex(
                name: "IX_MedioPagos_PlanTarjetaId",
                table: "MedioPagos",
                column: "PlanTarjetaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bancos_Empresas_EmpresaId",
                table: "Bancos",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarjetas_Empresas_EmpresaId",
                table: "Tarjetas",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bancos_Empresas_EmpresaId",
                table: "Bancos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tarjetas_Empresas_EmpresaId",
                table: "Tarjetas");

            migrationBuilder.DropTable(
                name: "MedioPagos");

            migrationBuilder.DropIndex(
                name: "IX_Tarjetas_EmpresaId",
                table: "Tarjetas");

            migrationBuilder.DropIndex(
                name: "IX_Bancos_EmpresaId",
                table: "Bancos");
        }
    }
}
