using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaStokeo.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateMigrationsTablaDetalleVenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "DetalleVenta",
                newName: "detalle_venta");

            migrationBuilder.RenameColumn(
                name: "idVenta",
                table: "detalle_venta",
                newName: "id_venta");

            migrationBuilder.RenameColumn(
                name: "idProducto",
                table: "detalle_venta",
                newName: "id_producto");

            migrationBuilder.RenameColumn(
                name: "idDetalleVens",
                table: "detalle_venta",
                newName: "id_detalle_venta");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_idVenta",
                table: "detalle_venta",
                newName: "IX_detalle_venta_id_venta");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_idProducto",
                table: "detalle_venta",
                newName: "IX_detalle_venta_id_producto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "detalle_venta",
                newName: "DetalleVenta");

            migrationBuilder.RenameColumn(
                name: "id_venta",
                table: "DetalleVenta",
                newName: "idVenta");

            migrationBuilder.RenameColumn(
                name: "id_producto",
                table: "DetalleVenta",
                newName: "idProducto");

            migrationBuilder.RenameColumn(
                name: "id_detalle_venta",
                table: "DetalleVenta",
                newName: "idDetalleVens");

            migrationBuilder.RenameIndex(
                name: "IX_detalle_venta_id_venta",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_idVenta");

            migrationBuilder.RenameIndex(
                name: "IX_detalle_venta_id_producto",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_idProducto");
        }
    }
}
