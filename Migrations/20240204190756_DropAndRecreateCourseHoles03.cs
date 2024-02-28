using Microsoft.EntityFrameworkCore.Migrations;
using System;
using Microsoft.EntityFrameworkCore.Metadata;
#nullable disable

namespace GolfApi.Migrations
{
    /// <inheritdoc />
    public partial class DropAndRecreateCourseHoles03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.DropTable(
            name: "CourseHoles");
            migrationBuilder.CreateTable(
                name: "CourseHoles",
                columns: table => new
                {
                    course_hole_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    golf_course_id = table.Column<long>(type: "bigint", nullable: false),
                    course_hole_no   = table.Column<long>(type: "int", nullable: false),
                    latitude = table.Column<double>(type: "double", nullable: false),
                    longitude= table.Column<double>(type: "double", nullable: false),
                    maxdistance= table.Column<double>(type: "double", nullable: false),
                   
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    create_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    last_upt_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                }
                ,
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseHoles", x => x.course_hole_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
