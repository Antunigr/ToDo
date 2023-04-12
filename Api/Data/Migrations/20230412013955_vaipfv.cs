using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud.Migrations
{
    /// <inheritdoc />
    public partial class vaipfv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaksRegister_TaksRegister_TarefasId",
                table: "TaksRegister");

            migrationBuilder.DropIndex(
                name: "IX_TaksRegister_TarefasId",
                table: "TaksRegister");

            migrationBuilder.DropColumn(
                name: "TarefasId",
                table: "TaksRegister");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TarefasId",
                table: "TaksRegister",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaksRegister_TarefasId",
                table: "TaksRegister",
                column: "TarefasId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaksRegister_TaksRegister_TarefasId",
                table: "TaksRegister",
                column: "TarefasId",
                principalTable: "TaksRegister",
                principalColumn: "Id");
        }
    }
}
