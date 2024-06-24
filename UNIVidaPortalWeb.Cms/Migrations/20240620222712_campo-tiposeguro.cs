using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class campotiposeguro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Habilitado",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Habilitado",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CatTipoSeguro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Ruta = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoSeguro", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatTipoSeguro");

            migrationBuilder.DropColumn(
                name: "CatTipoSeguroId",
                schema: "Seguro",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "Habilitado",
                schema: "Catalogo",
                table: "CatTipoSeccion");

            migrationBuilder.DropColumn(
                name: "Habilitado",
                schema: "Catalogo",
                table: "CatTipoRecurso");
        }
    }
}
