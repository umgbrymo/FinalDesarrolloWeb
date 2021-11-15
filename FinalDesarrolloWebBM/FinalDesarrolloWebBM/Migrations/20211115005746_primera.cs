using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalDesarrolloWebBM.Migrations
{
    public partial class primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlumnoItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    primer_nombre = table.Column<string>(nullable: false),
                    segundo_nombre = table.Column<string>(nullable: false),
                    primer_apellido = table.Column<string>(nullable: false),
                    segundo_apellido = table.Column<string>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    aprobadoreprobado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumnoItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotaItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Idalumno = table.Column<int>(nullable: false),
                    idcurso = table.Column<int>(nullable: false),
                    nota = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaItems_AlumnoItems_Idalumno",
                        column: x => x.Idalumno,
                        principalTable: "AlumnoItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotaItems_Idalumno",
                table: "NotaItems",
                column: "Idalumno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaItems");

            migrationBuilder.DropTable(
                name: "AlumnoItems");
        }
    }
}
