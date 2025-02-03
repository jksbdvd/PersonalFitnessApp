using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalFitnessApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac84b12-0afd-4bbd-aba0-5ea727f934f4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1899b6d3-064f-4086-95a3-313b69431328", "COACH@COACHING.COM", "AQAAAAIAAYagAAAAEIYv+dseTS4KjT1DiQngG2P2aehqKGBAdlR5C4Et/ofnXDu7/PtpKWE0pcJ2QjJaJQ==", "df58c207-5e74-4308-a4cd-970abfef9df6", "Coach@coaching.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc7974b-6cb5-497a-b5e4-bdb31c58c886",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5e517884-db4a-4dd7-aed8-ca1b493b12cd", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKjsKM32Jo8sSSpLTym/qV+JfJhDt63zuLRuL22GLhgZY3rFFBHK9vkszc2HvHw/cg==", "a529c04a-b0bb-4471-83c3-4392ba6ef3cd", "Admin@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac84b12-0afd-4bbd-aba0-5ea727f934f4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b6fb5789-bb5f-4f86-be86-c276003f264b", "COACH", "AQAAAAIAAYagAAAAEGc7Qb4QXnUXQhHRoHjiY6EzVCMUkXtRGz5pRE3ImDrESxgmGUU2knWg+njdeZTjXQ==", "84934a5d-023d-4a38-8f2a-e063c26403ac", "Coach" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc7974b-6cb5-497a-b5e4-bdb31c58c886",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "380f3561-e94d-45d5-8e04-bf334ae2d6c2", "ADMIN", "AQAAAAIAAYagAAAAEBF3AU06gbXreUCsMPeoEZkiwTLXmJTuIHLJ6Y2UKZK69Y1zig14MdOnojbLTVIt4A==", "66244ee9-8f66-4cc7-9668-a3cc47db3863", "Admin" });
        }
    }
}
