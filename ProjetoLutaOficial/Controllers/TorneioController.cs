using Microsoft.AspNetCore.Mvc;
using ProjetoLutaOficial.Models;
using ProjetoLutaOficial.Repositories.Interface;

namespace ProjetoLutaOficial.Controllers
{
    public class TorneioController : Controller
    {
        private readonly ILutadorRepository _lutadorRepository;
        private readonly ITorneioRepository _torneioRepository;

        public TorneioController(ILutadorRepository lutadorRepository, ITorneioRepository torneioRepository)
        {
            _lutadorRepository = lutadorRepository;
            _torneioRepository = torneioRepository;
        }

        public IActionResult Index()
        {
          return View(_lutadorRepository.Listagem());
           

        }

        public IActionResult PegaSelecionados(List<Lutador> listaLutadores)
        {
            try
            {

                List<Lutador> listaLutadoresTotal = _lutadorRepository.Listagem();
                List<Lutador> listaLutadoresSelecionados = RetornaLutadoresSelecionados(listaLutadores, listaLutadoresTotal);

                if (ValidaQuantidadeDeLutadoresSelecionados(listaLutadoresSelecionados) == false)
                {
                    ViewBag.Insuficiente = true;
                    return View("Index", PreparaListaLutadores());
                }

                Lutador vencedorFinal = _torneioRepository.ProcessaEtapas(listaLutadoresSelecionados);
                return View("Resultado", vencedorFinal);
            }

            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.Message));
            }



        }

        private List<Lutador> RetornaLutadoresSelecionados(List<Lutador> listaLutadoresCheckbox, List<Lutador> listaTotalLutadores)
        {
            List<Lutador> listaSelecionados = new List<Lutador>();

            int indice = 0;
            foreach (var lutador in listaLutadoresCheckbox)
            {
                if (lutador.Selecionado == true)
                {
                    Lutador meuLutador = new Lutador
                    {
                        Id = listaTotalLutadores[indice].Id,
                        Nome = listaTotalLutadores[indice].Nome,
                        Idade = listaTotalLutadores[indice].Idade,
                        ArtesMarciais = listaTotalLutadores[indice].ArtesMarciais,
                        Lutas = listaTotalLutadores[indice].Lutas,
                        Derrotas = listaTotalLutadores[indice].Derrotas,
                        Vitorias = listaTotalLutadores[indice].Vitorias
                    };

                    listaSelecionados.Add(meuLutador);

                }
                indice++;
            }
            return listaSelecionados;
        }

        private bool ValidaQuantidadeDeLutadoresSelecionados(List<Lutador> lista)
        {
            int quantidade = 0;

            foreach (var lutador in lista)
            {
                quantidade++;
            }

            if (quantidade != 16)
            {
                ViewBag.Insuficiente = true;
                return false;
            }

            return true;
        }

        private List<Lutador> PreparaListaLutadores()
        {
            List<Lutador> lista = _lutadorRepository.Listagem();
            return lista;
        }
    }
}
