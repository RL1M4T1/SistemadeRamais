using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemadeRamais.Migrations
{
    public partial class AtualizandoRamal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FILIAL_VC_RAMAL",
                table: "TAB_RAMAIS",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FILIAL_VC_RAMAL",
                table: "TAB_RAMAIS");
        }
    }
}
