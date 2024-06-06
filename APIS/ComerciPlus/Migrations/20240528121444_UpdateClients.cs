using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComerciPlus.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CedulaCliente",
                table: "clientes",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_clientes_CedulaCliente",
                table: "clientes",
                column: "CedulaCliente",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_clientes_CedulaCliente",
                table: "clientes");

            migrationBuilder.AlterColumn<string>(
                name: "CedulaCliente",
                table: "clientes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
