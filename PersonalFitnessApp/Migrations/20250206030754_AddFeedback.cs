using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalFitnessApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GivenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedback_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac84b12-0afd-4bbd-aba0-5ea727f934f4",
                columns: new[] { "Calories", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "f3717874-5069-4a41-b9e2-4213c2e39454", "AQAAAAIAAYagAAAAEJy1RZszb9HE+VC30V8ULFqgXz7j409uB9xq/u9SExDXWoBDaqvK5WIyfq8/FS1kEg==", "3749af33-68a4-4fb7-8921-a3883fd4f715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc7974b-6cb5-497a-b5e4-bdb31c58c886",
                columns: new[] { "Calories", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { 0, "a2cd10c9-5617-49f4-a892-d36ddde6ba6f", "AQAAAAIAAYagAAAAEDyZ+yvuC2xG3vjqXRZlxonJ6S0jeMPY8gfaARqIdPg31eggVTGwDVYWibnEA4+gtw==", "bc1a7472-fd23-43f7-97d3-218312f7c0dd" });

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_UserId",
                table: "Feedback",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ac84b12-0afd-4bbd-aba0-5ea727f934f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63e5bc66-b2ff-4110-966e-d40dce85b53c", "AQAAAAIAAYagAAAAEMqr3g/po6R4za8mBsXBI5DVgfDs1Fcr3Rzoaz8hIVu20TmPil+p2yh7hhKk+yJ0UQ==", "ba873fdd-da09-4ecf-bf46-fefa29ee59e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebc7974b-6cb5-497a-b5e4-bdb31c58c886",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e251b4a6-9b40-4db8-a88d-d7b66d2440fd", "AQAAAAIAAYagAAAAEL5nUvx4+azO78IH76kDMq/dsgHrWBoeYCZLb43+y9LAF73Bty5KEvhN+clcvqHL3g==", "ddb02ba7-e6da-43f3-a424-e04d2e88b421" });
        }
    }
}
