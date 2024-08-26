using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Noticias.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Noticias");

            migrationBuilder.EnsureSchema(
                name: "Parametricas");

            migrationBuilder.CreateTable(
                name: "ParCategoria",
                schema: "Parametricas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParCategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParEstado",
                schema: "Parametricas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParEstado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParTipoRecurso",
                schema: "Parametricas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Habilitado = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParTipoRecurso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                schema: "Noticias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    ParTipoRecursoId = table.Column<int>(type: "integer", nullable: false),
                    RecursoEscritorio = table.Column<string>(type: "text", nullable: false),
                    RecursoMovil = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recurso_ParTipoRecurso_ParTipoRecursoId",
                        column: x => x.ParTipoRecursoId,
                        principalSchema: "Parametricas",
                        principalTable: "ParTipoRecurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Noticia",
                schema: "Noticias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    TituloCorto = table.Column<string>(type: "text", nullable: false),
                    Contenido = table.Column<string>(type: "text", nullable: false),
                    Resumen = table.Column<string>(type: "text", nullable: false),
                    RecursoId_ImagenPrincipal = table.Column<int>(type: "integer", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ParCategoriaId = table.Column<int>(type: "integer", nullable: false),
                    ParEstado = table.Column<int>(type: "integer", nullable: false),
                    Etiquetas = table.Column<string>(type: "text", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Noticia_ParCategoria_ParCategoriaId",
                        column: x => x.ParCategoriaId,
                        principalSchema: "Parametricas",
                        principalTable: "ParCategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Noticia_Recurso_RecursoId_ImagenPrincipal",
                        column: x => x.RecursoId_ImagenPrincipal,
                        principalSchema: "Noticias",
                        principalTable: "Recurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_ParCategoriaId",
                schema: "Noticias",
                table: "Noticia",
                column: "ParCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_RecursoId_ImagenPrincipal",
                schema: "Noticias",
                table: "Noticia",
                column: "RecursoId_ImagenPrincipal");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_ParTipoRecursoId",
                schema: "Noticias",
                table: "Recurso",
                column: "ParTipoRecursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noticia",
                schema: "Noticias");

            migrationBuilder.DropTable(
                name: "ParEstado",
                schema: "Parametricas");

            migrationBuilder.DropTable(
                name: "ParCategoria",
                schema: "Parametricas");

            migrationBuilder.DropTable(
                name: "Recurso",
                schema: "Noticias");

            migrationBuilder.DropTable(
                name: "ParTipoRecurso",
                schema: "Parametricas");
        }
    }
}
