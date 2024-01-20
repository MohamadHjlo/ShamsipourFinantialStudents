using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShamsipourOnlineSystem.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DormStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DormStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EduExpertStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    GradReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReversedFromGradExpert = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduExpertStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinalGraduatesExpertStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalGraduatesExpertStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GraduatesExpertStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraduatesExpertStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITExpertStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITExpertStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LaboratoryStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearchAssistantStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchAssistantStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responsibles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponsibleId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NationalNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentAffairsStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAffairsStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThesisExpertStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ReverseDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDescribtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageStatus = table.Column<bool>(type: "bit", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThesisExpertStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_UserRoles_UserRoles_ResponsibleID",
                        column: x => x.UserID,
                        principalTable: "Responsibles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_UserRoles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NationalNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    EduExpertId = table.Column<int>(type: "int", nullable: true),
                    GraduatesExpertId = table.Column<int>(type: "int", nullable: true),
                    FinancialId = table.Column<int>(type: "int", nullable: true),
                    DormId = table.Column<int>(type: "int", nullable: true),
                    StudentAffairsId = table.Column<int>(type: "int", nullable: true),
                    LibraryId = table.Column<int>(type: "int", nullable: true),
                    LaboratoryId = table.Column<int>(type: "int", nullable: true),
                    ThesisExpertId = table.Column<int>(type: "int", nullable: true),
                    ITExpertId = table.Column<int>(type: "int", nullable: true),
                    ResearchAssistantId = table.Column<int>(type: "int", nullable: true),
                    FinalGraduatesExpertId = table.Column<int>(type: "int", nullable: true),
                    IsReversed = table.Column<bool>(type: "bit", nullable: true),
                    IsPending = table.Column<bool>(type: "bit", nullable: true),
                    IsFinaled = table.Column<bool>(type: "bit", nullable: true),
                    RequestTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Student_DormStudents",
                        column: x => x.DormId,
                        principalTable: "DormStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_EduExpertStudents",
                        column: x => x.EduExpertId,
                        principalTable: "EduExpertStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_FinalGraduatesExpertStudents",
                        column: x => x.FinalGraduatesExpertId,
                        principalTable: "FinalGraduatesExpertStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_FinancialStudents",
                        column: x => x.FinancialId,
                        principalTable: "FinancialStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_GraduatesExpertStudents",
                        column: x => x.GraduatesExpertId,
                        principalTable: "GraduatesExpertStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_ITExpertStudents",
                        column: x => x.ITExpertId,
                        principalTable: "ITExpertStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_LaboratoryStudents",
                        column: x => x.LaboratoryId,
                        principalTable: "LaboratoryStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_LibraryStudents",
                        column: x => x.LibraryId,
                        principalTable: "LibraryStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_ResearchAssistantStudents",
                        column: x => x.ResearchAssistantId,
                        principalTable: "ResearchAssistantStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_StudentAffairsStudents",
                        column: x => x.StudentAffairsId,
                        principalTable: "StudentAffairsStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_ThesisExpertStudents",
                        column: x => x.ThesisExpertId,
                        principalTable: "ThesisExpertStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_DormId",
                table: "Student",
                column: "DormId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_EduExpertId",
                table: "Student",
                column: "EduExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FinalGraduatesExpertId",
                table: "Student",
                column: "FinalGraduatesExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FinancialId",
                table: "Student",
                column: "FinancialId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GraduatesExpertId",
                table: "Student",
                column: "GraduatesExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ITExpertId",
                table: "Student",
                column: "ITExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_LaboratoryId",
                table: "Student",
                column: "LaboratoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_LibraryId",
                table: "Student",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ResearchAssistantId",
                table: "Student",
                column: "ResearchAssistantId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentAffairsId",
                table: "Student",
                column: "StudentAffairsId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ThesisExpertId",
                table: "Student",
                column: "ThesisExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "DormStudents");

            migrationBuilder.DropTable(
                name: "EduExpertStudents");

            migrationBuilder.DropTable(
                name: "FinalGraduatesExpertStudents");

            migrationBuilder.DropTable(
                name: "FinancialStudents");

            migrationBuilder.DropTable(
                name: "GraduatesExpertStudents");

            migrationBuilder.DropTable(
                name: "ITExpertStudents");

            migrationBuilder.DropTable(
                name: "LaboratoryStudents");

            migrationBuilder.DropTable(
                name: "LibraryStudents");

            migrationBuilder.DropTable(
                name: "ResearchAssistantStudents");

            migrationBuilder.DropTable(
                name: "StudentAffairsStudents");

            migrationBuilder.DropTable(
                name: "ThesisExpertStudents");

            migrationBuilder.DropTable(
                name: "Responsibles");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
