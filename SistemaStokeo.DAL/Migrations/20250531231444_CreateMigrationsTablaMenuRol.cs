using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaStokeo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigrationsTablaMenuRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "MenuRol",
                newName: "menu_rol");

            migrationBuilder.RenameColumn(
                name: "idRol",
                table: "menu_rol",
                newName: "id_rol");

            migrationBuilder.RenameColumn(
                name: "idMenu",
                table: "menu_rol",
                newName: "id_menu");

            migrationBuilder.RenameColumn(
                name: "idMenuRol",
                table: "menu_rol",
                newName: "id_menu_rol");

            migrationBuilder.RenameIndex(
                name: "IX_MenuRol_idRol",
                table: "menu_rol",
                newName: "IX_menu_rol_id_rol");

            migrationBuilder.RenameIndex(
                name: "IX_MenuRol_idMenu",
                table: "menu_rol",
                newName: "IX_menu_rol_id_menu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "menu_rol",
                newName: "MenuRol");

            migrationBuilder.RenameColumn(
                name: "id_rol",
                table: "MenuRol",
                newName: "idRol");

            migrationBuilder.RenameColumn(
                name: "id_menu",
                table: "MenuRol",
                newName: "idMenu");

            migrationBuilder.RenameColumn(
                name: "id_menu_rol",
                table: "MenuRol",
                newName: "idMenuRol");

            migrationBuilder.RenameIndex(
                name: "IX_menu_rol_id_rol",
                table: "MenuRol",
                newName: "IX_MenuRol_idRol");

            migrationBuilder.RenameIndex(
                name: "IX_menu_rol_id_menu",
                table: "MenuRol",
                newName: "IX_MenuRol_idMenu");
        }
    }
}
