using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Former.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedLimitedToIsAuthorized : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "is_authorized",
                table: "forms",
                newName: "is_authorized_limited");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "is_authorized_limited",
                table: "forms",
                newName: "is_authorized");
        }
    }
}
