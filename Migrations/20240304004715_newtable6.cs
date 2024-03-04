using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class newtable6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JoinOpenTournaments",
                columns: table => new
                {
                    join_open_tournament_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    game_id = table.Column<long>(type: "bigint", nullable: false),
                    milestone_id = table.Column<long>(type: "bigint", nullable: false),
                    golf_course_id = table.Column<long>(type: "bigint", nullable: false),
                    game_type_id = table.Column<long>(type: "bigint", nullable: false),
                    game_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    golf_id = table.Column<long>(type: "bigint", nullable: false),
                    start_half_id = table.Column<long>(type: "bigint", nullable: false),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    create_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    last_upt_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinOpenTournaments", x => x.join_open_tournament_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinOpenTournaments");
        }
    }
}
