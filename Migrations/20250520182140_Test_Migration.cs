using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiring_and_Selection_Process_Platform.Migrations
{
    /// <inheritdoc />
    public partial class Test_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    jobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobSalary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    jobRequirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    noEmployees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.jobId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
