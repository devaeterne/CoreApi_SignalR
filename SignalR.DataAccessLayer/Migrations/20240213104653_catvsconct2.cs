using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class catvsconct2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Contacts_ContactID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ContactID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ContactID",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactID",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ContactID",
                table: "Products",
                column: "ContactID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Contacts_ContactID",
                table: "Products",
                column: "ContactID",
                principalTable: "Contacts",
                principalColumn: "ContactID");
        }
    }
}
