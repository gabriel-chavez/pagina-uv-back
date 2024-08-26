using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class actualizaciónbasedomainmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "Seguro",
                table: "Seguros",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "Seguro",
                table: "Seguros",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "Seguro",
                table: "Seguros",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Seguro",
                table: "Seguros",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "Recurso",
                table: "Recursos",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "Recurso",
                table: "Recursos",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "Recurso",
                table: "Recursos",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Recurso",
                table: "Recursos",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "Seguro",
                table: "Planes",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "Seguro",
                table: "Planes",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "Seguro",
                table: "Planes",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Seguro",
                table: "Planes",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "CreadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "FechaUltimaModificacion");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "CreadoPor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "Seguro",
                table: "Seguros",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Seguro",
                table: "Seguros",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "Seguro",
                table: "Seguros",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "Seguro",
                table: "Seguros",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "Seguro",
                table: "SeguroDetalles",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "PaginaDinamica",
                table: "Secciones",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "Recurso",
                table: "Recursos",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Recurso",
                table: "Recursos",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "Recurso",
                table: "Recursos",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "Recurso",
                table: "Recursos",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "Seguro",
                table: "Planes",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Seguro",
                table: "Planes",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "Seguro",
                table: "Planes",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "Seguro",
                table: "Planes",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "PaginaDinamica",
                table: "PaginasDinamicas",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "Menu",
                table: "MenuPrincipal",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "PaginaDinamica",
                table: "Datos",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "Catalogo",
                table: "CatTipoSeguro",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "Catalogo",
                table: "CatTipoSeccion",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "Catalogo",
                table: "CatTipoRecurso",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "FechaUltimaModificacion",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CreadoPor",
                schema: "Recurso",
                table: "BannerPagina",
                newName: "CreatedBy");
        }
    }
}
