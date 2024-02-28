using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GolfCoursse",
                columns: table => new
                {
                    GolfCourseSystemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GolfCourseName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GolfCourseInitalLocationLat = table.Column<double>(type: "double", nullable: false),
                    GolfCourseInitalLocationLong = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfCoursse", x => x.GolfCourseSystemId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserSystemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Token = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserSystemId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GolfCourseHoles",
                columns: table => new
                {
                    GolfCourseHoleSystemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GolfCourseHoleNumber = table.Column<int>(type: "int", nullable: false),
                    GolfCourseSystemId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GolfCourseHoles", x => x.GolfCourseHoleSystemId);
                    table.ForeignKey(
                        name: "FK_GolfCourseHoles_GolfCoursse_GolfCourseSystemId",
                        column: x => x.GolfCourseSystemId,
                        principalTable: "GolfCoursse",
                        principalColumn: "GolfCourseSystemId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ThePerfectGame",
                columns: table => new
                {
                    ThePerfectGameSystemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GameName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartingHole = table.Column<int>(type: "int", nullable: false),
                    GolfCourseSystemId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThePerfectGame", x => x.ThePerfectGameSystemId);
                    table.ForeignKey(
                        name: "FK_ThePerfectGame_GolfCoursse_GolfCourseSystemId",
                        column: x => x.GolfCourseSystemId,
                        principalTable: "GolfCoursse",
                        principalColumn: "GolfCourseSystemId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ThePerfectGameUser",
                columns: table => new
                {
                    ThePerfectGameUserSystemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MinDistanceForGoodShot = table.Column<long>(type: "bigint", nullable: false),
                    UserSystemId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThePerfectGameUser", x => x.ThePerfectGameUserSystemId);
                    table.ForeignKey(
                        name: "FK_ThePerfectGameUser_Users_UserSystemId",
                        column: x => x.UserSystemId,
                        principalTable: "Users",
                        principalColumn: "UserSystemId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ThePerfectGameStroke",
                columns: table => new
                {
                    ThePerfectGameStrokeSystemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StrokeNumber = table.Column<int>(type: "int", nullable: false),
                    StartingLong = table.Column<long>(type: "bigint", nullable: true),
                    StartingLat = table.Column<long>(type: "bigint", nullable: true),
                    EndingLong = table.Column<long>(type: "bigint", nullable: true),
                    EndingLat = table.Column<long>(type: "bigint", nullable: true),
                    Distance = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    BallLie = table.Column<int>(type: "int", nullable: false),
                    GolfCourseHoleSystemId = table.Column<long>(type: "bigint", nullable: true),
                    ThePerfectGameUserSystemId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThePerfectGameStroke", x => x.ThePerfectGameStrokeSystemId);
                    table.ForeignKey(
                        name: "FK_ThePerfectGameStroke_GolfCourseHoles_GolfCourseHoleSystemId",
                        column: x => x.GolfCourseHoleSystemId,
                        principalTable: "GolfCourseHoles",
                        principalColumn: "GolfCourseHoleSystemId");
                    table.ForeignKey(
                        name: "FK_ThePerfectGameStroke_ThePerfectGameUser_ThePerfectGameUserSy~",
                        column: x => x.ThePerfectGameUserSystemId,
                        principalTable: "ThePerfectGameUser",
                        principalColumn: "ThePerfectGameUserSystemId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GolfCourseHoles_GolfCourseSystemId",
                table: "GolfCourseHoles",
                column: "GolfCourseSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ThePerfectGame_GolfCourseSystemId",
                table: "ThePerfectGame",
                column: "GolfCourseSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ThePerfectGameStroke_GolfCourseHoleSystemId",
                table: "ThePerfectGameStroke",
                column: "GolfCourseHoleSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ThePerfectGameStroke_ThePerfectGameUserSystemId",
                table: "ThePerfectGameStroke",
                column: "ThePerfectGameUserSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_ThePerfectGameUser_UserSystemId",
                table: "ThePerfectGameUser",
                column: "UserSystemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThePerfectGame");

            migrationBuilder.DropTable(
                name: "ThePerfectGameStroke");

            migrationBuilder.DropTable(
                name: "GolfCourseHoles");

            migrationBuilder.DropTable(
                name: "ThePerfectGameUser");

            migrationBuilder.DropTable(
                name: "GolfCoursse");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
