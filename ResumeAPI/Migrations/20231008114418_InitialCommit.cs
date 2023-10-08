using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeAPI.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    AboutMe = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    CertificationId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "VARCHAR(525)", nullable: false),
                    Issuer = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "Date", nullable: false),
                    CredentialURL = table.Column<string>(type: "VARCHAR(225)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.CertificationId);
                    table.ForeignKey(
                        name: "FK_Certifications_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Massage = table.Column<string>(type: "TEXT", nullable: false),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Phone = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    GitHub = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    LinkedIn = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    School = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Degree = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Educations_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Company = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Range = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Responsibilities = table.Column<string[]>(type: "TEXT[]", nullable: true),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experiences_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Repo = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Live = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Stacks = table.Column<string[]>(type: "TEXT[]", nullable: true),
                    Created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    ResumeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certifications_ResumeId",
                table: "Certifications",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ResumeId",
                table: "Comments",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ResumeId",
                table: "Contacts",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ResumeId",
                table: "Educations",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_ResumeId",
                table: "Experiences",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ResumeId",
                table: "Projects",
                column: "ResumeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Resume");
        }
    }
}
