using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lectores",
                columns: table => new
                {
                    lectorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(maxLength: 60, nullable: false),
                    Nombre = table.Column<string>(maxLength: 60, nullable: false),
                    Domicilio = table.Column<string>(maxLength: 60, nullable: true),
                    Localidad = table.Column<string>(maxLength: 60, nullable: true),
                    Provincia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lectores", x => x.lectorId);
                });

            migrationBuilder.CreateTable(
                name: "libros",
                columns: table => new
                {
                    libroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(maxLength: 80, nullable: true),
                    edicion = table.Column<int>(nullable: false),
                    rutaimagen = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.libroId);
                });

            migrationBuilder.CreateTable(
                name: "prestamos",
                columns: table => new
                {
                    prestamoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(nullable: false),
                    lectorId = table.Column<int>(nullable: false),
                    libroId = table.Column<int>(nullable: false),
                    usuarioId = table.Column<int>(nullable: false),
                    devolucion = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamos", x => x.prestamoId);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    usuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(maxLength: 20, nullable: false),
                    email = table.Column<string>(maxLength: 128, nullable: false),
                    clave = table.Column<string>(maxLength: 20, nullable: false),
                    Apellido = table.Column<string>(maxLength: 60, nullable: true),
                    Nombre = table.Column<string>(maxLength: 60, nullable: true),
                    Domicilio = table.Column<string>(maxLength: 60, nullable: true),
                    Localidad = table.Column<string>(maxLength: 50, nullable: true),
                    Provincia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.usuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lectores");

            migrationBuilder.DropTable(
                name: "libros");

            migrationBuilder.DropTable(
                name: "prestamos");

            migrationBuilder.DropTable(
                name: "usuarios");
        }
    }
}
