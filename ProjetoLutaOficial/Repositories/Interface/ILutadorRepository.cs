using ProjetoLutaOficial.Models;

namespace ProjetoLutaOficial.Repositories.Interface
{
    public interface ILutadorRepository
    {
        List<Lutador> Listagem();
        void Update(Lutador lutador);

    }
}
