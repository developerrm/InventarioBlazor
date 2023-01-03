using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TBodega",
                columns: new[] { "BodegaID", "Direccion", "Nombre" },
                values: new object[] { 1, "Los Esteros", "Principal" });

            migrationBuilder.InsertData(
                table: "TCategoria",
                columns: new[] { "CategoriaID", "Descripcion" },
                values: new object[] { 1, "Aseo Hogar" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TBodega",
                keyColumn: "BodegaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TCategoria",
                keyColumn: "CategoriaID",
                keyValue: 1);
        }
    }
}
