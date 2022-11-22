using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwilioClient.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSendGridKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SendGridAPIKey",
                table: "RegisteredApp",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendGridAPIKey",
                table: "RegisteredApp");
        }
    }
}
