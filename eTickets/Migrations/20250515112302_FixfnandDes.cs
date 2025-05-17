using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class FixfnandDes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fullnmae",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Descprition",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Fullnmae",
                table: "Actors",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "Fullnmae");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "Descprition");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "Fullnmae");
        }
    }
}
