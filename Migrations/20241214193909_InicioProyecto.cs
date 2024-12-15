using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Perfumeria.Migrations
{
    /// <inheritdoc />
    public partial class InicioProyecto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetodosDePago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodosDePago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: true),
                    MetodoDePagoId = table.Column<int>(type: "int", nullable: true),
                    AreaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clientes_MetodosDePago_MetodoDePagoId",
                        column: x => x.MetodoDePagoId,
                        principalTable: "MetodosDePago",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clientes_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Perfumeria" },
                    { 2, "Costumbre" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "AreaId", "MetodoDePagoId", "Nombre", "ProductoId" },
                values: new object[,]
                {
                    { 1, null, null, "Ramiro", null },
                    { 2, null, null, "Valentin", null }
                });

            migrationBuilder.InsertData(
                table: "MetodosDePago",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "MercadoPago" },
                    { 2, "Efectivo" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Boos" },
                    { 2, "Esmalte" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_AreaId",
                table: "Clientes",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_MetodoDePagoId",
                table: "Clientes",
                column: "MetodoDePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ProductoId",
                table: "Clientes",
                column: "ProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "MetodosDePago");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
