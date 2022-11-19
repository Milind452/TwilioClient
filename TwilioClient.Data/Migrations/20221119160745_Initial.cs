using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwilioClient.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisteredApp",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AppToken = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TwilioSID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TwilioToken = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredApp", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisteredApp");
        }
    }
}
