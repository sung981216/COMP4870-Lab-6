using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerBlazorEF.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "7af0740f-a420-454a-8468-e3157275de18", "Jane", "Smith", "Medicine" },
                    { "5fc3c244-7258-401b-8a89-4d65b412515c", "John", "Fisher", "Engineering" },
                    { "ebe05387-9855-46b6-b422-0a3c3c2aad8a", "Pamela", "Baker", "Food Science" },
                    { "3a3df98e-e6f4-4045-8347-a2881214a68e", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
