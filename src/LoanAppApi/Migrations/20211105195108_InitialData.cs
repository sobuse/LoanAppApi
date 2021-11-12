using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanAppApi.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "requestLoan",
                table: "LoanOfficers",
                newName: "RequestLoan");

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    RequesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Borrowers",
                columns: new[] { "BorrowersId", "BVN", "BorrowedOn", "DateOfBirth", "DueDate", "FullName", "Gender", "IsDeleted", "LoanAmount", "LoanOfficerId", "MonthlyIncome" },
                values: new object[] { new Guid("47632e5a-6d34-4ad2-869b-cf95c636c3ed"), "7689432176", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 11, 13, 20, 51, 7, 47, DateTimeKind.Local).AddTicks(7882), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OluwaDare John", 2, false, 1000000, new Guid("9a07b75e-e943-48bc-821c-76685161668d"), 200000 });

            migrationBuilder.InsertData(
                table: "LoanOfficers",
                columns: new[] { "LoanOfficerId", "Fullname", "RequestLoan" },
                values: new object[] { new Guid("9a07b75e-e943-48bc-821c-76685161668d"), "Obuse Samuel", 1 });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "Amount", "Comment", "CreatedAt", "RequesterId" },
                values: new object[] { new Guid("a466a903-2b53-40c1-8dbf-8d6e323baa43"), 10000000, "Please I need a loan for my house rent", new DateTime(2021, 11, 5, 20, 51, 7, 50, DateTimeKind.Local).AddTicks(5870), new Guid("47632e5a-6d34-4ad2-869b-cf95c636c3ed") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DeleteData(
                table: "Borrowers",
                keyColumn: "BorrowersId",
                keyValue: new Guid("47632e5a-6d34-4ad2-869b-cf95c636c3ed"));

            migrationBuilder.DeleteData(
                table: "LoanOfficers",
                keyColumn: "LoanOfficerId",
                keyValue: new Guid("9a07b75e-e943-48bc-821c-76685161668d"));

            migrationBuilder.RenameColumn(
                name: "RequestLoan",
                table: "LoanOfficers",
                newName: "requestLoan");
        }
    }
}
