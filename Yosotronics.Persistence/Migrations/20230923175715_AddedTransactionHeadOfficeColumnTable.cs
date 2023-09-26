using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedTransactionHeadOfficeColumnTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HeadOffice",
                schema: "bank",
                table: "Banks",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadOffice",
                schema: "bank",
                table: "Banks");
        }
    }
}
