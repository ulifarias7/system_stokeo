using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaStokeo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigrationsTablaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "usuario");

            migrationBuilder.RenameColumn(
                name: "nombreCompleto",
                table: "usuario",
                newName: "nombre_completo");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "usuario",
                newName: "fecha_registro");

            migrationBuilder.RenameColumn(
                name: "esActivo",
                table: "usuario",
                newName: "es_activo");

            migrationBuilder.RenameColumn(
                name: "idUsuario",
                table: "usuario",
                newName: "id_usuario");

            migrationBuilder.RenameIndex(
                name: "IX_Usuario_IdRol",
                table: "usuario",
                newName: "IX_usuario_IdRol");

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldUnicode: false,
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "clave",
                table: "usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldUnicode: false,
                oldMaxLength: 40,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "usuario",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "nombre_completo",
                table: "Usuario",
                newName: "nombreCompleto");

            migrationBuilder.RenameColumn(
                name: "fecha_registro",
                table: "Usuario",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "es_activo",
                table: "Usuario",
                newName: "esActivo");

            migrationBuilder.RenameColumn(
                name: "id_usuario",
                table: "Usuario",
                newName: "idUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_usuario_IdRol",
                table: "Usuario",
                newName: "IX_Usuario_IdRol");

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "Usuario",
                type: "varchar(40)",
                unicode: false,
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "clave",
                table: "Usuario",
                type: "varchar(40)",
                unicode: false,
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
