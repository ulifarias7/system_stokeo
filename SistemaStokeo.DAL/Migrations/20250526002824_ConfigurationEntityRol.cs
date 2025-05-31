using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaStokeo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ConfigurationEntityRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Rol",
                newName: "rol");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "rol",
                newName: "fecha_registro");

            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "rol",
                newName: "id_rol");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "rol",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_rol_nombre",
                table: "rol",
                column: "nombre",
                unique: true,
                filter: "[nombre] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_rol_nombre",
                table: "rol");

            migrationBuilder.RenameTable(
                name: "rol",
                newName: "Rol");

            migrationBuilder.RenameColumn(
                name: "fecha_registro",
                table: "Rol",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "id_rol",
                table: "Rol",
                newName: "IdRol");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Rol",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
