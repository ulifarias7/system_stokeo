using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaStokeo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigrationsTablaVenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Venta",
                newName: "venta");

            migrationBuilder.RenameColumn(
                name: "tipoPago",
                table: "venta",
                newName: "tipo_pago");

            migrationBuilder.RenameColumn(
                name: "numeroDocumento",
                table: "venta",
                newName: "numero_documento");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "venta",
                newName: "fecha_registro");

            migrationBuilder.RenameColumn(
                name: "idVenta",
                table: "venta",
                newName: "id_venta");

            migrationBuilder.AlterColumn<string>(
                name: "tipo_pago",
                table: "venta",
                type: "nvarchar(max)",
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
                name: "venta",
                newName: "Venta");

            migrationBuilder.RenameColumn(
                name: "tipo_pago",
                table: "Venta",
                newName: "tipoPago");

            migrationBuilder.RenameColumn(
                name: "numero_documento",
                table: "Venta",
                newName: "numeroDocumento");

            migrationBuilder.RenameColumn(
                name: "fecha_registro",
                table: "Venta",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "id_venta",
                table: "Venta",
                newName: "idVenta");

            migrationBuilder.AlterColumn<string>(
                name: "tipoPago",
                table: "Venta",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
