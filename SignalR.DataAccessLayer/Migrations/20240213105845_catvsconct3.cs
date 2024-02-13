using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class catvsconct3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CatergoryStatus",
                table: "Categories",
                newName: "CategoryStatus");

            migrationBuilder.RenameColumn(
                name: "CatergoryName",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "CatergoryID",
                table: "Categories",
                newName: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryStatus",
                table: "Categories",
                newName: "CatergoryStatus");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "CatergoryName");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "CatergoryID");
        }
    }
}
