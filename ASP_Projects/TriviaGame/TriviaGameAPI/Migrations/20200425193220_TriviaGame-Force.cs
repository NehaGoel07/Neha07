using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriviaGameAPI.Migrations
{
    public partial class TriviaGameForce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DifficultyLevel_Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diff_Lvl = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Weightage = table.Column<int>(type: "int", nullable: false),
                    Diff_Code = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultyLevel_Master", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platform_Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Platform_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Platform_Desc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Platform_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform_Master", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionType_Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuesType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Ques_Code = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionType_Master", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User_SocialShare_logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usr_Comp_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Share_Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_SocialShare_logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Game_Title = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Game_Desc = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Game_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ques_Count = table.Column<int>(type: "int", nullable: true),
                    Max_Score = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fk_Plateform_Id = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))"),
                    Game_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Game_ID = table.Column<int>(type: "int", nullable: false),
                    GameStart_Date = table.Column<int>(type: "int", nullable: true),
                    GameEnd_Date = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Plateform_Master",
                        column: x => x.fk_Plateform_Id,
                        principalTable: "Platform_Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Ques_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ques_Title = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Ques_Desc = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Ques_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fk_DiffLvl_Id = table.Column<int>(type: "int", nullable: false),
                    fk_QuesType_Id = table.Column<int>(type: "int", nullable: false),
                    fk_AdmUser_id = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Ques_Id);
                    table.ForeignKey(
                        name: "FK_Admin_Users",
                        column: x => x.fk_AdmUser_id,
                        principalTable: "Admin_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DifficultyLevel_Master",
                        column: x => x.fk_DiffLvl_Id,
                        principalTable: "DifficultyLevel_Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionType_Master",
                        column: x => x.fk_QuesType_Id,
                        principalTable: "QuestionType_Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameRules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fk_Game_Id = table.Column<int>(type: "int", nullable: false),
                    fk_DifficultyLvl_Id = table.Column<int>(type: "int", nullable: false),
                    No_Of_Ques = table.Column<int>(type: "int", nullable: false),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameRules_DifficultyLevel_Master",
                        column: x => x.fk_DifficultyLvl_Id,
                        principalTable: "DifficultyLevel_Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameRules_Games",
                        column: x => x.fk_Game_Id,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usr_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Usr_Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Usr_DOB = table.Column<int>(type: "int", nullable: true),
                    Usr_ZipCode = table.Column<int>(type: "int", nullable: true),
                    Usr_Phone = table.Column<long>(type: "bigint", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fk_Game_Id = table.Column<int>(type: "int", nullable: false),
                    fk_DiffLvl_Id = table.Column<int>(type: "int", nullable: false),
                    fk_Platform_Id = table.Column<int>(type: "int", nullable: false),
                    Total_Score = table.Column<int>(type: "int", nullable: false),
                    Total_Time = table.Column<int>(type: "int", nullable: false),
                    No_of_Ques_Attempt = table.Column<int>(type: "int", nullable: false),
                    Game_Sdt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Game_Edt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Usr_Comp_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_DifficultyLevel_Master",
                        column: x => x.fk_DiffLvl_Id,
                        principalTable: "DifficultyLevel_Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Platform_Master",
                        column: x => x.fk_Platform_Id,
                        principalTable: "Platform_Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersGames",
                        column: x => x.fk_Game_Id,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Ans_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fk_Ques_Id = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ans_Type = table.Column<bool>(type: "bit", nullable: false),
                    AnswerExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Ans_Id);
                    table.ForeignKey(
                        name: "FK_Questions",
                        column: x => x.fk_Ques_Id,
                        principalTable: "Questions",
                        principalColumn: "Ques_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameRule_Desc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fk_GameRule_Id = table.Column<int>(type: "int", nullable: false),
                    fk_DifficultyLvl_Id = table.Column<int>(type: "int", nullable: false),
                    No_Of_Ques = table.Column<int>(type: "int", nullable: false),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameRule_Desc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameRule_Desc_DifficultyLevel_Master",
                        column: x => x.fk_DifficultyLvl_Id,
                        principalTable: "DifficultyLevel_Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameRule_Desc_GameRules",
                        column: x => x.fk_GameRule_Id,
                        principalTable: "GameRules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User_Question_Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Total_Time = table.Column<int>(type: "int", nullable: false),
                    Ques_Sdt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ques_Edt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fk_Usr_Id = table.Column<int>(type: "int", nullable: false),
                    fk_Ques_Id = table.Column<int>(type: "int", nullable: false),
                    fk_Ans_Id = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Question_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Question_Logs_Answers",
                        column: x => x.fk_Ans_Id,
                        principalTable: "Answers",
                        principalColumn: "Ans_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Question_Logs_Questions",
                        column: x => x.fk_Ques_Id,
                        principalTable: "Questions",
                        principalColumn: "Ques_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Question_Logs_Users",
                        column: x => x.fk_Usr_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_fk_Ques_Id",
                table: "Answers",
                column: "fk_Ques_Id");

            migrationBuilder.CreateIndex(
                name: "IX_GameRule_Desc_fk_DifficultyLvl_Id",
                table: "GameRule_Desc",
                column: "fk_DifficultyLvl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_GameRule_Desc_fk_GameRule_Id",
                table: "GameRule_Desc",
                column: "fk_GameRule_Id");

            migrationBuilder.CreateIndex(
                name: "IX_GameRules_fk_DifficultyLvl_Id",
                table: "GameRules",
                column: "fk_DifficultyLvl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_GameRules_fk_Game_Id",
                table: "GameRules",
                column: "fk_Game_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Games_fk_Plateform_Id",
                table: "Games",
                column: "fk_Plateform_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_fk_AdmUser_id",
                table: "Questions",
                column: "fk_AdmUser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_fk_DiffLvl_Id",
                table: "Questions",
                column: "fk_DiffLvl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_fk_QuesType_Id",
                table: "Questions",
                column: "fk_QuesType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Question_Logs_fk_Ans_Id",
                table: "User_Question_Logs",
                column: "fk_Ans_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Question_Logs_fk_Ques_Id",
                table: "User_Question_Logs",
                column: "fk_Ques_Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Question_Logs_fk_Usr_Id",
                table: "User_Question_Logs",
                column: "fk_Usr_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_fk_DiffLvl_Id",
                table: "Users",
                column: "fk_DiffLvl_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_fk_Game_Id",
                table: "Users",
                column: "fk_Game_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_fk_Platform_Id",
                table: "Users",
                column: "fk_Platform_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameRule_Desc");

            migrationBuilder.DropTable(
                name: "User_Question_Logs");

            migrationBuilder.DropTable(
                name: "User_SocialShare_logs");

            migrationBuilder.DropTable(
                name: "GameRules");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "DifficultyLevel_Master");

            migrationBuilder.DropTable(
                name: "QuestionType_Master");

            migrationBuilder.DropTable(
                name: "Platform_Master");
        }
    }
}
