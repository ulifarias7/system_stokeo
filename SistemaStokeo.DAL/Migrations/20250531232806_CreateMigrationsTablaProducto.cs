using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaStokeo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigrationsTablaProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "producto");

            migrationBuilder.RenameColumn(
                name: "idCategoria",
                table: "producto",
                newName: "id_categoria");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "producto",
                newName: "fecha_registro");

            migrationBuilder.RenameColumn(
                name: "esActivo",
                table: "producto",
                newName: "es_activo");

            migrationBuilder.RenameColumn(
                name: "idProducto",
                table: "producto",
                newName: "id_producto");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_idCategoria",
                table: "producto",
                newName: "IX_producto_id_categoria");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "producto",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "producto",
                newName: "Producto");

            migrationBuilder.RenameColumn(
                name: "id_categoria",
                table: "Producto",
                newName: "idCategoria");

            migrationBuilder.RenameColumn(
                name: "fecha_registro",
                table: "Producto",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "es_activo",
                table: "Producto",
                newName: "esActivo");

            migrationBuilder.RenameColumn(
                name: "id_producto",
                table: "Producto",
                newName: "idProducto");

            migrationBuilder.RenameIndex(
                name: "IX_producto_id_categoria",
                table: "Producto",
                newName: "IX_Producto_idCategoria");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Producto",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
