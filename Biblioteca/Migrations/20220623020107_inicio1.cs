using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations
{
    public partial class inicio1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lectorId",
                table: "prestamos");

            migrationBuilder.DropColumn(
                name: "libroId",
                table: "prestamos");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "prestamos");

            migrationBuilder.AddColumn<int>(
                name: "Lector",
                table: "prestamos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Libro",
                table: "prestamos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Usuario",
                table: "prestamos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_Lector",
                table: "prestamos",
                column: "Lector");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_Libro",
                table: "prestamos",
                column: "Libro");

            migrationBuilder.CreateIndex(
                name: "IX_prestamos_Usuario",
                table: "prestamos",
                column: "Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_prestamos_lectores_Lector",
                table: "prestamos",
                column: "Lector",
                principalTable: "lectores",
                principalColumn: "lectorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prestamos_libros_Libro",
                table: "prestamos",
                column: "Libro",
                principalTable: "libros",
                principalColumn: "libroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_prestamos_usuarios_Usuario",
                table: "prestamos",
                column: "Usuario",
                principalTable: "usuarios",
                principalColumn: "usuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prestamos_lectores_Lector",
                table: "prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_prestamos_libros_Libro",
                table: "prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_prestamos_usuarios_Usuario",
                table: "prestamos");

            migrationBuilder.DropIndex(
                name: "IX_prestamos_Lector",
                table: "prestamos");

            migrationBuilder.DropIndex(
                name: "IX_prestamos_Libro",
                table: "prestamos");

            migrationBuilder.DropIndex(
                name: "IX_prestamos_Usuario",
                table: "prestamos");

            migrationBuilder.DropColumn(
                name: "Lector",
                table: "prestamos");

            migrationBuilder.DropColumn(
                name: "Libro",
                table: "prestamos");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "prestamos");

            migrationBuilder.AddColumn<int>(
                name: "lectorId",
                table: "prestamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "libroId",
                table: "prestamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuarioId",
                table: "prestamos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
