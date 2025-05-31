using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaStokeo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigrationsTablaNumeroDocumento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "NumeroDocumento",
                newName: "numero_documento");

            migrationBuilder.RenameColumn(
                name: "ultimo_Numero",
                table: "numero_documento",
                newName: "ultimo_numero");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "numero_documento",
                newName: "fecha_registro");

            migrationBuilder.RenameColumn(
                name: "idNumeroDocumento",
                table: "numero_documento",
                newName: "id_numero_documento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "numero_documento",
                newName: "NumeroDocumento");

            migrationBuilder.RenameColumn(
                name: "ultimo_numero",
                table: "NumeroDocumento",
                newName: "ultimo_Numero");

            migrationBuilder.RenameColumn(
                name: "fecha_registro",
                table: "NumeroDocumento",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "id_numero_documento",
                table: "NumeroDocumento",
                newName: "idNumeroDocumento");
        }
    }
}
