using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiring_and_Selection_Process_Platform.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
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
                    jobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobSalary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    noEmployees = table.Column<int>(type: "int", nullable: true)
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
