using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalFitnessApp.Migrations
{
    /// <inheritdoc />
    public partial class UserKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "WorkoutLog",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "FoodTracking",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Booking",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Steps",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac84b12-0afd-4bbd-aba0-5ea727f934f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "Steps" },
                values: new object[] { "63e5bc66-b2ff-4110-966e-d40dce85b53c", "AQAAAAIAAYagAAAAEMqr3g/po6R4za8mBsXBI5DVgfDs1Fcr3Rzoaz8hIVu20TmPil+p2yh7hhKk+yJ0UQ==", "ba873fdd-da09-4ecf-bf46-fefa29ee59e8", 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc7974b-6cb5-497a-b5e4-bdb31c58c886",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "Steps" },
                values: new object[] { "e251b4a6-9b40-4db8-a88d-d7b66d2440fd", "AQAAAAIAAYagAAAAEL5nUvx4+azO78IH76kDMq/dsgHrWBoeYCZLb43+y9LAF73Bty5KEvhN+clcvqHL3g==", "ddb02ba7-e6da-43f3-a424-e04d2e88b421", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutLog_UserId",
                table: "WorkoutLog",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodTracking_UserId",
                table: "FoodTracking",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodTracking_AspNetUsers_UserId",
                table: "FoodTracking",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutLog_AspNetUsers_UserId",
                table: "WorkoutLog",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_UserId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodTracking_AspNetUsers_UserId",
                table: "FoodTracking");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutLog_AspNetUsers_UserId",
                table: "WorkoutLog");

            migrationBuilder.DropIndex(
                name: "IX_WorkoutLog_UserId",
                table: "WorkoutLog");

            migrationBuilder.DropIndex(
                name: "IX_FoodTracking_UserId",
                table: "FoodTracking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_UserId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Steps",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "WorkoutLog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "FoodTracking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac84b12-0afd-4bbd-aba0-5ea727f934f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1899b6d3-064f-4086-95a3-313b69431328", "AQAAAAIAAYagAAAAEIYv+dseTS4KjT1DiQngG2P2aehqKGBAdlR5C4Et/ofnXDu7/PtpKWE0pcJ2QjJaJQ==", "df58c207-5e74-4308-a4cd-970abfef9df6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc7974b-6cb5-497a-b5e4-bdb31c58c886",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e517884-db4a-4dd7-aed8-ca1b493b12cd", "AQAAAAIAAYagAAAAEKjsKM32Jo8sSSpLTym/qV+JfJhDt63zuLRuL22GLhgZY3rFFBHK9vkszc2HvHw/cg==", "a529c04a-b0bb-4471-83c3-4392ba6ef3cd" });
        }
    }
}
