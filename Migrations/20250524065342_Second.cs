using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hiring_and_Selection_Process_Platform.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    educationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    educationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cgpa = table.Column<double>(type: "float", nullable: true),
                    passingYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    universityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    major = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    candidateId = table.Column<int>(type: "int", nullable: false),
                    candidatescandidateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.educationId);
                    table.ForeignKey(
                        name: "FK_Educations_Candidates_candidatescandidateId",
                        column: x => x.candidatescandidateId,
                        principalTable: "Candidates",
                        principalColumn: "candidateId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_candidatescandidateId",
                table: "Educations",
                column: "candidatescandidateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");
        }
    }
}
