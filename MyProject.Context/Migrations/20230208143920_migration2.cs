using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Context.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Persons_parentId",
                table: "Children");

            migrationBuilder.RenameColumn(
                name: "parentId",
                table: "Children",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Children_parentId",
                table: "Children",
                newName: "IX_Children_ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Persons_ParentId",
                table: "Children",
                column: "ParentId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Persons_ParentId",
                table: "Children");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Children",
                newName: "parentId");

            migrationBuilder.RenameIndex(
                name: "IX_Children_ParentId",
                table: "Children",
                newName: "IX_Children_parentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Persons_parentId",
                table: "Children",
                column: "parentId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
