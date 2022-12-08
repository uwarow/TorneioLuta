using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProjetoLutaOficial.Models
{
    public class Lutador
    {
        public int? Id { get; set; }

        public string? Nome { get; set; }
        public int Idade { get; set; }
        public int ArtesMarciais { get; set; }
        public int Lutas { get; set; }
        public int Derrotas { get; set; }
        public int Vitorias { get; set; }


        public bool? Selecionado { get; set; }
        

        

    }
}
