using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula_Backend.Migrations
{
    /// <inheritdoc />
    public partial class M04BugFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Usuários",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuários",
                newName: "Name");
        }
    }
}
