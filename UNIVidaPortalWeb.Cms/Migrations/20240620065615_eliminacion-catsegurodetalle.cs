using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class eliminacioncatsegurodetalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeguroDetalles_CatTipoSeguroDetalle_CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles");

            migrationBuilder.DropTable(
                name: "CatTipoSeguroDetalle",
                schema: "Catalogo");

            migrationBuilder.DropIndex(
                name: "IX_SeguroDetalles_CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles");

            migrationBuilder.DropColumn(
                name: "CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CatTipoSeguroDetalle",
                schema: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoSeguroDetalle", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeguroDetalles_CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles",
                column: "CatTipoSeguroDetalleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeguroDetalles_CatTipoSeguroDetalle_CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles",
                column: "CatTipoSeguroDetalleId",
                principalSchema: "Catalogo",
                principalTable: "CatTipoSeguroDetalle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
