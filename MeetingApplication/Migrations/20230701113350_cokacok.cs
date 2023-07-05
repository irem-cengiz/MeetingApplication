using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeetingApplication.Migrations
{
    public partial class cokacok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingPlatforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingPlatformName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingPlatforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeetingReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeetingSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingSubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingSubjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    TcNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.TcNo);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeetingPlatformId = table.Column<int>(type: "int", nullable: true),
                    MeetingReportId = table.Column<int>(type: "int", nullable: true),
                    MeetingSubjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meetings_MeetingPlatforms_MeetingPlatformId",
                        column: x => x.MeetingPlatformId,
                        principalTable: "MeetingPlatforms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Meetings_MeetingReports_MeetingReportId",
                        column: x => x.MeetingReportId,
                        principalTable: "MeetingReports",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Meetings_MeetingSubjects_MeetingSubjectId",
                        column: x => x.MeetingSubjectId,
                        principalTable: "MeetingSubjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MeetingPersons",
                columns: table => new
                {
                    TcNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingPersons", x => new { x.TcNo, x.Id });
                    table.ForeignKey(
                        name: "FK_MeetingPersons_Meetings_Id",
                        column: x => x.Id,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetingPersons_Person_TcNo",
                        column: x => x.TcNo,
                        principalTable: "Person",
                        principalColumn: "TcNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MeetingPersons_Id",
                table: "MeetingPersons",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MeetingPlatformId",
                table: "Meetings",
                column: "MeetingPlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MeetingReportId",
                table: "Meetings",
                column: "MeetingReportId",
                unique: true,
                filter: "[MeetingReportId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MeetingSubjectId",
                table: "Meetings",
                column: "MeetingSubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingPersons");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "MeetingPlatforms");

            migrationBuilder.DropTable(
                name: "MeetingReports");

            migrationBuilder.DropTable(
                name: "MeetingSubjects");
        }
    }
}
