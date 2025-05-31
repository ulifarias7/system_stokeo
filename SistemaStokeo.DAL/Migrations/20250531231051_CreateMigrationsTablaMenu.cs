using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaStokeo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigrationsTablaMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "menu");

            migrationBuilder.RenameColumn(
                name: "IdMenu",
                table: "menu",
                newName: "id_menu");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "menu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "icono",
                table: "menu",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "menu",
                newName: "Menu");

            migrationBuilder.RenameColumn(
                name: "id_menu",
                table: "Menu",
                newName: "IdMenu");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Menu",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "icono",
                table: "Menu",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);
        }
    }
}
