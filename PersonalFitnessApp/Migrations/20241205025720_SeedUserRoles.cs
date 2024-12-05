using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalFitnessApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc7974b-6cb5-497a-b5e4-bdb31c58c886",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfd506aa-41ec-42b8-98ff-efdfef19330d", "AQAAAAIAAYagAAAAEKOFepHDV0OvWj+UvGxSFnt4ZftE92O5gO0U2rpOLHUujE6MjzSrCHSBlo/hEo9mCQ==", "89967d22-cf75-421f-a722-50219e22a068" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc7974b-6cb5-497a-b5e4-bdb31c58c886",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4233c98e-80d6-4212-9d71-984bfcfa675b", "AQAAAAIAAYagAAAAEPEd4RiBbGkJ7yRxao+CeMaZixRsCx1FtFgu+WB4PxWlVmsQlC1omJ/4g2E3dtoMLQ==", "7e5c03de-9cfc-47c0-9f79-697285fe9dfd" });
        }
    }
}
