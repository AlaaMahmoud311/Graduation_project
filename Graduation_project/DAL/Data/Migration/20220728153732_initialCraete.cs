using Microsoft.EntityFrameworkCore.Migrations;

namespace Edu_Chatbot.DAL.Data.Migrations
{
    public partial class initialCraete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        
            migrationBuilder.CreateTable(
                name: "DashBoards",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoards", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    track_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course_link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Course_level = table.Column<int>(type: "int", nullable: false),
                    Track_id = table.Column<int>(type: "int", nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.id);
                    table.ForeignKey(
                        name: "FK_Courses_Tracks_Track_id",
                        column: x => x.Track_id,
                        principalTable: "Tracks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DashBoard_Track",
                columns: table => new
                {
                    Dash_Id = table.Column<int>(type: "int", nullable: false),
                    Track_Id = table.Column<int>(type: "int", nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoard_Track", x => new { x.Track_Id, x.Dash_Id });
                    table.ForeignKey(
                        name: "FK_DashBoard_Track_DashBoards_Dash_Id",
                        column: x => x.Dash_Id,
                        principalTable: "DashBoards",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DashBoard_Track_Tracks_Track_Id",
                        column: x => x.Track_Id,
                        principalTable: "Tracks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });



            migrationBuilder.CreateTable(
                name: "Quizes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Track_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Quizes_Tracks_Track_id",
                        column: x => x.Track_id,
                        principalTable: "Tracks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });



            migrationBuilder.CreateTable(
                name: "DashBoard_Course",
                columns: table => new
                {
                    Dash_Id = table.Column<int>(type: "int", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoard_Course", x => new { x.Course_Id, x.Dash_Id });
                    table.ForeignKey(
                        name: "FK_DashBoard_Course_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DashBoard_Course_DashBoards_Dash_Id",
                        column: x => x.Dash_Id,
                        principalTable: "DashBoards",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quize_id = table.Column<int>(type: "int", nullable: false),

                    question_Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Track_id = table.Column<int>(type: "int", nullable: false),
                    Right_answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Questions_Quizes_quize_id",
                        column: x => x.quize_id,
                        principalTable: "Quizes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Choices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question_id = table.Column<int>(type: "int", nullable: false),

                    choice = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choices", x => x.id);
                    table.ForeignKey(
                        name: "FK_Choices_Questions_Question_id",
                        column: x => x.Question_id,
                        principalTable: "Questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Choices_Questionid",
                table: "Choices",
                column: "Question_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Tracksid",
                table: "Courses",
                column: "Track_id");


            migrationBuilder.CreateIndex(
                name: "IX_DashBoard_Course_Courseid",
                table: "DashBoard_Course",
                column: "Course_id");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoard_Course_DashBoardid",
                table: "DashBoard_Course",
                column: "Dash_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoard_Track_DashBoardid",
                table: "DashBoard_Track",
                column: "Dash_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoard_Track_Tracksid",
                table: "DashBoard_Track",
                column: "Track_Id");

           
            migrationBuilder.CreateIndex(
                name: "IX_Questions_Quizesid",
                table: "Questions",
                column: "quize_id");

            migrationBuilder.CreateIndex(
                name: "IX_Quizes_Track_id",
                table: "Quizes",
                column: "Track_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Choices");

            migrationBuilder.DropTable(
                name: "CoursesDashBoard");

            migrationBuilder.DropTable(
                name: "DashBoard_Course");

            migrationBuilder.DropTable(
                name: "DashBoard_Track");

            migrationBuilder.DropTable(
                name: "DashBoardTracks");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "DashBoards");

            migrationBuilder.DropTable(
                name: "Quizes");

            migrationBuilder.DropTable(
                name: "Tracks");
        }
    }
}
