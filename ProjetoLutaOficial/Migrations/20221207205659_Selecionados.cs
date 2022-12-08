using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLutaOficial.Migrations
{
    public partial class Selecionados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Vitorias",
                table: "Lutadores",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Selecionado",
                table: "Lutadores",
                type: "BIT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Lutadores",
                type: "VARCHAR(MAX)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Lutas",
                table: "Lutadores",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Idade",
                table: "Lutadores",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Derrotas",
                table: "Lutadores",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArtesMarciais",
                table: "Lutadores",
                type: "INT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Vitorias",
                table: "Lutadores",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<bool>(
                name: "Selecionado",
                table: "Lutadores",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "BIT");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Lutadores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(MAX)");

            migrationBuilder.AlterColumn<int>(
                name: "Lutas",
                table: "Lutadores",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "Idade",
                table: "Lutadores",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "Derrotas",
                table: "Lutadores",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");

            migrationBuilder.AlterColumn<int>(
                name: "ArtesMarciais",
                table: "Lutadores",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");
        }
    }
}
