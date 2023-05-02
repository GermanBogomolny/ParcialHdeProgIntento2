using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stix.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantModelCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Food_FoodId",
                table: "Restaurant");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "Restaurant",
                newName: "FoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Restaurant_FoodId",
                table: "Restaurant",
                newName: "IX_Restaurant_FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Food_FoodId",
                table: "Restaurant",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Food_FoodId",
                table: "Restaurant");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "Restaurant",
                newName: "FoodId");

            migrationBuilder.RenameIndex(
                name: "IX_Restaurant_FoodId",
                table: "Restaurant",
                newName: "IX_Restaurant_FoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Food_FoodId",
                table: "Restaurant",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
