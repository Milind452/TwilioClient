using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwilioClient.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateOutboundEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OutboundEmail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SendGridAPIKey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    From = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReceivedUTC = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    SentUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MessageResponse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutboundEmail", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutboundEmail");
        }
    }
}
