using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Recurso");

            migrationBuilder.EnsureSchema(
                name: "Catalogo");

            migrationBuilder.EnsureSchema(
                name: "PaginaDinamica");

            migrationBuilder.EnsureSchema(
                name: "Seguro");

            migrationBuilder.CreateTable(
                name: "CatTipoRecurso",
                schema: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoRecurso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoSeccion",
                schema: "Catalogo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoSeccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoSeguroDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoSeguroDetalles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaginasDinamicas",
                schema: "PaginaDinamica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Ruta = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaginasDinamicas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seguros",
                schema: "Seguro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recursos",
                schema: "Recurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    CatTipoRecursoId = table.Column<int>(type: "integer", nullable: false),
                    RecursoEscritorio = table.Column<string>(type: "text", nullable: false),
                    RecursoMovil = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recursos_CatTipoRecurso_CatTipoRecursoId",
                        column: x => x.CatTipoRecursoId,
                        principalSchema: "Catalogo",
                        principalTable: "CatTipoRecurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Secciones",
                schema: "PaginaDinamica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CatTipoSeccionId = table.Column<int>(type: "integer", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: true),
                    SubTitulo = table.Column<string>(type: "text", nullable: true),
                    Clase = table.Column<string>(type: "text", nullable: true),
                    PaginaDinamicaId = table.Column<int>(type: "integer", nullable: false),
                    Orden = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secciones_CatTipoSeccion_CatTipoSeccionId",
                        column: x => x.CatTipoSeccionId,
                        principalSchema: "Catalogo",
                        principalTable: "CatTipoSeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Secciones_PaginasDinamicas_PaginaDinamicaId",
                        column: x => x.PaginaDinamicaId,
                        principalSchema: "PaginaDinamica",
                        principalTable: "PaginasDinamicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                schema: "Seguro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SeguroId = table.Column<int>(type: "integer", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    SubTitulo = table.Column<string>(type: "text", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    Cobertura = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Planes_Seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalSchema: "Seguro",
                        principalTable: "Seguros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeguroDetalles",
                schema: "Seguro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SeguroId = table.Column<int>(type: "integer", nullable: false),
                    CatTipoSeguroDetalleId = table.Column<int>(type: "integer", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Respuesta = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguroDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeguroDetalles_CatTipoSeguroDetalles_CatTipoSeguroDetalleId",
                        column: x => x.CatTipoSeguroDetalleId,
                        principalTable: "CatTipoSeguroDetalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeguroDetalles_Seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalSchema: "Seguro",
                        principalTable: "Seguros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BannerPagina",
                schema: "Recurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PaginaDinamicaId = table.Column<int>(type: "integer", nullable: true),
                    SeguroId = table.Column<int>(type: "integer", nullable: true),
                    RecursoId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerPagina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BannerPagina_PaginasDinamicas_PaginaDinamicaId",
                        column: x => x.PaginaDinamicaId,
                        principalSchema: "PaginaDinamica",
                        principalTable: "PaginasDinamicas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BannerPagina_Recursos_RecursoId",
                        column: x => x.RecursoId,
                        principalSchema: "Recurso",
                        principalTable: "Recursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BannerPagina_Seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalSchema: "Seguro",
                        principalTable: "Seguros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Datos",
                schema: "PaginaDinamica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DatoTexto = table.Column<string>(type: "text", nullable: true),
                    DatoFechaHora = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DatoUrl = table.Column<string>(type: "text", nullable: true),
                    RecursoId = table.Column<int>(type: "integer", nullable: true),
                    SeccionId = table.Column<int>(type: "integer", nullable: false),
                    Fila = table.Column<int>(type: "integer", nullable: false),
                    Columna = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datos_Recursos_RecursoId",
                        column: x => x.RecursoId,
                        principalSchema: "Recurso",
                        principalTable: "Recursos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Datos_Secciones_SeccionId",
                        column: x => x.SeccionId,
                        principalSchema: "PaginaDinamica",
                        principalTable: "Secciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BannerPagina_PaginaDinamicaId",
                schema: "Recurso",
                table: "BannerPagina",
                column: "PaginaDinamicaId");

            migrationBuilder.CreateIndex(
                name: "IX_BannerPagina_RecursoId",
                schema: "Recurso",
                table: "BannerPagina",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_BannerPagina_SeguroId",
                schema: "Recurso",
                table: "BannerPagina",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_RecursoId",
                schema: "PaginaDinamica",
                table: "Datos",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_SeccionId",
                schema: "PaginaDinamica",
                table: "Datos",
                column: "SeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_SeguroId",
                schema: "Seguro",
                table: "Planes",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Recursos_CatTipoRecursoId",
                schema: "Recurso",
                table: "Recursos",
                column: "CatTipoRecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Secciones_CatTipoSeccionId",
                schema: "PaginaDinamica",
                table: "Secciones",
                column: "CatTipoSeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Secciones_PaginaDinamicaId",
                schema: "PaginaDinamica",
                table: "Secciones",
                column: "PaginaDinamicaId");

            migrationBuilder.CreateIndex(
                name: "IX_SeguroDetalles_CatTipoSeguroDetalleId",
                schema: "Seguro",
                table: "SeguroDetalles",
                column: "CatTipoSeguroDetalleId");

            migrationBuilder.CreateIndex(
                name: "IX_SeguroDetalles_SeguroId",
                schema: "Seguro",
                table: "SeguroDetalles",
                column: "SeguroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannerPagina",
                schema: "Recurso");

            migrationBuilder.DropTable(
                name: "Datos",
                schema: "PaginaDinamica");

            migrationBuilder.DropTable(
                name: "Planes",
                schema: "Seguro");

            migrationBuilder.DropTable(
                name: "SeguroDetalles",
                schema: "Seguro");

            migrationBuilder.DropTable(
                name: "Recursos",
                schema: "Recurso");

            migrationBuilder.DropTable(
                name: "Secciones",
                schema: "PaginaDinamica");

            migrationBuilder.DropTable(
                name: "CatTipoSeguroDetalles");

            migrationBuilder.DropTable(
                name: "Seguros",
                schema: "Seguro");

            migrationBuilder.DropTable(
                name: "CatTipoRecurso",
                schema: "Catalogo");

            migrationBuilder.DropTable(
                name: "CatTipoSeccion",
                schema: "Catalogo");

            migrationBuilder.DropTable(
                name: "PaginasDinamicas",
                schema: "PaginaDinamica");
        }
    }
}
