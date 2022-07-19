using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HymnNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    HymnTitle = table.Column<string>(type: "TEXT", nullable: true),
                    HymnType = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Presiding = table.Column<string>(type: "TEXT", nullable: true),
                    Conducting = table.Column<string>(type: "TEXT", nullable: true),
                    Pianist = table.Column<string>(type: "TEXT", nullable: true),
                    Chorister = table.Column<string>(type: "TEXT", nullable: true),
                    OP = table.Column<string>(type: "TEXT", nullable: true),
                    CP = table.Column<string>(type: "TEXT", nullable: true),
                    Opening = table.Column<int>(type: "INTEGER", nullable: false),
                    Intermediate = table.Column<int>(type: "INTEGER", nullable: false),
                    Closing = table.Column<int>(type: "INTEGER", nullable: false),
                    SpeakerOne = table.Column<string>(type: "TEXT", nullable: true),
                    SpeakerOneSubject = table.Column<string>(type: "TEXT", nullable: true),
                    SpeakerTwo = table.Column<string>(type: "TEXT", nullable: true),
                    SpeakerTwoSubject = table.Column<string>(type: "TEXT", nullable: true),
                    SpeakerThree = table.Column<string>(type: "TEXT", nullable: true),
                    SpeakerThreeSubject = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hymn");

            migrationBuilder.DropTable(
                name: "Plan");
        }
    }
}
