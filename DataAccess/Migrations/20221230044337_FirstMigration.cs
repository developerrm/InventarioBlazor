using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBodega",
                columns: table => new
                {
                    BodegaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBodega", x => x.BodegaID);
                });

            migrationBuilder.CreateTable(
                name: "TCategoria",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TCategoria", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "TProducto",
                columns: table => new
                {
                    ProductoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CantidadTotal = table.Column<int>(type: "int", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProducto", x => x.ProductoID);
                    table.ForeignKey(
                        name: "FK_TProducto_TCategoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "TCategoria",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TStorage",
                columns: table => new
                {
                    StorageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CantidadParcial = table.Column<int>(type: "int", nullable: false),
                    ProductoID = table.Column<int>(type: "int", nullable: false),
                    BodegaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TStorage", x => x.StorageID);
                    table.ForeignKey(
                        name: "FK_TStorage_TBodega_BodegaID",
                        column: x => x.BodegaID,
                        principalTable: "TBodega",
                        principalColumn: "BodegaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TStorage_TProducto_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "TProducto",
                        principalColumn: "ProductoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TEntradaSalida",
                columns: table => new
                {
                    EntradaSalidaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    EsEntrada = table.Column<bool>(type: "bit", nullable: false),
                    StorageID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEntradaSalida", x => x.EntradaSalidaID);
                    table.ForeignKey(
                        name: "FK_TEntradaSalida_TStorage_StorageID",
                        column: x => x.StorageID,
                        principalTable: "TStorage",
                        principalColumn: "StorageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TEntradaSalida_StorageID",
                table: "TEntradaSalida",
                column: "StorageID");

            migrationBuilder.CreateIndex(
                name: "IX_TProducto_CategoriaID",
                table: "TProducto",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_TStorage_BodegaID",
                table: "TStorage",
                column: "BodegaID");

            migrationBuilder.CreateIndex(
                name: "IX_TStorage_ProductoID",
                table: "TStorage",
                column: "ProductoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TEntradaSalida");

            migrationBuilder.DropTable(
                name: "TStorage");

            migrationBuilder.DropTable(
                name: "TBodega");

            migrationBuilder.DropTable(
                name: "TProducto");

            migrationBuilder.DropTable(
                name: "TCategoria");
        }
    }
}
