using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoLutaOficial.Migrations
{
    public partial class InsercaoDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
               " VALUES ('Cassandra', 29, 3, 8, 3, 5)");

            // 2
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Wollysson', 19, 1, 15, 8, 7)");

            // 3
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Anduin Wrynn', 23, 1, 17, 8, 9)");


            // 4
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Garrosh', 31, 4, 13, 6, 7)");

            // 5
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Lucius', 20, 2, 14, 7, 7, 1)");

            // 6
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Alleria WindRunner', 20, 5, 18, 8, 10)");

            // 7 
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Orgalorg', 25, 4, 22, 12, 10)");

            // 8 
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Azriel Dremurr', 23, 1, 11, 4, 7)");

            // 9
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('L Lawliet', 27, 2, 15, 6, 9, 1)");

            // 10
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Jamal Massacrations', 21, 1, 18, 15, 3)");

            // 11
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Niko Bellic', 30, 2, 25, 19, 6)");

            // 12
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Kaito Yamatsu', 22, 3, 14, 4, 10)");

            // 13
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Yasuo WindRunner', 32, 2, 21, 7, 14)");

            // 14
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Hannah StormBlade', 18, 1, 9, 3, 6)");

            // 15
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Galadriel', 20, 3, 12, 8, 6)");

            // 16
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Luane Vincent', 22, 3, 16, 10, 6)");


            // 17
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Kristyanne', 25, 2, 20, 8, 12)");

            // 18
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Orton Steves', 29, 1, 10, 4, 6)");

            // 19
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Johann Bravo', 26, 2, 17, 12, 5)");

            // 20
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Dragão Guerreiro', 24, 6, 23, 13, 10)");

            // 21
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Dead Pool', 28, 3, 19, 9, 10)");

            // 22
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Udamur Valhalla', 30, 1, 18, 6, 12)");

            // 23
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Felícia Torres', 25, 2, 11, 4, 7)");

            // 24
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Oren', 18, 5, 15, 6, 9)");

            // 25
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Jeffrey Nightmare', 31, 2, 21, 10, 11)");

            // 26
            migrationBuilder.Sql("INSERT INTO Lutadores (Nome, Idade, ArtesMarciais, Lutas, Derrotas, Vitorias)" +
                " VALUES ('Dwayne Thunderbluff', 27, 4, 14, 5, 9)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
