using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FAQ_App.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "History" },
                    { 2, "General" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "JavaScript" },
                    { 2, "Bootstrap" }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FAQId", "Answer", "CategoryId", "Question", "TopicId" },
                values: new object[,]
                {
                    { 1, "JavaScript was created by Brendan Eich.", 1, "Who invented JavaScript?", 1 },
                    { 2, "Bootstrap is a popular CSS framework that helps you build responsive and mobile-first websites.", 2, "What is Bootstrap?", 2 },
                    { 3, "JavaScript is a programming language that allows you to add interactivity and dynamic content to websites.", 2, "What is JavaScript?", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "FAQId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -2, "General" },
                    { -1, "History" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -2, "Bootstrap" },
                    { -1, "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "FAQId", "Answer", "CategoryId", "Question", "TopicId" },
                values: new object[,]
                {
                    { -3, "JavaScript is a programming language that allows you to add interactivity and dynamic content to websites.", -2, "What is JavaScript?", -1 },
                    { -2, "Bootstrap is a popular CSS framework that helps you build responsive and mobile-first websites.", -2, "What is Bootstrap?", -2 },
                    { -1, "JavaScript was created by Brendan Eich.", -1, "Who invented JavaScript?", -1 }
                });
        }
    }
}
