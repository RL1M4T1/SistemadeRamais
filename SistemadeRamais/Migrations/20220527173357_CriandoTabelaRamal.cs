using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemadeRamais.Migrations
{
    public partial class CriandoTabelaRamal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TAB_RAMAIS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COLABORADOR_VC_RAMAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SETOR_VC_RAMAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAMAL_CH_RAMAL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAB_RAMAIS", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAB_RAMAIS");
        }
    }
}
