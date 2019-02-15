using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class fixedmiscues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons");

            migrationBuilder.RenameColumn(
                name: "LibraryBranchId",
                table: "Patrons",
                newName: "HomeLibraryBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_LibraryBranchId",
                table: "Patrons",
                newName: "IX_Patrons_HomeLibraryBranchId");

            migrationBuilder.RenameColumn(
                name: "OpenData",
                table: "LibraryBranches",
                newName: "OpenDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "LibraryCards",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Fees",
                table: "LibraryCards",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "LibraryCards");

            migrationBuilder.DropColumn(
                name: "Fees",
                table: "LibraryCards");

            migrationBuilder.RenameColumn(
                name: "HomeLibraryBranchId",
                table: "Patrons",
                newName: "LibraryBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patrons",
                newName: "IX_Patrons_LibraryBranchId");

            migrationBuilder.RenameColumn(
                name: "OpenDate",
                table: "LibraryBranches",
                newName: "OpenData");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
