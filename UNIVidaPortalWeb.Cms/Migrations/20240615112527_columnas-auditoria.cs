using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UNIVidaPortalWeb.Cms.Migrations
{
    /// <inheritdoc />
    public partial class columnasauditoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Secciones",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Secciones",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Secciones",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Secciones",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Recursos",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Recursos",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Recursos",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Recursos",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaginasDinamicas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PaginasDinamicas",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "PaginasDinamicas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "PaginasDinamicas",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Datos",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Datos",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Datos",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Datos",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CatTipoSeccion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CatTipoSeccion",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CatTipoSeccion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "CatTipoSeccion",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CatTipoRecurso",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CatTipoRecurso",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CatTipoRecurso",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "CatTipoRecurso",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "BannerPaginaDinamica",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BannerPaginaDinamica",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "BannerPaginaDinamica",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "BannerPaginaDinamica",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Secciones");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Secciones");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Secciones");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Secciones");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Recursos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Recursos");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Recursos");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Recursos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaginasDinamicas");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PaginasDinamicas");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PaginasDinamicas");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "PaginasDinamicas");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Datos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Datos");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Datos");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Datos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CatTipoSeccion");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CatTipoSeccion");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CatTipoSeccion");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "CatTipoSeccion");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CatTipoRecurso");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CatTipoRecurso");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CatTipoRecurso");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "CatTipoRecurso");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "BannerPaginaDinamica");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BannerPaginaDinamica");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "BannerPaginaDinamica");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "BannerPaginaDinamica");
        }
    }
}
