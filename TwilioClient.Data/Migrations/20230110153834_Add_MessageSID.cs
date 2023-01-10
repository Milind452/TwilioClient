using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwilioClient.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMessageSID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageSID",
                table: "OutboundSMS",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageSID",
                table: "OutboundSMS");
        }
    }
}
