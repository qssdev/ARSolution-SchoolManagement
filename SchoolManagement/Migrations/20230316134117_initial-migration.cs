using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagement.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfessorClassId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfessorClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessorClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessorClasses_People_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4668), "English Vocabulary", "English", new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4667) },
                    { 2, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4670), "Mathematics", "Calculus", new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4669) },
                    { 3, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4672), "ARTS", "Music", new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4671) }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CreatedDate", "Email", "Firstname", "Lastname", "ProfessorClassId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4502), "email1@email.com", "Carla", "Santos", null, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4492) },
                    { 4, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4509), "email4@email.com", "Katt", "Nevib", null, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4508) },
                    { 5, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4511), "email5@email.com", "Sue", "Chesdy", null, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4510) },
                    { 7, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4515), "email7@email.com", "Jim", "Greg", null, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4514) },
                    { 10, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4504), "email2@email.com", "James", "Nobina", null, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4503) },
                    { 11, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4506), "email3@email.com", "Matt", "Mathew", null, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4505) },
                    { 12, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4513), "email6@email.com", "Paul", "Juan", null, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4512) }
                });

            migrationBuilder.InsertData(
                table: "ProfessorClasses",
                columns: new[] { "Id", "ClassId", "CreatedDate", "ProfessorId", "StudentId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4691), 10, 1, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4690) },
                    { 2, 1, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4693), 10, 11, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4692) },
                    { 3, 1, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4695), 10, 14, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4694) },
                    { 4, 1, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4697), 10, 5, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4696) },
                    { 5, 1, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4699), 10, 12, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4698) },
                    { 6, 2, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4701), 11, 10, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4700) },
                    { 7, 2, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4703), 11, 1, new DateTime(2023, 3, 16, 21, 41, 17, 25, DateTimeKind.Local).AddTicks(4702) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_ProfessorClassId",
                table: "People",
                column: "ProfessorClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorClasses_ProfessorId",
                table: "ProfessorClasses",
                column: "ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_ProfessorClasses_ProfessorClassId",
                table: "People",
                column: "ProfessorClassId",
                principalTable: "ProfessorClasses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_ProfessorClasses_ProfessorClassId",
                table: "People");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "ProfessorClasses");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
