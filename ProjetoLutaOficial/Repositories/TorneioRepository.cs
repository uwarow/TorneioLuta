
using ProjetoLutaOficial.Models;
using ProjetoLutaOficial.Repositories.Interface;

namespace ProjetoLutaOficial.Repositories
{
    public class TorneioRepository : ITorneioRepository
    {
        private readonly ILutadorRepository _lutadorRepository;

        public TorneioRepository(ILutadorRepository lutadorRepository)
        {
            _lutadorRepository = lutadorRepository;
        }

        public struct ParLutadores
        {
            public Lutador Lutador1 { get; set; }
            public Lutador Lutador2 { get; set; }
        }

        public Lutador ProcessaEtapas(List<Lutador> lista)
        {
            List<Lutador> listaOrdenada = lista.OrderBy(x => x.Idade).ToList();
            List<Lutador> vencedoresOitavas = EtapaDoTorneio(listaOrdenada);
            vencedoresOitavas = vencedoresOitavas.OrderBy(x => x.Idade).ToList();
            List<Lutador> vencedoresQuartas = EtapaDoTorneio(vencedoresOitavas);
            List<Lutador> vencedoresSemiFinais = EtapaDoTorneio(vencedoresQuartas);
            Lutador vencedorDaFinal = EtapaDoTorneio(vencedoresSemiFinais)[0];
            return vencedorDaFinal;
        }

        public List<Lutador> EtapaDoTorneio(List<Lutador> lista)
        {
            List<Lutador> vencedores = new List<Lutador>();
            for (int i = 0; i < lista.Count; i += 2)
            {
                Lutador vencedor = DefineVencedor(new ParLutadores
                {
                    Lutador1 = lista[i],
                    Lutador2 = lista[i + 1]
                });
                vencedores.Add(vencedor);
            }
            return vencedores;
        }

        public Lutador DefineVencedor(ParLutadores luta)
        {
            double criterioDeVitoriaLutador1 = CalculaVitoria(luta.Lutador1.Vitorias, luta.Lutador1.Lutas);
            double criterioDeVitoriaLutador2 = CalculaVitoria(luta.Lutador2.Vitorias, luta.Lutador2.Lutas);

            if (criterioDeVitoriaLutador1 > criterioDeVitoriaLutador2)
            {
                AtualizarDadosDosLutadores(luta.Lutador1, luta.Lutador2);
                return luta.Lutador1;
            }

            else if (criterioDeVitoriaLutador2 > criterioDeVitoriaLutador1)
            {
                AtualizarDadosDosLutadores(luta.Lutador2, luta.Lutador1);
                return luta.Lutador2;
            }

            else
            {
                return CriterioDeDesempate(luta);
            }
        }

        public Lutador CriterioDeDesempate(ParLutadores luta)
        {
            if (luta.Lutador1.ArtesMarciais > luta.Lutador2.ArtesMarciais)
            {
                AtualizarDadosDosLutadores(luta.Lutador1, luta.Lutador2);
                return luta.Lutador1;
            }

            else if (luta.Lutador2.ArtesMarciais > luta.Lutador1.ArtesMarciais)
            {
                AtualizarDadosDosLutadores(luta.Lutador2, luta.Lutador1);
                return luta.Lutador2;
            }

            else
            {
                if (luta.Lutador1.Lutas > luta.Lutador2.Lutas)
                {
                    AtualizarDadosDosLutadores(luta.Lutador1, luta.Lutador2);
                    return luta.Lutador1;
                }

                else if (luta.Lutador2.Lutas > luta.Lutador1.Lutas)
                {
                    AtualizarDadosDosLutadores(luta.Lutador2, luta.Lutador1);
                    return luta.Lutador2;
                }

                else
                {
                    return Sorteio(luta);
                }
            }
        }

        public void AtualizarDadosDosLutadores(Lutador vencedor, Lutador perdedor)
        {
            vencedor.Lutas += 1;
            perdedor.Lutas += 1;

            vencedor.Vitorias += 1;
            perdedor.Derrotas += 1;

            _lutadorRepository.Update(vencedor);
            _lutadorRepository.Update(perdedor);
        }

        public Lutador Sorteio(ParLutadores luta)
        {
            Random gerador = new Random();
            int sorteado = gerador.Next(1, 11);

            if (sorteado % 2 == 0)
            {
                AtualizarDadosDosLutadores(luta.Lutador2, luta.Lutador1);
                return luta.Lutador2;
            }

            else
            {
                AtualizarDadosDosLutadores(luta.Lutador1, luta.Lutador2);
                return luta.Lutador1;
            }
        }

        public double CalculaVitoria(double a, double b)
        {
            double resultado = 0;
            resultado += (a / b) * 100;

            return resultado;
        }
    }
}


    

