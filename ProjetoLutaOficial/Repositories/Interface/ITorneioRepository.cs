using ProjetoLutaOficial.Models;
using static ProjetoLutaOficial.Repositories.TorneioRepository;

namespace ProjetoLutaOficial.Repositories.Interface
{
    public interface ITorneioRepository
    {
        Lutador ProcessaEtapas(List<Lutador> lista);
        List<Lutador> EtapaDoTorneio(List<Lutador> lista);
        Lutador DefineVencedor(ParLutadores luta);
        Lutador CriterioDeDesempate(ParLutadores luta);
        void AtualizarDadosDosLutadores(Lutador vencedor, Lutador perdedor);
        Lutador Sorteio(ParLutadores luta);
        double CalculaVitoria(double a, double b);

    }
}
