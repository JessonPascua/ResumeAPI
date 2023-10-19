using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeAPI.Migrations
{
    public partial class UpdateRelasionship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certifications_Resume_ResumeId",
                table: "Certifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Resume_ResumeId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Resume_ResumeId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Resume_ResumeId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Resume_ResumeId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Resume_ResumeId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Created_at",
                table: "Certifications");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Projects",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Experiences",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Educations",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Contacts",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Comments",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Certifications",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_Resume_ResumeId",
                table: "Certifications",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Resume_ResumeId",
                table: "Comments",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Resume_ResumeId",
                table: "Contacts",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Resume_ResumeId",
                table: "Educations",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Resume_ResumeId",
                table: "Experiences",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Resume_ResumeId",
                table: "Projects",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certifications_Resume_ResumeId",
                table: "Certifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Resume_ResumeId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Resume_ResumeId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Resume_ResumeId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Resume_ResumeId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Resume_ResumeId",
                table: "Projects");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Projects",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Experiences",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Educations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Contacts",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Comments",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Certifications",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_at",
                table: "Certifications",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Certifications_Resume_ResumeId",
                table: "Certifications",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Resume_ResumeId",
                table: "Comments",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Resume_ResumeId",
                table: "Contacts",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Resume_ResumeId",
                table: "Educations",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Resume_ResumeId",
                table: "Experiences",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Resume_ResumeId",
                table: "Projects",
                column: "ResumeId",
                principalTable: "Resume",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
